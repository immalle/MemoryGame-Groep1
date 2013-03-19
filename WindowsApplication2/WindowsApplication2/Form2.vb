Public Class form2

    Private Sub form2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Form1.RadioButton1.Checked = True Then
            zetkaarten(4)
        ElseIf Form1.RadioButton2.Checked = True Then
            zetkaarten(6)
        ElseIf Form1.RadioButton3.Checked = True Then
            zetkaarten(8)
        End If
       
    End Sub
    Private Sub picutreboxOnMouseEnterEventHandler(sender As Label, e As System.EventArgs)
        sender.BackColor = Color.Red
    End Sub
    Sub zetkaarten(aantal As Integer)
        For i = 1 To aantal
            For j = 1 To aantal

                Dim pic As New PictureBox()
                pic.Size = New Size(50, 50)
                pic.Location = New Point(60 * i, 60 * j)
                pic.BackColor = Color.Blue

                Me.Controls.Add(pic)

            Next
        Next
    End Sub
End Class