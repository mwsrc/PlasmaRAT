Public Class Builder

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Size = New System.Drawing.Size(255, 418)

    End Sub

    Private Sub Builder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Shared Function Proper_RC4(ByVal Input As Byte(), ByVal Key As Byte()) As Byte()
        'Leave a thanks at least..
        'by d3c0mpil3r from HF
        Dim i, j, swap As UInteger
        Dim s As UInteger() = New UInteger(255) {}
        Dim Output As Byte() = New Byte(Input.Length - 1) {}

        For i = 0 To 255
            s(i) = i
        Next

        For i = 0 To 255
            j = (j + Key(i Mod Key.Length) + s(i)) And 255
            swap = s(i) 'Swapping of s(i) and s(j)
            s(i) = s(j)
            s(j) = swap
        Next

        i = 0 : j = 0
        For c = 0 To Output.Length - 1
            i = (i + 1) And 255
            j = (j + s(i)) And 255
            swap = s(i) 'Swapping of s(i) and s(j)
            s(i) = s(j)
            s(j) = swap
            Output(c) = Input(c) Xor s((s(i) + s(j)) And 255)
        Next

        Return Output
    End Function

    Public Shared Function ReplaceBytes(ByVal src As Byte(), ByVal search As Byte(), ByVal repl As Byte()) As Byte()
        Try
            Dim dst As Byte() = Nothing
            Dim index As Integer = FindBytes(src, search)
            If index >= 0 Then
                dst = New Byte(src.Length - search.Length + (repl.Length - 1)) {}
                ' before found array
                Buffer.BlockCopy(src, 0, dst, 0, index)
                ' repl copy
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length)
                ' rest of src array
                Buffer.BlockCopy(src, index + search.Length, dst, index + repl.Length, src.Length - (index + search.Length))
            End If
            Return dst
        Catch
            MessageBox.Show("Error occured")
        End Try

    End Function

    Public Shared Function FindBytes(ByVal src As Byte(), ByVal find As Byte()) As Integer
        Try
            Dim index As Integer = -1
            Dim matchIndex As Integer = 0
            ' handle the complete source array
            For i As Integer = 0 To src.Length - 1
                If src(i) = find(matchIndex) Then
                    If matchIndex = (find.Length - 1) Then
                        index = i - matchIndex
                        Exit For
                    End If
                    matchIndex += 1
                Else
                    matchIndex = 0

                End If
            Next
            Return index
        Catch
            MessageBox.Show("Error occured")
        End Try

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




    End Sub
    Public Shared Function EncryptConfig(ByVal input As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Seal.GetVariable("Username"))) 'IUWEEQWIOER$89^*(&@^$*&#@$HAFKJHDAKJSFHjd89379327AJHFD*&#($hajklshdf##*$&^(AAA
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = System.Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
End Class