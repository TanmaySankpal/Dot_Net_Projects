Imports System.Data.SqlClient

Module Auto_Increm_Module
    Public cnt As Integer = 0
    ' Public start_no As Integer

    Function Auto_Increment(ByVal get_current_id As String, ByVal start_no As Integer)

        getconnection()
        cmd = New SqlCommand(get_current_id, connection)

        cnt = cmd.ExecuteScalar()

        cnt = cnt + start_no

        terminateconnection()
        Return cnt

    End Function


    ' Dim i As Integer
    'Dim reducme As Integer
    'Dim getidValue As Integer
    'Dim R As SqlDataReader
    ' Dim IDIncremen As String = "0000"


    'Public Sub Auto_Increment(ByVal getmy_ID_values As String, ByVal txt As TextBox)


    'getconnection()
    'cmd = New SqlCommand(getmy_ID_values, con)
    'dbadapter = New SqlDataAdapter
    'dbadapter.SelectCommand = cmd
    'dbdt = New DataTable
    'dbadapter.Fill(dbdt)

    'Dim maxrow As Integer = dbdt.Rows.Count - 1

    '   i = dbdt.Rows(0).Item("customerID") + 1

    '    reducme = dbdt.Rows(0).Item("customerID") - 1
    '   With txt

    '        If maxrow > -1 Then
    '           .Text = "000" & dbdt.Rows(maxrow).Item(0)

    '        Else
    '           .Text = "000"
    '     End If
    '  End With


    'terminateconnection()
    'End Sub
End Module
