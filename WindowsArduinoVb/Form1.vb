Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SerialPort1.PortName = "COM9"

        If SerialPort1.IsOpen Then

        Else

            Try
                SerialPort1.Open()
            Catch ex As Exception

            End Try
            Timer1.Start()

            Button1.Enabled = False
            Button2.Enabled = True


        End If





    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Button1.Enabled = True
        Button2.Enabled = False

        Timer1.Stop()
        SerialPort1.Close()





    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim data As String
        data = SerialPort1.ReadExisting().ToString()
        RichTextBox1.AppendText(data)


    End Sub
End Class
