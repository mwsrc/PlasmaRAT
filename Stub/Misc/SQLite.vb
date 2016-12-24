'**************************************************************
'
'               Coded By: RockingWithTheBest
'
'                           v 0.1
'
'
'      A Handler for SQLite without needing the sqlite3.dll!
'      You can read every table and value from database, but
'      there is no support for input. Also no support for
'      journal files and overflow pages, maybe i will add
'      that in a later release.
'      
'
'                       Have Fun!
'
'   If u want to learn more about or enhance it then visit:
'           http://www.sqlite.org/fileformat.html
'
'   If you copy or modify it, please add me to credits!
'
'   Questions etc. to:      peterrlustig@googlemail.com
'
'**************************************************************
'
'   Example:
'
'   Dim SQLDatabase = New SQLiteHandler("C:\Temp\Login Data")
'   SQLDatabase.ReadTable("logins")
'
'   MsgBox(GetValue(SQLDatabase.GetValue(0, "username_value")))
'
'**************************************************************

Imports System.IO

Public Class SQLiteHandler
    Private db_bytes() As Byte
    Private page_size As UInt16
    Private encoding As UInt64
    Private master_table_entries() As sqlite_master_entry

    Private SQLDataTypeSize() As Byte = New Byte() {0, 1, 2, 3, 4, 6, 8, 8, 0, 0}
    Private table_entries() As table_entry
    Private field_names() As String

    Private Structure record_header_field
        Dim size As Int64
        Dim type As Int64
    End Structure

    Private Structure table_entry
        Dim row_id As Int64
        Dim content() As String
    End Structure

    Private Structure sqlite_master_entry
        Dim row_id As Int64
        Dim item_type As String
        Dim item_name As String
        Dim astable_name As String
        Dim root_num As Int64
        Dim sql_statement As String
    End Structure

    'Needs BigEndian
    'GetVariableLength
    ' returns the endindex of an variable length integer
    Private Function GVL(ByVal startIndex As Integer) As Integer
        Try
            If startIndex > db_bytes.Length Then Return Nothing

            For i = startIndex To startIndex + 8 Step 1
                If i > db_bytes.Length - 1 Then
                    Return Nothing
                ElseIf (db_bytes(i) And &H80) <> &H80 Then
                    Return i
                End If
            Next

            Return startIndex + 8
        Catch : End Try
    End Function

    ' Eingaberichtung BigEndian
    ' ConvertVariableLength
    Private Function CVL(ByVal startIndex As Integer, ByVal endIndex As Integer) As Int64
        Try
            endIndex = endIndex + 1

            Dim retus(7) As Byte
            Dim Length = endIndex - startIndex
            Dim Bit64 As Boolean = False

            If Length = 0 Or Length > 9 Then Return Nothing
            If Length = 1 Then
                retus(0) = (db_bytes(startIndex) And &H7F)
                Return BitConverter.ToInt64(retus, 0)
            End If

            If Length = 9 Then
                ' Ein Byte wird nämlich grad hinzugefügt
                Bit64 = True
            End If

            Dim j As Integer = 1
            Dim k As Integer = 7
            Dim y As Integer = 0

            If Bit64 Then
                retus(0) = db_bytes(endIndex - 1)
                endIndex = endIndex - 1
                y = 1
            End If

            For i = (endIndex - 1) To startIndex Step -1
                If (i - 1) >= startIndex Then
                    retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j)) Or (db_bytes(i - 1) << k)
                    j = j + 1
                    y = y + 1
                    k = k - 1
                Else
                    If Not Bit64 Then retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j))
                End If
            Next

            Return BitConverter.ToInt64(retus, 0)
        Catch : End Try
    End Function

    'Checks if a number is odd
    Private Function IsOdd(ByVal value As Int64) As Boolean
        Return (value And 1) = 1
    End Function

    'Big Endian Conversation
    Private Function ConvertToInteger(ByVal startIndex As Integer, ByVal Size As Integer) As UInt64
        Try
            If Size > 8 Or Size = 0 Then Return Nothing

            Dim retVal As UInt64 = 0

            For i = 0 To Size - 1 Step 1
                retVal = ((retVal << 8) Or db_bytes(startIndex + i))
            Next

            Return retVal
        Catch : End Try
    End Function

    Private Sub ReadMasterTable(ByVal Offset As UInt64)
        Try
            If db_bytes(Offset) = &HD Then 'Leaf node
                'Length for setting the array length for the entries
                Dim Length As UInt16 = ConvertToInteger(Offset + 3, 2) - 1
                Dim ol As Integer = 0

                If Not master_table_entries Is Nothing Then
                    ol = master_table_entries.Length
                    ReDim Preserve master_table_entries(master_table_entries.Length + Length)
                Else
                    ReDim master_table_entries(Length)
                End If

                Dim ent_offset As UInt64

                For i = 0 To Length Step 1
                    ent_offset = ConvertToInteger(Offset + 8 + (i * 2), 2)

                    If Offset <> 100 Then ent_offset = ent_offset + Offset

                    'Table Cell auslesen
                    Dim t = GVL(ent_offset)
                    Dim size As Int64 = CVL(ent_offset, t)

                    Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                    master_table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                    'Table Content
                    'Resetting the offset
                    ent_offset = ent_offset + (s - ent_offset) + 1

                    'Now get to the Record Header
                    t = GVL(ent_offset)
                    s = t
                    Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                    Dim Field_Size(4) As Int64

                    'Now get the field sizes and fill in the Values
                    For j = 0 To 4 Step 1
                        t = s + 1
                        s = GVL(t)
                        Field_Size(j) = CVL(t, s)

                        If Field_Size(j) > 9 Then
                            If IsOdd(Field_Size(j)) Then
                                Field_Size(j) = (Field_Size(j) - 13) / 2
                            Else
                                Field_Size(j) = (Field_Size(j) - 12) / 2
                            End If
                        Else
                            Field_Size(j) = SQLDataTypeSize(Field_Size(j))
                        End If
                    Next

                    ' Wir lesen nur unbedingt notwendige Sachen aus
                    If encoding = 1 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    End If
                    If encoding = 1 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    End If
                    'master_table_entries(ol + i).astable_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1), Field_Size(2))
                    master_table_entries(ol + i).root_num = ConvertToInteger(ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2), Field_Size(3))
                    If encoding = 1 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    End If
                Next
            ElseIf db_bytes(Offset) = &H5 Then 'internal node
                Dim Length As UInt16 = ConvertToInteger(Offset + 3, 2) - 1
                Dim ent_offset As UInt16

                For i = 0 To Length Step 1
                    ent_offset = ConvertToInteger(Offset + 12 + (i * 2), 2)

                    If Offset = 100 Then
                        ReadMasterTable((ConvertToInteger(ent_offset, 4) - 1) * page_size)
                    Else
                        ReadMasterTable((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
                    End If

                Next

                ReadMasterTable((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
            End If
        Catch : End Try
    End Sub

    Private Function ReadTableFromOffset(ByVal Offset As UInt64) As Boolean
        Try
            If db_bytes(Offset) = &HD Then 'Leaf node

                'Length for setting the array length for the entries
                Dim Length As UInt16 = ConvertToInteger(Offset + 3, 2) - 1
                Dim ol As Integer = 0

                If Not table_entries Is Nothing Then
                    ol = table_entries.Length
                    ReDim Preserve table_entries(table_entries.Length + Length)
                Else
                    ReDim table_entries(Length)
                End If

                Dim ent_offset As UInt64

                For i = 0 To Length Step 1
                    ent_offset = ConvertToInteger(Offset + 8 + (i * 2), 2)

                    If Offset <> 100 Then ent_offset = ent_offset + Offset

                    'Table Cell auslesen
                    Dim t = GVL(ent_offset)
                    Dim size As Int64 = CVL(ent_offset, t)

                    Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                    table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                    'Table Content
                    'Resetting the offset
                    ent_offset = ent_offset + (s - ent_offset) + 1

                    'Now get to the Record Header
                    t = GVL(ent_offset)
                    s = t
                    Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                    Dim Field_Size() As record_header_field
                    Dim size_read As Int64 = (ent_offset - t) + 1
                    Dim j = 0

                    'Now get the field sizes and fill in the Values
                    While size_read < Rec_Header_Size
                        ReDim Preserve Field_Size(j)

                        t = s + 1
                        s = GVL(t)
                        Field_Size(j).type = CVL(t, s)

                        If Field_Size(j).type > 9 Then
                            If IsOdd(Field_Size(j).type) Then
                                Field_Size(j).size = (Field_Size(j).type - 13) / 2
                            Else
                                Field_Size(j).size = (Field_Size(j).type - 12) / 2
                            End If
                        Else
                            Field_Size(j).size = SQLDataTypeSize(Field_Size(j).type)
                        End If

                        size_read = size_read + (s - t) + 1
                        j = j + 1
                    End While

                    ReDim table_entries(ol + i).content(Field_Size.Length - 1)
                    Dim counter As Integer = 0

                    For k = 0 To Field_Size.Length - 1 Step 1
                        If Field_Size(k).type > 9 Then
                            If Not IsOdd(Field_Size(k).type) Then
                                If encoding = 1 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                ElseIf encoding = 2 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                ElseIf encoding = 3 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                End If
                            Else
                                table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                            End If
                        Else
                            table_entries(ol + i).content(k) = CStr(ConvertToInteger(ent_offset + Rec_Header_Size + counter, Field_Size(k).size))
                        End If

                        counter = counter + Field_Size(k).size
                    Next
                Next
            ElseIf db_bytes(Offset) = &H5 Then 'internal node
                Dim Length As UInt16 = ConvertToInteger(Offset + 3, 2) - 1
                Dim ent_offset As UInt16

                For i = 0 To Length Step 1
                    ent_offset = ConvertToInteger(Offset + 12 + (i * 2), 2)

                    ReadTableFromOffset((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
                Next

                ReadTableFromOffset((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
            End If

            Return True
        Catch : End Try
    End Function

    ' Reads a complete table with all entries in it
    Public Function ReadTable(ByVal TableName As String) As Boolean
        Try
            ' First loop through sqlite_master and look if table exists
            Dim found As Integer = -1

            For i = 0 To master_table_entries.Length Step 1
                If master_table_entries(i).item_name.ToLower().CompareTo(TableName.ToLower()) = 0 Then
                    found = i
                    Exit For
                End If
            Next

            If found = -1 Then Return False

            Dim fields() = master_table_entries(found).sql_statement.Substring(master_table_entries(found).sql_statement.IndexOf("(") + 1).Split(",")

            For i = 0 To fields.Length - 1 Step 1
                fields(i) = LTrim(fields(i))

                Dim index = fields(i).IndexOf(" ")

                If index > 0 Then fields(i) = fields(i).Substring(0, index)

                If fields(i).IndexOf("UNIQUE") = 0 Then
                    Exit For
                Else
                    ReDim Preserve field_names(i)
                    field_names(i) = fields(i)
                End If
            Next

            Return ReadTableFromOffset((master_table_entries(found).root_num - 1) * page_size)
        Catch : End Try
    End Function

    ' Returns the row count of current table
    Public Function GetRowCount() As Integer
        Return table_entries.Length
    End Function

    ' Returns a Value from current table in row row_num with field number field
    Public Function GetValue(ByVal row_num As Integer, ByVal field As Integer) As String
        Try
            If row_num >= table_entries.Length Then Return Nothing
            If field >= table_entries(row_num).content.Length Then Return Nothing

            Return table_entries(row_num).content(field)
        Catch : End Try
    End Function

    ' Returns a Value from current table in row row_num with field name field
    Public Function GetValue(ByVal row_num As Integer, ByVal field As String) As String
        Try
            Dim found As Integer = -1

            For i = 0 To field_names.Length Step 1
                If field_names(i).ToLower().CompareTo(field.ToLower()) = 0 Then
                    found = i
                    Exit For
                End If
            Next

            If found = -1 Then Return Nothing

            Return GetValue(row_num, found)
        Catch : End Try
    End Function

    ' Returns a String-Array with all Tablenames
    Public Function GetTableNames() As String()
        Try
            Dim retVal As String()
            Dim arr = 0

            For i = 0 To master_table_entries.Length - 1 Step 1
                If master_table_entries(i).item_type = "table" Then
                    ReDim Preserve retVal(arr)
                    retVal(arr) = master_table_entries(i).item_name
                    arr = arr + 1
                End If
            Next

            Return retVal
        Catch : End Try
    End Function

    ' Constructor
    Public Sub New(ByVal baseName As String)
        Try
            'Page Number n is page_size*(n-1)
            If File.Exists(baseName) Then
                FileOpen(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
                Dim asi As String = Space(LOF(1))
                FileGet(1, asi)
                FileClose(1)

                db_bytes = System.Text.Encoding.Default.GetBytes(asi)

                If System.Text.Encoding.Default.GetString(db_bytes, 0, 15).CompareTo("SQLite format 3") <> 0 Then
                    Throw New Exception("Not a valid SQLite 3 Database File")
                    End
                End If

                If db_bytes(52) <> 0 Then
                    Throw New Exception("Auto-vacuum capable database is not supported")
                    End
                ElseIf ConvertToInteger(44, 4) >= 4 Then
                    Throw New Exception("No supported Schema layer file-format")
                    End
                End If

                page_size = ConvertToInteger(16, 2)
                encoding = ConvertToInteger(56, 4)

                If encoding = 0 Then encoding = 1

                'Now we read the sqlite_master table
                'Offset is 100 in first page
                ReadMasterTable(100)
            End If
        Catch : End Try
    End Sub
End Class