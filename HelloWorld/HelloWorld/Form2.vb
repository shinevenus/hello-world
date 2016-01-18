Public Class Form2
    Dim myRecord As String =
    IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "record.wav")

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(myRecord, _
            AudioPlayMode.Background)
    End Sub
End Class