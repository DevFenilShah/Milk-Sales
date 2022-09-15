<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TImeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.CowType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnemail = New System.Windows.Forms.Button()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.cmbquantity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkcash = New System.Windows.Forms.CheckBox()
        Me.chkcard = New System.Windows.Forms.CheckBox()
        Me.chkdairy = New System.Windows.Forms.CheckBox()
        Me.chkhouse = New System.Windows.Forms.CheckBox()
        Me.chkSunil = New System.Windows.Forms.CheckBox()
        Me.chkGanesh = New System.Windows.Forms.CheckBox()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TImeLabel
        '
        Me.TImeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TImeLabel.AutoSize = True
        Me.TImeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TImeLabel.Location = New System.Drawing.Point(180, 10)
        Me.TImeLabel.Name = "TImeLabel"
        Me.TImeLabel.Size = New System.Drawing.Size(56, 25)
        Me.TImeLabel.TabIndex = 0
        Me.TImeLabel.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cow Type:"
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToOrderColumns = True
        Me.dgvdata.AllowUserToResizeColumns = False
        Me.dgvdata.AllowUserToResizeRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CowType, Me.Quantity, Me.Payment, Me.Amount})
        Me.dgvdata.Location = New System.Drawing.Point(16, 130)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersWidth = 51
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(628, 203)
        Me.dgvdata.TabIndex = 11
        '
        'CowType
        '
        Me.CowType.HeaderText = "Cow Type"
        Me.CowType.MinimumWidth = 6
        Me.CowType.Name = "CowType"
        Me.CowType.Width = 150
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 80
        '
        'Payment
        '
        Me.Payment.HeaderText = "Payment"
        Me.Payment.MinimumWidth = 6
        Me.Payment.Name = "Payment"
        Me.Payment.ReadOnly = True
        Me.Payment.Width = 105
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MinimumWidth = 6
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(421, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Amount :"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(555, 358)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(18, 20)
        Me.lblquantity.TabIndex = 6
        Me.lblquantity.Text = "0"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(555, 394)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(18, 20)
        Me.lblamount.TabIndex = 7
        Me.lblamount.Text = "0"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(16, 358)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(99, 56)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(137, 358)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 56)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnemail
        '
        Me.btnemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemail.Location = New System.Drawing.Point(259, 358)
        Me.btnemail.Name = "btnemail"
        Me.btnemail.Size = New System.Drawing.Size(143, 56)
        Me.btnemail.TabIndex = 10
        Me.btnemail.Text = "Send Email"
        Me.btnemail.UseVisualStyleBackColor = True
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Cow", "Gir", "Buffalo"})
        Me.cmbtype.Location = New System.Drawing.Point(114, 45)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(121, 28)
        Me.cmbtype.TabIndex = 1
        '
        'cmbquantity
        '
        Me.cmbquantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbquantity.FormattingEnabled = True
        Me.cmbquantity.Items.AddRange(New Object() {"100 gm", "200 gm", "300 gm", "400 gm", "500 gm", "1 ltr", "1.5 ltr", "2 ltr", "2.5 ltr", "3 ltr", "4 ltr", "5 ltr", "6 ltr", "7 ltr", "8 ltr", "9 ltr", "10 ltr", "15 ltr", "20 ltr", "25 ltr", "30 ltr", "35 ltr", "40 ltr", "45 ltr", "50 ltr", "55 ltr", "60 ltr", "65 ltr", "70 ltr", "75 ltr", "80 ltr", "85 ltr", "90 ltr"})
        Me.cmbquantity.Location = New System.Drawing.Point(349, 45)
        Me.cmbquantity.Name = "cmbquantity"
        Me.cmbquantity.Size = New System.Drawing.Size(121, 28)
        Me.cmbquantity.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Quantity:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(498, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkcash
        '
        Me.chkcash.AutoSize = True
        Me.chkcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcash.Location = New System.Drawing.Point(106, 92)
        Me.chkcash.Name = "chkcash"
        Me.chkcash.Size = New System.Drawing.Size(70, 24)
        Me.chkcash.TabIndex = 3
        Me.chkcash.Text = "Cash"
        Me.chkcash.UseVisualStyleBackColor = True
        '
        'chkcard
        '
        Me.chkcard.AutoSize = True
        Me.chkcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcard.Location = New System.Drawing.Point(185, 92)
        Me.chkcard.Name = "chkcard"
        Me.chkcard.Size = New System.Drawing.Size(67, 24)
        Me.chkcard.TabIndex = 4
        Me.chkcard.Text = "Card"
        Me.chkcard.UseVisualStyleBackColor = True
        '
        'chkdairy
        '
        Me.chkdairy.AutoSize = True
        Me.chkdairy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdairy.Location = New System.Drawing.Point(261, 92)
        Me.chkdairy.Name = "chkdairy"
        Me.chkdairy.Size = New System.Drawing.Size(71, 24)
        Me.chkdairy.TabIndex = 5
        Me.chkdairy.Text = "Dairy"
        Me.chkdairy.UseVisualStyleBackColor = True
        '
        'chkhouse
        '
        Me.chkhouse.AutoSize = True
        Me.chkhouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkhouse.Location = New System.Drawing.Point(338, 92)
        Me.chkhouse.Name = "chkhouse"
        Me.chkhouse.Size = New System.Drawing.Size(80, 24)
        Me.chkhouse.TabIndex = 6
        Me.chkhouse.Text = "House"
        Me.chkhouse.UseVisualStyleBackColor = True
        '
        'chkSunil
        '
        Me.chkSunil.AutoSize = True
        Me.chkSunil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSunil.Location = New System.Drawing.Point(421, 92)
        Me.chkSunil.Name = "chkSunil"
        Me.chkSunil.Size = New System.Drawing.Size(68, 24)
        Me.chkSunil.TabIndex = 13
        Me.chkSunil.Text = "Sunil"
        Me.chkSunil.UseVisualStyleBackColor = True
        '
        'chkGanesh
        '
        Me.chkGanesh.AutoSize = True
        Me.chkGanesh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGanesh.Location = New System.Drawing.Point(493, 92)
        Me.chkGanesh.Name = "chkGanesh"
        Me.chkGanesh.Size = New System.Drawing.Size(89, 24)
        Me.chkGanesh.TabIndex = 14
        Me.chkGanesh.Text = "Ganesh"
        Me.chkGanesh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(658, 434)
        Me.Controls.Add(Me.chkGanesh)
        Me.Controls.Add(Me.chkSunil)
        Me.Controls.Add(Me.chkhouse)
        Me.Controls.Add(Me.chkdairy)
        Me.Controls.Add(Me.chkcard)
        Me.Controls.Add(Me.chkcash)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbquantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.btnemail)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TImeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Milk Sales"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TImeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblamount As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnemail As Button
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents cmbquantity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkcash As CheckBox
    Friend WithEvents chkcard As CheckBox
    Friend WithEvents chkdairy As CheckBox
    Friend WithEvents chkhouse As CheckBox
    Friend WithEvents CowType As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents chkSunil As CheckBox
    Friend WithEvents chkGanesh As CheckBox
End Class
