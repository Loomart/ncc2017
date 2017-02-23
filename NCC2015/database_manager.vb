Imports System.IO
Imports MySql.Data.MySqlClient

Public Class database_manager

    Public conn As New MySqlConnection
    Dim gf As globalFunctions = New globalFunctions
    Dim savedImage As Boolean = False
    Public user_id As Integer
    Public Property userId() As Integer
        Get
            Return user_id
        End Get
        Set(ByVal value As Integer)
            user_id = value
        End Set
    End Property


    Sub New()
        conn.ConnectionString = "server=127.0.0.1; userid=lutrix; password=0p3nm!nd; database=ncc_2015;"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Erro ao conectar a Base de Dados: " & ex.ToString)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Function login(username As String, password As String) As Boolean
        Dim cmd As New MySqlCommand("select user_id from loo_user where user_name = '" + username + "' and user_password = hex(md5('" + password + "'))", conn)
        Dim res As Boolean = False
        conn.Open()
        userId = CInt(cmd.ExecuteScalar())
        conn.Close()
        If (userId > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' This method is to encrypt to MD5

    'Private Function getMD5Hash(ByVal strToHash As String) As String
    '    Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
    '    Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
    '    bytesToHash = md5Obj.ComputeHash(bytesToHash)
    '    Dim strResult As String = ""
    '    Dim b As Byte
    '    For Each b In bytesToHash
    '        strResult += b.ToString("x2")
    '    Next
    '    Return strResult
    'End Function

    Public Function getUser(userId As Integer) As user
        Dim actualUser As New user
        Using conn
            Dim cmd As New MySqlCommand("select user_id,user_name,user_email,user_is_super,user_is_admin from loo_user where user_id=" & userId, conn)
            Dim mysqlReader As MySqlDataReader

            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                Do While mysqlReader.Read()
                    actualUser = New user(mysqlReader.GetInt32(0), mysqlReader.GetString(1), mysqlReader.GetString(2), mysqlReader.GetBoolean(3), mysqlReader.GetBoolean(4))
                Loop
            Else
                Console.WriteLine("No rows found.")
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return actualUser
    End Function

    Public Function getImage(imageId As Integer) As System.Drawing.Bitmap
        Dim image As System.Drawing.Bitmap = Nothing
        Using conn
            Dim cmd As New MySqlCommand("select image from loo_image where image_id =" & imageId, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                Do While mysqlReader.Read()
                    Dim bytes As Byte() = TryCast(mysqlReader.GetValue(0), Byte())
                    Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                    Dim ms As New System.IO.MemoryStream(Convert.FromBase64String(base64String))
                    Dim bmp As New Bitmap(ms)
                    image = bmp
                Loop
            Else
                Console.WriteLine("No rows found.")
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return image
    End Function

    Public Function saveImage(photoFilePath As String, extension As String) As Integer
        Dim photo As Byte() = GetPhoto(photoFilePath)
        Dim imageId As Integer = 0
        Using conn
            Dim cmd As New MySqlCommand("INSERT INTO loo_image(image, image_extension) Values(@image, @image_extension); SELECT LAST_INSERT_ID()", conn)

            cmd.Parameters.AddWithValue("@image_extension", extension)
            cmd.Parameters.AddWithValue("@image", photo)
            conn.Open()
            imageId = CInt(cmd.ExecuteScalar())
            conn.Close()
            savedImage = True
        End Using
        Return imageId
    End Function

    Private Function GetPhoto(filePath As String) As Byte()
        Dim stream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo As Byte() = reader.ReadBytes(CInt(stream.Length))

        reader.Close()
        stream.Close()

        Return photo
    End Function

    Public Function getPartnerLastId() As Integer
        Dim partner_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_id FROM ncc_2015.loo_partner WHERE partner_card > 0 order by partner_id desc limit 1", conn)
            conn.Open()
            partner_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        Return If(partner_id = 0, -1, partner_id)
    End Function

    Public Function getPreviousPartnerId(partnerId As Integer) As Integer
        Dim partner_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_id FROM ncc_2015.loo_partner WHERE partner_id < " & partnerId & " ORDER BY partner_id DESC LIMIT 1", conn)
            conn.Open()
            partner_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        Return If(partner_id = 0, 1, partner_id)
    End Function

    Public Function getFollowingPartnerId(partnerId As Integer) As Integer
        Dim partner_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_id FROM ncc_2015.loo_partner WHERE partner_id > " & partnerId & " ORDER BY partner_id ASC LIMIT 1", conn)
            conn.Open()
            partner_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        Return If(partner_id = 0, 1, partner_id)
    End Function



    Public Function getImageLastId() As Integer
        Dim image_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT image_id FROM ncc_2015.loo_image order by image_id desc limit 1", conn)
            conn.Open()
            image_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        Return image_id
    End Function

    '*******************************
    '****PARTNER DATABASE CRUD******
    '*******************************

    Public Sub savePartner(partner As partner)
        Using conn
            Dim cmd As New MySqlCommand("INSERT INTO `ncc_2015`.`loo_partner` (`partner_id`, `partner_name`, `partner_birthdate`, `partner_add_date`, `partner_gender`,`partner_cc`, `partner_address`, `partner_postal`, `partner_city`, `partner_phone`, `partner_mobile`, `partner_email`, `partner_parent`, `partner_is_competition`, `partner_image_id`, `partner_card`, `partner_state`, `partner_month`, `partner_obs`, `partner_nif`, `partner_class` ) VALUES (@partner_id, @partner_name, @partner_birthdate, @partner_add_date, @partner_gender, @partner_cc, @partner_address, @partner_postal, @partner_city, @partner_phone, @partner_mobile, @partner_email, @partner_parent, @partner_is_competition, @partner_image_id, @partner_card, @partner_state, 0, @partner_obs, @partner_nif, @partner_class);", conn)
            cmd.Parameters.AddWithValue("@partner_id", partner.partnerNumber)
            cmd.Parameters.AddWithValue("@partner_name", partner.partnerName)
            cmd.Parameters.AddWithValue("@partner_birthdate", partner.partnerBirthDate)
            cmd.Parameters.AddWithValue("@partner_add_date", partner.partnerAddDate)
            cmd.Parameters.AddWithValue("@partner_gender", partner.partnerGender)
            cmd.Parameters.AddWithValue("@partner_cc", partner.partnerCC)
            cmd.Parameters.AddWithValue("@partner_address", partner.partnerAddress)
            cmd.Parameters.AddWithValue("@partner_postal", partner.partnerPostal)
            cmd.Parameters.AddWithValue("@partner_city", partner.partnerCity)
            cmd.Parameters.AddWithValue("@partner_phone", partner.partnerPhone)
            cmd.Parameters.AddWithValue("@partner_mobile", partner.partnerMobile)
            cmd.Parameters.AddWithValue("@partner_email", partner.partnerEmail)
            cmd.Parameters.AddWithValue("@partner_parent", partner.partnerParent)
            cmd.Parameters.AddWithValue("@partner_is_competition", partner.partnerIsCompetition)
            cmd.Parameters.AddWithValue("@partner_image_id", partner.partnerImageId)
            cmd.Parameters.AddWithValue("@partner_card", partner.partnerCard)
            cmd.Parameters.AddWithValue("@partner_state", partner.partnerState)
            cmd.Parameters.AddWithValue("@partner_obs", partner.partnerObs)
            cmd.Parameters.AddWithValue("@partner_nif", partner.partnerNif)
            cmd.Parameters.AddWithValue("@partner_class", 0)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Sub updatePartner(partner As partner)
        Using conn
            Dim cmd As New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` set partner_name = @partner_name, partner_birthdate = @partner_birthdate,  partner_gender = @partner_gender,  partner_cc = @partner_cc,  partner_address = @partner_address,  partner_postal = @partner_postal,  partner_city = @partner_city,  partner_phone = @partner_phone,  partner_mobile = @partner_mobile,  partner_email = @partner_email,  partner_parent = @partner_parent,  partner_is_competition = @partner_is_competition,  partner_image_id = @partner_image_id,  partner_state = @partner_state,  partner_obs = @partner_obs,  partner_nif = @partner_nif,  partner_class = @partner_class, partner_month=@partner_month WHERE partner_id = @partner_id;", conn)
            cmd.Parameters.AddWithValue("@partner_id", partner.partnerNumber)
            cmd.Parameters.AddWithValue("@partner_name", partner.partnerName)
            cmd.Parameters.AddWithValue("@partner_birthdate", partner.partnerBirthDate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@partner_gender", Integer.Parse(partner.partnerGender))
            cmd.Parameters.AddWithValue("@partner_cc", partner.partnerCC)
            cmd.Parameters.AddWithValue("@partner_address", partner.partnerAddress)
            cmd.Parameters.AddWithValue("@partner_postal", partner.partnerPostal)
            cmd.Parameters.AddWithValue("@partner_city", partner.partnerCity)
            cmd.Parameters.AddWithValue("@partner_phone", partner.partnerPhone)
            cmd.Parameters.AddWithValue("@partner_mobile", partner.partnerMobile)
            cmd.Parameters.AddWithValue("@partner_email", partner.partnerEmail)
            cmd.Parameters.AddWithValue("@partner_parent", partner.partnerParent)
            cmd.Parameters.AddWithValue("@partner_is_competition", partner.partnerIsCompetition)
            cmd.Parameters.AddWithValue("@partner_image_id", partner.partnerImageId)
            cmd.Parameters.AddWithValue("@partner_state", partner.partnerState)
            cmd.Parameters.AddWithValue("@partner_obs", partner.partnerObs)
            cmd.Parameters.AddWithValue("@partner_nif", partner.partnerNif)
            cmd.Parameters.AddWithValue("@partner_class", partner.partnerClass)
            cmd.Parameters.AddWithValue("@partner_month", partner.partnerMonth)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Sub deletePartner(partnerId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                Dim part As New partner
                part = getPartner(partnerId)
                If part.partnerImageId > 0 Then
                    cmd = New MySqlCommand("DELETE FROM `ncc_2015`.`loo_image` WHERE image_id = @image_id;", conn)
                    cmd.Parameters.AddWithValue("@image_id", part.partnerImageId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End If
                cmd = New MySqlCommand("DELETE FROM `ncc_2015`.`loo_partner` WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Else
                MsgBox("Não pode remover um sócio sem número.")
            End If
        End Using
    End Sub

    Public Function getPartner(partnerId As Integer) As partner
        Dim partner As New partner
        Using conn
            Dim cmd As New MySqlCommand("select * from loo_partner where partner_id=" & partnerId, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                Do While mysqlReader.Read()
                    partner.partnerNumber = mysqlReader.GetInt32(0)
                    partner.partnerName = mysqlReader.GetString(1)
                    partner.partnerBirthDate = mysqlReader.GetDateTime(2)
                    partner.partnerGender = mysqlReader.GetInt16(4).ToString
                    partner.partnerCC = mysqlReader.GetString(5)
                    partner.partnerNif = mysqlReader.GetString(6)
                    partner.partnerAddress = mysqlReader.GetString(7)
                    partner.partnerPostal = mysqlReader.GetString(8)
                    partner.partnerCity = mysqlReader.GetString(9)
                    partner.partnerPhone = mysqlReader.GetString(10)
                    partner.partnerMobile = mysqlReader.GetString(11)
                    partner.partnerEmail = mysqlReader.GetString(12)
                    partner.partnerParent = mysqlReader.GetInt32(13)
                    partner.partnerIsCompetition = mysqlReader.GetBoolean(14)
                    partner.partnerImageId = mysqlReader.GetInt32(16)
                    partner.partnerState = mysqlReader.GetBoolean(18)
                    partner.partnerObs = mysqlReader.GetString(20)
                Loop
            Else
                Console.WriteLine("Não Foram encontrados registos ao procurar Sócio.")
                Return Nothing
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return partner
    End Function

    Public Function existsPartner(partnerId As Integer) As Boolean
        Dim partner As New partner
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand("select * from loo_partner where partner_id=" & partnerId, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                result = True
            Else
                Console.WriteLine("Não Foram encontrados registos ao procurar Sócio.")
                result = False
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return result
    End Function

    '*********************************
    '****TIMETABLE DATABASE CRUD******
    '*********************************

    Sub saveTimetable(timetable As timetable)
        Using conn
            Dim cmd As New MySqlCommand("INSERT INTO `ncc_2015`.`loo_partner_timetable` (`timetable_day`, `timetable_since_hour`, `timetable_since_minutes`, `timetable_to_hour`,`timetable_to_minutes`, `timetable_partner_id`) VALUES (@timetable_day,@timetable_since_hour,@timetable_since_minutes,@timetable_to_hour,@timetable_to_minutes,@timetable_partner_id);", conn)
            cmd.Parameters.AddWithValue("@timetable_day", timetable.day)
            cmd.Parameters.AddWithValue("@timetable_since_hour", timetable.since_hour)
            cmd.Parameters.AddWithValue("@timetable_since_minutes", timetable.since_minutes)
            cmd.Parameters.AddWithValue("@timetable_to_hour", timetable.to_hour)
            cmd.Parameters.AddWithValue("@timetable_to_minutes", timetable.to_minutes)
            cmd.Parameters.AddWithValue("@timetable_partner_id", timetable.partner_id)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
                conn.Dispose()
            End Try

        End Using
    End Sub

    Sub updateTimetable(timetable As timetable)
        Throw New NotImplementedException
    End Sub

    Sub deleteTimetable(timetableId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (timetableId > 0) Then
                cmd = New MySqlCommand("DELETE FROM `ncc_2015`.`loo_partner_timetable` WHERE timetable_id = @timetable_id;", conn)
                cmd.Parameters.AddWithValue("@timetable_id", timetableId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Horário removido com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao remover horário.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Não pode remover horário vazio.")
            End If
        End Using
    End Sub


    Sub getTimeTable(dataGridView As DataGridView, partnerId As Integer)
        Dim dt As New DataTable
        Dim adp As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT `loo_partner_timetable`.`timetable_id` as id, CASE `loo_partner_timetable`.`timetable_day` WHEN 0 THEN 'Segunda'WHEN 1 THEN 'Terça'WHEN 2 THEN 'Quarta'WHEN 3 THEN 'Quinta'WHEN 4 THEN 'Sexta'WHEN 5 THEN 'Sábado'WHEN 6 THEN 'Domingo'END AS day, CONCAT(`loo_partner_timetable`.`timetable_since_hour`, ':' , `loo_partner_timetable`.`timetable_since_minutes`) AS begin, CONCAT(`loo_partner_timetable`.`timetable_to_hour`, ':', `loo_partner_timetable`.`timetable_to_minutes`) AS end FROM `ncc_2015`.`loo_partner_timetable` WHERE timetable_partner_id =" & partnerId
            Dim cmd As New MySqlCommand(Query, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt)
            bSource.DataSource = dt
            dataGridView.DataSource = bSource
            adp.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub


    '*********************************
    '******CLASSES DATABASE CRUD******
    '*********************************

    Sub addClassToPartner(partnerId As Integer, partnerClass As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                cmd = New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` SET partner_class = @partner_class WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_class", partnerClass)
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Classe atribuída com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao atribuir classe.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Não atribuir classe a um não sócio.")
            End If
        End Using
    End Sub

    Public Function getPartnerClassId(partnerId As Integer) As Integer
        Dim class_id As String = ""
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_class FROM ncc_2015.loo_partner WHERE partner_id = @partner_id;", conn)
            cmd.Parameters.AddWithValue("@partner_id", partnerId)
            conn.Open()
            If Not cmd.ExecuteScalar().Equals(vbNull) Then
                class_id = CType(cmd.ExecuteScalar, String)
            End If
            conn.Close()
        End Using
        Return If(CInt(class_id) > 0, CInt(class_id), 0)
    End Function

    Public Function getPartnerClassName(classId As Integer) As String
        Dim class_name As String
        Using conn
            Dim cmd As New MySqlCommand("SELECT class_name FROM ncc_2015.loo_partner_class WHERE class_id = @class_id;", conn)
            cmd.Parameters.AddWithValue("@class_id", classId)
            conn.Open()
            class_name = CType(cmd.ExecuteScalar(), String)
            conn.Close()
        End Using
        Return class_name
    End Function

    Sub getClassePartners(dataGridView As DataGridView, class_id As Integer)
        Dim dt As New DataTable
        Dim adp As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            If class_id = -1 Then
                Query = "SELECT `partner_id`,`partner_name` FROM `ncc_2015`.`loo_partner` WHERE partner_is_competition = 1"
            Else
                Query = "SELECT `partner_id`,`partner_name` FROM `ncc_2015`.`loo_partner` WHERE partner_class =" & class_id
            End If
            Dim cmd As New MySqlCommand(Query, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt)
            bSource.DataSource = dt
            dataGridView.DataSource = bSource
            adp.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub


    '*********************************
    '**PARTNER PARENT DATABASE CRUD***
    '*********************************

    Public Function hasParent(partnerId As Integer) As partner
        Dim partner_parent_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_parent FROM ncc_2015.loo_partner WHERE partner_id = @partner_id;", conn)
            cmd.Parameters.AddWithValue("@partner_id", partnerId)
            conn.Open()
            partner_parent_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        If partner_parent_id > 0 Then
            Return getPartner(partner_parent_id)
        Else
            Return Nothing
        End If
    End Function

    Public Function isParent(partnerId As Integer) As partner
        Dim partner_parent_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT partner_parent FROM ncc_2015.loo_partner WHERE partner_id = @partner_parent;", conn)
            cmd.Parameters.AddWithValue("@partner_parent", partnerId)
            conn.Open()
            partner_parent_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        If partner_parent_id > 0 Then
            Return getPartner(partner_parent_id)
        Else
            Return Nothing
        End If
    End Function

    Sub removeParentFromPartner(partnerId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                cmd = New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` SET partner_parent = 0 WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Enc. de Edu. retirado com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao retirar Enc. de Edu.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Problema ao retirar Enc. de Edu. Verifique o número de sócio.")
            End If
        End Using
    End Sub

    Sub addParentToPartner(partnerId As Integer, parentId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                cmd = New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` SET partner_parent = @partner_parent WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                cmd.Parameters.AddWithValue("@partner_parent", parentId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Enc. de Edu. reposto com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao repor Enc. de Edu.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Problema ao repor Enc. de Edu. Verifique o número de sócio.")
            End If
        End Using
    End Sub

    '************************
    '**MEDIC DATABASE CRUD***
    '************************

    Public Sub saveMedic(m As medic)
        Using conn
            Dim cmd As New MySqlCommand("INSERT INTO `ncc_2015`.`loo_medic` (`medic_id`, `medic_card_number`, `medic_entity`, `medic_partner_id`) VALUES (@medic_id,@medic_card_number,@medic_entity,@medic_partner_id);", conn)
            cmd.Parameters.AddWithValue("@medic_id", m.medicId)
            cmd.Parameters.AddWithValue("@medic_card_number", m.medicCardNumber)
            cmd.Parameters.AddWithValue("@medic_entity", m.medicEntity)
            cmd.Parameters.AddWithValue("@medic_partner_id", m.medicPartnerId)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registo guardado com sucesso !!")
            Catch ex As MySqlException
                MessageBox.Show("Problemas ao guardar informacoes medicas.MSG: " & ex.Message)
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End Using
    End Sub

    Public Sub updateMedic(m As medic)
        Using conn
            Dim cmd As New MySqlCommand("UPDATE `ncc_2015`.`loo_medic` set medic_id = @medic_id, medic_card_number = @medic_card_number, medic_entity = @medic_entity WHERE medic_partner_id = @medic_partner_id;", conn)
            cmd.Parameters.AddWithValue("@medic_id", m.medicId)
            cmd.Parameters.AddWithValue("@medic_card_number", m.medicCardNumber)
            cmd.Parameters.AddWithValue("@medic_entity", m.medicEntity)
            cmd.Parameters.AddWithValue("@medic_partner_id", m.medicPartnerId)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registo guardado com sucesso !!")
            Catch ex As Exception
                MessageBox.Show("Problemas ao atualizar informacoes medicas.MSG: " & ex.Message)
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End Using
    End Sub

    Sub addMedicInfoToPartner(partnerId As Integer, partnerClass As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                cmd = New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` SET partner_class = @partner_class WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_class", partnerClass)
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Classe atribuída com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao atribuir classe.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Não atribuir classe a um não sócio.")
            End If
        End Using
    End Sub

    Public Function getMedicLastId() As Integer
        Dim medic_id As Integer
        Using conn
            Dim cmd As New MySqlCommand("SELECT medic_id FROM ncc_2015.loo_medic order by medic_id desc limit 1", conn)
            conn.Open()
            medic_id = CInt(cmd.ExecuteScalar())
            conn.Close()
        End Using
        Return medic_id + 1
    End Function

    Public Function getMedicPartner(pid As Integer) As medic
        Dim m As New medic
        Using conn
            Dim cmd As New MySqlCommand("select * from loo_medic where medic_partner_id=" & pid, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                Do While mysqlReader.Read()
                    m.medicId = mysqlReader.GetInt32(0)
                    m.medicCardNumber = mysqlReader.GetString(1)
                    m.medicEntity = mysqlReader.GetString(2)
                    m.medicPartnerId = mysqlReader.GetInt32(3)
                Loop
            Else
                Console.WriteLine("Não Foram encontrados registos ao procurar Sócio.")
                Return Nothing
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return m
    End Function

    '********************
    '**CARD VALIDATION***
    '********************

    Public Function isValid(cn As String) As Boolean
        Dim partner As New partner
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand("select * from loo_partner where partner_card=" & cn & " ", conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                result = True
            Else
                Console.WriteLine("Não Foram encontrados registos ao procurar Sócio.")
                result = False
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return result
    End Function

    Public Function getPartnerByCard(cn As Integer) As partner
        Dim partner As New partner
        Using conn
            Dim cmd As New MySqlCommand("select * from loo_partner where partner_card=" & cn, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                Do While mysqlReader.Read()
                    partner.partnerNumber = mysqlReader.GetInt32(0)
                    partner.partnerName = mysqlReader.GetString(1)
                    partner.partnerBirthDate = mysqlReader.GetDateTime(2)
                    partner.partnerGender = mysqlReader.GetInt16(4).ToString
                    partner.partnerCC = mysqlReader.GetString(5)
                    partner.partnerNif = mysqlReader.GetString(6)
                    partner.partnerAddress = mysqlReader.GetString(7)
                    partner.partnerPostal = mysqlReader.GetString(8)
                    partner.partnerCity = mysqlReader.GetString(9)
                    partner.partnerPhone = mysqlReader.GetString(10)
                    partner.partnerMobile = mysqlReader.GetString(11)
                    partner.partnerEmail = mysqlReader.GetString(12)
                    partner.partnerParent = mysqlReader.GetInt32(13)
                    partner.partnerIsCompetition = mysqlReader.GetBoolean(14)
                    partner.partnerImageId = mysqlReader.GetInt32(16)
                    partner.partnerState = mysqlReader.GetBoolean(18)
                    partner.partnerMonth = mysqlReader.GetInt32(19)
                    partner.partnerObs = mysqlReader.GetString(20)
                Loop
            Else
                Console.WriteLine("Não Foram encontrados registos ao procurar Sócio.")
                Return Nothing
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return partner
    End Function

    Sub addCardToPartner(partnerId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (partnerId > 0) Then
                cmd = New MySqlCommand("UPDATE `ncc_2015`.`loo_partner` SET partner_card = @partner_card WHERE partner_id = @partner_id;", conn)
                cmd.Parameters.AddWithValue("@partner_card", gf.preparaNumeroCartao(partnerId.ToString))
                cmd.Parameters.AddWithValue("@partner_id", partnerId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Problema ao atribuir numero de cartao.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Problema ao atribuir numero de cartao. Contacte suporte por favor.")
            End If
        End Using
    End Sub

    '*************
    '**PAYMENTS***
    '*************
    Public Sub savePayment(pay As payment)
        Using conn
            Dim cmd As New MySqlCommand("INSERT INTO `ncc_2015`.`loo_payment` (`payment_date`,`payment_value`,`payment_partner`) VALUES (@payment_date,@payment_value,@payment_partner);", conn)
            cmd.Parameters.AddWithValue("@payment_date", pay.paymentDay)
            cmd.Parameters.AddWithValue("@payment_value", pay.paymentValue)
            cmd.Parameters.AddWithValue("@payment_partner", pay.paymentPartner.partnerNumber)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Sub updatePayment(pay As payment)
        Using conn
            Dim cmd As New MySqlCommand("UPDATE `ncc_2015`.`loo_payment` set payment_date = @payment_date, payment_value = @payment_value WHERE partner_id = @partner_id ORDER BY @payment_date DESC LIMIT 1;", conn)
            cmd.Parameters.AddWithValue("@payment_date", pay.paymentDay)
            cmd.Parameters.AddWithValue("@payment_value", pay.paymentValue)
            cmd.Parameters.AddWithValue("@payment_partner", pay.paymentPartner.partnerNumber)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Function setPaymentValue(partnerid As Integer, money As Integer, dateMonth As Integer) As Boolean
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand()
            Try
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "set_payment_value"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("partnerid", partnerid)
                cmd.Parameters.AddWithValue("money", money)
                cmd.Parameters.AddWithValue("date_month", dateMonth)
                cmd.Parameters("partnerid").Direction = ParameterDirection.Input
                cmd.Parameters("money").Direction = ParameterDirection.Input
                cmd.Parameters("date_month").Direction = ParameterDirection.Input
                gf.logNcc("pagamento efetuado com sucesso em " & Date.Now)
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                Console.WriteLine(("Error " & ex.Number & " has occurred: ") + ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return result
    End Function

    Public Function getLastPayment(partnerid As Integer) As Integer
        Dim result As Integer
        Using conn
            Dim cmd As New MySqlCommand()
            Try
                cmd.Connection = conn
                cmd.CommandText = "get_last_payment"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("partnerid", partnerid)
                cmd.Parameters("partnerid").Direction = ParameterDirection.Input
                conn.Open()
                result = CInt(cmd.ExecuteScalar())
            Catch ex As MySqlException
                Console.WriteLine(("Error " & ex.Number & " has occurred: ") + ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return result
    End Function

    '*******************
    '**ACCESS CONTROL***
    '*******************

    Public Function isValidDay(partnerNumber As Integer) As Boolean
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand("SELECT * FROM ncc_2015.loo_partner_timetable where timetable_partner_id = " & partnerNumber & " and timetable_since_hour = " & System.DateTime.Now.Hour & " and timetable_to_hour > " & System.DateTime.Now.Hour & " and timetable_day =" & Today.DayOfWeek - 1, conn)
            Dim mysqlReader As MySqlDataReader
            conn.Open()
            mysqlReader = cmd.ExecuteReader
            If mysqlReader.HasRows Then
                result = True
            Else
                result = False
            End If
            mysqlReader.Close()
            conn.Close()
        End Using
        Return result
    End Function

    Public Function hasPayed(partnerNumber As Integer, month As Integer) As Boolean
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand()
            Try
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "has_payed"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("partnerid", partnerNumber)
                cmd.Parameters.AddWithValue("date_month", month)
                cmd.Parameters("partnerid").Direction = ParameterDirection.Input
                cmd.Parameters("date_month").Direction = ParameterDirection.Input
                Dim sqlReader As MySqlDataReader = cmd.ExecuteReader
                If sqlReader.HasRows Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As MySqlException
                Console.WriteLine(("Error " & ex.Number & " has occurred: ") + ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return result
    End Function

    Public Function resetGlobalPartnerState() As Boolean
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand()
            Try
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "reset_state"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQueryAsync()
            Catch ex As MySqlException
                Console.WriteLine(("Error " & ex.Number & " has occurred: ") + ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return result
    End Function


    '***********************
    '**EXPENSES OPERATIONS**
    '***********************

    Public Sub insertExpense(expense_value As Double, expense_type As Int16, expense_date As Date)
        Dim result As New Boolean
        Using conn
            Dim cmd As New MySqlCommand()
            Try
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "create_expense"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("expense_type", expense_type)
                cmd.Parameters.AddWithValue("expense_value", expense_value)
                cmd.Parameters.AddWithValue("expense_date", expense_date)
                cmd.Parameters("expense_type").Direction = ParameterDirection.Input
                cmd.Parameters("expense_value").Direction = ParameterDirection.Input
                cmd.Parameters("expense_date").Direction = ParameterDirection.Input
                cmd.ExecuteNonQueryAsync()
                MsgBox("Despesa criada com sucesso.")
            Catch ex As MySqlException
                Console.WriteLine(("Error " & ex.Number & " has occurred: ") + ex.Message)
                MsgBox("Despesa não criada. Reporte ao seu Administrador.")
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Sub deleteExpense(expenseId As Integer)
        Using conn
            Dim cmd As New MySqlCommand
            If (expenseId > 0) Then
                cmd = New MySqlCommand("DELETE FROM `ncc_2015`.`loo_expense` WHERE expense_id = @expense_id;", conn)
                cmd.Parameters.AddWithValue("@expense_id", expenseId)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Despesa Removida com sucesso.")
                Catch ex As Exception
                    MsgBox("Problema ao remover despesa.")
                Finally
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("Não pode remover despesa vazia.")
            End If
        End Using
    End Sub

End Class
