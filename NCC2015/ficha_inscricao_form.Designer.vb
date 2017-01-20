<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ficha_inscricao_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ficha_inscricao_form))
        Me.partner_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ncc_2015DataSet = New NCC2015.ncc_2015DataSet()
        Me.loo_sysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loo_partner_timetable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoosysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ncc2015DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Loopartnertimetable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.previousBtn = New System.Windows.Forms.ToolStripButton()
        Me.posTxt = New System.Windows.Forms.ToolStripTextBox()
        Me.nextBtn = New System.Windows.Forms.ToolStripButton()
        Me.searchBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PartnerinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loo_partnerTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_partnerTableAdapter()
        Me.Partner_infoTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.partner_infoTableAdapter()
        Me.Loo_sysTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_sysTableAdapter()
        Me.loo_partner_timetable1TableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_partner_timetable1TableAdapter()
        CType(Me.partner_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loo_sysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loo_partner_timetable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoosysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncc2015DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loopartnertimetable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PartnerinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'partner_infoBindingSource
        '
        Me.partner_infoBindingSource.DataMember = "partner_info"
        Me.partner_infoBindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'Ncc_2015DataSet
        '
        Me.Ncc_2015DataSet.DataSetName = "ncc_2015DataSet"
        Me.Ncc_2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'loo_sysBindingSource
        '
        Me.loo_sysBindingSource.DataMember = "loo_sys"
        Me.loo_sysBindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'loo_partner_timetable1BindingSource
        '
        Me.loo_partner_timetable1BindingSource.DataMember = "loo_partner_timetable1"
        Me.loo_partner_timetable1BindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'LoosysBindingSource
        '
        Me.LoosysBindingSource.DataMember = "loo_sys"
        Me.LoosysBindingSource.DataSource = Me.Ncc2015DataSetBindingSource
        '
        'Ncc2015DataSetBindingSource
        '
        Me.Ncc2015DataSetBindingSource.DataSource = Me.Ncc_2015DataSet
        Me.Ncc2015DataSetBindingSource.Position = 0
        '
        'Loopartnertimetable1BindingSource
        '
        Me.Loopartnertimetable1BindingSource.DataMember = "loo_partner_timetable1"
        Me.Loopartnertimetable1BindingSource.DataSource = Me.Ncc2015DataSetBindingSource
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "partner_info"
        ReportDataSource1.Value = Me.partner_infoBindingSource
        ReportDataSource2.Name = "sys"
        ReportDataSource2.Value = Me.loo_sysBindingSource
        ReportDataSource3.Name = "partner_timetable"
        ReportDataSource3.Value = Me.loo_partner_timetable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NCC2015.ficha_inscricao.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 631)
        Me.ReportViewer1.TabIndex = 0
        '
        'previousBtn
        '
        Me.previousBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.previousBtn.Image = Global.NCC2015.My.Resources.Resources.Previous_24
        Me.previousBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(28, 28)
        Me.previousBtn.Text = "ToolStripButton2"
        '
        'posTxt
        '
        Me.posTxt.Name = "posTxt"
        Me.posTxt.Size = New System.Drawing.Size(80, 31)
        Me.posTxt.Text = "1"
        '
        'nextBtn
        '
        Me.nextBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nextBtn.Image = Global.NCC2015.My.Resources.Resources.Next_24
        Me.nextBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(28, 28)
        Me.nextBtn.Text = "ToolStripButton1"
        '
        'searchBtn
        '
        Me.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.searchBtn.Image = Global.NCC2015.My.Resources.Resources.Go_24
        Me.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(28, 28)
        Me.searchBtn.Text = "ToolStripButton1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.previousBtn, Me.posTxt, Me.nextBtn, Me.searchBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 600)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(684, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PartnerinfoBindingSource
        '
        Me.PartnerinfoBindingSource.DataMember = "partner_info"
        Me.PartnerinfoBindingSource.DataSource = Me.Ncc2015DataSetBindingSource
        '
        'loo_partnerTableAdapter
        '
        Me.loo_partnerTableAdapter.ClearBeforeFill = True
        '
        'Partner_infoTableAdapter
        '
        Me.Partner_infoTableAdapter.ClearBeforeFill = True
        '
        'Loo_sysTableAdapter
        '
        Me.Loo_sysTableAdapter.ClearBeforeFill = True
        '
        'loo_partner_timetable1TableAdapter
        '
        Me.loo_partner_timetable1TableAdapter.ClearBeforeFill = True
        '
        'ficha_inscricao_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 631)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ficha_inscricao_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Ficha de Inscrição"
        CType(Me.partner_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loo_sysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loo_partner_timetable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoosysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncc2015DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loopartnertimetable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PartnerinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents previousBtn As ToolStripButton
    Friend WithEvents posTxt As ToolStripTextBox
    Friend WithEvents nextBtn As ToolStripButton
    Friend WithEvents searchBtn As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Ncc2015DataSetBindingSource As BindingSource
    Friend WithEvents Ncc_2015DataSet As ncc_2015DataSet
    Friend WithEvents loo_partnerTableAdapter As ncc_2015DataSetTableAdapters.loo_partnerTableAdapter
    Friend WithEvents PartnerinfoBindingSource As BindingSource
    Friend WithEvents Partner_infoTableAdapter As ncc_2015DataSetTableAdapters.partner_infoTableAdapter
    Friend WithEvents partner_infoBindingSource As BindingSource
    Friend WithEvents LoosysBindingSource As BindingSource
    Friend WithEvents Loo_sysTableAdapter As ncc_2015DataSetTableAdapters.loo_sysTableAdapter
    Friend WithEvents Loopartnertimetable1BindingSource As BindingSource
    Friend WithEvents loo_sysBindingSource As BindingSource
    Friend WithEvents loo_partner_timetable1BindingSource As BindingSource
    Friend WithEvents loo_partner_timetable1TableAdapter As ncc_2015DataSetTableAdapters.loo_partner_timetable1TableAdapter
End Class
