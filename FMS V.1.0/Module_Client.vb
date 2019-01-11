Imports MySql.Data.MySqlClient
Module Module_Client

    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public reader As MySqlDataReader
    Public strQuery = " "




#Region "Function Add Client"
    Public Sub Add_Cient(ByVal last_name As String, ByVal first_name As String, ByVal middle_name As String,
                         ByVal suffix As String,
                         ByVal address As String, ByVal birth_date As Date,
                         ByVal mobile_num As String, ByVal landline As String, ByVal zipcode As String,
                         ByVal gender As String, ByVal marital_status As String,
                         ByVal tin_no As String, ByVal umid_sss As String, ByVal email_address As String, ByVal philhealth_num As String,
                         ByVal pag_ibig_num As String, ByVal gsis_id As String, ByVal dependants As Integer,
                         ByVal employee_business_name As String,
                         ByVal spouse_name As String, ByVal employee_business_address As String,
                         ByVal spouse_birthdate As Date, ByVal position As String, ByVal department As String, ByVal spouse_contact As String,
                         ByVal employer_business_contact As String, ByVal spouse_address As String
                     )


        Load_Connection()
        conn.Open()
        cmd = New MySqlCommand("INSERT INTO client(last_name,first_name, middle_name, suffix,address, birth_date, mobile_num, landline,
                                zipcode, gender, marital_status, tin_no, umid_sss,email_address,philhealth_num,pag_ibig_num, gsis_id, dependants,
                                employee_business_name, spouse_name, employee_business_address, spouse_birthdate, position, department,
                                spouse_contact, employer_business_contact, spouse_address, date_created,date_modified, client_status
                                ) VALUES (
                                @last_name,@first_name,@middle_name,@suffix,@address,@birth_date,@mobile_num,@landline,@zipcode,@gender,@marital_status,@tin_no,@umid_sss,@email_address,
                                @philhealth_num,@pag_ibig_num,@gsis_id,@dependants,@employee_business_name,@spouse_name,@employee_business_address,@spouse_birthdate,@position,@department,@spouse_contact,
                                @employer_business_contact,@spouse_address,NOW(),NOW(),1)", conn)

        cmd.Parameters.AddWithValue("@last_name", last_name)
        cmd.Parameters.AddWithValue("@first_name", first_name)
        cmd.Parameters.AddWithValue("@middle_name", middle_name)
        cmd.Parameters.AddWithValue("@suffix", suffix)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@birth_date", birth_date)
        cmd.Parameters.AddWithValue("@mobile_num", mobile_num)
        cmd.Parameters.AddWithValue("@landline", landline)
        cmd.Parameters.AddWithValue("@zipcode", zipcode)
        cmd.Parameters.AddWithValue("@gender", gender)
        cmd.Parameters.AddWithValue("@marital_status", marital_status)
        cmd.Parameters.AddWithValue("@tin_no", tin_no)
        cmd.Parameters.AddWithValue("@umid_sss", umid_sss)
        cmd.Parameters.AddWithValue("@email_address", email_address)
        cmd.Parameters.AddWithValue("@philhealth_num", philhealth_num)
        cmd.Parameters.AddWithValue("@pag_ibig_num", pag_ibig_num)
        cmd.Parameters.AddWithValue("@gsis_id", gsis_id)
        cmd.Parameters.AddWithValue("@dependants", dependants)
        cmd.Parameters.AddWithValue("@employee_business_name", employee_business_name)
        cmd.Parameters.AddWithValue("@spouse_name", spouse_name)
        cmd.Parameters.AddWithValue("@employee_business_address", employee_business_address)
        cmd.Parameters.AddWithValue("@spouse_birthdate", spouse_birthdate)
        cmd.Parameters.AddWithValue("@position", position)
        cmd.Parameters.AddWithValue("@department", department)
        cmd.Parameters.AddWithValue("@spouse_contact", spouse_contact)
        cmd.Parameters.AddWithValue("@employer_business_contact", employer_business_contact)
        cmd.Parameters.AddWithValue("@spouse_address", spouse_address)
        cmd.ExecuteNonQuery()
        conn.Close()
        conn.Dispose()
        MessageBox.Show("Client Added Successfully")
    End Sub

#End Region










End Module
