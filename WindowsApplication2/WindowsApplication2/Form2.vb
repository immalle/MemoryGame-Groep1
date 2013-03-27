Imports System.IO
Public Class form2
    Public rndgetal As Random
    Public prentjes As New List(Of String)



    Private Sub form2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Form1.RadioButton1.Checked = True Then
            zetkaarten(4)
        ElseIf Form1.RadioButton2.Checked = True Then
            zetkaarten(6)
        ElseIf Form1.RadioButton3.Checked = True Then
            zetkaarten(8)
        End If
        Me.Size = New Size(1200, 1200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Private Sub picutreboxOnMouseEnterEventHandler(sender As Label, e As System.EventArgs)
        sender.BackColor = Color.Red
    End Sub
    Sub zetkaarten(aantal As Integer)

        prentjes.AddRange(System.IO.Directory.GetFiles("D:\5I\SoftwareOntwikkeling\MemoryGame-Groep1\prentjes", "*.jpg"))

        For i = 1 To aantal
            For j = 1 To aantal
                Dim pic As New PictureBox()
                pic.Size = New Size(80, 100)
                pic.Location = New Point(120 * i, 120 * j)
                pic.BackColor = Color.Transparent
                pic.AutoSize = True
                Me.Controls.Add(pic)
                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Image = My.Resources.unnamed
                AddHandler pic.Click, AddressOf klikkenopkaart
            Next
        Next


    End Sub
    Sub klikkenopkaart(sender As System.Windows.Forms.PictureBox, e As System.EventArgs)
        For Each prent In prentjes
            sender.Image = Image.FromFile((prent.Substring(0)))
        Next
    End Sub

   

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class




