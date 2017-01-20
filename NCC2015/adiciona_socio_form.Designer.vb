<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adiciona_socio_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adiciona_socio_form))
        Me.openImageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.partnerObsTxt = New System.Windows.Forms.TextBox()
        Me.partnerIdLbl = New System.Windows.Forms.Label()
        Me.partnerNameLbl = New System.Windows.Forms.Label()
        Me.partnerBirthDateLbl = New System.Windows.Forms.Label()
        Me.partnerPostalLbl = New System.Windows.Forms.Label()
        Me.partnerAddressLbl = New System.Windows.Forms.Label()
        Me.partnerCCLbl = New System.Windows.Forms.Label()
        Me.partnerGenderLbl = New System.Windows.Forms.Label()
        Me.partnerEmailLbl = New System.Windows.Forms.Label()
        Me.partnerMobileLbl = New System.Windows.Forms.Label()
        Me.partnerPhoneLbl = New System.Windows.Forms.Label()
        Me.partnerCityLbl = New System.Windows.Forms.Label()
        Me.partnerIdTxt = New System.Windows.Forms.TextBox()
        Me.partnerNameTxt = New System.Windows.Forms.TextBox()
        Me.partnerBirthDateDfl = New System.Windows.Forms.DateTimePicker()
        Me.partnerGenderCbx = New System.Windows.Forms.ComboBox()
        Me.partnerCCTxt = New System.Windows.Forms.TextBox()
        Me.partnerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.partnerCityTxt = New System.Windows.Forms.TextBox()
        Me.partnerPostalTxt = New System.Windows.Forms.TextBox()
        Me.partnerAddressTxt = New System.Windows.Forms.TextBox()
        Me.partnerMobileTxt = New System.Windows.Forms.TextBox()
        Me.partnerEmailTxt = New System.Windows.Forms.TextBox()
        Me.partnerQuitBtn = New System.Windows.Forms.Button()
        Me.partnerSaveBtn = New System.Windows.Forms.Button()
        Me.partnerGetIdBtn = New System.Windows.Forms.Button()
        Me.partnerClearBtn = New System.Windows.Forms.Button()
        Me.partnerNifLbl = New System.Windows.Forms.Label()
        Me.partnerNifTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.isCompetitionChk = New System.Windows.Forms.CheckBox()
        Me.addSocioActiveChk = New System.Windows.Forms.CheckBox()
        Me.addSocioActiveLbl = New System.Windows.Forms.Label()
        Me.partnerImageBox = New System.Windows.Forms.PictureBox()
        Me.addSocioToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.partnerImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'partnerObsTxt
        '
        Me.partnerObsTxt.Location = New System.Drawing.Point(169, 7)
        Me.partnerObsTxt.Multiline = True
        Me.partnerObsTxt.Name = "partnerObsTxt"
        Me.partnerObsTxt.Size = New System.Drawing.Size(429, 151)
        Me.partnerObsTxt.TabIndex = 15
        Me.partnerObsTxt.TabStop = False
        '
        'partnerIdLbl
        '
        Me.partnerIdLbl.AutoSize = True
        Me.partnerIdLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerIdLbl.Location = New System.Drawing.Point(85, 174)
        Me.partnerIdLbl.Name = "partnerIdLbl"
        Me.partnerIdLbl.Size = New System.Drawing.Size(69, 16)
        Me.partnerIdLbl.TabIndex = 2
        Me.partnerIdLbl.Text = "N. Sócio:"
        '
        'partnerNameLbl
        '
        Me.partnerNameLbl.AutoSize = True
        Me.partnerNameLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerNameLbl.Location = New System.Drawing.Point(102, 204)
        Me.partnerNameLbl.Name = "partnerNameLbl"
        Me.partnerNameLbl.Size = New System.Drawing.Size(52, 16)
        Me.partnerNameLbl.TabIndex = 3
        Me.partnerNameLbl.Text = "Nome:"
        '
        'partnerBirthDateLbl
        '
        Me.partnerBirthDateLbl.AutoSize = True
        Me.partnerBirthDateLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerBirthDateLbl.Location = New System.Drawing.Point(69, 235)
        Me.partnerBirthDateLbl.Name = "partnerBirthDateLbl"
        Me.partnerBirthDateLbl.Size = New System.Drawing.Size(85, 16)
        Me.partnerBirthDateLbl.TabIndex = 4
        Me.partnerBirthDateLbl.Text = "Data Nasc.:"
        '
        'partnerPostalLbl
        '
        Me.partnerPostalLbl.AutoSize = True
        Me.partnerPostalLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerPostalLbl.Location = New System.Drawing.Point(85, 354)
        Me.partnerPostalLbl.Name = "partnerPostalLbl"
        Me.partnerPostalLbl.Size = New System.Drawing.Size(69, 16)
        Me.partnerPostalLbl.TabIndex = 5
        Me.partnerPostalLbl.Text = "C.Postal:"
        '
        'partnerAddressLbl
        '
        Me.partnerAddressLbl.AutoSize = True
        Me.partnerAddressLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerAddressLbl.Location = New System.Drawing.Point(89, 324)
        Me.partnerAddressLbl.Name = "partnerAddressLbl"
        Me.partnerAddressLbl.Size = New System.Drawing.Size(65, 16)
        Me.partnerAddressLbl.TabIndex = 6
        Me.partnerAddressLbl.Text = "Morada:"
        '
        'partnerCCLbl
        '
        Me.partnerCCLbl.AutoSize = True
        Me.partnerCCLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerCCLbl.Location = New System.Drawing.Point(96, 294)
        Me.partnerCCLbl.Name = "partnerCCLbl"
        Me.partnerCCLbl.Size = New System.Drawing.Size(58, 16)
        Me.partnerCCLbl.TabIndex = 7
        Me.partnerCCLbl.Text = "BI / CC:"
        '
        'partnerGenderLbl
        '
        Me.partnerGenderLbl.AutoSize = True
        Me.partnerGenderLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerGenderLbl.Location = New System.Drawing.Point(107, 263)
        Me.partnerGenderLbl.Name = "partnerGenderLbl"
        Me.partnerGenderLbl.Size = New System.Drawing.Size(47, 16)
        Me.partnerGenderLbl.TabIndex = 8
        Me.partnerGenderLbl.Text = "Sexo:"
        '
        'partnerEmailLbl
        '
        Me.partnerEmailLbl.AutoSize = True
        Me.partnerEmailLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerEmailLbl.Location = New System.Drawing.Point(105, 474)
        Me.partnerEmailLbl.Name = "partnerEmailLbl"
        Me.partnerEmailLbl.Size = New System.Drawing.Size(49, 16)
        Me.partnerEmailLbl.TabIndex = 9
        Me.partnerEmailLbl.Text = "Email:"
        '
        'partnerMobileLbl
        '
        Me.partnerMobileLbl.AutoSize = True
        Me.partnerMobileLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerMobileLbl.Location = New System.Drawing.Point(101, 444)
        Me.partnerMobileLbl.Name = "partnerMobileLbl"
        Me.partnerMobileLbl.Size = New System.Drawing.Size(53, 16)
        Me.partnerMobileLbl.TabIndex = 10
        Me.partnerMobileLbl.Text = "Telem:"
        '
        'partnerPhoneLbl
        '
        Me.partnerPhoneLbl.AutoSize = True
        Me.partnerPhoneLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerPhoneLbl.Location = New System.Drawing.Point(107, 414)
        Me.partnerPhoneLbl.Name = "partnerPhoneLbl"
        Me.partnerPhoneLbl.Size = New System.Drawing.Size(46, 16)
        Me.partnerPhoneLbl.TabIndex = 11
        Me.partnerPhoneLbl.Text = "Telef:"
        '
        'partnerCityLbl
        '
        Me.partnerCityLbl.AutoSize = True
        Me.partnerCityLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerCityLbl.Location = New System.Drawing.Point(93, 384)
        Me.partnerCityLbl.Name = "partnerCityLbl"
        Me.partnerCityLbl.Size = New System.Drawing.Size(61, 16)
        Me.partnerCityLbl.TabIndex = 12
        Me.partnerCityLbl.Text = "Cidade:"
        '
        'partnerIdTxt
        '
        Me.partnerIdTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerIdTxt.Location = New System.Drawing.Point(169, 170)
        Me.partnerIdTxt.MaxLength = 11
        Me.partnerIdTxt.Name = "partnerIdTxt"
        Me.partnerIdTxt.Size = New System.Drawing.Size(121, 24)
        Me.partnerIdTxt.TabIndex = 1
        '
        'partnerNameTxt
        '
        Me.partnerNameTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerNameTxt.Location = New System.Drawing.Point(169, 200)
        Me.partnerNameTxt.MaxLength = 255
        Me.partnerNameTxt.Name = "partnerNameTxt"
        Me.partnerNameTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerNameTxt.TabIndex = 2
        '
        'partnerBirthDateDfl
        '
        Me.partnerBirthDateDfl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerBirthDateDfl.Location = New System.Drawing.Point(169, 231)
        Me.partnerBirthDateDfl.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.partnerBirthDateDfl.Name = "partnerBirthDateDfl"
        Me.partnerBirthDateDfl.Size = New System.Drawing.Size(429, 23)
        Me.partnerBirthDateDfl.TabIndex = 3
        Me.partnerBirthDateDfl.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'partnerGenderCbx
        '
        Me.partnerGenderCbx.BackColor = System.Drawing.SystemColors.Window
        Me.partnerGenderCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partnerGenderCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.partnerGenderCbx.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerGenderCbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.partnerGenderCbx.FormattingEnabled = True
        Me.partnerGenderCbx.Items.AddRange(New Object() {"Outro", "Feminino", "Masculino"})
        Me.partnerGenderCbx.Location = New System.Drawing.Point(169, 260)
        Me.partnerGenderCbx.Name = "partnerGenderCbx"
        Me.partnerGenderCbx.Size = New System.Drawing.Size(121, 24)
        Me.partnerGenderCbx.TabIndex = 4
        '
        'partnerCCTxt
        '
        Me.partnerCCTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerCCTxt.Location = New System.Drawing.Point(169, 290)
        Me.partnerCCTxt.MaxLength = 35
        Me.partnerCCTxt.Name = "partnerCCTxt"
        Me.partnerCCTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerCCTxt.TabIndex = 5
        '
        'partnerPhoneTxt
        '
        Me.partnerPhoneTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerPhoneTxt.Location = New System.Drawing.Point(169, 410)
        Me.partnerPhoneTxt.MaxLength = 15
        Me.partnerPhoneTxt.Name = "partnerPhoneTxt"
        Me.partnerPhoneTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerPhoneTxt.TabIndex = 9
        '
        'partnerCityTxt
        '
        Me.partnerCityTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerCityTxt.Location = New System.Drawing.Point(169, 380)
        Me.partnerCityTxt.MaxLength = 255
        Me.partnerCityTxt.Name = "partnerCityTxt"
        Me.partnerCityTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerCityTxt.TabIndex = 8
        '
        'partnerPostalTxt
        '
        Me.partnerPostalTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerPostalTxt.Location = New System.Drawing.Point(169, 350)
        Me.partnerPostalTxt.MaxLength = 255
        Me.partnerPostalTxt.Name = "partnerPostalTxt"
        Me.partnerPostalTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerPostalTxt.TabIndex = 7
        '
        'partnerAddressTxt
        '
        Me.partnerAddressTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerAddressTxt.Location = New System.Drawing.Point(169, 320)
        Me.partnerAddressTxt.MaxLength = 255
        Me.partnerAddressTxt.Name = "partnerAddressTxt"
        Me.partnerAddressTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerAddressTxt.TabIndex = 6
        '
        'partnerMobileTxt
        '
        Me.partnerMobileTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerMobileTxt.Location = New System.Drawing.Point(169, 440)
        Me.partnerMobileTxt.MaxLength = 15
        Me.partnerMobileTxt.Name = "partnerMobileTxt"
        Me.partnerMobileTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerMobileTxt.TabIndex = 10
        '
        'partnerEmailTxt
        '
        Me.partnerEmailTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerEmailTxt.Location = New System.Drawing.Point(169, 470)
        Me.partnerEmailTxt.MaxLength = 255
        Me.partnerEmailTxt.Name = "partnerEmailTxt"
        Me.partnerEmailTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerEmailTxt.TabIndex = 11
        '
        'partnerQuitBtn
        '
        Me.partnerQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.partnerQuitBtn.Location = New System.Drawing.Point(548, 527)
        Me.partnerQuitBtn.Name = "partnerQuitBtn"
        Me.partnerQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerQuitBtn.TabIndex = 15
        Me.addSocioToolTip.SetToolTip(Me.partnerQuitBtn, "Fechar")
        Me.partnerQuitBtn.UseVisualStyleBackColor = False
        '
        'partnerSaveBtn
        '
        Me.partnerSaveBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerSaveBtn.Image = Global.NCC2015.My.Resources.Resources.Save_24
        Me.partnerSaveBtn.Location = New System.Drawing.Point(492, 527)
        Me.partnerSaveBtn.Name = "partnerSaveBtn"
        Me.partnerSaveBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerSaveBtn.TabIndex = 14
        Me.addSocioToolTip.SetToolTip(Me.partnerSaveBtn, "Guardar")
        Me.partnerSaveBtn.UseVisualStyleBackColor = False
        '
        'partnerGetIdBtn
        '
        Me.partnerGetIdBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerGetIdBtn.Location = New System.Drawing.Point(296, 170)
        Me.partnerGetIdBtn.Name = "partnerGetIdBtn"
        Me.partnerGetIdBtn.Size = New System.Drawing.Size(22, 24)
        Me.partnerGetIdBtn.TabIndex = 31
        Me.partnerGetIdBtn.TabStop = False
        Me.partnerGetIdBtn.Text = "?"
        Me.addSocioToolTip.SetToolTip(Me.partnerGetIdBtn, "Atribuir Número")
        Me.partnerGetIdBtn.UseVisualStyleBackColor = False
        '
        'partnerClearBtn
        '
        Me.partnerClearBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.partnerClearBtn.Image = Global.NCC2015.My.Resources.Resources.Refresh_24
        Me.partnerClearBtn.Location = New System.Drawing.Point(436, 527)
        Me.partnerClearBtn.Name = "partnerClearBtn"
        Me.partnerClearBtn.Size = New System.Drawing.Size(50, 50)
        Me.partnerClearBtn.TabIndex = 13
        Me.addSocioToolTip.SetToolTip(Me.partnerClearBtn, "Apagar Tudo")
        Me.partnerClearBtn.UseVisualStyleBackColor = False
        '
        'partnerNifLbl
        '
        Me.partnerNifLbl.AutoSize = True
        Me.partnerNifLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerNifLbl.Location = New System.Drawing.Point(122, 504)
        Me.partnerNifLbl.Name = "partnerNifLbl"
        Me.partnerNifLbl.Size = New System.Drawing.Size(31, 16)
        Me.partnerNifLbl.TabIndex = 9
        Me.partnerNifLbl.Text = "Nif:"
        '
        'partnerNifTxt
        '
        Me.partnerNifTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerNifTxt.Location = New System.Drawing.Point(169, 500)
        Me.partnerNifTxt.MaxLength = 255
        Me.partnerNifTxt.Name = "partnerNifTxt"
        Me.partnerNifTxt.Size = New System.Drawing.Size(429, 24)
        Me.partnerNifTxt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Competição:"
        '
        'isCompetitionChk
        '
        Me.isCompetitionChk.AutoSize = True
        Me.isCompetitionChk.Location = New System.Drawing.Point(424, 176)
        Me.isCompetitionChk.Name = "isCompetitionChk"
        Me.isCompetitionChk.Size = New System.Drawing.Size(15, 14)
        Me.isCompetitionChk.TabIndex = 33
        Me.isCompetitionChk.TabStop = False
        Me.isCompetitionChk.UseVisualStyleBackColor = True
        '
        'addSocioActiveChk
        '
        Me.addSocioActiveChk.AutoSize = True
        Me.addSocioActiveChk.Location = New System.Drawing.Point(547, 176)
        Me.addSocioActiveChk.Name = "addSocioActiveChk"
        Me.addSocioActiveChk.Size = New System.Drawing.Size(15, 14)
        Me.addSocioActiveChk.TabIndex = 40
        Me.addSocioActiveChk.TabStop = False
        Me.addSocioActiveChk.UseVisualStyleBackColor = True
        '
        'addSocioActiveLbl
        '
        Me.addSocioActiveLbl.AutoSize = True
        Me.addSocioActiveLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSocioActiveLbl.Location = New System.Drawing.Point(494, 174)
        Me.addSocioActiveLbl.Name = "addSocioActiveLbl"
        Me.addSocioActiveLbl.Size = New System.Drawing.Size(48, 16)
        Me.addSocioActiveLbl.TabIndex = 39
        Me.addSocioActiveLbl.Text = "Ativo:"
        '
        'partnerImageBox
        '
        Me.partnerImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.partnerImageBox.Location = New System.Drawing.Point(6, 7)
        Me.partnerImageBox.Name = "partnerImageBox"
        Me.partnerImageBox.Size = New System.Drawing.Size(147, 151)
        Me.partnerImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnerImageBox.TabIndex = 27
        Me.partnerImageBox.TabStop = False
        Me.addSocioToolTip.SetToolTip(Me.partnerImageBox, "Adicionar Imagem")
        '
        'addSocioToolTip
        '
        Me.addSocioToolTip.AutomaticDelay = 0
        Me.addSocioToolTip.AutoPopDelay = 5500
        Me.addSocioToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.addSocioToolTip.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.addSocioToolTip.InitialDelay = 0
        Me.addSocioToolTip.ReshowDelay = 0
        '
        'adiciona_socio_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(606, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.addSocioActiveChk)
        Me.Controls.Add(Me.addSocioActiveLbl)
        Me.Controls.Add(Me.isCompetitionChk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.partnerGetIdBtn)
        Me.Controls.Add(Me.partnerClearBtn)
        Me.Controls.Add(Me.partnerSaveBtn)
        Me.Controls.Add(Me.partnerQuitBtn)
        Me.Controls.Add(Me.partnerImageBox)
        Me.Controls.Add(Me.partnerMobileTxt)
        Me.Controls.Add(Me.partnerNifTxt)
        Me.Controls.Add(Me.partnerEmailTxt)
        Me.Controls.Add(Me.partnerAddressTxt)
        Me.Controls.Add(Me.partnerPostalTxt)
        Me.Controls.Add(Me.partnerCityTxt)
        Me.Controls.Add(Me.partnerPhoneTxt)
        Me.Controls.Add(Me.partnerCCTxt)
        Me.Controls.Add(Me.partnerGenderCbx)
        Me.Controls.Add(Me.partnerBirthDateDfl)
        Me.Controls.Add(Me.partnerNameTxt)
        Me.Controls.Add(Me.partnerIdTxt)
        Me.Controls.Add(Me.partnerCityLbl)
        Me.Controls.Add(Me.partnerPhoneLbl)
        Me.Controls.Add(Me.partnerNifLbl)
        Me.Controls.Add(Me.partnerMobileLbl)
        Me.Controls.Add(Me.partnerEmailLbl)
        Me.Controls.Add(Me.partnerGenderLbl)
        Me.Controls.Add(Me.partnerCCLbl)
        Me.Controls.Add(Me.partnerAddressLbl)
        Me.Controls.Add(Me.partnerPostalLbl)
        Me.Controls.Add(Me.partnerBirthDateLbl)
        Me.Controls.Add(Me.partnerNameLbl)
        Me.Controls.Add(Me.partnerIdLbl)
        Me.Controls.Add(Me.partnerObsTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adiciona_socio_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Adicionar Socio"
        CType(Me.partnerImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openImageDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents partnerObsTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerIdLbl As System.Windows.Forms.Label
    Friend WithEvents partnerNameLbl As System.Windows.Forms.Label
    Friend WithEvents partnerBirthDateLbl As System.Windows.Forms.Label
    Friend WithEvents partnerPostalLbl As System.Windows.Forms.Label
    Friend WithEvents partnerAddressLbl As System.Windows.Forms.Label
    Friend WithEvents partnerCCLbl As System.Windows.Forms.Label
    Friend WithEvents partnerGenderLbl As System.Windows.Forms.Label
    Friend WithEvents partnerEmailLbl As System.Windows.Forms.Label
    Friend WithEvents partnerMobileLbl As System.Windows.Forms.Label
    Friend WithEvents partnerPhoneLbl As System.Windows.Forms.Label
    Friend WithEvents partnerCityLbl As System.Windows.Forms.Label
    Friend WithEvents partnerIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerBirthDateDfl As System.Windows.Forms.DateTimePicker
    Friend WithEvents partnerGenderCbx As System.Windows.Forms.ComboBox
    Friend WithEvents partnerCCTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerCityTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerPostalTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerMobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerEmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents partnerImageBox As System.Windows.Forms.PictureBox
    Friend WithEvents partnerQuitBtn As System.Windows.Forms.Button
    Friend WithEvents partnerSaveBtn As System.Windows.Forms.Button
    Friend WithEvents partnerClearBtn As System.Windows.Forms.Button
    Friend WithEvents partnerGetIdBtn As System.Windows.Forms.Button
    Friend WithEvents partnerNifLbl As Label
    Friend WithEvents partnerNifTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents isCompetitionChk As CheckBox
    Friend WithEvents addSocioActiveChk As CheckBox
    Friend WithEvents addSocioActiveLbl As Label
    Friend WithEvents addSocioToolTip As ToolTip
End Class
