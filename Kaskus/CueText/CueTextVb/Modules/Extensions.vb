Imports System.Windows.Forms
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Modules
    Public Module Extensions

        <Extension> _
        Public Sub CueText(control As Control, text As [String])
            NativeMethods.SendMessageW(If(TypeOf control Is ComboBox, control.GetComboBoxInfo().hwndItem, control.Handle), NativeMethods.EmSetCueBanner, CType(0, IntPtr), text)
        End Sub

        <Extension> _
        Friend Function GetComboBoxInfo(control As IWin32Window) As NativeMethods.ComboboxInfo
            Dim info = New NativeMethods.ComboboxInfo()
            info.cbSize = Marshal.SizeOf(info)
            NativeMethods.GetComboBoxInfo(control.Handle, info)
            Return info
        End Function
    End Module
End Namespace