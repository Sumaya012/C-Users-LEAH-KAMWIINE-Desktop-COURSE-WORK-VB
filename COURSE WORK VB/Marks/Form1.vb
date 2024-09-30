Public Class Form1

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnevaluate.Click
        Dim marks As Integer
        If Not Integer.TryParse(txtMarks.Text, marks) Then
            MessageBox.Show("Please enter a valid numeric value for marks.")
        End If
        If marks > 100 Then

            txtMarks.Text = "" 'sets the textbox to an empty string after a wrong entry
            'txtmarks.clear() ' textbox is cleared after a wrong entry
        ElseIf marks >= 90 And marks <= 100 Then
            txtGrade.Text = "Excellent"
        ElseIf marks >= 80 And marks <= 89 Then
            txtGrade.Text = "Very Good"
        ElseIf marks >= 70 And marks <= 79 Then
            txtGrade.Text = "Good"
        ElseIf marks >= 60 And marks <= 69 Then
            txtGrade.Text = "Medium"
        ElseIf marks >= 50 And marks <= 59 Then
            txtGrade.Text = "Pass"
        ElseIf marks >= 40 And marks <= 49 Then
            txtGrade.Text = "Failed"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
