Imports System.Data.SqlClient
Imports System.IO
Public Class Comman_Class
    Public Shared id As Integer
    Public Shared type As String
    Public Shared category As String
    Public Shared charges As Integer
    Public Shared img As Image
    Public Shared Cust_id As Integer
    Public Shared S_Cust_id As Integer


    Public Shared Sub brows(ByRef search As Image)
        Dim obj As New OpenFileDialog
        obj.Filter = "Choose Images(*.JPG;*.PNG;*GIF)|*.jpg;*.png;*gif"
        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
            search = Image.FromFile(obj.FileName)
        End If
    End Sub
    Public Shared Function view(ByVal img As Byte())
        Using ms As New MemoryStream(img)
            Return Image.FromStream(ms)
        End Using
    End Function

End Class
