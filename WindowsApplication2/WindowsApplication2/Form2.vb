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
                pic.Size = New Size(40, 40)
                pic.Location = New Point(60 * i, 60 * j)
                pic.Image = My.Resources._10


                Me.Controls.Add(pic)

            Next
        Next

    End Sub

    Private Sub pic_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        sender.backcolor = Color.Red
    End Sub


End Class