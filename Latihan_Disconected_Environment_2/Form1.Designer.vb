<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        kodeBrg = New TextBox()
        label = New Label()
        Label2 = New Label()
        Label1 = New Label()
        nmBrg = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        hrgJual = New TextBox()
        Label5 = New Label()
        hrgBeli = New TextBox()
        cbJnsSatuan = New ComboBox()
        cbJnsBrg = New ComboBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(74, 273)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(642, 165)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(219, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(68, 38)
        Button1.TabIndex = 1
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(490, 219)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 39)
        Button2.TabIndex = 2
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(347, 220)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 38)
        Button3.TabIndex = 3
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' kodeBrg
        ' 
        kodeBrg.Location = New Point(199, 62)
        kodeBrg.Name = "kodeBrg"
        kodeBrg.Size = New Size(107, 23)
        kodeBrg.TabIndex = 4
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(104, 65)
        label.Name = "label"
        label.Size = New Size(81, 15)
        label.TabIndex = 7
        label.Text = "Kode Barang:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(106, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 8
        Label2.Text = "Jenis Barang:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(104, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 10
        Label1.Text = "Nama Barang:"
        ' 
        ' nmBrg
        ' 
        nmBrg.Location = New Point(199, 118)
        nmBrg.Name = "nmBrg"
        nmBrg.Size = New Size(107, 23)
        nmBrg.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(454, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 12
        Label3.Text = "Satuan:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(453, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 14
        Label4.Text = "Harga Jual:"
        ' 
        ' hrgJual
        ' 
        hrgJual.Location = New Point(541, 171)
        hrgJual.Name = "hrgJual"
        hrgJual.Size = New Size(121, 23)
        hrgJual.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(453, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 16
        Label5.Text = "Harga Beli:"
        ' 
        ' hrgBeli
        ' 
        hrgBeli.Location = New Point(541, 118)
        hrgBeli.Name = "hrgBeli"
        hrgBeli.Size = New Size(121, 23)
        hrgBeli.TabIndex = 15
        ' 
        ' cbJnsSatuan
        ' 
        cbJnsSatuan.FormattingEnabled = True
        cbJnsSatuan.Items.AddRange(New Object() {"Grm", "Rim", "ml", "pcs"})
        cbJnsSatuan.Location = New Point(541, 62)
        cbJnsSatuan.Name = "cbJnsSatuan"
        cbJnsSatuan.Size = New Size(121, 23)
        cbJnsSatuan.TabIndex = 17
        ' 
        ' cbJnsBrg
        ' 
        cbJnsBrg.FormattingEnabled = True
        cbJnsBrg.Items.AddRange(New Object() {"Jus", "Dessert", "baru", "Makanan", "Minuman", "Roti", "Soft Drinks"})
        cbJnsBrg.Location = New Point(199, 171)
        cbJnsBrg.Name = "cbJnsBrg"
        cbJnsBrg.Size = New Size(107, 23)
        cbJnsBrg.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(292, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 25)
        Label6.TabIndex = 19
        Label6.Text = "PENDATAAN BARANG"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(cbJnsBrg)
        Controls.Add(cbJnsSatuan)
        Controls.Add(Label5)
        Controls.Add(hrgBeli)
        Controls.Add(Label4)
        Controls.Add(hrgJual)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(nmBrg)
        Controls.Add(Label2)
        Controls.Add(label)
        Controls.Add(kodeBrg)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents kodeBrg As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nmBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hrgJual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents hrgBeli As TextBox
    Friend WithEvents cbJnsSatuan As ComboBox
    Friend WithEvents cbJnsBrg As ComboBox
    Friend WithEvents Label6 As Label

End Class
