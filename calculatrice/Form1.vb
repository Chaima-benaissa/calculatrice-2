Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        affiche.Text = A + " " + op + " " + B

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        affiche.Text = A + " " + op + " " + B

    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt_Click(sender As Object, e As EventArgs) Handles bt.Click
        If Not A = " " Then
            op = "+"
        End If
        affiche.Text = A + " " + op + " " + B


    End Sub

    Private Sub bt12_Click(sender As Object, e As EventArgs) Handles bt12.Click
        If Not A = " " Then
            op = "-"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt13_Click(sender As Object, e As EventArgs) Handles bt13.Click
        If Not A = " " Then
            op = "*"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub bt14_Click(sender As Object, e As EventArgs) Handles bt14.Click
        If Not A = " " Then
            op = "/"
        End If
        affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub c_Click(sender As Object, e As EventArgs) Handles c.Click
        affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = " " Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" Then
                res = va / vb
            Else
                MessageBox.Show("A et B doivent etre des entires")
                test = False

            End If
            If test Then
                affiche.Text = affiche.Text + "=" + res.ToString
            End If
        End If
    End Sub
End Class
