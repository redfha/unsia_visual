<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTipe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.submit_items = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxHargaSatuan = New System.Windows.Forms.TextBox()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipe2 = New System.Windows.Forms.ComboBox()
        Me.TextBoxLimit = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.list_items = New System.Windows.Forms.ListView()
        Me.jenis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deskripsi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.harga_satuan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.total_harga = New System.Windows.Forms.Label()
        Me.sisa_limit = New System.Windows.Forms.Label()
        Me.TextBoxLastLimit = New System.Windows.Forms.TextBox()
        Me.button_hapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxFileLocation = New System.Windows.Forms.TextBox()
        Me.ButtonBrowseFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama  :"
        '
        'TextBoxName
        '
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(115, 27)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipe :"
        '
        'ComboBoxTipe
        '
        Me.ComboBoxTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBoxTipe.FormattingEnabled = True
        Me.ComboBoxTipe.Items.AddRange(New Object() {"Operasional", "Non-operasional"})
        Me.ComboBoxTipe.Location = New System.Drawing.Point(115, 64)
        Me.ComboBoxTipe.Name = "ComboBoxTipe"
        Me.ComboBoxTipe.Size = New System.Drawing.Size(204, 28)
        Me.ComboBoxTipe.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Limit :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.submit_items, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxQty, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxHargaSatuan, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxTipe2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 170)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05556!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.94444!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(887, 72)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Deskripsi :"
        '
        'submit_items
        '
        Me.submit_items.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.submit_items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submit_items.AutoSize = True
        Me.submit_items.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.submit_items.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.submit_items.Location = New System.Drawing.Point(757, 30)
        Me.submit_items.Name = "submit_items"
        Me.submit_items.Size = New System.Drawing.Size(127, 30)
        Me.submit_items.TabIndex = 10
        Me.submit_items.Text = "Submit"
        Me.submit_items.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.submit_items.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jenis :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(519, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Qty :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(615, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Harga Satuan :"
        '
        'TextBoxQty
        '
        Me.TextBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQty.Location = New System.Drawing.Point(519, 30)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(90, 26)
        Me.TextBoxQty.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(757, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Aksi"
        '
        'TextBoxHargaSatuan
        '
        Me.TextBoxHargaSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxHargaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHargaSatuan.Location = New System.Drawing.Point(615, 30)
        Me.TextBoxHargaSatuan.Name = "TextBoxHargaSatuan"
        Me.TextBoxHargaSatuan.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxHargaSatuan.TabIndex = 14
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDesc.Location = New System.Drawing.Point(158, 30)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(355, 26)
        Me.TextBoxDesc.TabIndex = 9
        '
        'ComboBoxTipe2
        '
        Me.ComboBoxTipe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBoxTipe2.FormattingEnabled = True
        Me.ComboBoxTipe2.Items.AddRange(New Object() {"Alat Tulis Kantor", "Rumah Tangga Kantor", "Lain-lain"})
        Me.ComboBoxTipe2.Location = New System.Drawing.Point(3, 30)
        Me.ComboBoxTipe2.Name = "ComboBoxTipe2"
        Me.ComboBoxTipe2.Size = New System.Drawing.Size(149, 28)
        Me.ComboBoxTipe2.TabIndex = 9
        '
        'TextBoxLimit
        '
        Me.TextBoxLimit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLimit.Location = New System.Drawing.Point(134, 138)
        Me.TextBoxLimit.Name = "TextBoxLimit"
        Me.TextBoxLimit.ReadOnly = True
        Me.TextBoxLimit.Size = New System.Drawing.Size(185, 19)
        Me.TextBoxLimit.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(100, 138)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(35, 19)
        Me.TextBox7.TabIndex = 11
        Me.TextBox7.Text = "Rp."
        '
        'list_items
        '
        Me.list_items.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.jenis, Me.deskripsi, Me.qty, Me.harga_satuan, Me.total})
        Me.list_items.FullRowSelect = True
        Me.list_items.HideSelection = False
        Me.list_items.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.list_items.Location = New System.Drawing.Point(38, 259)
        Me.list_items.Name = "list_items"
        Me.list_items.Size = New System.Drawing.Size(887, 153)
        Me.list_items.TabIndex = 12
        Me.list_items.UseCompatibleStateImageBehavior = False
        Me.list_items.View = System.Windows.Forms.View.Details
        '
        'jenis
        '
        Me.jenis.Text = "Jenis"
        Me.jenis.Width = 143
        '
        'deskripsi
        '
        Me.deskripsi.Text = "Deskripsi"
        Me.deskripsi.Width = 353
        '
        'qty
        '
        Me.qty.Text = "Qty"
        '
        'harga_satuan
        '
        Me.harga_satuan.Text = "Harga Satuan"
        Me.harga_satuan.Width = 168
        '
        'total
        '
        Me.total.Text = "Total"
        Me.total.Width = 159
        '
        'TextBoxTotalCost
        '
        Me.TextBoxTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTotalCost.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalCost.Location = New System.Drawing.Point(778, 426)
        Me.TextBoxTotalCost.Name = "TextBoxTotalCost"
        Me.TextBoxTotalCost.ReadOnly = True
        Me.TextBoxTotalCost.Size = New System.Drawing.Size(147, 29)
        Me.TextBoxTotalCost.TabIndex = 13
        '
        'total_harga
        '
        Me.total_harga.AutoSize = True
        Me.total_harga.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_harga.Location = New System.Drawing.Point(724, 432)
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Size = New System.Drawing.Size(48, 23)
        Me.total_harga.TabIndex = 14
        Me.total_harga.Text = "Total"
        '
        'sisa_limit
        '
        Me.sisa_limit.AutoSize = True
        Me.sisa_limit.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sisa_limit.Location = New System.Drawing.Point(691, 471)
        Me.sisa_limit.Name = "sisa_limit"
        Me.sisa_limit.Size = New System.Drawing.Size(81, 23)
        Me.sisa_limit.TabIndex = 15
        Me.sisa_limit.Text = "Sisa Limit"
        '
        'TextBoxLastLimit
        '
        Me.TextBoxLastLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLastLimit.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastLimit.Location = New System.Drawing.Point(778, 465)
        Me.TextBoxLastLimit.Name = "TextBoxLastLimit"
        Me.TextBoxLastLimit.ReadOnly = True
        Me.TextBoxLastLimit.Size = New System.Drawing.Size(147, 29)
        Me.TextBoxLastLimit.TabIndex = 17
        '
        'button_hapus
        '
        Me.button_hapus.BackColor = System.Drawing.Color.Salmon
        Me.button_hapus.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.button_hapus.Location = New System.Drawing.Point(38, 422)
        Me.button_hapus.Name = "button_hapus"
        Me.button_hapus.Size = New System.Drawing.Size(127, 33)
        Me.button_hapus.TabIndex = 16
        Me.button_hapus.Text = "Hapus"
        Me.button_hapus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_hapus.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "File :"
        '
        'TextBoxFileLocation
        '
        Me.TextBoxFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxFileLocation.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFileLocation.Location = New System.Drawing.Point(433, 27)
        Me.TextBoxFileLocation.Name = "TextBoxFileLocation"
        Me.TextBoxFileLocation.Size = New System.Drawing.Size(412, 25)
        Me.TextBoxFileLocation.TabIndex = 19
        '
        'ButtonBrowseFile
        '
        Me.ButtonBrowseFile.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonBrowseFile.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.ButtonBrowseFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBrowseFile.Location = New System.Drawing.Point(845, 24)
        Me.ButtonBrowseFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonBrowseFile.Name = "ButtonBrowseFile"
        Me.ButtonBrowseFile.Size = New System.Drawing.Size(77, 33)
        Me.ButtonBrowseFile.TabIndex = 0
        Me.ButtonBrowseFile.Text = "Browse"
        Me.ButtonBrowseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBrowseFile.UseVisualStyleBackColor = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 523)
        Me.Controls.Add(Me.ButtonBrowseFile)
        Me.Controls.Add(Me.TextBoxFileLocation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.button_hapus)
        Me.Controls.Add(Me.TextBoxLastLimit)
        Me.Controls.Add(Me.sisa_limit)
        Me.Controls.Add(Me.total_harga)
        Me.Controls.Add(Me.TextBoxTotalCost)
        Me.Controls.Add(Me.list_items)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBoxLimit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxTipe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Pengajuan Barang"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxTipe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ComboBoxTipe2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents submit_items As Button
    Friend WithEvents TextBoxLimit As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents list_items As ListView
    Private WithEvents jenis As ColumnHeader
    Friend WithEvents deskripsi As ColumnHeader
    Friend WithEvents qty As ColumnHeader
    Friend WithEvents harga_satuan As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents TextBoxTotalCost As TextBox
    Friend WithEvents total_harga As Label
    Friend WithEvents sisa_limit As Label
    Friend WithEvents TextBoxHargaSatuan As TextBox
    Friend WithEvents TextBoxLastLimit As TextBox
    Friend WithEvents button_hapus As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxFileLocation As TextBox
    Friend WithEvents ButtonBrowseFile As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
