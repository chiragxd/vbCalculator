Public Class frmCalculator
    Dim firstVal As Double
    Dim secondVal As Double
    Dim result As Double
    Dim Oper As String
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub enterNumber(sender As Object, e As EventArgs) Handles btnZero.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnOne.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click, btnDot.Click
        Dim B As Button = sender

        If (txtIN.Text = "0") Then
            txtIN.Text = ""
            txtIN.Text = B.Text
        ElseIf (B.Text = ".") Then
            If (Not txtIN.Text.Contains(".")) Then
                txtIN.Text = txtIN.Text + B.Text
            End If
        Else
            txtIN.Text = txtIN.Text + B.Text
        End If
    End Sub

    Private Sub btnBS_Click(sender As Object, e As EventArgs) Handles btnBS.Click
        If (txtIN.Text.Length > 0) Then
            txtIN.Text = txtIN.Text.Remove(txtIN.Text.Length - 1, 1)
        End If
        If (txtIN.Text.Length = 0) Then
            txtIN.Text = 0
        End If
    End Sub

    Private Sub arithOps(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMult.Click, btnMinus.Click, btnDiv.Click, btnMod.Click
        Dim b As Button = sender
        firstVal = txtIN.Text
        Oper = b.Text
        txtIN.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        secondVal = txtIN.Text

        If Oper = "+" Then
            result = firstVal + secondVal
            txtIN.Text = result
        End If
        If Oper = "-" Then
            result = firstVal - secondVal
            txtIN.Text = result
        End If
        If Oper = "*" Then
            result = firstVal * secondVal
            txtIN.Text = result
        End If
        If Oper = "/" Then
            result = firstVal / secondVal
            txtIN.Text = result
        End If
        If Oper = "%" Then
            result = firstVal Mod secondVal
            txtIN.Text = result
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtIN.Text = 0
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtIN.Text = 0
    End Sub
End Class
