Public Class frmInvoiceTotal

    Dim numberOfInvoices As Integer
    Dim totalOfInvoices As Decimal
    Dim invoiceAverage As Decimal
    Dim largestInvoice As Decimal
    Dim smallestInvoice As Decimal = 999999999
    Dim midPoint As Decimal
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'takes the input of customer type as string
        Dim customerType As String = txtCustomerType.Text

        'converts the data type to a decimal data type
        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal

        'if user enters r or R
        Select Case customerType
            Case "R", "r"
                'and subtotal less then 100
                If subtotal < 100 Then
                    'no discount for "r" type
                    discountPercent = 0
                    'if subtotal more than 100 and < 250
                ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                    'discount is 10% for "r" type
                    discountPercent = 0.1D
                    'if subtotal more than 250 and < 500
                ElseIf subtotal >= 250 AndAlso subtotal < 500 Then
                    'discount is 25% for "r" type
                    discountPercent = 0.25D
                    'if subtotal more or = to 500
                ElseIf subtotal >= 500 Then
                    'doscount is 30% for "r" type
                    discountPercent = 0.3D
                End If

                'if user enters c or C
            Case "C", "c"
                'discount is 20% for "c" type
                discountPercent = 0.2D

                'if user enters t or T
            Case "T", "t"
                'and subtotal less than 500
                If subtotal >= 500 Then
                    'doscount is 50% for "t" type
                    discountPercent = 0.5D
                Else
                    'or less then 500 discount is 40% for "t" type
                    discountPercent = 0.4D
                End If
            Case Else
                discountPercent = 0.1D
        End Select

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        numberOfInvoices = numberOfInvoices + 1
        totalOfInvoices = totalOfInvoices + invoiceTotal
        invoiceAverage = totalOfInvoices / numberOfInvoices
        largestInvoice = Math.Max(largestInvoice, invoiceTotal)
        smallestInvoice = Math.Min(smallestInvoice, invoiceTotal)
        midPoint = (largestInvoice + smallestInvoice) / 2

        'formats a numeric value with a percent sign
        txtDiscountPercent.Text = FormatPercent(discountPercent)
        'formats the numeric value with a dollar sign
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        'formats the numeric value with a dollar sign
        txtTotal.Text = FormatCurrency(invoiceTotal)
        txtNumberOfInvoices.Text = numberOfInvoices.ToString
        txtTotalOfInvoices.Text = totalOfInvoices.ToString("C")
        txtInvoiceAverage.Text = invoiceAverage.ToString("C")
        txtLargestInvoice.Text = FormatCurrency(largestInvoice)
        txtSmallestInvoice.Text = FormatCurrency(smallestInvoice)
        txtMidpoint.Text = FormatCurrency(midPoint)

        'puts focus on customer type text box
        txtCustomerType.Select()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmInvoiceTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClearTotals_Click(sender As Object, e As EventArgs) Handles btnClearTotals.Click
        numberOfInvoices = 0
        totalOfInvoices = 0
        invoiceAverage = 0
        largestInvoice = 0
        smallestInvoice = 999999999
        midPoint = 0

        txtSubtotal.Text = ""
        txtDiscountPercent.Text = ""
        txtDiscountAmount.Text = ""
        txtTotal.Text = ""

        txtCustomerType.Text = ""
        txtNumberOfInvoices.Text = ""
        txtTotalOfInvoices.Text = ""
        txtInvoiceAverage.Text = ""
        txtLargestInvoice.Text = ""
        txtSmallestInvoice.Text = ""
        txtMidpoint.Text = ""

        'puts focus on customer type text box
        txtCustomerType.Select()
    End Sub
End Class
