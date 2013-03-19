Public Class Form1

   

 
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 9
            For j = 0 To 9
                Dim lbl As New Label()
                lbl.Name = "lbl" & i
                lbl.Size = New Size(20, 20)
                lbl.Location = New Point(30 * i, 30 * j)
                lbl.BackColor = Color.DeepSkyBlue
                Me.Controls.Add(lbl)

            Next
        Next
    End Sub
End Class
