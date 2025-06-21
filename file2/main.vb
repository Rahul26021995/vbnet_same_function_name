Public Function IsOrderValidForProcessing(order As Order) As Boolean
    If order.Items.Count = 0 Then Return False
    If order.TotalAmount <= 0 Then Return False
    If Not order.Customer.HasValidPaymentMethod Then Return False
    Return True
End Function
