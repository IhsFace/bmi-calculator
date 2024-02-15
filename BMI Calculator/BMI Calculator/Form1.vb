Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim fltHeight As Decimal = Val(txtHeight.Text)
        Dim fltWeight As Decimal = Val(txtWeight.Text)

        If fltHeight <= 0 OrElse fltWeight <= 0 Then
            MsgBox("Height and weight must be greater than zero")
            txtHeight.Focus()
            Return
        End If

        Dim fltBmi As Decimal = fltWeight / (fltHeight) ^ 2

        Select Case fltBmi
            Case Is < 18.5
                MsgBox("Underweight (< 18.5)")
            Case 18.5 To 24.9
                MsgBox("Normal weight (18.5 - 24.9)")
            Case 25 To 29.9
                MsgBox("Overweight (25 - 29.9)")
            Case Is >= 30
                MsgBox("Obese (>= 30)")
            Case Else
                MsgBox("There was an error when determining your BMI")
        End Select
    End Sub
End Class
