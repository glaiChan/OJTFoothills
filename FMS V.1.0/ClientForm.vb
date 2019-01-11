Public Class ClientForm

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbogender.selectedIndex = 0
        cboMaritalStatus.selectedIndex = 0
    End Sub

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
End Class