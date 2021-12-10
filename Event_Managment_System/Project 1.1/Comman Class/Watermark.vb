Imports System.Runtime.InteropServices

Imports System.Runtime.CompilerServices
Public Class Watermark


    Public Class WatermarkTextBox
        Inherits TextBox

        Private NotInheritable Class NativeMethods
            Private Sub New()
            End Sub

            Private Const ECM_FIRST As UInteger = &H1500
            Friend Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

            <DllImport("user32.dll", EntryPoint:="SendMessageW")>
            Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
            End Function
        End Class

        Private _watermark As String
        Public Property Watermark() As String
            Get
                Return _watermark
            End Get
            Set(ByVal value As String)
                _watermark = value
                UpdateWatermark()
            End Set
        End Property

        Private Sub UpdateWatermark()
            If IsHandleCreated AndAlso _watermark IsNot Nothing Then
                NativeMethods.SendMessageW(Handle, NativeMethods.EM_SETCUEBANNER, CType(1, IntPtr), _watermark)
            End If
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateWatermark()
        End Sub


    End Class


End Class
Public Module TextBoxExtensions

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
    End Function

    <Extension()>
    Public Sub SetWaterMark(ByVal tb As TextBox, ByRef watermark As String)
        SendMessageW(tb.Handle, EM_SETCUEBANNER, 0, watermark)
    End Sub

End Module
