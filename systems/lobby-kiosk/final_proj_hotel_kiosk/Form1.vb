Partial Class Form1

    ' FIX 1: Added file extensions (e.g., .jpg)
    Dim images As String() = {
        "C:\slideshow\ad1",
        "C:\slideshow\ad2",
        "C:\slideshow\ad3"
    }

    Dim index As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Always good to check if the file exists before loading
        If IO.File.Exists(images(index)) Then
            ads.Image = Image.FromFile(images(index))
            timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        index += 1

        If index >= images.Length Then
            index = 0 ' loop back to first image
        End If

        ' FIX 2: Dispose of the old image to prevent the app from slowing down
        If ads.Image IsNot Nothing Then
            ads.Image.Dispose()
        End If

        If IO.File.Exists(images(index)) Then
            ads.Image = Image.FromFile(images(index))
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles footandbev_btn.Click, voucher_btn.Click

    End Sub

    Private Sub room_btn_Click(sender As Object, e As EventArgs) Handles room_btn.Click
        ' 1. Clear everything currently on Form1 (buttons, labels, etc.)
        Me.Controls.Clear()

        ' 2. Create the rooms User Control
        Dim roomsUC As New rooms()

        ' 3. Make it fill the entire window
        roomsUC.Dock = DockStyle.Fill

        ' 4. Add it to the Form
        Me.Controls.Add(roomsUC)
    End Sub


End Class