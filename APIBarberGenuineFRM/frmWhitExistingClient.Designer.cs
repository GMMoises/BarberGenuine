namespace APIBarberGenuineFRM
{
    partial class frmWhitExistingClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhitExistingClient));
            this.label4 = new System.Windows.Forms.Label();
            this.dtmpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdClient = new System.Windows.Forms.ComboBox();
            this.lblIdCita = new System.Windows.Forms.Label();
            this.lblCita = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgtvExistingClient = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvExistingClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1021, 76);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(12, 367);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(1024, 438);
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Date :";
            // 
            // dtmpDate
            // 
            this.dtmpDate.Location = new System.Drawing.Point(533, 154);
            this.dtmpDate.Name = "dtmpDate";
            this.dtmpDate.Size = new System.Drawing.Size(200, 23);
            this.dtmpDate.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(467, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Services :";
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.Black;
            this.cmbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbServicio.ForeColor = System.Drawing.Color.White;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "CORTE DE PELO.",
            "ARREGLO DE BARBA.",
            "AFEITADO CON RITUAL.",
            "MASCARILLA ANTIPUNTOS NEGROS.",
            "MASAJE EXFOLIANTE FACIAL.",
            "CORTE INFANTIL."});
            this.cmbServicio.Location = new System.Drawing.Point(533, 106);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(200, 23);
            this.cmbServicio.TabIndex = 46;
            this.cmbServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServicio_KeyPress);
            this.cmbServicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbServicio_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Id Client :";
            // 
            // cmbIdClient
            // 
            this.cmbIdClient.BackColor = System.Drawing.Color.Black;
            this.cmbIdClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbIdClient.ForeColor = System.Drawing.Color.White;
            this.cmbIdClient.FormattingEnabled = true;
            this.cmbIdClient.Location = new System.Drawing.Point(233, 111);
            this.cmbIdClient.Name = "cmbIdClient";
            this.cmbIdClient.Size = new System.Drawing.Size(133, 23);
            this.cmbIdClient.TabIndex = 50;
            this.cmbIdClient.SelectedIndexChanged += new System.EventHandler(this.cmbIdClient_SelectedIndexChanged);
            // 
            // lblIdCita
            // 
            this.lblIdCita.AutoSize = true;
            this.lblIdCita.BackColor = System.Drawing.Color.Black;
            this.lblIdCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCita.ForeColor = System.Drawing.Color.White;
            this.lblIdCita.Location = new System.Drawing.Point(188, 88);
            this.lblIdCita.Name = "lblIdCita";
            this.lblIdCita.Size = new System.Drawing.Size(18, 17);
            this.lblIdCita.TabIndex = 53;
            this.lblIdCita.Text = "--";
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.BackColor = System.Drawing.Color.Black;
            this.lblCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCita.ForeColor = System.Drawing.Color.White;
            this.lblCita.Location = new System.Drawing.Point(131, 88);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(52, 17);
            this.lblCita.TabIndex = 52;
            this.lblCita.Text = "Id Cita :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 56;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Black;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(233, 198);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 23);
            this.txtLastName.TabIndex = 60;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameClient_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Apellido :";
            // 
            // txtNameClient
            // 
            this.txtNameClient.BackColor = System.Drawing.Color.Black;
            this.txtNameClient.Enabled = false;
            this.txtNameClient.Location = new System.Drawing.Point(233, 151);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(133, 23);
            this.txtNameClient.TabIndex = 58;
            this.txtNameClient.TextChanged += new System.EventHandler(this.txtNameClient_TextChanged);
            this.txtNameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameClient_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(162, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Nombre :";
            // 
            // dgtvExistingClient
            // 
            this.dgtvExistingClient.AllowUserToAddRows = false;
            this.dgtvExistingClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtvExistingClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvExistingClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgtvExistingClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvExistingClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgtvExistingClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgtvExistingClient.EnableHeadersVisualStyles = false;
            this.dgtvExistingClient.Location = new System.Drawing.Point(137, 239);
            this.dgtvExistingClient.Name = "dgtvExistingClient";
            this.dgtvExistingClient.ReadOnly = true;
            this.dgtvExistingClient.RowTemplate.Height = 25;
            this.dgtvExistingClient.Size = new System.Drawing.Size(743, 240);
            this.dgtvExistingClient.TabIndex = 69;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1065, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "CITAS";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmWhitExistingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgtvExistingClient);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblIdCita);
            this.Controls.Add(this.lblCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtmpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmWhitExistingClient";
            this.Text = "frmWhitExistingClient";
            this.Load += new System.EventHandler(this.frmWhitExistingClient_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.cmbServicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtmpDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbIdClient, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblCita, 0);
            this.Controls.SetChildIndex(this.lblIdCita, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtNameClient, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.dgtvExistingClient, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvExistingClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private DateTimePicker dtmpDate;
        private Label label3;
        private ComboBox cmbServicio;
        private Label label1;
        private ComboBox cmbIdClient;
        private Label lblIdCita;
        private Label lblCita;
        private Button button1;
        private TextBox txtLastName;
        private Label label6;
        private TextBox txtNameClient;
        private Label label7;
        private DataGridView dgtvExistingClient;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn IdCita;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Fecha;
        private PictureBox pictureBox1;
        private Label label2;
        private ErrorProvider error;
    }
}