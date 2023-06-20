namespace APIBarberGenuineFRM
{
    partial class frmWhitNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhitNewClient));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgtvNewClient = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtApellidoClient = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblServices = new System.Windows.Forms.Label();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvNewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1046, 76);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(12, 517);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(1049, 536);
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(885, 525);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 27);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgtvNewClient
            // 
            this.dgtvNewClient.AllowUserToAddRows = false;
            this.dgtvNewClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtvNewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvNewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgtvNewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvNewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.IdCita,
            this.Servicio,
            this.Fecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtvNewClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgtvNewClient.EnableHeadersVisualStyles = false;
            this.dgtvNewClient.Location = new System.Drawing.Point(136, 312);
            this.dgtvNewClient.Name = "dgtvNewClient";
            this.dgtvNewClient.ReadOnly = true;
            this.dgtvNewClient.RowTemplate.Height = 25;
            this.dgtvNewClient.Size = new System.Drawing.Size(743, 240);
            this.dgtvNewClient.TabIndex = 68;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // IdCita
            // 
            this.IdCita.HeaderText = "Id Cita";
            this.IdCita.Name = "IdCita";
            this.IdCita.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Black;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(229, 235);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 23);
            this.txtPhone.TabIndex = 67;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Black;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(172, 244);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 15);
            this.lblPhone.TabIndex = 66;
            this.lblPhone.Text = "Phone :";
            // 
            // txtApellidoClient
            // 
            this.txtApellidoClient.BackColor = System.Drawing.Color.Black;
            this.txtApellidoClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoClient.ForeColor = System.Drawing.Color.White;
            this.txtApellidoClient.Location = new System.Drawing.Point(229, 182);
            this.txtApellidoClient.Name = "txtApellidoClient";
            this.txtApellidoClient.Size = new System.Drawing.Size(133, 23);
            this.txtApellidoClient.TabIndex = 65;
            this.txtApellidoClient.TextChanged += new System.EventHandler(this.txtApellidoClient_TextChanged);
            this.txtApellidoClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoClient_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Black;
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(163, 191);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 15);
            this.lblApellido.TabIndex = 64;
            this.lblApellido.Text = "Apellido :";
            // 
            // txtNameClient
            // 
            this.txtNameClient.BackColor = System.Drawing.Color.Black;
            this.txtNameClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameClient.ForeColor = System.Drawing.Color.White;
            this.txtNameClient.Location = new System.Drawing.Point(229, 135);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(133, 23);
            this.txtNameClient.TabIndex = 63;
            this.txtNameClient.TextChanged += new System.EventHandler(this.txtNameClient_TextChanged);
            this.txtNameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoClient_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Black;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(163, 139);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 62;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.BackColor = System.Drawing.Color.Black;
            this.lblIdClient.ForeColor = System.Drawing.Color.White;
            this.lblIdClient.Location = new System.Drawing.Point(193, 89);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(17, 15);
            this.lblIdClient.TabIndex = 61;
            this.lblIdClient.Text = "--";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Black;
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(130, 89);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(57, 15);
            this.lblClient.TabIndex = 60;
            this.lblClient.Text = "Id Client :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(465, 184);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 59;
            this.lblDate.Text = "Date :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(526, 179);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 58;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.BackColor = System.Drawing.Color.Black;
            this.lblServices.ForeColor = System.Drawing.Color.White;
            this.lblServices.Location = new System.Drawing.Point(465, 141);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(55, 15);
            this.lblServices.TabIndex = 57;
            this.lblServices.Text = "Services :";
            // 
            // cmbServicios
            // 
            this.cmbServicios.BackColor = System.Drawing.Color.Black;
            this.cmbServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbServicios.ForeColor = System.Drawing.Color.White;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Items.AddRange(new object[] {
            "CORTE DE PELO.",
            "ARREGLO DE BARBA.",
            "AFEITADO CON RITUAL.",
            "MASCARILLA ANTIPUNTOS NEGROS.",
            "MASAJE EXFOLIANTE FACIAL.",
            "CORTE INFANTIL."});
            this.cmbServicios.Location = new System.Drawing.Point(526, 138);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(200, 23);
            this.cmbServicios.TabIndex = 56;
            this.cmbServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServicios_KeyPress);
            this.cmbServicios.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbServicios_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1090, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "CITAS";
            // 
            // frmWhitNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgtvNewClient);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtApellidoClient);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmWhitNewClient";
            this.Text = "frmWhitNewClient";
            this.Load += new System.EventHandler(this.frmWhitNewClient_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.cmbServicios, 0);
            this.Controls.SetChildIndex(this.lblServices, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.lblIdClient, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNameClient, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.txtApellidoClient, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.dgtvNewClient, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvNewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgtvNewClient;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtApellidoClient;
        private Label lblApellido;
        private TextBox txtNameClient;
        private Label lblNombre;
        private Label lblIdClient;
        private Label lblClient;
        private Label lblDate;
        private DateTimePicker dtpFecha;
        private Label lblServices;
        private ComboBox cmbServicios;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn IdCita;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Fecha;
        private PictureBox pictureBox1;
        private ErrorProvider error;
        private Label label1;
    }
}