Imports System.IO
Imports System.IO.Ports

Imports System.Threading

Public Class Form1

    Shared _continue As Boolean

    Shared _serialPort As SerialPort

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerialPort1.Close()

        SerialPort1.PortName = "com4"

        SerialPort1.BaudRate = 9600

        SerialPort1.DataBits = 8

        SerialPort1.Parity = Parity.None

        SerialPort1.StopBits = StopBits.One

        SerialPort1.Handshake = Handshake.None

        SerialPort1.Encoding = System.Text.Encoding.Default

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SerialPort1.Open()

        SerialPort1.Write("1")

        SerialPort1.Close()

    End Sub

    Private Sub GaugeControl2_Click(sender As Object, e As EventArgs) Handles GaugeControl2.Click

    End Sub
End Class