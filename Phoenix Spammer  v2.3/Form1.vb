Imports System.ComponentModel

Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Timer1.Enabled = True
        txtInt.Enabled = False
        txtLimit.Enabled = False
        txtSpam.Enabled = False
        BackgroundWorker1.RunWorkerAsync()




    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        txtSpam.Enabled = True
        txtLimit.Enabled = True
        txtInt.Enabled = True
        txtSpam.Text = ""
        txtLimit.Text = "9999"
        txtCounter.Text = "0"
        txtInt.Text = "1"
        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()
        MessageBox.Show("Spamming has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtSpam.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim int As Integer
        int = Val(txtInt.Text) * 1000

        If txtLimit.Text = "" Then

            txtLimit.Text = "9999"

        Else

            txtLimit.Text = txtLimit.Text

        End If


    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click

        BackgroundWorker1.CancelAsync()
        Me.Close()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim int As Integer
        int = Val(txtInt.Text) * 1000

        Do While Val(Trim(txtCounter.Text)) <= Val(Trim(txtLimit.Text - 1))

            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True

            Else
                SendKeys.SendWait(txtSpam.Text)
                SendKeys.SendWait("{Enter}")

                txtCounter.Text = txtCounter.Text + 1

                Threading.Thread.Sleep(int)

            End If

        Loop

        MessageBox.Show("Spamming has been completed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtInt.Text = "1"
        txtLimit.Text = "9999"
        txtSpam.Text = ""
        txtCounter.Text = "0"
        txtInt.Enabled = True
        txtSpam.Enabled = True
        txtLimit.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted



    End Sub

End Class
