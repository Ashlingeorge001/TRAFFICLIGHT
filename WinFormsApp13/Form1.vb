Public Class Form1
    Dim signalIndex As Integer = 0
    Dim signals() As String = {"Red", "Yellow", "Green"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up timer
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        signalIndex = (signalIndex + 1) Mod signals.Length
        UpdateSignal()
    End Sub

    Private Sub UpdateSignal()
        Select Case signals(signalIndex)
            Case "Red"
                PictureBoxRed.Visible = True
                PictureBoxYellow.Visible = False
                PictureBoxGreen.Visible = False
            Case "Yellow"
                PictureBoxRed.Visible = False
                PictureBoxYellow.Visible = True
                PictureBoxGreen.Visible = False
            Case "Green"
                PictureBoxRed.Visible = False
                PictureBoxYellow.Visible = False
                PictureBoxGreen.Visible = True
        End Select
    End Sub


End Class