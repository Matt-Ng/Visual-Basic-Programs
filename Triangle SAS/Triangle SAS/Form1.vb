Public Class Form1
    Dim a, b, c, ans As Double

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' if base x height is selected, labels fill in
        If ComboBox1.Text = "Base x Height" Then
            Label2.Text = "Base"
            Label3.Text = "Height"
            Label4.Text = " "
            ' if herons formula is selected, labels fill in
        ElseIf ComboBox1.Text = "Heron's Formula" Then
            Label2.Text = "a"
            Label3.Text = "b"
            Label4.Text = "c"
            ' if sas is selected, labels fill in
        ElseIf ComboBox1.Text = "Side Angle Side" Then
            Label2.Text = "Side 1"
            Label3.Text = "Side 2"
            Label4.Text = "Angle"
            ' if hypotenuse is selected, labels fill in
        ElseIf ComboBox1.Text = "Hypotenuse" Then
            Label2.Text = "Side A"
            Label3.Text = "Side B"

            ' if degree to radian is selected, labels fill in
        ElseIf ComboBox1.Text = "Degree to Radian" Then
            Label2.Text = "Angle"
            Label3.Text = " "
            Label4.Text = " "
        End If
        


    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        ' base x height
        If ComboBox1.Text = "Base x Height" Then
            'declaring variables
            a = TextBox1.Text
            b = TextBox2.Text
            'formula for base x height
            ans = Math.Round(a * b / 2, 2)
            'output to textbox
            Answer.Text = ans
            ' herons forumla
        ElseIf ComboBox1.Text = "Heron's Formula" Then
            'declaring variables
            a = TextBox1.Text
            b = TextBox2.Text
            c = TextBox3.Text
            'variable for s in heron's formula
            Dim s As Double
            'formula to find s
            s = ((a + b + c) / 2)
            'formula to find the area
            ans = Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2)
            'output to textbox
            Answer.Text = ans
        ElseIf ComboBox1.Text = "Side Angle Side" Then
            'declaring variables
            a = TextBox1.Text
            b = TextBox2.Text
            c = TextBox3.Text
            Dim sine As Double
            'finding sin c
            sine = Math.Sin(c)
            'formula for sas
            ans = Math.Round((a * b * sine) / 2, 2)
            'output to textbox
            Answer.Text = ans
        ElseIf ComboBox1.Text = "Hypotenuse" Then
            'declaring variables
            a = TextBox1.Text
            b = TextBox2.Text
            'Hypotenuse formula
            ans = Math.Sqrt(a * a + b * b)
            'output to textbox
            Answer.Text = Math.Round(ans, 2)
        ElseIf ComboBox1.Text = "Degree to Radian" Then
            'declaring variable
            a = TextBox1.Text
            'formula for degree to radian
            ans = Math.Round((a * Math.PI) / 2, 2)
            'output to textbox
            Answer.Text = ans
        End If
    End Sub
End Class
