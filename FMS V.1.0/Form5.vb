Imports MySql.Data.MySqlClient
Public Class Form5
    'Dim users As New Class_Particular
    Dim query As String
    Dim prod_query As String
    'RAndell
    'HAHAHAHAH
#Region "form Load"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbogender.selectedIndex = 0
        cboMaritalStatus.selectedIndex = 0

        displayRecords1("Select * from particular", dgParticular)
        displayProducts("Select * from tbl_product", dgProduct)
        txtCode.Text = recordCount("Select * from particular")
        btn_code.Text = recordCountProduct("Select * from tbl_product")
    End Sub
#End Region

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        '  Add_Cient()
    End Sub

    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        Dim last_name As String = txt_lastname.Text
        Dim first_name As String = txt_firstname.Text
        Dim middle_name As String = txt_middlename.Text
        Dim suffix As String = txt_suffix.Text
        Dim address As String = txt_address.Text
        Dim birth_date As Date = dp_birthdate.Value
        Dim mobile_num As String = txt_mobile.Text
        Dim landline As String = txt_landline.Text
        Dim zipcode As String = txt_zipcode.Text
        Dim gender As String = cbogender.selectedValue
        Dim marital_status As String = cboMaritalStatus.selectedValue
        Dim tin_no As String = txt_tin.Text
        Dim umid_sss As String = txt_umid_ss.Text
        Dim email_address As String = txt_emailaddress.Text
        Dim philhealth_num As String = txt_philhealth.Text
        Dim pag_ibig_num As String = txt_pagibig.Text
        Dim gsis_id As String = txt_gsis.Text
        Dim dependants As Integer = CInt(txt_dependents.Text)
        Dim employee_business_name As String = txt_employee_business_address.Text
        Dim spouse_name As String = txt_spouse_fullname.Text
        Dim employee_business_address As String = txt_employee_business_address.Text
        Dim spouse_birthdate = dt_spouse_birthdate.Value.Date
        Dim position As String = txt_position.Text
        Dim department As String = txt_department.Text
        Dim spouse_contact As String = txt_spouse_contact.Text
        Dim employer_business_contact As String = txt_employee_business_contact.Text
        Dim spouse_address As String = txt_spouse_business_address.Text
        Add_Cient(last_name, first_name, middle_name, suffix, address, birth_date, mobile_num, landline, zipcode, gender, marital_status, tin_no, umid_sss, email_address, philhealth_num, pag_ibig_num, gsis_id, dependants, employee_business_name, spouse_name, employee_business_address, spouse_birthdate, position, department, spouse_contact, employer_business_contact, spouse_address)
    End Sub

    Private Sub cbogender_onItemSelected(sender As Object, e As EventArgs) Handles cbogender.onItemSelected

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub







    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged

    End Sub

    Private Sub txt_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lastname.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_firstname.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_middlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_middlename.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_suffix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_suffix.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mobile.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_landline_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_landline.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_zipcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_zipcode.KeyPress
        Dim allowedChars As String = "1234567890- "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_philhealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_philhealth.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_pagibig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pagibig.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_gsis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_gsis.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_employee_business_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_employee_business_name.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_spouse_fullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_spouse_fullname.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_employee_business_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_employee_business_address.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_position_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_position.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_department_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_department.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_spouse_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_spouse_contact.KeyPress
        Dim allowedChars As String = "1234567890-"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_employee_business_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_employee_business_contact.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub

    Private Sub txt_spouse_business_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_spouse_business_address.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_ "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then

            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
            End If
        End If
    End Sub



    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4)
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4)
        e.DrawFocusRectangle()
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        For i As Integer = 0 To TabControl1.TabPages.Count - 1
            Dim r As Rectangle = TabControl1.GetTabRect(i)
            Dim closeButton As Rectangle = New Rectangle(r.Right - 15, r.Top + 4, 9, 7)
            If closeButton.Contains(e.Location) Then
                If MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TabControl1.TabPages.RemoveAt(i)
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        query = "Insert into particular(code, description, amount) values ('" & txtCode.Text & "','" & txtDesc.Text & "', 
'" & txtAmount.Text & "')"
        SQLManager(query)
        MsgBox("congrats nagawa mo!")
        displayRecords1("Select * from particular", dgParticular)
        txtCode.Text = recordCount("Select * from particular")
    End Sub
#Region "Add Sales Invoice"
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim sales_invoice_no As Integer
        Dim inv_date As Date
        Dim client_id As Integer
        Dim fund_source As String
        Dim Type As String
        Dim product_id As Integer
        Dim penalty As Decimal
        Dim interest As Decimal
        Dim project_id As Integer
        Dim downpayment_percent As Decimal
        Dim downpayment_amount As Decimal
        Dim sales_rep_id As Integer
        Dim commision As Decimal
        Dim commision_amount As Decimal
        Dim contract_price As Decimal
        Dim gross_amount As Decimal
    End Sub
#End Region
    'PRODUCT FORM
    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        prod_query = "Insert into tbl_product(prod_code, prod_description) values ('" & btn_code.Text & "','" & btn_description.Text & "')"
        SQLManagerProduct(prod_query)
        MsgBox("Product Added!")
        displayProducts("Select * from tbl_product", dgProduct)
        txtCode.Text = recordCountProduct("Select * from tbl_product")
    End Sub
    'PRODUCT FORM
    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub dgParticular_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgParticular.CellClick

        Dim i
        i = dgParticular.CurrentRow.Index
        txtCode.Text = dgParticular.Item(0, i).Value
        txtDesc.Text = dgParticular.Item(1, i).Value
        txtAmount.Text = dgParticular.Item(2, i).Value

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        query = "Update particular set description='" & txtDesc.Text & "',amount='" & txtAmount.Text & "' where code=" & txtCode.Text & ""
        SQLManager(query)
        MsgBox("na edit na te!")
        displayRecords1("Select * from particular", dgParticular)
        txtCode.Text = recordCount("Select * from particular")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        txtDesc.Text = ""
    End Sub
End Class
