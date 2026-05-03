<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAIN))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_ViewDataProduct = New System.Windows.Forms.Button()
        Me.bt_DeleteDataProduct = New System.Windows.Forms.Button()
        Me.bt_UpdateDataProduct = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tx_Price = New System.Windows.Forms.TextBox()
        Me.tx_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_AddDataProduct = New System.Windows.Forms.Button()
        Me.bt_database_conn_check = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "new.bmp")
        Me.ImageList1.Images.SetKeyName(1, "save.bmp")
        Me.ImageList1.Images.SetKeyName(2, "delete.bmp")
        Me.ImageList1.Images.SetKeyName(3, "move first.bmp")
        Me.ImageList1.Images.SetKeyName(4, "move previous.bmp")
        Me.ImageList1.Images.SetKeyName(5, "move next.bmp")
        Me.ImageList1.Images.SetKeyName(6, "move last.bmp")
        Me.ImageList1.Images.SetKeyName(7, "browse.bmp")
        Me.ImageList1.Images.SetKeyName(8, "find.bmp")
        Me.ImageList1.Images.SetKeyName(9, "find next.bmp")
        Me.ImageList1.Images.SetKeyName(10, "cancel.bmp")
        Me.ImageList1.Images.SetKeyName(11, "edit.bmp")
        Me.ImageList1.Images.SetKeyName(12, "lock.bmp")
        Me.ImageList1.Images.SetKeyName(13, "print.bmp")
        '
        'bt_ViewDataProduct
        '
        Me.bt_ViewDataProduct.Location = New System.Drawing.Point(12, 211)
        Me.bt_ViewDataProduct.Name = "bt_ViewDataProduct"
        Me.bt_ViewDataProduct.Size = New System.Drawing.Size(153, 23)
        Me.bt_ViewDataProduct.TabIndex = 69
        Me.bt_ViewDataProduct.Text = "View Data Product"
        Me.bt_ViewDataProduct.UseVisualStyleBackColor = True
        '
        'bt_DeleteDataProduct
        '
        Me.bt_DeleteDataProduct.Location = New System.Drawing.Point(12, 269)
        Me.bt_DeleteDataProduct.Name = "bt_DeleteDataProduct"
        Me.bt_DeleteDataProduct.Size = New System.Drawing.Size(153, 23)
        Me.bt_DeleteDataProduct.TabIndex = 71
        Me.bt_DeleteDataProduct.Text = "Delete Data Product"
        Me.bt_DeleteDataProduct.UseVisualStyleBackColor = True
        '
        'bt_UpdateDataProduct
        '
        Me.bt_UpdateDataProduct.Location = New System.Drawing.Point(12, 240)
        Me.bt_UpdateDataProduct.Name = "bt_UpdateDataProduct"
        Me.bt_UpdateDataProduct.Size = New System.Drawing.Size(153, 23)
        Me.bt_UpdateDataProduct.TabIndex = 72
        Me.bt_UpdateDataProduct.Text = "Update Data Product"
        Me.bt_UpdateDataProduct.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(316, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(437, 271)
        Me.DataGridView1.TabIndex = 73
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.tx_Price)
        Me.Panel1.Controls.Add(Me.tx_ID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tx_Name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bt_AddDataProduct)
        Me.Panel1.Location = New System.Drawing.Point(12, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 136)
        Me.Panel1.TabIndex = 80
        '
        'tx_Price
        '
        Me.tx_Price.Location = New System.Drawing.Point(71, 65)
        Me.tx_Price.Name = "tx_Price"
        Me.tx_Price.Size = New System.Drawing.Size(194, 20)
        Me.tx_Price.TabIndex = 86
        '
        'tx_ID
        '
        Me.tx_ID.Location = New System.Drawing.Point(71, 21)
        Me.tx_ID.Name = "tx_ID"
        Me.tx_ID.Size = New System.Drawing.Size(194, 20)
        Me.tx_ID.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Price"
        '
        'tx_Name
        '
        Me.tx_Name.Location = New System.Drawing.Point(71, 43)
        Me.tx_Name.Name = "tx_Name"
        Me.tx_Name.Size = New System.Drawing.Size(194, 20)
        Me.tx_Name.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Name"
        '
        'bt_AddDataProduct
        '
        Me.bt_AddDataProduct.Location = New System.Drawing.Point(71, 91)
        Me.bt_AddDataProduct.Name = "bt_AddDataProduct"
        Me.bt_AddDataProduct.Size = New System.Drawing.Size(194, 23)
        Me.bt_AddDataProduct.TabIndex = 80
        Me.bt_AddDataProduct.Text = "Add Data Product"
        Me.bt_AddDataProduct.UseVisualStyleBackColor = True
        '
        'bt_database_conn_check
        '
        Me.bt_database_conn_check.Location = New System.Drawing.Point(12, 16)
        Me.bt_database_conn_check.Name = "bt_database_conn_check"
        Me.bt_database_conn_check.Size = New System.Drawing.Size(153, 23)
        Me.bt_database_conn_check.TabIndex = 81
        Me.bt_database_conn_check.Text = "Check Database Connection"
        Me.bt_database_conn_check.UseVisualStyleBackColor = True
        '
        'frmMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 377)
        Me.Controls.Add(Me.bt_database_conn_check)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_UpdateDataProduct)
        Me.Controls.Add(Me.bt_DeleteDataProduct)
        Me.Controls.Add(Me.bt_ViewDataProduct)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "visualbasic_sqlite_desktop_crud"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_ViewDataProduct As Button
    Friend WithEvents bt_DeleteDataProduct As Button
    Friend WithEvents bt_UpdateDataProduct As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tx_Price As TextBox
    Friend WithEvents tx_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tx_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_AddDataProduct As Button
    Friend WithEvents bt_database_conn_check As Button
End Class
