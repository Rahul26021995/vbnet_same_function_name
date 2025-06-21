Public Function CalculateDiscountAmount(orderTotal As Decimal, customerType As String) As Decimal
    If customerType = "Premium" Then
        Return orderTotal * 0.15D ' 15% discount for premium customers
    ElseIf orderTotal > 1000 Then
        Return orderTotal * 0.1D ' 10% discount for orders above $1000
    Else
        Return 0D
    End If
End Function
