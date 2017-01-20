<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altera_socio_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altera_socio_form))
        Me.openImageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.partnerModifyObsTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyIdLbl = New System.Windows.Forms.Label()
        Me.partnerModifyNameLbl = New System.Windows.Forms.Label()
        Me.partnerModifyBirthDateLbl = New System.Windows.Forms.Label()
        Me.partnerModifyPostalLbl = New System.Windows.Forms.Label()
        Me.partnerModifyAddressLbl = New System.Windows.Forms.Label()
        Me.partnerModifyCCLbl = New System.Windows.Forms.Label()
        Me.partnerModifyGenderLbl = New System.Windows.Forms.Label()
        Me.partnerModifyEmailLbl = New System.Windows.Forms.Label()
        Me.partnerModifyMobileLbl = New System.Windows.Forms.Label()
        Me.partnerModifyPhoneLbl = New System.Windows.Forms.Label()
        Me.partnerModifyCityLbl = New System.Windows.Forms.Label()
        Me.partnerModifyIdTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyNameTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyBirthDateDfl = New System.Windows.Forms.DateTimePicker()
        Me.partnerModifyGenderCbx = New System.Windows.Forms.ComboBox()
        Me.partnerModifyCCTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyPhoneTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyCityTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyPostalTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyAddressTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyMobileTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyEmailTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyNifLbl = New System.Windows.Forms.Label()
        Me.partnerModifyNifTxt = New System.Windows.Forms.TextBox()
        Me.partnerModifyCompetitionChk = New System.Windows.Forms.CheckBox()
        Me.isCompetitionLbl = New System.Windows.Forms.Label()
        Me.activeChk = New System.Windows.Forms.CheckBox()
        Me.activeLbl = New System.Windows.Forms.Label()
        Me.alterSocioToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.alterPaymentBtn = New System.Windows.Forms.Button()
        Me.alterCardCreateBtn = New System.Windows.Forms.Button()
        Me.addMedicBtn = New System.Windows.Forms.Button()
        Me.searchSocioBtn = New System.Windows.Forms.Button()
        Me.partnerModifyReportBtn = New System.Windows.Forms.Button()
        Me.addParentBtn = New System.Windows.Forms.Button()
        Me.partnerModifyAddClass = New System.Windows.Forms.Button()
        Me.partnerBackBtn = New System.Windows.Forms.Button()
        Me.partnerNextBtn = New System.Windows.Forms.Button()
        Me.partnerAddTimetableBtn = New System.Windows.Forms.Button()
        Me.partnerModifyClearBtn = New System.Windows.Forms.Button()
        Me.partnerModifySaveBtn = New System.Windows.Forms.Button()
        Me.partnerModifyQuitBtn = New System.Windows.Forms.Button()
        Me.partnerModifyImageBox = New System.Windows.Forms.PictureBox()
        CType(Me.partnerModifyImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'partnerModifyObsTxt
        '
        Me.partnerModifyObsTxt.Location = New System.Drawing.Point(169, 7)
        Me.partnerModifyObsTxt.Multiline = True
        Me.partnerModifyObsTxt.Name = "partnerModifyObsTxt"
        Me.partnerModifyObsTxt.Size = New System.Drawing.Size(533, 151)
        Me.partnerModifyObsTxt.TabIndex = 15
        '
        'partnerModifyIdLbl
        '
        Me.partnerModifyIdLbl.AutoSize = True
        Me.partnerModifyIdLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyIdLbl.Location = New System.Drawing.Point(85, 174)
        Me.partnerModifyIdLbl.Name = "partnerModifyIdLbl"
        Me.partnerModifyIdLbl.Size = New System.Drawing.Size(69, 16)
        Me.partnerModifyIdLbl.TabIndex = 2
        Me.partnerModifyIdLbl.Text = "N. Sócio:"
        '
        'partnerModifyNameLbl
        '
        Me.partnerModifyNameLbl.AutoSize = True
        Me.partnerModifyNameLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyNameLbl.Location = New System.Drawing.Point(102, 204)
        Me.partnerModifyNameLbl.Name = "partnerModifyNameLbl"
        Me.partnerModifyNameLbl.Size = New System.Drawing.Size(52, 16)
        Me.partnerModifyNameLbl.TabIndex = 3
        Me.partnerModifyNameLbl.Text = "Nome:"
        '
        'partnerModifyBirthDateLbl
        '
        Me.partnerModifyBirthDateLbl.AutoSize = True
        Me.partnerModifyBirthDateLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyBirthDateLbl.Location = New System.Drawing.Point(69, 235)
        Me.partnerModifyBirthDateLbl.Name = "partnerModifyBirthDateLbl"
        Me.partnerModifyBirthDateLbl.Size = New System.Drawing.Size(85, 16)
        Me.partnerModifyBirthDateLbl.TabIndex = 4
        Me.partnerModifyBirthDateLbl.Text = "Data Nasc.:"
        '
        'partnerModifyPostalLbl
        '
        Me.partnerModifyPostalLbl.AutoSize = True
        Me.partnerModifyPostalLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyPostalLbl.Location = New System.Drawing.Point(85, 354)
        Me.partnerModifyPostalLbl.Name = "partnerModifyPostalLbl"
        Me.partnerModifyPostalLbl.Size = New System.Drawing.Size(69, 16)
        Me.partnerModifyPostalLbl.TabIndex = 5
        Me.partnerModifyPostalLbl.Text = "C.Postal:"
        '
        'partnerModifyAddressLbl
        '
        Me.partnerModifyAddressLbl.AutoSize = True
        Me.partnerModifyAddressLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyAddressLbl.Location = New System.Drawing.Point(89, 324)
        Me.partnerModifyAddressLbl.Name = "partnerModifyAddressLbl"
        Me.partnerModifyAddressLbl.Size = New System.Drawing.Size(65, 16)
        Me.partnerModifyAddressLbl.TabIndex = 6
        Me.partnerModifyAddressLbl.Text = "Morada:"
        '
        'partnerModifyCCLbl
        '
        Me.partnerModifyCCLbl.AutoSize = True
        Me.partnerModifyCCLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyCCLbl.Location = New System.Drawing.Point(96, 294)
        Me.partnerModifyCCLbl.Name = "partnerModifyCCLbl"
        Me.partnerModifyCCLbl.Size = New System.Drawing.Size(58, 16)
        Me.partnerModifyCCLbl.TabIndex = 7
        Me.partnerModifyCCLbl.Text = "BI / CC:"
        '
        'partnerModifyGenderLbl
        '
        Me.partnerModifyGenderLbl.AutoSize = True
        Me.partnerModifyGenderLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyGenderLbl.Location = New System.Drawing.Point(107, 263)
        Me.partnerModifyGenderLbl.Name = "partnerModifyGenderLbl"
        Me.partnerModifyGenderLbl.Size = New System.Drawing.Size(47, 16)
        Me.partnerModifyGenderLbl.TabIndex = 8
        Me.partnerModifyGenderLbl.Text = "Sexo:"
        '
        'partnerModifyEmailLbl
        '
        Me.partnerModifyEmailLbl.AutoSize = True
        Me.partnerModifyEmailLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyEmailLbl.Location = New System.Drawing.Point(105, 474)
        Me.partnerModifyEmailLbl.Name = "partnerModifyEmailLbl"
        Me.partnerModifyEmailLbl.Size = New System.Drawing.Size(49, 16)
        Me.partnerModifyEmailLbl.TabIndex = 9
        Me.partnerModifyEmailLbl.Text = "Email:"
        '
        'partnerModifyMobileLbl
        '
        Me.partnerModifyMobileLbl.AutoSize = True
        Me.partnerModifyMobileLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyMobileLbl.Location = New System.Drawing.Point(101, 444)
        Me.partnerModifyMobileLbl.Name = "partnerModifyMobileLbl"
        Me.partnerModifyMobileLbl.Size = New System.Drawing.Size(53, 16)
        Me.partnerModifyMobileLbl.TabIndex = 10
        Me.partnerModifyMobileLbl.Text = "Telem:"
        '
        'partnerModifyPhoneLbl
        '
        Me.partnerModifyPhoneLbl.AutoSize = True
        Me.partnerModifyPhoneLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyPhoneLbl.Location = New System.Drawing.Point(107, 414)
        Me.partnerModifyPhoneLbl.Name = "partnerModifyPhoneLbl"
        Me.partnerModifyPhoneLbl.Size = New System.Drawing.Size(46, 16)
        Me.partnerModifyPhoneLbl.TabIndex = 11
        Me.partnerModifyPhoneLbl.Text = "Telef:"
        '
        'partnerModifyCityLbl
        '
        Me.partnerModifyCityLbl.AutoSize = True
        Me.partnerModifyCityLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyCityLbl.Location = New System.Drawing.Point(93, 384)
        Me.partnerModifyCityLbl.Name = "partnerModifyCityLbl"
        Me.partnerModifyCityLbl.Size = New System.Drawing.Size(61, 16)
        Me.partnerModifyCityLbl.TabIndex = 12
        Me.partnerModifyCityLbl.Text = "Cidade:"
        '
        'partnerModifyIdTxt
        '
        Me.partnerModifyIdTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyIdTxt.Location = New System.Drawing.Point(169, 170)
        Me.partnerModifyIdTxt.MaxLength = 11
        Me.partnerModifyIdTxt.Name = "partnerModifyIdTxt"
        Me.partnerModifyIdTxt.Size = New System.Drawing.Size(121, 24)
        Me.partnerModifyIdTxt.TabIndex = 1
        '
        'partnerModifyNameTxt
        '
        Me.partnerModifyNameTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyNameTxt.Location = New System.Drawing.Point(169, 200)
        Me.partnerModifyNameTxt.MaxLength = 255
        Me.partnerModifyNameTxt.Name = "partnerModifyNameTxt"
        Me.partnerModifyNameTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyNameTxt.TabIndex = 2
        '
        'partnerModifyBirthDateDfl
        '
        Me.partnerModifyBirthDateDfl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyBirthDateDfl.Location = New System.Drawing.Point(169, 231)
        Me.partnerModifyBirthDateDfl.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.partnerModifyBirthDateDfl.Name = "partnerModifyBirthDateDfl"
        Me.partnerModifyBirthDateDfl.Size = New System.Drawing.Size(533, 23)
        Me.partnerModifyBirthDateDfl.TabIndex = 3
        Me.partnerModifyBirthDateDfl.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'partnerModifyGenderCbx
        '
        Me.partnerModifyGenderCbx.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.partnerModifyGenderCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partnerModifyGenderCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.partnerModifyGenderCbx.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyGenderCbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.partnerModifyGenderCbx.FormattingEnabled = True
        Me.partnerModifyGenderCbx.Items.AddRange(New Object() {"Outro", "Feminino", "Masculino"})
        Me.partnerModifyGenderCbx.Location = New System.Drawing.Point(169, 260)
        Me.partnerModifyGenderCbx.Name = "partnerModifyGenderCbx"
        Me.partnerModifyGenderCbx.Size = New System.Drawing.Size(121, 24)
        Me.partnerModifyGenderCbx.TabIndex = 4
        '
        'partnerModifyCCTxt
        '
        Me.partnerModifyCCTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyCCTxt.Location = New System.Drawing.Point(169, 290)
        Me.partnerModifyCCTxt.MaxLength = 35
        Me.partnerModifyCCTxt.Name = "partnerModifyCCTxt"
        Me.partnerModifyCCTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyCCTxt.TabIndex = 5
        '
        'partnerModifyPhoneTxt
        '
        Me.partnerModifyPhoneTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyPhoneTxt.Location = New System.Drawing.Point(169, 410)
        Me.partnerModifyPhoneTxt.MaxLength = 20
        Me.partnerModifyPhoneTxt.Name = "partnerModifyPhoneTxt"
        Me.partnerModifyPhoneTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyPhoneTxt.TabIndex = 9
        '
        'partnerModifyCityTxt
        '
        Me.partnerModifyCityTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyCityTxt.Location = New System.Drawing.Point(169, 380)
        Me.partnerModifyCityTxt.MaxLength = 255
        Me.partnerModifyCityTxt.Name = "partnerModifyCityTxt"
        Me.partnerModifyCityTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyCityTxt.TabIndex = 8
        '
        'partnerModifyPostalTxt
        '
        Me.partnerModifyPostalTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyPostalTxt.Location = New System.Drawing.Point(169, 350)
        Me.partnerModifyPostalTxt.MaxLength = 255
        Me.partnerModifyPostalTxt.Name = "partnerModifyPostalTxt"
        Me.partnerModifyPostalTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyPostalTxt.TabIndex = 7
        '
        'partnerModifyAddressTxt
        '
        Me.partnerModifyAddressTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyAddressTxt.Location = New System.Drawing.Point(169, 320)
        Me.partnerModifyAddressTxt.MaxLength = 255
        Me.partnerModifyAddressTxt.Name = "partnerModifyAddressTxt"
        Me.partnerModifyAddressTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyAddressTxt.TabIndex = 6
        '
        'partnerModifyMobileTxt
        '
        Me.partnerModifyMobileTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyMobileTxt.Location = New System.Drawing.Point(169, 440)
        Me.partnerModifyMobileTxt.MaxLength = 20
        Me.partnerModifyMobileTxt.Name = "partnerModifyMobileTxt"
        Me.partnerModifyMobileTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyMobileTxt.TabIndex = 10
        '
        'partnerModifyEmailTxt
        '
        Me.partnerModifyEmailTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyEmailTxt.Location = New System.Drawing.Point(169, 470)
        Me.partnerModifyEmailTxt.MaxLength = 255
        Me.partnerModifyEmailTxt.Name = "partnerModifyEmailTxt"
        Me.partnerModifyEmailTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyEmailTxt.TabIndex = 11
        '
        'partnerModifyNifLbl
        '
        Me.partnerModifyNifLbl.AutoSize = True
        Me.partnerModifyNifLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyNifLbl.Location = New System.Drawing.Point(105, 504)
        Me.partnerModifyNifLbl.Name = "partnerModifyNifLbl"
        Me.partnerModifyNifLbl.Size = New System.Drawing.Size(31, 16)
        Me.partnerModifyNifLbl.TabIndex = 9
        Me.partnerModifyNifLbl.Text = "Nif:"
        '
        'partnerModifyNifTxt
        '
        Me.partnerModifyNifTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerModifyNifTxt.Location = New System.Drawing.Point(169, 500)
        Me.partnerModifyNifTxt.MaxLength = 255
        Me.partnerModifyNifTxt.Name = "partnerModifyNifTxt"
        Me.partnerModifyNifTxt.Size = New System.Drawing.Size(533, 24)
        Me.partnerModifyNifTxt.TabIndex = 11
        '
        'partnerModifyCompetitionChk
        '
        Me.partnerModifyCompetitionChk.AutoSize = True
        Me.partnerModifyCompetitionChk.Location = New System.Drawing.Point(424, 176)
        Me.partnerModifyCompetitionChk.Name = "partnerModifyCompetitionChk"
        Me.partnerModifyCompetitionChk.Size = New System.Drawing.Size(15, 14)
        Me.partnerModifyCompetitionChk.TabIndex = 38
        Me.partnerModifyCompetitionChk.UseVisualStyleBackColor = True
        '
        'isCompetitionLbl
        '
        Me.isCompetitionLbl.AutoSize = True
        Me.isCompetitionLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isCompetitionLbl.Location = New System.Drawing.Point(324, 174)
        Me.isCompetitionLbl.Name = "isCompetitionLbl"
        Me.isCompetitionLbl.Size = New System.Drawing.Size(95, 16)
        Me.isCompetitionLbl.TabIndex = 37
        Me.isCompetitionLbl.Text = "Competição:"
        '
        'activeChk
        '
        Me.activeChk.AutoSize = True
        Me.activeChk.Location = New System.Drawing.Point(545, 176)
        Me.activeChk.Name = "activeChk"
        Me.activeChk.Size = New System.Drawing.Size(15, 14)
        Me.activeChk.TabIndex = 40
        Me.activeChk.UseVisualStyleBackColor = True
        '
        'activeLbl
        '
        Me.activeLbl.AutoSize = True
        Me.activeLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activeLbl.Location = New System.Drawing.Point(489, 174)
        Me.activeLbl.Name = "activeLbl"
        Me.activeLbl.Size = New System.Drawing.Size(48, 16)
        Me.activeLbl.TabIndex = 39
        Me.activeLbl.Text = "Ativo:"
        '
        'alterSocioToolTip
        '
        Me.alterSocioToolTip.AutomaticDelay = 0
        Me.alterSocioToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.alterSocioToolTip.ForeColor = System.Drawing.SystemColors.HighlightText
        '
        'alterPaymentBtn
        '
        Me.alterPaymentBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.alterPaymentBtn.Image = Global.NCC2015.My.Resources.Resources.Euro_32
        Me.alterPaymentBtn.Location = New System.Drawing.Point(202, 530)
        Me.alterPaymentBtn.Name = "alterPaymentBtn"
        Me.alterPaymentBtn.Size = New System.Drawing.Size(50, 50)
        Me.alterPaymentBtn.TabIndex = 45
        Me.alterSocioToolTip.SetToolTip(Me.alterPaymentBtn, "Pagamento")
        Me.alterPaymentBtn.UseVisualStyleBackColor = False
        '
        'alterCardCreateBtn
        '
        Me.alterCardCreateBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.alterCardCreateBtn.Image = Global.NCC2015.My.Resources.Resources.Insert_Card_24
        Me.alterCardCreateBtn.Location = New System.Drawing.Point(252, 530)
        Me.alterCardCreateBtn.Name = "alterCardCreateBtn"
        Me.alterCardCreateBtn.Size = New System.Drawing.Size(50, 50)
        Me.alterCardCreateBtn.TabIndex = 44
        Me.alterSocioToolTip.SetToolTip(Me.alterCardCreateBtn, "Criar Cartao")
        Me.alterCardCreateBtn.UseVisualStyleBackColor = False
        '
        'addMedicBtn
        '
        Me.addMedicBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.addMedicBtn.Image = Global.NCC2015.My.Resources.Resources.Nurse_Female_24
        Me.addMedicBtn.Location = New System.Drawing.Point(352, 530)
        Me.addMedicBtn.Name = "addMedicBtn"
        Me.addMedicBtn.Size = New System.Drawing.Size(50, 50)
        Me.addMedicBtn.TabIndex = 43
        Me.alterSocioToolTip.SetToolTip(Me.addMedicBtn, "Informacao Medica")
        Me.addMedicBtn.UseVisualStyleBackColor = False
        '
        'searchSocioBtn
        '
        Me.searchSocioBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.searchSocioBtn.Image = Global.NCC2015.My.Resources.Resources.Search_24
        Me.searchSocioBtn.Location = New System.Drawing.Point(102, 530)
        Me.searchSocioBtn.Name = "searchSocioBtn"
        Me.searchSocioBtn.Size = New System.Drawing.Size(50, 50)
        Me.searchSocioBtn.TabIndex = 42
        Me.alterSocioToolTip.SetToolTip(Me.searchSocioBtn, "Procurar Sócio")
        Me.searchSocioBtn.UseVisualStyleBackColor = False
        '
        'partnerModifyReportBtn
        '
        Me.partnerModifyReportBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerModifyReportBtn.Image = Global.NCC2015.My.Resources.Resources.View_File_24
        Me.partnerModifyReportBtn.Location = New System.Drawing.Point(302, 530)
        Me.partnerModifyReportBtn.Name = "partnerModifyReportBtn"
        Me.partnerModifyReportBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerModifyReportBtn.TabIndex = 41
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifyReportBtn, "Visualizar Ficha")
        Me.partnerModifyReportBtn.UseVisualStyleBackColor = False
        '
        'addParentBtn
        '
        Me.addParentBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.addParentBtn.Image = Global.NCC2015.My.Resources.Resources.Parent_Guardian_24
        Me.addParentBtn.Location = New System.Drawing.Point(402, 530)
        Me.addParentBtn.Name = "addParentBtn"
        Me.addParentBtn.Size = New System.Drawing.Size(50, 50)
        Me.addParentBtn.TabIndex = 36
        Me.alterSocioToolTip.SetToolTip(Me.addParentBtn, "Adicionar Enc. Educação")
        Me.addParentBtn.UseVisualStyleBackColor = False
        '
        'partnerModifyAddClass
        '
        Me.partnerModifyAddClass.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerModifyAddClass.Image = Global.NCC2015.My.Resources.Resources.User_Groups_24
        Me.partnerModifyAddClass.Location = New System.Drawing.Point(452, 530)
        Me.partnerModifyAddClass.Name = "partnerModifyAddClass"
        Me.partnerModifyAddClass.Size = New System.Drawing.Size(50, 50)
        Me.partnerModifyAddClass.TabIndex = 35
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifyAddClass, "Atribuir Classe")
        Me.partnerModifyAddClass.UseVisualStyleBackColor = False
        '
        'partnerBackBtn
        '
        Me.partnerBackBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerBackBtn.Image = Global.NCC2015.My.Resources.Resources.Circled_Left_24
        Me.partnerBackBtn.Location = New System.Drawing.Point(52, 530)
        Me.partnerBackBtn.Name = "partnerBackBtn"
        Me.partnerBackBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerBackBtn.TabIndex = 34
        Me.alterSocioToolTip.SetToolTip(Me.partnerBackBtn, "Anterior")
        Me.partnerBackBtn.UseVisualStyleBackColor = False
        '
        'partnerNextBtn
        '
        Me.partnerNextBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerNextBtn.Image = Global.NCC2015.My.Resources.Resources.Circled_Right_24
        Me.partnerNextBtn.Location = New System.Drawing.Point(152, 530)
        Me.partnerNextBtn.Name = "partnerNextBtn"
        Me.partnerNextBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerNextBtn.TabIndex = 33
        Me.alterSocioToolTip.SetToolTip(Me.partnerNextBtn, "Seguinte")
        Me.partnerNextBtn.UseVisualStyleBackColor = False
        '
        'partnerAddTimetableBtn
        '
        Me.partnerAddTimetableBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerAddTimetableBtn.Image = Global.NCC2015.My.Resources.Resources.Overtime_24
        Me.partnerAddTimetableBtn.Location = New System.Drawing.Point(502, 530)
        Me.partnerAddTimetableBtn.Name = "partnerAddTimetableBtn"
        Me.partnerAddTimetableBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerAddTimetableBtn.TabIndex = 32
        Me.alterSocioToolTip.SetToolTip(Me.partnerAddTimetableBtn, "Adicionar / Alterar Horário")
        Me.partnerAddTimetableBtn.UseVisualStyleBackColor = False
        '
        'partnerModifyClearBtn
        '
        Me.partnerModifyClearBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerModifyClearBtn.Image = Global.NCC2015.My.Resources.Resources.Remove_User_Male_24
        Me.partnerModifyClearBtn.Location = New System.Drawing.Point(552, 530)
        Me.partnerModifyClearBtn.Name = "partnerModifyClearBtn"
        Me.partnerModifyClearBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerModifyClearBtn.TabIndex = 12
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifyClearBtn, "Remover Sócio")
        Me.partnerModifyClearBtn.UseVisualStyleBackColor = False
        '
        'partnerModifySaveBtn
        '
        Me.partnerModifySaveBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerModifySaveBtn.Image = Global.NCC2015.My.Resources.Resources.Save_24
        Me.partnerModifySaveBtn.Location = New System.Drawing.Point(602, 530)
        Me.partnerModifySaveBtn.Name = "partnerModifySaveBtn"
        Me.partnerModifySaveBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerModifySaveBtn.TabIndex = 13
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifySaveBtn, "Guardar")
        Me.partnerModifySaveBtn.UseVisualStyleBackColor = False
        '
        'partnerModifyQuitBtn
        '
        Me.partnerModifyQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerModifyQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.partnerModifyQuitBtn.Location = New System.Drawing.Point(652, 530)
        Me.partnerModifyQuitBtn.Name = "partnerModifyQuitBtn"
        Me.partnerModifyQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerModifyQuitBtn.TabIndex = 14
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifyQuitBtn, "Fechar")
        Me.partnerModifyQuitBtn.UseVisualStyleBackColor = False
        '
        'partnerModifyImageBox
        '
        Me.partnerModifyImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.partnerModifyImageBox.Location = New System.Drawing.Point(6, 7)
        Me.partnerModifyImageBox.Name = "partnerModifyImageBox"
        Me.partnerModifyImageBox.Size = New System.Drawing.Size(147, 151)
        Me.partnerModifyImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnerModifyImageBox.TabIndex = 27
        Me.partnerModifyImageBox.TabStop = False
        Me.alterSocioToolTip.SetToolTip(Me.partnerModifyImageBox, "Alterar Imagem")
        '
        'altera_socio_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(714, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.alterPaymentBtn)
        Me.Controls.Add(Me.alterCardCreateBtn)
        Me.Controls.Add(Me.addMedicBtn)
        Me.Controls.Add(Me.searchSocioBtn)
        Me.Controls.Add(Me.partnerModifyReportBtn)
        Me.Controls.Add(Me.activeChk)
        Me.Controls.Add(Me.activeLbl)
        Me.Controls.Add(Me.partnerModifyCompetitionChk)
        Me.Controls.Add(Me.isCompetitionLbl)
        Me.Controls.Add(Me.addParentBtn)
        Me.Controls.Add(Me.partnerModifyAddClass)
        Me.Controls.Add(Me.partnerBackBtn)
        Me.Controls.Add(Me.partnerNextBtn)
        Me.Controls.Add(Me.partnerAddTimetableBtn)
        Me.Controls.Add(Me.partnerModifyClearBtn)
        Me.Controls.Add(Me.partnerModifySaveBtn)
        Me.Controls.Add(Me.partnerModifyQuitBtn)
        Me.Controls.Add(Me.partnerModifyImageBox)
        Me.Controls.Add(Me.partnerModifyMobileTxt)
        Me.Controls.Add(Me.partnerModifyNifTxt)
        Me.Controls.Add(Me.partnerModifyEmailTxt)
        Me.Controls.Add(Me.partnerModifyAddressTxt)
        Me.Controls.Add(Me.partnerModifyPostalTxt)
        Me.Controls.Add(Me.partnerModifyCityTxt)
        Me.Controls.Add(Me.partnerModifyPhoneTxt)
        Me.Controls.Add(Me.partnerModifyCCTxt)
        Me.Controls.Add(Me.partnerModifyGenderCbx)
        Me.Controls.Add(Me.partnerModifyBirthDateDfl)
        Me.Controls.Add(Me.partnerModifyNameTxt)
        Me.Controls.Add(Me.partnerModifyIdTxt)
        Me.Controls.Add(Me.partnerModifyCityLbl)
        Me.Controls.Add(Me.partnerModifyPhoneLbl)
        Me.Controls.Add(Me.partnerModifyNifLbl)
        Me.Controls.Add(Me.partnerModifyMobileLbl)
        Me.Controls.Add(Me.partnerModifyEmailLbl)
        Me.Controls.Add(Me.partnerModifyGenderLbl)
        Me.Controls.Add(Me.partnerModifyCCLbl)
        Me.Controls.Add(Me.partnerModifyAddressLbl)
        Me.Controls.Add(Me.partnerModifyPostalLbl)
        Me.Controls.Add(Me.partnerModifyBirthDateLbl)
        Me.Controls.Add(Me.partnerModifyNameLbl)
        Me.Controls.Add(Me.partnerModifyIdLbl)
        Me.Controls.Add(Me.partnerModifyObsTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "altera_socio_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Alterar Sócio"
        CType(Me.partnerModifyImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openImageDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents partnerModifyObsTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyIdLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyNameLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyBirthDateLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyPostalLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyAddressLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyCCLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyGenderLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyEmailLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyMobileLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyPhoneLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyCityLbl As System.Windows.Forms.Label
    Friend WithEvents partnerModifyIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyBirthDateDfl As System.Windows.Forms.DateTimePicker
    Friend WithEvents partnerModifyGenderCbx As System.Windows.Forms.ComboBox
    Friend WithEvents partnerModifyCCTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyCityTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyPostalTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyMobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyEmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerModifyImageBox As System.Windows.Forms.PictureBox
    Friend WithEvents partnerModifyQuitBtn As System.Windows.Forms.Button
    Friend WithEvents partnerModifySaveBtn As System.Windows.Forms.Button
    Friend WithEvents partnerModifyClearBtn As System.Windows.Forms.Button
    Friend WithEvents partnerAddTimetableBtn As System.Windows.Forms.Button
    Friend WithEvents partnerNextBtn As System.Windows.Forms.Button
    Friend WithEvents partnerBackBtn As System.Windows.Forms.Button
    Friend WithEvents partnerModifyAddClass As Button
    Friend WithEvents partnerModifyNifLbl As Label
    Friend WithEvents partnerModifyNifTxt As TextBox
    Friend WithEvents addParentBtn As Button
    Friend WithEvents partnerModifyCompetitionChk As CheckBox
    Friend WithEvents isCompetitionLbl As Label
    Friend WithEvents activeChk As CheckBox
    Friend WithEvents activeLbl As Label
    Friend WithEvents partnerModifyReportBtn As Button
    Friend WithEvents alterSocioToolTip As ToolTip
    Friend WithEvents searchSocioBtn As Button
    Friend WithEvents addMedicBtn As Button
    Friend WithEvents alterCardCreateBtn As Button
    Friend WithEvents alterPaymentBtn As Button
End Class
