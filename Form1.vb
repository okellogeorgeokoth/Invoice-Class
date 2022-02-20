'Name
'Details

Public Class Form1

    ' Creating an object of Invoice class

    Dim myInvoice As New Invoice()

    '  calculateButton Event handler

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        '  Using properties to assign values to the class instance variables

        myInvoice.PartDescription = partDescriptionBox.Text

        myInvoice.PartNumber = partNumberBox.Text

        myInvoice.Price = Convert.ToInt32(priceBox.Text)

        myInvoice.Quantity = Convert.ToInt32(quantityBox.Text)

        resultLabel.Text = "$" & myInvoice.DisplayInvoiceAmount()

    End Sub

End Class

' Class Invoice definition

Public Class Invoice

    'Class Invoice instance variable 

    Private _partNumber As String

    Private _partDescription As String

    Private _quantity As Integer

    Private _price As Integer

    ' The Invoice class constructor 

    Public Sub New()

        _partNumber = ""

        _partDescription = ""

        _quantity = 0

        _price = 0

    End Sub

    'Property for the variable _partNumber

    Public Property PartNumber() As String

        Get

            Return _partNumber

        End Get

        Set(value As String)
            _partNumber = value
        End Set

    End Property

    'Property for the variable _partDescription

    Public Property PartDescription() As String

        Get

            Return _partDescription

        End Get

        Set(value As String)

            _partDescription = value

        End Set

    End Property

    'Property for the variable _quantity

    Public Property Quantity() As Integer

        Get

            Return _quantity

        End Get

        Set(value As Integer)

            'checking  positive value

            If value < 0 Then

                ' if value is negative assign 0

                _quantity = 0

            Else

                'assign the value

                _quantity = value

            End If

        End Set

    End Property

    'Property for the variable _price

    Public Property Price() As Integer

        Get

            Return _price

        End Get

        Set(value As Integer)

            'checking  positive value 

            If value < 0 Then

                ' if value is negative assign 0

                _price = 0

            Else

                'Assign the value

                _price = value

            End If

        End Set

    End Property

    'Function DisplayInvoiceAmount to calculate the total

    Public Function DisplayInvoiceAmount() As Integer

        'variable used to store the total

        Dim result As Integer

        'calculating result

        result = _price * _quantity

        'return the result

        Return result

    End Function

End Class
