<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza104
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pizza104))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.txtStList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radCrispy = New System.Windows.Forms.RadioButton()
        Me.radFat = New System.Windows.Forms.RadioButton()
        Me.chkAnchovies = New System.Windows.Forms.CheckBox()
        Me.chkOlives = New System.Windows.Forms.CheckBox()
        Me.chkCabanossi = New System.Windows.Forms.CheckBox()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.cboMinutes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dteDelivery = New System.Windows.Forms.DateTimePicker()
        Me.chkPamesan = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTopPrice = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotalPrice = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBasePrice = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTop1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTop2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTop3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTop4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.override = New System.Windows.Forms.Button()
        Me.newPassword = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Coral
        Me.txtFirstName.Location = New System.Drawing.Point(54, 133)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(148, 33)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Coral
        Me.txtLastName.Location = New System.Drawing.Point(216, 133)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(148, 33)
        Me.txtLastName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.Color.Coral
        Me.txtPostcode.Location = New System.Drawing.Point(54, 203)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtPostcode.MaxLength = 4
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(148, 33)
        Me.txtPostcode.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Coral
        Me.txtQuantity.Location = New System.Drawing.Point(540, 133)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtQuantity.Size = New System.Drawing.Size(148, 33)
        Me.txtQuantity.TabIndex = 3
        '
        'btnAddStud
        '
        Me.btnAddStud.Location = New System.Drawing.Point(378, 364)
        Me.btnAddStud.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(153, 35)
        Me.btnAddStud.TabIndex = 11
        Me.btnAddStud.Text = "Add Order"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'txtStList
        '
        Me.txtStList.BackColor = System.Drawing.Color.Coral
        Me.txtStList.FormattingEnabled = True
        Me.txtStList.ItemHeight = 21
        Me.txtStList.Location = New System.Drawing.Point(54, 420)
        Me.txtStList.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtStList.Name = "txtStList"
        Me.txtStList.Size = New System.Drawing.Size(796, 256)
        Me.txtStList.TabIndex = 15
        Me.txtStList.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 399)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of orders"
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Location = New System.Drawing.Point(540, 189)
        Me.radThin.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(67, 25)
        Me.radThin.TabIndex = 9
        Me.radThin.Text = "Thin"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radCrispy
        '
        Me.radCrispy.AutoSize = True
        Me.radCrispy.Location = New System.Drawing.Point(540, 231)
        Me.radCrispy.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.radCrispy.Name = "radCrispy"
        Me.radCrispy.Size = New System.Drawing.Size(81, 25)
        Me.radCrispy.TabIndex = 10
        Me.radCrispy.TabStop = True
        Me.radCrispy.Text = "Crispy"
        Me.radCrispy.UseVisualStyleBackColor = True
        '
        'radFat
        '
        Me.radFat.AutoSize = True
        Me.radFat.Location = New System.Drawing.Point(540, 266)
        Me.radFat.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.radFat.Name = "radFat"
        Me.radFat.Size = New System.Drawing.Size(59, 25)
        Me.radFat.TabIndex = 11
        Me.radFat.Text = "Fat"
        Me.radFat.UseVisualStyleBackColor = True
        '
        'chkAnchovies
        '
        Me.chkAnchovies.AutoSize = True
        Me.chkAnchovies.Location = New System.Drawing.Point(684, 189)
        Me.chkAnchovies.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.chkAnchovies.Name = "chkAnchovies"
        Me.chkAnchovies.Size = New System.Drawing.Size(110, 25)
        Me.chkAnchovies.TabIndex = 12
        Me.chkAnchovies.Text = "Anchovies"
        Me.chkAnchovies.UseVisualStyleBackColor = True
        '
        'chkOlives
        '
        Me.chkOlives.AutoSize = True
        Me.chkOlives.Location = New System.Drawing.Point(684, 231)
        Me.chkOlives.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.chkOlives.Name = "chkOlives"
        Me.chkOlives.Size = New System.Drawing.Size(81, 25)
        Me.chkOlives.TabIndex = 13
        Me.chkOlives.Text = "Olives"
        Me.chkOlives.UseVisualStyleBackColor = True
        '
        'chkCabanossi
        '
        Me.chkCabanossi.AutoSize = True
        Me.chkCabanossi.Location = New System.Drawing.Point(684, 266)
        Me.chkCabanossi.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.chkCabanossi.Name = "chkCabanossi"
        Me.chkCabanossi.Size = New System.Drawing.Size(112, 25)
        Me.chkCabanossi.TabIndex = 14
        Me.chkCabanossi.Text = "Cabanossi"
        Me.chkCabanossi.UseVisualStyleBackColor = True
        '
        'cboHour
        '
        Me.cboHour.BackColor = System.Drawing.Color.Coral
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboHour.Location = New System.Drawing.Point(54, 280)
        Me.cboHour.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(49, 29)
        Me.cboHour.TabIndex = 7
        Me.cboHour.Text = "10"
        '
        'cboMinutes
        '
        Me.cboMinutes.BackColor = System.Drawing.Color.Coral
        Me.cboMinutes.FormattingEnabled = True
        Me.cboMinutes.Items.AddRange(New Object() {"00", "15", "30", "45", "60"})
        Me.cboMinutes.Location = New System.Drawing.Point(171, 280)
        Me.cboMinutes.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.cboMinutes.Name = "cboMinutes"
        Me.cboMinutes.Size = New System.Drawing.Size(58, 29)
        Me.cboMinutes.TabIndex = 8
        Me.cboMinutes.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "24 hour time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 252)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 21)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Minutes"
        '
        'dteDelivery
        '
        Me.dteDelivery.CalendarMonthBackground = System.Drawing.Color.Coral
        Me.dteDelivery.Location = New System.Drawing.Point(54, 364)
        Me.dteDelivery.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.dteDelivery.Name = "dteDelivery"
        Me.dteDelivery.Size = New System.Drawing.Size(301, 33)
        Me.dteDelivery.TabIndex = 16
        '
        'chkPamesan
        '
        Me.chkPamesan.AutoSize = True
        Me.chkPamesan.Location = New System.Drawing.Point(684, 301)
        Me.chkPamesan.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.chkPamesan.Name = "chkPamesan"
        Me.chkPamesan.Size = New System.Drawing.Size(105, 25)
        Me.chkPamesan.TabIndex = 15
        Me.chkPamesan.Text = "Pamesan"
        Me.chkPamesan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 336)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 21)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Delivery date"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.Coral
        Me.txtPhoneNumber.Location = New System.Drawing.Point(369, 133)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.txtPhoneNumber.Mask = "0000-000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(148, 33)
        Me.txtPhoneNumber.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Phone number"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(216, 168)
        Me.Address.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(69, 21)
        Me.Address.TabIndex = 33
        Me.Address.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(369, 168)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 21)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Suburb"
        '
        'txtTopPrice
        '
        Me.txtTopPrice.BackColor = System.Drawing.Color.Coral
        Me.txtTopPrice.Location = New System.Drawing.Point(261, 245)
        Me.txtTopPrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTopPrice.Name = "txtTopPrice"
        Me.txtTopPrice.ReadOnly = True
        Me.txtTopPrice.Size = New System.Drawing.Size(121, 33)
        Me.txtTopPrice.TabIndex = 36
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.Coral
        Me.txtTotalPrice.Location = New System.Drawing.Point(261, 315)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(121, 33)
        Me.txtTotalPrice.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(387, 252)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Toppings Price"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.BackColor = System.Drawing.Color.Coral
        Me.txtBasePrice.Location = New System.Drawing.Point(261, 280)
        Me.txtBasePrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.ReadOnly = True
        Me.txtBasePrice.Size = New System.Drawing.Size(121, 33)
        Me.txtBasePrice.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(387, 280)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 21)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Base Price"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(387, 315)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 21)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Total Price"
        '
        'txtTop1
        '
        Me.txtTop1.BackColor = System.Drawing.Color.Coral
        Me.txtTop1.Location = New System.Drawing.Point(819, 189)
        Me.txtTop1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.ReadOnly = True
        Me.txtTop1.Size = New System.Drawing.Size(58, 33)
        Me.txtTop1.TabIndex = 42
        '
        'txtTop2
        '
        Me.txtTop2.BackColor = System.Drawing.Color.Coral
        Me.txtTop2.Location = New System.Drawing.Point(819, 224)
        Me.txtTop2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.ReadOnly = True
        Me.txtTop2.Size = New System.Drawing.Size(58, 33)
        Me.txtTop2.TabIndex = 43
        '
        'txtTop3
        '
        Me.txtTop3.BackColor = System.Drawing.Color.Coral
        Me.txtTop3.Location = New System.Drawing.Point(819, 266)
        Me.txtTop3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTop3.Name = "txtTop3"
        Me.txtTop3.ReadOnly = True
        Me.txtTop3.Size = New System.Drawing.Size(58, 33)
        Me.txtTop3.TabIndex = 44
        '
        'txtTop4
        '
        Me.txtTop4.BackColor = System.Drawing.Color.Coral
        Me.txtTop4.Location = New System.Drawing.Point(819, 301)
        Me.txtTop4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTop4.Name = "txtTop4"
        Me.txtTop4.ReadOnly = True
        Me.txtTop4.Size = New System.Drawing.Size(58, 33)
        Me.txtTop4.TabIndex = 45
        '
        'txtSuburb
        '
        Me.txtSuburb.BackColor = System.Drawing.Color.Coral
        Me.txtSuburb.Location = New System.Drawing.Point(369, 203)
        Me.txtSuburb.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(148, 33)
        Me.txtSuburb.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Coral
        Me.txtAddress.Location = New System.Drawing.Point(216, 203)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(148, 33)
        Me.txtAddress.TabIndex = 46
        '
        'override
        '
        Me.override.Location = New System.Drawing.Point(540, 56)
        Me.override.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.override.Name = "override"
        Me.override.Size = New System.Drawing.Size(72, 28)
        Me.override.TabIndex = 47
        Me.override.Text = "Admin"
        Me.override.UseVisualStyleBackColor = True
        '
        'newPassword
        '
        Me.newPassword.Enabled = False
        Me.newPassword.Location = New System.Drawing.Point(612, 56)
        Me.newPassword.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.Size = New System.Drawing.Size(153, 28)
        Me.newPassword.TabIndex = 48
        Me.newPassword.Text = "New Password"
        Me.newPassword.UseVisualStyleBackColor = True
        Me.newPassword.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(792, 189)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 21)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(792, 231)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 21)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(792, 266)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 21)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(792, 301)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 21)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "$"
        '
        'Pizza104
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1584, 665)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.newPassword)
        Me.Controls.Add(Me.override)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSuburb)
        Me.Controls.Add(Me.txtTop4)
        Me.Controls.Add(Me.txtTop3)
        Me.Controls.Add(Me.txtTop2)
        Me.Controls.Add(Me.txtTop1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBasePrice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtTopPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkPamesan)
        Me.Controls.Add(Me.dteDelivery)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboMinutes)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.chkCabanossi)
        Me.Controls.Add(Me.chkOlives)
        Me.Controls.Add(Me.chkAnchovies)
        Me.Controls.Add(Me.radFat)
        Me.Controls.Add(Me.radCrispy)
        Me.Controls.Add(Me.radThin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStList)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Yu Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Margin = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.Name = "Pizza104"
        Me.Text = "v1.04 Pizza ordering app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddStud As Button


    Friend WithEvents txtStList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents radThin As RadioButton
    Friend WithEvents radCrispy As RadioButton
    Friend WithEvents radFat As RadioButton
    Friend WithEvents chkAnchovies As CheckBox
    Friend WithEvents chkOlives As CheckBox
    Friend WithEvents chkCabanossi As CheckBox
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents cboMinutes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dteDelivery As DateTimePicker
    Friend WithEvents chkPamesan As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Address As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTopPrice As MaskedTextBox
    Friend WithEvents txtTotalPrice As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBasePrice As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTop1 As MaskedTextBox
    Friend WithEvents txtTop2 As MaskedTextBox
    Friend WithEvents txtTop3 As MaskedTextBox
    Friend WithEvents txtTop4 As MaskedTextBox
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents override As Button
    Friend WithEvents newPassword As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
