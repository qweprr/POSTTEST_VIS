<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
    Inherits Form

    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents pbFoto As PictureBox

    Private Sub InitializeComponent()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        pbFoto = New PictureBox()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(20, 20)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(100, 23)
        lblNama.TabIndex = 0
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(20, 50)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 1
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.Location = New Point(20, 80)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(100, 23)
        lblKomunitas.TabIndex = 2
        ' 
        ' lblKontak
        ' 
        lblKontak.Location = New Point(20, 110)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(100, 23)
        lblKontak.TabIndex = 3
        ' 
        ' lblHobi
        ' 
        lblHobi.Location = New Point(20, 140)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(100, 23)
        lblHobi.TabIndex = 4
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(250, 20)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(120, 120)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 5
        pbFoto.TabStop = False
        ' 
        ' FormKartu
        ' 
        ClientSize = New Size(382, 203)
        Controls.Add(lblNama)
        Controls.Add(lblID)
        Controls.Add(lblKomunitas)
        Controls.Add(lblKontak)
        Controls.Add(lblHobi)
        Controls.Add(pbFoto)
        Name = "FormKartu"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class