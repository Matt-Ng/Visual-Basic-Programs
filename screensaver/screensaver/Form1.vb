Public Class Form1
    ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/5a9389fb-e5de-40d6-b1ca-bc1b89489112/what-is-the-coding-to-blink-labeltext-in-vb-2008?forum=vbgeneral
    ' http://www.vbforums.com/showthread.php?710379-Change-background-color-using-a-timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Visible = Not Label1.Visible
        Static rand As New Random()
        Me.BackColor = Color.FromArgb(rand.Next(255), rand.Next(256), rand.Next(256))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
    End Sub
End Class
