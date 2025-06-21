Public Function ValidateCustomerEligibility(customer As Customer) As Boolean
    ' Business rule: Customer must be active and have a credit score above 650
    Return customer.IsActive AndAlso customer.CreditScore > 650
End Function
