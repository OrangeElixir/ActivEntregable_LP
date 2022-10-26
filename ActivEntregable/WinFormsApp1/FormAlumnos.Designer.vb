<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlumnos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pNombre = New System.Windows.Forms.TextBox()
        Me.txt_Papellido = New System.Windows.Forms.TextBox()
        Me.txt_Snombre = New System.Windows.Forms.TextBox()
        Me.txt_Sapellido = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Fnacim = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_obser = New System.Windows.Forms.TextBox()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(2, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(315, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segundo Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(2, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Primer Apellido: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(316, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Segundo Apellido: "
        '
        'txt_pNombre
        '
        Me.txt_pNombre.Location = New System.Drawing.Point(110, 60)
        Me.txt_pNombre.Name = "txt_pNombre"
        Me.txt_pNombre.Size = New System.Drawing.Size(199, 23)
        Me.txt_pNombre.TabIndex = 4
        '
        'txt_Papellido
        '
        Me.txt_Papellido.Location = New System.Drawing.Point(110, 110)
        Me.txt_Papellido.Name = "txt_Papellido"
        Me.txt_Papellido.Size = New System.Drawing.Size(199, 23)
        Me.txt_Papellido.TabIndex = 5
        '
        'txt_Snombre
        '
        Me.txt_Snombre.Location = New System.Drawing.Point(440, 63)
        Me.txt_Snombre.Name = "txt_Snombre"
        Me.txt_Snombre.Size = New System.Drawing.Size(204, 23)
        Me.txt_Snombre.TabIndex = 6
        '
        'txt_Sapellido
        '
        Me.txt_Sapellido.Location = New System.Drawing.Point(440, 110)
        Me.txt_Sapellido.Name = "txt_Sapellido"
        Me.txt_Sapellido.Size = New System.Drawing.Size(204, 23)
        Me.txt_Sapellido.TabIndex = 7
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(110, 156)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(125, 23)
        Me.txt_telefono.TabIndex = 8
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(306, 159)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(98, 23)
        Me.txt_celular.TabIndex = 9
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(471, 156)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(379, 23)
        Me.txt_email.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(2, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Teléfono: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(250, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Celular: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(418, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(668, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha de Nacimiento: "
        '
        'txt_Fnacim
        '
        Me.txt_Fnacim.Location = New System.Drawing.Point(668, 89)
        Me.txt_Fnacim.Name = "txt_Fnacim"
        Me.txt_Fnacim.Size = New System.Drawing.Size(160, 23)
        Me.txt_Fnacim.TabIndex = 15
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(110, 205)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(373, 23)
        Me.txt_direccion.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(2, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Dirección: "
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_insertar.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_insertar.Image = Global.CapaPresentacion.My.Resources.Resources.UserAdd_40960__1_
        Me.btn_insertar.Location = New System.Drawing.Point(520, 196)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(124, 39)
        Me.btn_insertar.TabIndex = 18
        Me.btn_insertar.UseVisualStyleBackColor = False
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.dgvAlumnos.Location = New System.Drawing.Point(12, 417)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.RowTemplate.Height = 25
        Me.dgvAlumnos.Size = New System.Drawing.Size(937, 218)
        Me.dgvAlumnos.TabIndex = 19
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_modificar.Image = Global.CapaPresentacion.My.Resources.Resources.notes_edit_modify_icon_143729
        Me.btn_modificar.Location = New System.Drawing.Point(691, 193)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(137, 42)
        Me.btn_modificar.TabIndex = 20
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Image = Global.CapaPresentacion.My.Resources.Resources._1492790846_9cancel_84247
        Me.btn_eliminar.Location = New System.Drawing.Point(431, 641)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(128, 44)
        Me.btn_eliminar.TabIndex = 21
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(12, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Buscar: "
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(110, 375)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(632, 23)
        Me.txtBuscar.TabIndex = 23
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Image = Global.CapaPresentacion.My.Resources.Resources._1490129321_rounded10_82180
        Me.btn_buscar.Location = New System.Drawing.Point(772, 364)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(78, 42)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Historic", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(207, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(452, 32)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Institución Educativa - Carlos Morales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources._4213449_building_college_education_library_school_university_115404__2_
        Me.PictureBox1.Location = New System.Drawing.Point(859, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 86)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(2, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Observaciones: "
        '
        'txt_obser
        '
        Me.txt_obser.Location = New System.Drawing.Point(110, 255)
        Me.txt_obser.Name = "txt_obser"
        Me.txt_obser.Size = New System.Drawing.Size(650, 23)
        Me.txt_obser.TabIndex = 28
        '
        'FormAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(952, 697)
        Me.Controls.Add(Me.txt_obser)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_Fnacim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_Sapellido)
        Me.Controls.Add(Me.txt_Snombre)
        Me.Controls.Add(Me.txt_Papellido)
        Me.Controls.Add(Me.txt_pNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FormAlumnos"
        Me.Text = "Alumnos"
        Me.TopMost = True
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pNombre As TextBox
    Friend WithEvents txt_Papellido As TextBox
    Friend WithEvents txt_Snombre As TextBox
    Friend WithEvents txt_Sapellido As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Fnacim As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_obser As TextBox
End Class
