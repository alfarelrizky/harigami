Public Class Form3
    Public LIFFTING_REAL As Integer
    Public slide_now As Integer
    Public next_liffting As Integer
    Sub bersih()
        content1.Text = "-"
        content2.Text = "-"
        content3.Text = "-"
        content4.Text = "-"
        content5.Text = "-"
        content6.Text = "-"
        content7.Text = "-"
        content8.Text = "-"
        content9.Text = "-"
        content10.Text = "-"
        content11.Text = "-"
        content12.Text = "-"
        content13.Text = "-"
        content14.Text = "-"

        header1.Text = "-"
        header2.Text = "-"
        header3.Text = "-"
        header4.Text = "-"
        header5.Text = "-"
        header6.Text = "-"
        header7.Text = "-"
        header8.Text = "-"
        header9.Text = "-"
        header10.Text = "-"
        header11.Text = "-"
        header12.Text = "-"
        header13.Text = "-"
        header14.Text = "-"

        content1.BackColor = Color.LimeGreen
        content2.BackColor = Color.LimeGreen
        content3.BackColor = Color.LimeGreen
        content4.BackColor = Color.LimeGreen
        content5.BackColor = Color.LimeGreen
        content6.BackColor = Color.LimeGreen
        content7.BackColor = Color.LimeGreen
        content8.BackColor = Color.LimeGreen
        content9.BackColor = Color.LimeGreen
        content10.BackColor = Color.LimeGreen
        content11.BackColor = Color.LimeGreen
        content12.BackColor = Color.LimeGreen
        content13.BackColor = Color.LimeGreen
        content14.BackColor = Color.LimeGreen
        content15.BackColor = Color.LimeGreen

        header1.BackColor = Color.LimeGreen
        header2.BackColor = Color.LimeGreen
        header3.BackColor = Color.LimeGreen
        header4.BackColor = Color.LimeGreen
        header5.BackColor = Color.LimeGreen
        header6.BackColor = Color.LimeGreen
        header7.BackColor = Color.LimeGreen
        header8.BackColor = Color.LimeGreen
        header9.BackColor = Color.LimeGreen
        header10.BackColor = Color.LimeGreen
        header11.BackColor = Color.LimeGreen
        header12.BackColor = Color.LimeGreen
        header13.BackColor = Color.LimeGreen
        header14.BackColor = Color.LimeGreen
        header15.BackColor = Color.LimeGreen
    End Sub
    Sub isikan(slide)
            header1.Text = Form2.header(slide, 1)
            header2.Text = Form2.header(slide, 2)
            header3.Text = Form2.header(slide, 3)
            header4.Text = Form2.header(slide, 4)
            header5.Text = Form2.header(slide, 5)
            header6.Text = Form2.header(slide, 6)
            header7.Text = Form2.header(slide, 7)
            header8.Text = Form2.header(slide, 8)
            header9.Text = Form2.header(slide, 9)
            header10.Text = Form2.header(slide, 10)
            header11.Text = Form2.header(slide, 11)
            header12.Text = Form2.header(slide, 12)
            header13.Text = Form2.header(slide, 13)
            header14.Text = Form2.header(slide, 14)


                content1.Text = Form2.content(slide, 1)
                content2.Text = Form2.content(slide, 2)
                content3.Text = Form2.content(slide, 3)
                content4.Text = Form2.content(slide, 4)
                content5.Text = Form2.content(slide, 5)
                content6.Text = Form2.content(slide, 6)
                content7.Text = Form2.content(slide, 7)
                content8.Text = Form2.content(slide, 8)
                content9.Text = Form2.content(slide, 9)
                content10.Text = Form2.content(slide, 10)
                content11.Text = Form2.content(slide, 11)
                content12.Text = Form2.content(slide, 12)
                content13.Text = Form2.content(slide, 13)
                content14.Text = Form2.content(slide, 14)

            If content1.Text = "-" Or content1.Text = "" Then
                content1.BackColor = Color.LimeGreen
                content1.Text = "-"
            ElseIf Form2.warna(1, 1) = "" Then
                content1.BackColor = Color.Cyan
                header1.BackColor = Color.Cyan
            ElseIf Form2.warna(1, 1) = "1" Then
                header1.BackColor = Color.Red
                content1.BackColor = Color.Red
            ElseIf Form2.warna(1, 1) = "2" Then
            header1.BackColor = Color.Red
            content1.BackColor = Color.Red
        ElseIf Form2.warna(1, 1) = "3" Then
            header1.BackColor = Color.Gray
            content1.BackColor = Color.Gray
        ElseIf Form2.warna(1, 1) = "4" Then
            header1.BackColor = Color.Orange
            content1.BackColor = Color.Orange
        ElseIf Form2.warna(1, 1) = "5" Then
            header1.BackColor = Color.Pink
            content1.BackColor = Color.Pink
        End If

        If content2.Text = "-" Or content2.Text = "" Then
            content2.BackColor = Color.LimeGreen
            content2.Text = "-"
        ElseIf Form2.warna(1, 2) = "" Then
            content2.BackColor = Color.Cyan
            header2.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 2) = "1" Then
            header2.BackColor = Color.Red
            content2.BackColor = Color.Red
        ElseIf Form2.warna(1, 2) = "2" Then
            header2.BackColor = Color.Red
            content2.BackColor = Color.Red
        ElseIf Form2.warna(1, 2) = "3" Then
            header2.BackColor = Color.Gray
            content2.BackColor = Color.Gray
        ElseIf Form2.warna(1, 2) = "4" Then
            header2.BackColor = Color.Orange
            content2.BackColor = Color.Orange
        ElseIf Form2.warna(1, 2) = "5" Then
            header2.BackColor = Color.Pink
            content2.BackColor = Color.Pink
        End If


        If content3.Text = "-" Or content3.Text = "" Then
            content3.BackColor = Color.LimeGreen
            content3.Text = "-"
        ElseIf Form2.warna(1, 3) = "" Then
            content3.BackColor = Color.Cyan
            header3.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 3) = "1" Then
            header3.BackColor = Color.Red
            content3.BackColor = Color.Red
        ElseIf Form2.warna(1, 3) = "2" Then
            header3.BackColor = Color.Red
            content3.BackColor = Color.Red
        ElseIf Form2.warna(1, 3) = "3" Then
            header3.BackColor = Color.Gray
            content3.BackColor = Color.Gray
        ElseIf Form2.warna(1, 3) = "4" Then
            header3.BackColor = Color.Orange
            content3.BackColor = Color.Orange
        ElseIf Form2.warna(1, 3) = "5" Then
            header3.BackColor = Color.Pink
            content3.BackColor = Color.Pink
        End If

        If content4.Text = "-" Or content4.Text = "" Then
            content4.BackColor = Color.LimeGreen
            content4.Text = "-"
        ElseIf Form2.warna(1, 4) = "" Then
            content4.BackColor = Color.Cyan
            header4.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 4) = "1" Then
            header4.BackColor = Color.Red
            content4.BackColor = Color.Red
        ElseIf Form2.warna(1, 4) = "2" Then
            header4.BackColor = Color.Red
            content4.BackColor = Color.Red
        ElseIf Form2.warna(1, 4) = "3" Then
            header4.BackColor = Color.Gray
            content4.BackColor = Color.Gray
        ElseIf Form2.warna(1, 4) = "4" Then
            header4.BackColor = Color.Orange
            content4.BackColor = Color.Orange
        ElseIf Form2.warna(1, 4) = "5" Then
            header4.BackColor = Color.Pink
            content4.BackColor = Color.Pink
        End If

        If content5.Text = "-" Or content5.Text = "" Then
            content5.BackColor = Color.LimeGreen
            content5.Text = "-"
        ElseIf Form2.warna(1, 5) = "" Then
            content5.BackColor = Color.Cyan
            header5.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 5) = "1" Then
            header5.BackColor = Color.Red
            content5.BackColor = Color.Red
        ElseIf Form2.warna(1, 5) = "2" Then
            header5.BackColor = Color.Red
            content5.BackColor = Color.Red
        ElseIf Form2.warna(1, 5) = "3" Then
            header5.BackColor = Color.Gray
            content5.BackColor = Color.Gray
        ElseIf Form2.warna(1, 5) = "4" Then
            header5.BackColor = Color.Orange
            content5.BackColor = Color.Orange
        ElseIf Form2.warna(1, 5) = "5" Then
            header5.BackColor = Color.Pink
            content5.BackColor = Color.Pink
        End If


        If content6.Text = "-" Or content6.Text = "" Then
            content6.BackColor = Color.LimeGreen
            content6.Text = "-"
        ElseIf Form2.warna(1, 6) = "" Then
            content6.BackColor = Color.Cyan
            header6.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 6) = "1" Then
            header6.BackColor = Color.Red
            content6.BackColor = Color.Red
        ElseIf Form2.warna(1, 6) = "2" Then
            header6.BackColor = Color.Red
            content6.BackColor = Color.Red
        ElseIf Form2.warna(1, 6) = "3" Then
            header6.BackColor = Color.Gray
            content6.BackColor = Color.Gray
        ElseIf Form2.warna(1, 6) = "4" Then
            header6.BackColor = Color.Orange
            content6.BackColor = Color.Orange
        ElseIf Form2.warna(1, 6) = "5" Then
            header6.BackColor = Color.Pink
            content6.BackColor = Color.Pink
        End If

        If content7.Text = "-" Or content7.Text = "" Then
            content7.BackColor = Color.LimeGreen
            content7.Text = "-"
        ElseIf Form2.warna(1, 7) = "" Then
            content7.BackColor = Color.Cyan
            header7.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 7) = "1" Then
            header7.BackColor = Color.Red
            content7.BackColor = Color.Red
        ElseIf Form2.warna(1, 7) = "2" Then
            header7.BackColor = Color.Red
            content7.BackColor = Color.Red
        ElseIf Form2.warna(1, 7) = "3" Then
            header7.BackColor = Color.Gray
            content7.BackColor = Color.Gray
        ElseIf Form2.warna(1, 7) = "4" Then
            header7.BackColor = Color.Orange
            content7.BackColor = Color.Orange
        ElseIf Form2.warna(1, 7) = "5" Then
            header7.BackColor = Color.Pink
            content7.BackColor = Color.Pink
        End If

        If content8.Text = "-" Or content8.Text = "" Then
            content8.BackColor = Color.LimeGreen
            content8.Text = "-"
        ElseIf Form2.warna(1, 8) = "" Then
            content8.BackColor = Color.Cyan
            header8.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 8) = "1" Then
            header8.BackColor = Color.Red
            content8.BackColor = Color.Red
        ElseIf Form2.warna(1, 8) = "2" Then
            header8.BackColor = Color.Red
            content8.BackColor = Color.Red
        ElseIf Form2.warna(1, 8) = "3" Then
            header8.BackColor = Color.Gray
            content8.BackColor = Color.Gray
        ElseIf Form2.warna(1, 8) = "4" Then
            header8.BackColor = Color.Orange
            content8.BackColor = Color.Orange
        ElseIf Form2.warna(1, 8) = "5" Then
            header8.BackColor = Color.Pink
            content8.BackColor = Color.Pink
        End If

        If content9.Text = "-" Or content9.Text = "" Then
            content9.BackColor = Color.LimeGreen
            content9.Text = "-"
        ElseIf Form2.warna(1, 9) = "" Then
            content9.BackColor = Color.Cyan
            header9.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 9) = "1" Then
            header9.BackColor = Color.Red
            content9.BackColor = Color.Red
        ElseIf Form2.warna(1, 9) = "2" Then
            header9.BackColor = Color.Red
            content9.BackColor = Color.Red
        ElseIf Form2.warna(1, 9) = "3" Then
            header9.BackColor = Color.Gray
            content9.BackColor = Color.Gray
        ElseIf Form2.warna(1, 9) = "4" Then
            header9.BackColor = Color.Orange
            content9.BackColor = Color.Orange
        ElseIf Form2.warna(1, 9) = "5" Then
            header9.BackColor = Color.Pink
            content9.BackColor = Color.Pink
        End If

        If content10.Text = "-" Or content10.Text = "" Then
            content10.BackColor = Color.LimeGreen
            content10.Text = "-"
        ElseIf Form2.warna(1, 10) = "" Then
            content10.BackColor = Color.Cyan
            header10.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 10) = "1" Then
            header10.BackColor = Color.Red
            content10.BackColor = Color.Red
        ElseIf Form2.warna(1, 10) = "2" Then
            header10.BackColor = Color.Red
            content10.BackColor = Color.Red
        ElseIf Form2.warna(1, 10) = "3" Then
            header10.BackColor = Color.Gray
            content10.BackColor = Color.Gray
        ElseIf Form2.warna(1, 10) = "4" Then
            header10.BackColor = Color.Orange
            content10.BackColor = Color.Orange
        ElseIf Form2.warna(1, 10) = "5" Then
            header10.BackColor = Color.Pink
            content10.BackColor = Color.Pink
        End If

        If content11.Text = "-" Or content11.Text = "" Then
            content11.BackColor = Color.LimeGreen
            content11.Text = "-"
        ElseIf Form2.warna(1, 11) = "" Then
            content11.BackColor = Color.Cyan
            header11.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 11) = "1" Then
            header11.BackColor = Color.Red
            content11.BackColor = Color.Red
        ElseIf Form2.warna(1, 11) = "2" Then
            header11.BackColor = Color.Red
            content11.BackColor = Color.Red
        ElseIf Form2.warna(1, 11) = "3" Then
            header11.BackColor = Color.Gray
            content11.BackColor = Color.Gray
        ElseIf Form2.warna(1, 11) = "4" Then
            header11.BackColor = Color.Orange
            content11.BackColor = Color.Orange
        ElseIf Form2.warna(1, 11) = "5" Then
            header11.BackColor = Color.Pink
            content11.BackColor = Color.Pink
        End If

        If content12.Text = "-" Or content12.Text = "" Then
            content12.BackColor = Color.LimeGreen
            content12.Text = "-"
        ElseIf Form2.warna(1, 12) = "" Then
            content12.BackColor = Color.Cyan
            header12.BackColor = Color.Cyan
        ElseIf Form2.warna(1, 12) = "1" Then
            header12.BackColor = Color.Red
            content12.BackColor = Color.Red
        ElseIf Form2.warna(1, 12) = "2" Then
            header12.BackColor = Color.Red
            content12.BackColor = Color.Red
        ElseIf Form2.warna(1, 12) = "3" Then
            header12.BackColor = Color.Gray
            content12.BackColor = Color.Gray
        ElseIf Form2.warna(1, 12) = "4" Then
            header12.BackColor = Color.Orange
            content12.BackColor = Color.Orange
        ElseIf Form2.warna(1, 12) = "5" Then
            header12.BackColor = Color.Pink
            content12.BackColor = Color.Pink
        End If
            cek_font()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        slide_now = 1
        vin.Text = Form1.posnya
        Call cek_font()
    End Sub
    Sub cek_font()
        If header1.Text.Count <= 5 Then
            header1.Font = New Font("Times New Roman", 9)
        ElseIf header1.Text.Count <= 10 Then
            header1.Font = New Font("Times New Roman", 10)
        ElseIf header1.Text.Count <= 17 Then
            header1.Font = New Font("Times New Roman", 8)
        Else
            header1.Font = New Font("Times New Roman", 8)
        End If

        If content1.Text.Count <= 3 Then
            content1.Font = New Font("Times New Roman", 35)
        ElseIf content1.Text.Count <= 6 Then
            content1.Font = New Font("Times New Roman", 28)
        ElseIf content1.Text.Count <= 9 Then
            content1.Font = New Font("Times New Roman", 24)
        ElseIf content1.Text.Count <= 12 Then
            content1.Font = New Font("Times New Roman", 22)
        ElseIf content1.Text.Count <= 20 Then
            content1.Font = New Font("Times New Roman", 20)
        Else
            content1.Font = New Font("Times New Roman", 18)
        End If

        If header2.Text.Count <= 5 Then
            header2.Font = New Font("Times New Roman", 9)
        ElseIf header2.Text.Count <= 10 Then
            header2.Font = New Font("Times New Roman", 10)
        ElseIf header2.Text.Count <= 17 Then
            header2.Font = New Font("Times New Roman", 8)
        Else
            header2.Font = New Font("Times New Roman", 8)
        End If

        If content2.Text.Count <= 3 Then
            content2.Font = New Font("Times New Roman", 35)
        ElseIf content2.Text.Count <= 6 Then
            content2.Font = New Font("Times New Roman", 28)
        ElseIf content2.Text.Count <= 9 Then
            content2.Font = New Font("Times New Roman", 24)
        ElseIf content2.Text.Count <= 12 Then
            content2.Font = New Font("Times New Roman", 22)
        ElseIf content2.Text.Count <= 20 Then
            content2.Font = New Font("Times New Roman", 20)
        Else
            content2.Font = New Font("Times New Roman", 18)
        End If

        If header3.Text.Count <= 5 Then
            header3.Font = New Font("Times New Roman", 9)
        ElseIf header3.Text.Count <= 10 Then
            header3.Font = New Font("Times New Roman", 10)
        ElseIf header3.Text.Count <= 17 Then
            header3.Font = New Font("Times New Roman", 8)
        Else
            header3.Font = New Font("Times New Roman", 8)
        End If

        If content3.Text.Count <= 3 Then
            content3.Font = New Font("Times New Roman", 35)
        ElseIf content3.Text.Count <= 6 Then
            content3.Font = New Font("Times New Roman", 28)
        ElseIf content3.Text.Count <= 9 Then
            content3.Font = New Font("Times New Roman", 24)
        ElseIf content3.Text.Count <= 12 Then
            content3.Font = New Font("Times New Roman", 22)
        ElseIf content3.Text.Count <= 20 Then
            content3.Font = New Font("Times New Roman", 20)
        Else
            content3.Font = New Font("Times New Roman", 18)
        End If

        If header4.Text.Count <= 5 Then
            header4.Font = New Font("Times New Roman", 9)
        ElseIf header4.Text.Count <= 10 Then
            header4.Font = New Font("Times New Roman", 10)
        ElseIf header4.Text.Count <= 17 Then
            header4.Font = New Font("Times New Roman", 8)
        Else
            header4.Font = New Font("Times New Roman", 8)
        End If

        If content4.Text.Count <= 3 Then
            content4.Font = New Font("Times New Roman", 35)
        ElseIf content4.Text.Count <= 6 Then
            content4.Font = New Font("Times New Roman", 28)
        ElseIf content4.Text.Count <= 9 Then
            content4.Font = New Font("Times New Roman", 24)
        ElseIf content4.Text.Count <= 12 Then
            content4.Font = New Font("Times New Roman", 22)
        ElseIf content4.Text.Count <= 20 Then
            content4.Font = New Font("Times New Roman", 20)
        Else
            content4.Font = New Font("Times New Roman", 18)
        End If

        If header5.Text.Count <= 5 Then
            header5.Font = New Font("Times New Roman", 9)
        ElseIf header5.Text.Count <= 10 Then
            header5.Font = New Font("Times New Roman", 10)
        ElseIf header5.Text.Count <= 17 Then
            header5.Font = New Font("Times New Roman", 8)
        Else
            header5.Font = New Font("Times New Roman", 8)
        End If

        If content5.Text.Count <= 3 Then
            content5.Font = New Font("Times New Roman", 35)
        ElseIf content5.Text.Count <= 6 Then
            content5.Font = New Font("Times New Roman", 28)
        ElseIf content5.Text.Count <= 9 Then
            content5.Font = New Font("Times New Roman", 24)
        ElseIf content5.Text.Count <= 12 Then
            content5.Font = New Font("Times New Roman", 22)
        ElseIf content5.Text.Count <= 20 Then
            content5.Font = New Font("Times New Roman", 20)
        Else
            content5.Font = New Font("Times New Roman", 18)
        End If

        If header6.Text.Count <= 5 Then
            header6.Font = New Font("Times New Roman", 9)
        ElseIf header6.Text.Count <= 10 Then
            header6.Font = New Font("Times New Roman", 10)
        ElseIf header6.Text.Count <= 17 Then
            header6.Font = New Font("Times New Roman", 8)
        Else
            header6.Font = New Font("Times New Roman", 8)
        End If

        If content6.Text.Count <= 3 Then
            content6.Font = New Font("Times New Roman", 35)
        ElseIf content6.Text.Count <= 6 Then
            content6.Font = New Font("Times New Roman", 28)
        ElseIf content6.Text.Count <= 9 Then
            content6.Font = New Font("Times New Roman", 24)
        ElseIf content6.Text.Count <= 12 Then
            content6.Font = New Font("Times New Roman", 22)
        ElseIf content6.Text.Count <= 20 Then
            content6.Font = New Font("Times New Roman", 20)
        Else
            content6.Font = New Font("Times New Roman", 18)
        End If

        If header7.Text.Count <= 5 Then
            header7.Font = New Font("Times New Roman", 9)
        ElseIf header7.Text.Count <= 10 Then
            header7.Font = New Font("Times New Roman", 10)
        ElseIf header7.Text.Count <= 17 Then
            header7.Font = New Font("Times New Roman", 8)
        Else
            header7.Font = New Font("Times New Roman", 8)
        End If

        If content7.Text.Count <= 3 Then
            content7.Font = New Font("Times New Roman", 35)
        ElseIf content7.Text.Count <= 6 Then
            content7.Font = New Font("Times New Roman", 28)
        ElseIf content7.Text.Count <= 9 Then
            content7.Font = New Font("Times New Roman", 24)
        ElseIf content7.Text.Count <= 12 Then
            content7.Font = New Font("Times New Roman", 22)
        ElseIf content7.Text.Count <= 20 Then
            content7.Font = New Font("Times New Roman", 20)
        Else
            content7.Font = New Font("Times New Roman", 18)
        End If

        If header8.Text.Count <= 5 Then
            header8.Font = New Font("Times New Roman", 9)
        ElseIf header8.Text.Count <= 10 Then
            header8.Font = New Font("Times New Roman", 10)
        ElseIf header8.Text.Count <= 17 Then
            header8.Font = New Font("Times New Roman", 8)
        Else
            header8.Font = New Font("Times New Roman", 8)
        End If

        If content8.Text.Count <= 3 Then
            content8.Font = New Font("Times New Roman", 35)
        ElseIf content8.Text.Count <= 6 Then
            content8.Font = New Font("Times New Roman", 28)
        ElseIf content8.Text.Count <= 9 Then
            content8.Font = New Font("Times New Roman", 24)
        ElseIf content8.Text.Count <= 12 Then
            content8.Font = New Font("Times New Roman", 22)
        ElseIf content8.Text.Count <= 20 Then
            content8.Font = New Font("Times New Roman", 20)
        Else
            content8.Font = New Font("Times New Roman", 18)
        End If

        If header9.Text.Count <= 5 Then
            header9.Font = New Font("Times New Roman", 9)
        ElseIf header9.Text.Count <= 10 Then
            header9.Font = New Font("Times New Roman", 10)
        ElseIf header9.Text.Count <= 17 Then
            header9.Font = New Font("Times New Roman", 8)
        Else
            header9.Font = New Font("Times New Roman", 8)
        End If

        If content9.Text.Count <= 3 Then
            content9.Font = New Font("Times New Roman", 35)
        ElseIf content9.Text.Count <= 6 Then
            content9.Font = New Font("Times New Roman", 28)
        ElseIf content9.Text.Count <= 9 Then
            content9.Font = New Font("Times New Roman", 24)
        ElseIf content9.Text.Count <= 12 Then
            content9.Font = New Font("Times New Roman", 22)
        ElseIf content9.Text.Count <= 20 Then
            content9.Font = New Font("Times New Roman", 20)
        Else
            content9.Font = New Font("Times New Roman", 18)
        End If

        If header10.Text.Count <= 5 Then
            header10.Font = New Font("Times New Roman", 9)
        ElseIf header10.Text.Count <= 10 Then
            header10.Font = New Font("Times New Roman", 10)
        ElseIf header10.Text.Count <= 17 Then
            header10.Font = New Font("Times New Roman", 8)
        Else
            header10.Font = New Font("Times New Roman", 8)
        End If

        If content10.Text.Count <= 3 Then
            content10.Font = New Font("Times New Roman", 35)
        ElseIf content10.Text.Count <= 6 Then
            content10.Font = New Font("Times New Roman", 28)
        ElseIf content10.Text.Count <= 9 Then
            content10.Font = New Font("Times New Roman", 24)
        ElseIf content10.Text.Count <= 12 Then
            content10.Font = New Font("Times New Roman", 22)
        ElseIf content10.Text.Count <= 20 Then
            content10.Font = New Font("Times New Roman", 20)
        Else
            content10.Font = New Font("Times New Roman", 18)
        End If

        If header11.Text.Count <= 5 Then
            header11.Font = New Font("Times New Roman", 9)
        ElseIf header11.Text.Count <= 10 Then
            header11.Font = New Font("Times New Roman", 10)
        ElseIf header11.Text.Count <= 17 Then
            header11.Font = New Font("Times New Roman", 8)
        Else
            header11.Font = New Font("Times New Roman", 8)
        End If

        If content11.Text.Count <= 3 Then
            content11.Font = New Font("Times New Roman", 35)
        ElseIf content11.Text.Count <= 6 Then
            content11.Font = New Font("Times New Roman", 28)
        ElseIf content11.Text.Count <= 9 Then
            content11.Font = New Font("Times New Roman", 24)
        ElseIf content11.Text.Count <= 12 Then
            content11.Font = New Font("Times New Roman", 22)
        ElseIf content11.Text.Count <= 20 Then
            content11.Font = New Font("Times New Roman", 20)
        Else
            content11.Font = New Font("Times New Roman", 18)
        End If

        If header12.Text.Count <= 5 Then
            header12.Font = New Font("Times New Roman", 9)
        ElseIf header12.Text.Count <= 10 Then
            header12.Font = New Font("Times New Roman", 10)
        ElseIf header12.Text.Count <= 17 Then
            header12.Font = New Font("Times New Roman", 8)
        Else
            header12.Font = New Font("Times New Roman", 8)
        End If

        If content12.Text.Count <= 3 Then
            content12.Font = New Font("Times New Roman", 35)
        ElseIf content12.Text.Count <= 6 Then
            content12.Font = New Font("Times New Roman", 28)
        ElseIf content12.Text.Count <= 9 Then
            content12.Font = New Font("Times New Roman", 24)
        ElseIf content12.Text.Count <= 12 Then
            content12.Font = New Font("Times New Roman", 22)
        ElseIf content12.Text.Count <= 20 Then
            content12.Font = New Font("Times New Roman", 20)
        Else
            content12.Font = New Font("Times New Roman", 18)
        End If
    End Sub

    Private Sub content15_Click(sender As Object, e As EventArgs) Handles content15.Click
        content15.BackColor = Color.LimeGreen
        Dim con As Integer = 0
        If slide_now <= Form2.slide And content1.BackColor = Color.LimeGreen And content2.BackColor = Color.LimeGreen And content3.BackColor = Color.LimeGreen And content4.BackColor = Color.LimeGreen And content5.BackColor = Color.LimeGreen And content6.BackColor = Color.LimeGreen And content7.BackColor = Color.LimeGreen And content8.BackColor = Color.LimeGreen And content9.BackColor = Color.LimeGreen And content10.BackColor = Color.LimeGreen And content11.BackColor = Color.LimeGreen And content12.BackColor = Color.LimeGreen And content13.BackColor = Color.LimeGreen And content14.BackColor = Color.LimeGreen And content15.BackColor = Color.LimeGreen Then
            slide_now = 1
            next_liffting = liffting.Text + 1
            If next_liffting <= 9999 Then
            Else
                next_liffting = 1
            End If
            Call Form2.clean_isi()
            Call bersih()
            Call Form2.scan(next_liffting)
            Koneksi_content()
            If connection_content = True Then
                Try
                    For index = 1 To 15
                        con += 1
                        Call Form2.panggil_db(con)
                    Next
                    Call isikan(1)
                    vin.Text = Form1.posnya
                Catch ex As Exception
                    MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA | Position Tb_Master_Content")
                End Try
            Else
                MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA")
            End If
        ElseIf content1.BackColor = Color.LimeGreen And content2.BackColor = Color.LimeGreen And content3.BackColor = Color.LimeGreen And content4.BackColor = Color.LimeGreen And content5.BackColor = Color.LimeGreen And content6.BackColor = Color.LimeGreen And content7.BackColor = Color.LimeGreen And content8.BackColor = Color.LimeGreen And content9.BackColor = Color.LimeGreen And content10.BackColor = Color.LimeGreen And content11.BackColor = Color.LimeGreen And content12.BackColor = Color.LimeGreen And content13.BackColor = Color.LimeGreen And content14.BackColor = Color.LimeGreen And content15.BackColor = Color.LimeGreen Then
            slide_now = slide_now + 1
            Call Form2.clean_isi()
            Call bersih()
            Call Form2.scan(liffting.Text)
            Koneksi_content()
            If connection_content = True Then
                Try
                    Call Form2.panggil_db(next_liffting)
                    Call isikan(slide_now)
                    vin.Text = Form1.posnya
                Catch ex As Exception
                    MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA | Position Tb_Master_Content")
                End Try
            Else
                MsgBox("GET DATA GAGAL | CEK JARINGAN ANDA")
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form2.Show()
        Call bersih()
    End Sub

    Private Sub content1_Click(sender As Object, e As EventArgs) Handles content1.Click
        content1.BackColor = Color.LimeGreen
    End Sub

    Private Sub content2_Click(sender As Object, e As EventArgs) Handles content2.Click
        content2.BackColor = Color.LimeGreen
    End Sub

    Private Sub content3_Click(sender As Object, e As EventArgs) Handles content3.Click
        content3.BackColor = Color.LimeGreen
    End Sub

    Private Sub content4_Click(sender As Object, e As EventArgs) Handles content4.Click
        content4.BackColor = Color.LimeGreen
    End Sub

    Private Sub content5_Click(sender As Object, e As EventArgs) Handles content5.Click
        content5.BackColor = Color.LimeGreen
    End Sub

    Private Sub content6_Click(sender As Object, e As EventArgs) Handles content6.Click
        content6.BackColor = Color.LimeGreen
    End Sub

    Private Sub content7_Click(sender As Object, e As EventArgs) Handles content7.Click
        content7.BackColor = Color.LimeGreen
    End Sub

    Private Sub content8_Click(sender As Object, e As EventArgs) Handles content8.Click
        content8.BackColor = Color.LimeGreen
    End Sub

    Private Sub content9_Click(sender As Object, e As EventArgs) Handles content9.Click
        content9.BackColor = Color.LimeGreen
    End Sub

    Private Sub content10_Click(sender As Object, e As EventArgs) Handles content10.Click
        content10.BackColor = Color.LimeGreen
    End Sub

    Private Sub content11_Click(sender As Object, e As EventArgs) Handles content11.Click
        content11.BackColor = Color.LimeGreen
    End Sub

    Private Sub content12_Click(sender As Object, e As EventArgs) Handles content12.Click
        content12.BackColor = Color.LimeGreen
    End Sub

    Private Sub content13_Click(sender As Object, e As EventArgs) Handles content13.Click
        content13.BackColor = Color.LimeGreen
    End Sub

    Private Sub content14_Click(sender As Object, e As EventArgs) Handles content14.Click
        content14.BackColor = Color.LimeGreen
    End Sub
End Class