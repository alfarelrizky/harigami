Imports System.Data.Odbc
Public Class Form2
    Dim str As String
    Dim liat, suffix_head, color_head, model_head As String
    Dim judul1, judul2, judul3, judul4 As String
    Dim header1, isi1, isi2 As String
    Public vin As String
    Dim lifting As Integer
    Public slide As Integer
    Public a As Integer = 0
    Public b As Integer = 0
    Dim col As Integer = 0
    Public content(100, 100), header(100, 100), warna(100, 100) As String
    Public model(100), suffix(100), color(100) As String
    Dim zone_name, pos_name As String

    Sub clean_isi()
        For v As Integer = 1 To 100
            For b As Integer = 1 To 100
                content(v, b) = "-"
                header(v, b) = "-"
            Next
        Next
    End Sub
    Sub scan(liff)
        koneksi()
        If connection_stat = True Then
            Try
                Dim liffting As Integer
                Dim urut As Integer = 0
                For index = 1 To 12
                    urut += 1
                    suffix(urut) = ""
                    color(urut) = ""
                    model(urut) = ""
                Next
                liffting = liff
                urut = 0
                For index = 1 To 12
                    urut += 1
                    If liffting <= 9999 Then

                    Else
                        liffting = 1
                    End If
                    liat = "select *from scan where liffting =" & liffting
                    Using cmd As New OdbcCommand(liat, connection)
                        Using rd As OdbcDataReader = cmd.ExecuteReader
                            If rd.Read Then
                                suffix(urut) = rd.Item("Suffix")
                                color(urut) = rd.Item("color_code")
                                model(urut) = rd.Item("model_code")
                                col += 1
                                header(1, urut) = liffting & "-" & model(urut) & "-" & color(urut) & "-" & suffix(urut)
                                slide = 1
                                Form3.liffting.Text = liffting
                                liffting += 1
                            Else
                                suffix(urut) = ""
                                color(urut) = ""
                                model(urut) = ""
                                liffting = liffting
                            End If
                        End Using
                    End Using
                Next
            Catch ex As Exception
                MsgBox("GET DATA GAGAL | CEK JARINGAN TAB | Position SCAN")
            End Try
        Else
            MsgBox("GET DATA GAGAL | CEK JARINGAN TAB")
        End If
    End Sub
    Sub panggil_db(liff)
        Dim str As String = "SELECT * FROM `tb_master_content` where zone_name = 'SPS_ZONE_1' and pos_name = 'MIRROR_LH' and model_code = '" & model(liff) & "' and suffix = '" & suffix(liff) & "' and color_code = '" & color(liff) & "'"
        cmd = New OdbcCommand(str, connection2)
        rd = cmd.ExecuteReader()
        If rd.Read() Then
            content(1, liff) = rd("column1")
            warna(1, liff) = rd("column4")
        Else

        End If
        'content
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + Button1.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + Button2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + Button3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + Button4.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + Button5.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + Button6.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + Button7.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + Button8.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + Button9.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + Button10.Text
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        col = 0
        TextBox1.MaxLength = 4
        If e.ToString = Chr(4) Then
            Button13.Focus()
        End If
        Form1.posnya = "SET_ENGINE"
        Form1.zonenya = "CH_1_ENGINE"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim a As Integer
        Dim con As Integer
        If TextBox1.Text = "" Then
            MsgBox("MAS MASUKIN NO LIFTINGNYA...", MsgBoxStyle.Exclamation)
        Else
            a = CInt(TextBox1.Text)
            If a <= 9999 Then
                Call clean_isi()
                Call Form3.bersih()
                con = 0
                Call scan(a)
                Koneksi_content()
                If connection_content = True Then
                    Me.Hide()
                    Try
                        For index = 1 To 12
                            con += 1
                            Call panggil_db(con)
                        Next
                        Call Form3.isikan(1)
                        Form3.Show()
                        Form3.slide_now = 1
                        Form3.vin.Text = "MIRROR LH"
                        Form1.posnya = "MIRROR_LH"
                        Form1.zonenya = "SPS_ZONE_1"
                    Catch ex As Exception
                        MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA | Position Tb_Master_Content")
                    End Try
                Else
                    MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA")
                End If
            Else
                MsgBox("maaf LIFTING tidak VALID", MsgBoxStyle.Exclamation)
                TextBox1.Text = ""
            End If
        End If
    End Sub
    Sub bersih_isi()
        vin = ""
        isi1 = ""
        isi2 = ""
        header1 = ""
    End Sub
End Class
