Imports MySql.Data.MySqlClient


Module Invoice_Module

    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "



    Public Sub Add_Sales_Invoice(ByVal sales_invoice_no As Integer, ByVal inv_date As Date, ByVal client_id As Integer, ByVal fund_source As String, ByVal type As String, ByVal product_id As Integer,
                                 ByVal penalty As Decimal, ByVal interest As Decimal, ByVal project_id As Integer,
                                ByVal downpayment_percent As Decimal, ByVal downpayment_amount As Decimal, ByVal sales_rep_id As Integer, ByVal commision As Decimal, ByVal commision_amount As Decimal,
                                ByVal contract_price As Decimal, ByVal gross_amount As Decimal, ByVal issued_by As String, ByVal loan_terms As Integer, ByVal loan_date As Date
                                )

    End Sub




End Module
