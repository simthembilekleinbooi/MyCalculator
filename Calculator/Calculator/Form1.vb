Public Class Calculator

    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim operation As Integer
    Dim Operatior_Selector As Boolean = False
    Dim Operator_Selector As Boolean

    Private Property Fisrtnum As String

    Private Property Operations As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btncoma.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnaddition.Click
        Fisrtnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnsubstract.Click
        Fisrtnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        Fisrtnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Fisrtnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 4 ' = /
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If Operator_Selector = True Then
            secondnum = txtDisplay.Text
            If Operations = 1 Then
                txtDisplay.Text = Firstnum + secondnum
            ElseIf Operations = 2 Then
                txtDisplay.Text = Firstnum - secondnum
            ElseIf Operations = 3 Then
                txtDisplay.Text = Firstnum * secondnum
            Else
                If secondnum = 0 Then
                    txtDisplay.Text = "Error!"
                Else
                    txtDisplay.Text = Firstnum / secondnum
                End If
            End If
            Operator_Selector = False

        End If
    End Sub
End Class


