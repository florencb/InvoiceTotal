<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceTotal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberOfInvoices = New System.Windows.Forms.TextBox()
        Me.txtTotalOfInvoices = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAverage = New System.Windows.Forms.TextBox()
        Me.txtLargestInvoice = New System.Windows.Forms.TextBox()
        Me.txtSmallestInvoice = New System.Windows.Forms.TextBox()
        Me.txtMidpoint = New System.Windows.Forms.TextBox()
        Me.btnClearTotals = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCustomerType = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Discount Percent"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Discount Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(138, 74)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 2
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(138, 114)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.ReadOnly = True
        Me.txtDiscountPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountPercent.TabIndex = 0
        Me.txtDiscountPercent.TabStop = False
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(138, 154)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountAmount.TabIndex = 0
        Me.txtDiscountAmount.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(138, 194)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(235, 279)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(463, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumberOfInvoices
        '
        Me.txtNumberOfInvoices.Location = New System.Drawing.Point(414, 34)
        Me.txtNumberOfInvoices.Name = "txtNumberOfInvoices"
        Me.txtNumberOfInvoices.ReadOnly = True
        Me.txtNumberOfInvoices.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfInvoices.TabIndex = 4
        Me.txtNumberOfInvoices.TabStop = False
        '
        'txtTotalOfInvoices
        '
        Me.txtTotalOfInvoices.Location = New System.Drawing.Point(414, 71)
        Me.txtTotalOfInvoices.Name = "txtTotalOfInvoices"
        Me.txtTotalOfInvoices.ReadOnly = True
        Me.txtTotalOfInvoices.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOfInvoices.TabIndex = 5
        Me.txtTotalOfInvoices.TabStop = False
        '
        'txtInvoiceAverage
        '
        Me.txtInvoiceAverage.Location = New System.Drawing.Point(414, 113)
        Me.txtInvoiceAverage.Name = "txtInvoiceAverage"
        Me.txtInvoiceAverage.ReadOnly = True
        Me.txtInvoiceAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceAverage.TabIndex = 6
        Me.txtInvoiceAverage.TabStop = False
        '
        'txtLargestInvoice
        '
        Me.txtLargestInvoice.Location = New System.Drawing.Point(414, 151)
        Me.txtLargestInvoice.Name = "txtLargestInvoice"
        Me.txtLargestInvoice.ReadOnly = True
        Me.txtLargestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtLargestInvoice.TabIndex = 7
        Me.txtLargestInvoice.TabStop = False
        '
        'txtSmallestInvoice
        '
        Me.txtSmallestInvoice.Location = New System.Drawing.Point(414, 193)
        Me.txtSmallestInvoice.Name = "txtSmallestInvoice"
        Me.txtSmallestInvoice.ReadOnly = True
        Me.txtSmallestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtSmallestInvoice.TabIndex = 8
        Me.txtSmallestInvoice.TabStop = False
        '
        'txtMidpoint
        '
        Me.txtMidpoint.Location = New System.Drawing.Point(414, 227)
        Me.txtMidpoint.Name = "txtMidpoint"
        Me.txtMidpoint.ReadOnly = True
        Me.txtMidpoint.Size = New System.Drawing.Size(100, 20)
        Me.txtMidpoint.TabIndex = 9
        Me.txtMidpoint.TabStop = False
        '
        'btnClearTotals
        '
        Me.btnClearTotals.Location = New System.Drawing.Point(349, 279)
        Me.btnClearTotals.Name = "btnClearTotals"
        Me.btnClearTotals.Size = New System.Drawing.Size(75, 23)
        Me.btnClearTotals.TabIndex = 5
        Me.btnClearTotals.Text = "C&lear Totals"
        Me.btnClearTotals.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Number of invoices:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total of invoices:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Invoice average:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Largest invoice:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Smallest invoice"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Mid point:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Customer Type"
        '
        'txtCustomerType
        '
        Me.txtCustomerType.Location = New System.Drawing.Point(138, 33)
        Me.txtCustomerType.Name = "txtCustomerType"
        Me.txtCustomerType.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerType.TabIndex = 1
        '
        'frmInvoiceTotal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(574, 324)
        Me.Controls.Add(Me.txtCustomerType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClearTotals)
        Me.Controls.Add(Me.txtMidpoint)
        Me.Controls.Add(Me.txtSmallestInvoice)
        Me.Controls.Add(Me.txtLargestInvoice)
        Me.Controls.Add(Me.txtInvoiceAverage)
        Me.Controls.Add(Me.txtTotalOfInvoices)
        Me.Controls.Add(Me.txtNumberOfInvoices)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInvoiceTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfInvoices As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalOfInvoices As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtLargestInvoice As System.Windows.Forms.TextBox
    Friend WithEvents txtSmallestInvoice As System.Windows.Forms.TextBox
    Friend WithEvents txtMidpoint As System.Windows.Forms.TextBox
    Friend WithEvents btnClearTotals As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerType As System.Windows.Forms.TextBox

End Class
