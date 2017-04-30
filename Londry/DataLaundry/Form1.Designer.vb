<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputDataPetugas
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.KategoriPilihan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paket = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Parfum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.noHP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jenKel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Button6 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Input Data Petugas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(721, 289)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 38)
        Me.Save.TabIndex = 16
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Jalan C. Simanjuntak No.128 Yogyakarta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 39)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "LAUNDRIZE"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KategoriPilihan, Me.Paket, Me.username, Me.Parfum, Me.noHP, Me.alamat, Me.jenKel})
        Me.DataGridView1.Location = New System.Drawing.Point(53, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'KategoriPilihan
        '
        Me.KategoriPilihan.HeaderText = "ID"
        Me.KategoriPilihan.Name = "KategoriPilihan"
        '
        'Paket
        '
        Me.Paket.HeaderText = "Nama"
        Me.Paket.Name = "Paket"
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        '
        'Parfum
        '
        Me.Parfum.HeaderText = "Password"
        Me.Parfum.Name = "Parfum"
        '
        'noHP
        '
        Me.noHP.HeaderText = "Nomor HP"
        Me.noHP.Name = "noHP"
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        '
        'jenKel
        '
        Me.jenKel.HeaderText = "Jenis Kelamin"
        Me.jenKel.Name = "jenKel"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Input Laundry"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(619, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Kasir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(700, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Report"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(440, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(795, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 13)
        Me.LinkLabel1.TabIndex = 34
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Hi Admin!"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(781, 47)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Logout"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DataLaundry.My.Resources.Resources.Logo_208_78
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(871, 385)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents KategoriPilihan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Parfum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noHP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenKel As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
