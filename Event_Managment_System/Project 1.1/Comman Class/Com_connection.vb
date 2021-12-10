Imports System.Data.SqlClient

Module Com_connection

    Public Const connstring = "Data Source=.\SQLEXPRESS;Initial Catalog=Project1.1;Integrated Security=True"
    Public connection As SqlConnection
    Public cmd As SqlCommand
    

    Public Sub getconnection()
        'create new connection string
        connection = New SqlConnection
        connection.ConnectionString = connstring

        If connection.ConnectionString <> connstring Then
            MsgBox("database connection failed or does not exist...", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")
            Exit Sub
        ElseIf connection.State = ConnectionState.Closed Then
            connection.Open()
        Else
            MsgBox("Not Connected")
        End If

    End Sub

    Public Sub terminateconnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
    Public Sub Charlock(ByVal e)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Public Sub Numlock(ByVal e)
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Public Sub Mobile_No(ByVal len As Integer)
        If len < 10 Then
            MsgBox("Check Mobile Number...")
        End If
    End Sub
End Module
