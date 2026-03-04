<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtJudulTambah = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        txtJudulHapus = New TextBox()
        btnHapus = New Button()
        GroupBox2 = New GroupBox()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(120, 32)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(200, 27)
        txtJudulTambah.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(120, 72)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(200, 27)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(140, 115)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 30)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Location = New Point(20, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 170)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(120, 32)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(200, 27)
        txtJudulHapus.TabIndex = 2
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(140, 75)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 30)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Location = New Point(20, 210)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(350, 130)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(400, 30)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(250, 304)
        ListBox1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(680, 370)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Daftar Buku Perpustakaan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
End Class