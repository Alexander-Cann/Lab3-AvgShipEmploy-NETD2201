Option Strict On

Public Class EmployeeShippedAverages

    Dim units(2, 6) As Integer
    Dim AverageData(6) As Integer
    Dim totalUnits(2) As Double
    Public day As Integer = 1
    Public employee As Integer = 1
    Public validNumber As Boolean = False


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbEmployee2.Click

    End Sub

    Public Sub Reset()
        Application.Restart()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        validNumber = False
        Dim userInput As Integer
        validNumber = Integer.TryParse(tbInput.Text, userInput)

        If employee = 1 Then
            If userInput >= 0 AndAlso userInput <= 1000 AndAlso validNumber = True Then
                units(employee - 1, day - 1) = Int32.Parse(tbInput.Text)
                tbData1.Text += "Day " & day & " : " & userInput & Environment.NewLine
                day += 1
                tbInput.Text = ""
                lbDay.Text = "Day " & day

            Else
                MessageBox.Show("Entered data either isn't a whole number or is not between 0-1000 inclusive", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                tbInput.SelectAll()
                tbInput.Focus()
            End If
        ElseIf employee = 2 Then
            If userInput >= 0 AndAlso userInput <= 1000 AndAlso validNumber = True Then
                units(employee - 1, day - 1) = Int32.Parse(tbInput.Text)
                tbData2.Text += "Day " & day & " : " & userInput & Environment.NewLine
                day += 1
                tbInput.Text = ""
                lbDay.Text = "Day " & day

            Else
                MessageBox.Show("Entered data either isn't a whole number or is not between 0-1000 inclusive", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                tbInput.SelectAll()
                tbInput.Focus()
            End If
        ElseIf employee = 3 Then
            If userInput >= 0 AndAlso userInput <= 1000 AndAlso validNumber = True Then
                units(employee - 1, day - 1) = Int32.Parse(tbInput.Text)
                tbData3.Text += "Day " & day & " : " & userInput & Environment.NewLine
                day += 1
                tbInput.Text = ""
                lbDay.Text = "Day " & day

            Else
                MessageBox.Show("Entered data either isn't a whole number or is not between 0-1000 inclusive", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                tbInput.SelectAll()
                tbInput.Focus()
            End If
        End If

        If day = 8 AndAlso employee = 3 Then
            For x As Integer = 0 To 6 Step 1
                AverageData(x) = units(2, x)
            Next
            Dim average As Double = Math.Round(AverageData.Average(), 2, MidpointRounding.AwayFromZero)
            tbDataAverage3.Text = "Average: " & average.ToString()
            totalUnits(employee - 1) = average
            tbInput.[ReadOnly] = True
            average = Math.Round(totalUnits.Average(), 2, MidpointRounding.AwayFromZero)
            tbCompanyAverage.Text = "Average per day: " & average.ToString()
            btnEnter.Enabled = False
            lbDay.Text = "Day 1"

        ElseIf day = 8 Then
            If employee = 1 Then
                For x As Integer = 0 To 6 Step 1
                    AverageData(x) = units(0, x)
                Next
                Dim average As Double = Math.Round(AverageData.Average(), 2, MidpointRounding.AwayFromZero)
                tbDataAverage1.Text = "Average: " & average.ToString()
                totalUnits(employee - 1) = average
                lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
                lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Bold)
            ElseIf employee = 2 Then
                For x As Integer = 0 To 6 Step 1
                    AverageData(x) = units(1, x)
                Next
                Dim average As Double = Math.Round(AverageData.Average(), 2, MidpointRounding.AwayFromZero)
                tbDataAverage2.Text = "Average: " & average.ToString()
                totalUnits(employee - 1) = average
                lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Regular)
                lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Bold)
            End If
            employee += 1
            day = 1
            lbDay.Text = "Day 1"

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
