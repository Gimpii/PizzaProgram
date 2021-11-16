Imports System.Text.RegularExpressions
Public Class Pizza103
    'set up a record or "class" for a student
    Public isValid As Boolean
    Class STUDENT
        'Store any numberical values that do not require mathmatical calculations as Strings
        Public studID As Int16
        Public firstName As String
        Public lastName As String
        Public deliveryDate As String
        Public postcode As String
        Public quantity As Byte
        Public phoneNo As String
        Public street As String
        Public suburb As String
        Public hour As Byte
        Public minute As Byte
        Public pizzaBase As String
        Public top1 As Boolean
        Public top2 As Boolean
        Public top3 As Boolean
        Public top4 As Boolean

    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0
    Dim basePrice As Single
    Dim top1Price As Single
    Dim top2Price As Single
    Dim top3Price As Single
    Dim top4Price As Single
    Dim topPrice As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load default prices
        basePrice = 10.0
        txtQuantity.Text = 0
        top1Price = 0.3
        top2Price = 0.45
        top3Price = 0.9
        top4Price = 1.3

        'display prices'
        txtBasePrice.Text = FormatCurrency(basePrice)
        txtTop1.Text = FormatCurrency(top1Price)
        txtTop2.Text = FormatCurrency(top2Price)
        txtTop3.Text = FormatCurrency(top3Price)
        txtTop4.Text = FormatCurrency(top4Price)

        'load 4 test records
        students(0).studID = 1
        students(0).firstName = "Johnny"
        students(0).lastName = "Depp"
        students(0).deliveryDate = "9/6/63"
        students(0).postcode = "m"
        students(0).quantity = 78.2
        students(1).studID = 2
        students(1).firstName = "Jennifer"
        students(1).lastName = "Lawrence"
        students(1).deliveryDate = "15/8/90"
        students(1).postcode = "f"
        students(1).quantity = 88.2
        students(2).studID = 3
        students(2).firstName = "George"
        students(2).lastName = "Clooney"
        students(2).deliveryDate = "6/5/61"
        students(2).postcode = "m"
        students(2).quantity = 68.2
        students(3).studID = 4
        students(3).firstName = "Scarlett"
        students(3).lastName = "Johansson"
        students(3).deliveryDate = "22/11/84"
        students(3).postcode = "f"
        students(3).quantity = 72.2
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click

        isValid = True
        validateStrBox(txtFirstName, "First Name")
        validateStrBox(txtLastName, "Last Name")
        validateStrBox(txtSuburb, "Suburb")

        If txtPhoneNumber.Text.Contains(" ") Then
            MsgBox("Please do not use spaces within the phone number box")
            Return
        End If
        Dim postCode = New Regex("^\d{4}$")
        Dim postCodeMatch = postCode.Match(txtPostcode.Text)
        If Not postCodeMatch.Success Then
            MsgBox("Please enter a valid 4 digit Australian PostCode")
            Return
        End If 'Block of Code credited to Aiden Gardner @aiden2480 on Github

        If isValid = True Then
            students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value
            'place text from text boxes into the array - first students(0), then students(1), students(2) etc
            students(studentCount).firstName = txtFirstName.Text
            students(studentCount).lastName = txtLastName.Text
            students(studentCount).deliveryDate = dteDelivery.Text & " " & cboHour.Text & ":" & cboMinutes.Text
            students(studentCount).postcode = txtPostcode.Text
            students(studentCount).quantity = txtQuantity.Text
            studentCount += 1
            'return text boxes to blank ready for next entry
            txtFirstName.Text = ""
            txtLastName.Text = ""
            dteDelivery.Text = ""
            txtPostcode.Text = ""
            txtQuantity.Text = 0
            displayList()
        End If

    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        txtStList.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & "-" & students(i).firstName & "-" &
                              UCase(students(i).lastName) & "-" & students(i).deliveryDate & "-" &
                              students(i).postcode & "-" & students(i).quantity & "-" & students(i).pizzaBase & ": Ach " & students(i).top1 & ": Olive " & students(i).top2 & ": Cab " & students(i).top3 & ": Parm " & students(i).top4)
        Next
    End Sub

    Private Sub CalcToppedPrice()
        Dim toppedPrice As Single
        toppedPrice = basePrice
        If chkAnchovies.Checked Then
            toppedPrice += top1Price
        End If
        If chkOlives.Checked Then
            toppedPrice += top2Price
        End If
        If chkCabanossi.Checked Then
            toppedPrice += top3Price
        End If
        If chkPamesan.Checked Then
            toppedPrice += top4Price
        End If
        txtTopPrice.Text = FormatCurrency(toppedPrice)
        topPrice = toppedPrice
    End Sub

    Private Sub chkAnchovies_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnchovies.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkOlives_CheckedChanged(sender As Object, e As EventArgs) Handles chkOlives.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkCabanossi_CheckedChanged(sender As Object, e As EventArgs) Handles chkCabanossi.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkPamesan_CheckedChanged(sender As Object, e As EventArgs) Handles chkPamesan.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub validateStrBox(box As TextBox, name As String)
        Dim int As Integer
        If box.Text = "" Then
            MsgBox("Please input valid answer for " + name)
            isValid = False
            Exit Sub
        End If

        If Integer.TryParse(box.Text, int) Then
            MsgBox("Please only enter characters for " + name)
            isValid = False
        End If
    End Sub
    Private Sub CalcTotalPrice()

        If txtQuantity.Text = "" Then
            txtQuantity.Text = 0
        End If

        Dim int As Integer
        If Not Integer.TryParse(txtQuantity.Text, int) Then
            MsgBox("Enter a whole number", MsgBoxStyle.Exclamation)
            txtQuantity.Focus()
        Else
            txtTotalPrice.Text = FormatCurrency(topPrice * int)
        End If

        If txtQuantity.Text > 15 Then
            MsgBox("15 Pizzas per order at max")
            txtQuantity.Text = 15
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        CalcTotalPrice()
    End Sub

    Private Sub radThin_CheckedChanged(sender As Object, e As EventArgs) Handles radThin.CheckedChanged
        If radThin.Checked Then
            students(studentCount).pizzaBase = "Thin"
        End If
    End Sub

    Private Sub radCrispy_CheckedChanged(sender As Object, e As EventArgs) Handles radCrispy.CheckedChanged
        If radCrispy.Checked Then
            students(studentCount).pizzaBase = "Crispy"
        End If
    End Sub

    Private Sub radFat_CheckedChanged(sender As Object, e As EventArgs) Handles radFat.CheckedChanged
        If radFat.Checked Then
            students(studentCount).pizzaBase = "Fat"
        End If
    End Sub
End Class
