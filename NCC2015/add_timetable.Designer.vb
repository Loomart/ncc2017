<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_timetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_timetable))
        Me.timetableDayCmb = New System.Windows.Forms.ComboBox()
        Me.timetableInfoLbl = New System.Windows.Forms.Label()
        Me.timetableFromCmb = New System.Windows.Forms.ComboBox()
        Me.timetableToCmb = New System.Windows.Forms.ComboBox()
        Me.timetableDayLbl = New System.Windows.Forms.Label()
        Me.timetableFromLbl = New System.Windows.Forms.Label()
        Me.timetableToLbl = New System.Windows.Forms.Label()
        Me.timetableViewBtn = New System.Windows.Forms.Button()
        Me.timetableSaveBtn = New System.Windows.Forms.Button()
        Me.timetableQuitBtn = New System.Windows.Forms.Button()
        Me.addTimetableToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'timetableDayCmb
        '
        Me.timetableDayCmb.DropDownHeight = 80
        Me.timetableDayCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timetableDayCmb.DropDownWidth = 50
        Me.timetableDayCmb.FormattingEnabled = True
        Me.timetableDayCmb.IntegralHeight = False
        Me.timetableDayCmb.Items.AddRange(New Object() {"Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"})
        Me.timetableDayCmb.Location = New System.Drawing.Point(183, 44)
        Me.timetableDayCmb.Name = "timetableDayCmb"
        Me.timetableDayCmb.Size = New System.Drawing.Size(121, 21)
        Me.timetableDayCmb.TabIndex = 0
        Me.addTimetableToolTip.SetToolTip(Me.timetableDayCmb, "Seleccione um dia da Semana")
        '
        'timetableInfoLbl
        '
        Me.timetableInfoLbl.AutoSize = True
        Me.timetableInfoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetableInfoLbl.Location = New System.Drawing.Point(12, 9)
        Me.timetableInfoLbl.Name = "timetableInfoLbl"
        Me.timetableInfoLbl.Size = New System.Drawing.Size(468, 29)
        Me.timetableInfoLbl.TabIndex = 1
        Me.timetableInfoLbl.Text = "Seleccione um dia e um intervalo de horas"
        '
        'timetableFromCmb
        '
        Me.timetableFromCmb.DropDownHeight = 80
        Me.timetableFromCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timetableFromCmb.DropDownWidth = 50
        Me.timetableFromCmb.FormattingEnabled = True
        Me.timetableFromCmb.IntegralHeight = False
        Me.timetableFromCmb.Items.AddRange(New Object() {"7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.timetableFromCmb.Location = New System.Drawing.Point(183, 71)
        Me.timetableFromCmb.Name = "timetableFromCmb"
        Me.timetableFromCmb.Size = New System.Drawing.Size(121, 21)
        Me.timetableFromCmb.TabIndex = 2
        Me.addTimetableToolTip.SetToolTip(Me.timetableFromCmb, "Seleccione a hora de início")
        '
        'timetableToCmb
        '
        Me.timetableToCmb.DropDownHeight = 80
        Me.timetableToCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timetableToCmb.DropDownWidth = 50
        Me.timetableToCmb.FormattingEnabled = True
        Me.timetableToCmb.IntegralHeight = False
        Me.timetableToCmb.Items.AddRange(New Object() {"7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.timetableToCmb.Location = New System.Drawing.Point(183, 98)
        Me.timetableToCmb.Name = "timetableToCmb"
        Me.timetableToCmb.Size = New System.Drawing.Size(121, 21)
        Me.timetableToCmb.TabIndex = 3
        Me.addTimetableToolTip.SetToolTip(Me.timetableToCmb, "Seleccione a hora de fim")
        '
        'timetableDayLbl
        '
        Me.timetableDayLbl.AutoSize = True
        Me.timetableDayLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetableDayLbl.Location = New System.Drawing.Point(140, 42)
        Me.timetableDayLbl.Name = "timetableDayLbl"
        Me.timetableDayLbl.Size = New System.Drawing.Size(37, 20)
        Me.timetableDayLbl.TabIndex = 4
        Me.timetableDayLbl.Text = "Dia:"
        '
        'timetableFromLbl
        '
        Me.timetableFromLbl.AutoSize = True
        Me.timetableFromLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetableFromLbl.Location = New System.Drawing.Point(117, 69)
        Me.timetableFromLbl.Name = "timetableFromLbl"
        Me.timetableFromLbl.Size = New System.Drawing.Size(60, 20)
        Me.timetableFromLbl.TabIndex = 5
        Me.timetableFromLbl.Text = "Desde:"
        '
        'timetableToLbl
        '
        Me.timetableToLbl.AutoSize = True
        Me.timetableToLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetableToLbl.Location = New System.Drawing.Point(137, 96)
        Me.timetableToLbl.Name = "timetableToLbl"
        Me.timetableToLbl.Size = New System.Drawing.Size(38, 20)
        Me.timetableToLbl.TabIndex = 6
        Me.timetableToLbl.Text = "Até:"
        '
        'timetableViewBtn
        '
        Me.timetableViewBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.timetableViewBtn.Image = Global.NCC2015.My.Resources.Resources.View_Details_24
        Me.timetableViewBtn.Location = New System.Drawing.Point(160, 129)
        Me.timetableViewBtn.Name = "timetableViewBtn"
        Me.timetableViewBtn.Size = New System.Drawing.Size(50, 50)
        Me.timetableViewBtn.TabIndex = 18
        Me.addTimetableToolTip.SetToolTip(Me.timetableViewBtn, "Ver Horários")
        Me.timetableViewBtn.UseVisualStyleBackColor = False
        '
        'timetableSaveBtn
        '
        Me.timetableSaveBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.timetableSaveBtn.Image = Global.NCC2015.My.Resources.Resources.Save_24
        Me.timetableSaveBtn.Location = New System.Drawing.Point(216, 129)
        Me.timetableSaveBtn.Name = "timetableSaveBtn"
        Me.timetableSaveBtn.Size = New System.Drawing.Size(50, 50)
        Me.timetableSaveBtn.TabIndex = 16
        Me.addTimetableToolTip.SetToolTip(Me.timetableSaveBtn, "Guardar")
        Me.timetableSaveBtn.UseVisualStyleBackColor = False
        '
        'timetableQuitBtn
        '
        Me.timetableQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.timetableQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.timetableQuitBtn.Location = New System.Drawing.Point(272, 129)
        Me.timetableQuitBtn.Name = "timetableQuitBtn"
        Me.timetableQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.timetableQuitBtn.TabIndex = 17
        Me.addTimetableToolTip.SetToolTip(Me.timetableQuitBtn, "Fechar")
        Me.timetableQuitBtn.UseVisualStyleBackColor = False
        '
        'addTimetableToolTip
        '
        Me.addTimetableToolTip.AutomaticDelay = 0
        Me.addTimetableToolTip.AutoPopDelay = 5500
        Me.addTimetableToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.addTimetableToolTip.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.addTimetableToolTip.InitialDelay = 0
        Me.addTimetableToolTip.ReshowDelay = 0
        '
        'add_timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(492, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.timetableViewBtn)
        Me.Controls.Add(Me.timetableSaveBtn)
        Me.Controls.Add(Me.timetableQuitBtn)
        Me.Controls.Add(Me.timetableToLbl)
        Me.Controls.Add(Me.timetableFromLbl)
        Me.Controls.Add(Me.timetableDayLbl)
        Me.Controls.Add(Me.timetableToCmb)
        Me.Controls.Add(Me.timetableFromCmb)
        Me.Controls.Add(Me.timetableInfoLbl)
        Me.Controls.Add(Me.timetableDayCmb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "add_timetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Adicionar Horario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timetableDayCmb As System.Windows.Forms.ComboBox
    Friend WithEvents timetableInfoLbl As System.Windows.Forms.Label
    Friend WithEvents timetableFromCmb As System.Windows.Forms.ComboBox
    Friend WithEvents timetableToCmb As System.Windows.Forms.ComboBox
    Friend WithEvents timetableDayLbl As System.Windows.Forms.Label
    Friend WithEvents timetableFromLbl As System.Windows.Forms.Label
    Friend WithEvents timetableToLbl As System.Windows.Forms.Label
    Friend WithEvents timetableSaveBtn As System.Windows.Forms.Button
    Friend WithEvents timetableQuitBtn As System.Windows.Forms.Button
    Friend WithEvents timetableViewBtn As System.Windows.Forms.Button
    Friend WithEvents addTimetableToolTip As ToolTip
End Class
