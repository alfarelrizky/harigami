Imports System.Data.Odbc
Public Class Form1
    Dim str As String
    Public zonenya, posnya As String
    Sub jalur()
        koneksi()
        If connection_stat = True Then
            Try
                Dim dataset As New DataSet
                Dim str As String = "select *from tb_master_zone"
                cmd = New OdbcCommand(str, connection)
                rd = cmd.ExecuteReader()
                While rd.Read()
                    ComboBox1.Items.Add(rd("zone_name"))
                End While
            Catch ex As Exception
                MsgBox("GET DATA GAGAL | Cek Jaringan Anda | Position tb_master_zone")
            End Try
        Else
            MsgBox("GET DATA GAGAL | Cek Jaringan Anda")
        End If
    End Sub
    Sub POS(a)
        koneksi()
        If connection_stat = True Then
            Try
                Dim str As String = "SELECT pos_name from tb_master_pos where zone_name = '" & a & "'"
                cmd = New OdbcCommand(str, connection)
                rd = cmd.ExecuteReader()
                While rd.Read()
                    ComboBox2.Items.Add(rd("pos_name"))
                End While
            Catch ex As Exception
                MsgBox("GET DATA GAGAL | Cek Jaringan Anda | Position tb_master_zone")
            End Try
        Else
            MsgBox("GET DATA GAGAL | Cek Jaringan Anda")
        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call jalur()

    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.Items.Clear()
        Call POS(ComboBox1.Text)
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox2.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            MsgBox("Lengkapi Form Terlebih dahulu")
        Else
            posnya = ""
            zonenya = ""
            posnya = ComboBox2.Text
            zonenya = ComboBox1.Text
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class