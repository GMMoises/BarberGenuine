namespace APIBarberGenuineFRM
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnCreatedAgenda = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCreatedAgenda = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConClienteNuevo = new System.Windows.Forms.Button();
            this.btnConClienteExistente = new System.Windows.Forms.Button();
            this.panelClient = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActualizarClient = new System.Windows.Forms.Button();
            this.btnVerTablaCliente = new System.Windows.Forms.Button();
            this.panelCita = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActualizarEliminarCita = new System.Windows.Forms.Button();
            this.btnVerTablaCita = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTablaProduct = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCreatedAgenda.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.panelCita.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.pMenu.Controls.Add(this.btnProduct);
            this.pMenu.Controls.Add(this.btnExit);
            this.pMenu.Controls.Add(this.btnCita);
            this.pMenu.Controls.Add(this.btnCreatedAgenda);
            this.pMenu.Controls.Add(this.btnClient);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 74);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(111, 414);
            this.pMenu.TabIndex = 1;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(14, 236);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(86, 40);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnProduct.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(14, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCita.ForeColor = System.Drawing.Color.White;
            this.btnCita.Location = new System.Drawing.Point(14, 159);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(86, 40);
            this.btnCita.TabIndex = 2;
            this.btnCita.Text = "Citas";
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            this.btnCita.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnCita.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnCreatedAgenda
            // 
            this.btnCreatedAgenda.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCreatedAgenda.FlatAppearance.BorderSize = 0;
            this.btnCreatedAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCreatedAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreatedAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatedAgenda.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatedAgenda.ForeColor = System.Drawing.Color.White;
            this.btnCreatedAgenda.Location = new System.Drawing.Point(14, 18);
            this.btnCreatedAgenda.Name = "btnCreatedAgenda";
            this.btnCreatedAgenda.Size = new System.Drawing.Size(86, 40);
            this.btnCreatedAgenda.TabIndex = 0;
            this.btnCreatedAgenda.Text = "Add Cita";
            this.btnCreatedAgenda.UseVisualStyleBackColor = false;
            this.btnCreatedAgenda.Click += new System.EventHandler(this.button1_Click);
            this.btnCreatedAgenda.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnCreatedAgenda.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(14, 89);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(86, 40);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            this.btnClient.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnClient.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 74);
            this.panel2.TabIndex = 2;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panelCreatedAgenda
            // 
            this.panelCreatedAgenda.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCreatedAgenda.Controls.Add(this.btnConClienteNuevo);
            this.panelCreatedAgenda.Controls.Add(this.btnConClienteExistente);
            this.panelCreatedAgenda.Location = new System.Drawing.Point(111, 74);
            this.panelCreatedAgenda.Name = "panelCreatedAgenda";
            this.panelCreatedAgenda.Size = new System.Drawing.Size(120, 93);
            this.panelCreatedAgenda.TabIndex = 0;
            this.panelCreatedAgenda.Visible = false;
            // 
            // btnConClienteNuevo
            // 
            this.btnConClienteNuevo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConClienteNuevo.FlatAppearance.BorderSize = 0;
            this.btnConClienteNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConClienteNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConClienteNuevo.ForeColor = System.Drawing.Color.White;
            this.btnConClienteNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnConClienteNuevo.Name = "btnConClienteNuevo";
            this.btnConClienteNuevo.Size = new System.Drawing.Size(75, 39);
            this.btnConClienteNuevo.TabIndex = 4;
            this.btnConClienteNuevo.Text = "New Client";
            this.btnConClienteNuevo.UseVisualStyleBackColor = false;
            this.btnConClienteNuevo.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnConClienteExistente
            // 
            this.btnConClienteExistente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConClienteExistente.FlatAppearance.BorderSize = 0;
            this.btnConClienteExistente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConClienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConClienteExistente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConClienteExistente.ForeColor = System.Drawing.Color.White;
            this.btnConClienteExistente.Location = new System.Drawing.Point(3, 48);
            this.btnConClienteExistente.Name = "btnConClienteExistente";
            this.btnConClienteExistente.Size = new System.Drawing.Size(75, 39);
            this.btnConClienteExistente.TabIndex = 5;
            this.btnConClienteExistente.Text = "Existing Client";
            this.btnConClienteExistente.UseVisualStyleBackColor = false;
            this.btnConClienteExistente.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.Goldenrod;
            this.panelClient.Controls.Add(this.btnActualizarClient);
            this.panelClient.Controls.Add(this.btnVerTablaCliente);
            this.panelClient.Location = new System.Drawing.Point(111, 147);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(120, 96);
            this.panelClient.TabIndex = 3;
            this.panelClient.Visible = false;
            // 
            // btnActualizarClient
            // 
            this.btnActualizarClient.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActualizarClient.FlatAppearance.BorderSize = 0;
            this.btnActualizarClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarClient.ForeColor = System.Drawing.Color.White;
            this.btnActualizarClient.Location = new System.Drawing.Point(3, 3);
            this.btnActualizarClient.Name = "btnActualizarClient";
            this.btnActualizarClient.Size = new System.Drawing.Size(75, 41);
            this.btnActualizarClient.TabIndex = 4;
            this.btnActualizarClient.Text = "Update Client";
            this.btnActualizarClient.UseVisualStyleBackColor = false;
            this.btnActualizarClient.Click += new System.EventHandler(this.btnActualizarClient_Click);
            // 
            // btnVerTablaCliente
            // 
            this.btnVerTablaCliente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnVerTablaCliente.FlatAppearance.BorderSize = 0;
            this.btnVerTablaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnVerTablaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTablaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerTablaCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerTablaCliente.Location = new System.Drawing.Point(3, 50);
            this.btnVerTablaCliente.Name = "btnVerTablaCliente";
            this.btnVerTablaCliente.Size = new System.Drawing.Size(75, 41);
            this.btnVerTablaCliente.TabIndex = 3;
            this.btnVerTablaCliente.Text = "View Table";
            this.btnVerTablaCliente.UseVisualStyleBackColor = false;
            this.btnVerTablaCliente.Click += new System.EventHandler(this.btnVerTablaCliente_Click);
            // 
            // panelCita
            // 
            this.panelCita.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCita.Controls.Add(this.btnActualizarEliminarCita);
            this.panelCita.Controls.Add(this.btnVerTablaCita);
            this.panelCita.Location = new System.Drawing.Point(111, 210);
            this.panelCita.Name = "panelCita";
            this.panelCita.Size = new System.Drawing.Size(120, 96);
            this.panelCita.TabIndex = 4;
            this.panelCita.Visible = false;
            // 
            // btnActualizarEliminarCita
            // 
            this.btnActualizarEliminarCita.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActualizarEliminarCita.FlatAppearance.BorderSize = 0;
            this.btnActualizarEliminarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizarEliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEliminarCita.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEliminarCita.Location = new System.Drawing.Point(3, 3);
            this.btnActualizarEliminarCita.Name = "btnActualizarEliminarCita";
            this.btnActualizarEliminarCita.Size = new System.Drawing.Size(97, 41);
            this.btnActualizarEliminarCita.TabIndex = 4;
            this.btnActualizarEliminarCita.Text = "Update and Deleted";
            this.btnActualizarEliminarCita.UseVisualStyleBackColor = false;
            this.btnActualizarEliminarCita.Click += new System.EventHandler(this.btnActualizarEliminarCita_Click);
            // 
            // btnVerTablaCita
            // 
            this.btnVerTablaCita.BackColor = System.Drawing.Color.Goldenrod;
            this.btnVerTablaCita.FlatAppearance.BorderSize = 0;
            this.btnVerTablaCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnVerTablaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTablaCita.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerTablaCita.ForeColor = System.Drawing.Color.White;
            this.btnVerTablaCita.Location = new System.Drawing.Point(3, 50);
            this.btnVerTablaCita.Name = "btnVerTablaCita";
            this.btnVerTablaCita.Size = new System.Drawing.Size(97, 41);
            this.btnVerTablaCita.TabIndex = 3;
            this.btnVerTablaCita.Text = "View Table";
            this.btnVerTablaCita.UseVisualStyleBackColor = false;
            this.btnVerTablaCita.Click += new System.EventHandler(this.btnVerTablaCita_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.panelProduct.Controls.Add(this.button1);
            this.panelProduct.Controls.Add(this.btnTablaProduct);
            this.panelProduct.Controls.Add(this.btnFactura);
            this.panelProduct.Location = new System.Drawing.Point(111, 271);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(120, 142);
            this.panelProduct.TabIndex = 5;
            this.panelProduct.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sell Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTablaProduct
            // 
            this.btnTablaProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.btnTablaProduct.FlatAppearance.BorderSize = 0;
            this.btnTablaProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTablaProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTablaProduct.ForeColor = System.Drawing.Color.White;
            this.btnTablaProduct.Location = new System.Drawing.Point(3, 50);
            this.btnTablaProduct.Name = "btnTablaProduct";
            this.btnTablaProduct.Size = new System.Drawing.Size(97, 41);
            this.btnTablaProduct.TabIndex = 3;
            this.btnTablaProduct.Text = "View Table";
            this.btnTablaProduct.UseVisualStyleBackColor = false;
            this.btnTablaProduct.Click += new System.EventHandler(this.btnTablaProduct_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Location = new System.Drawing.Point(3, 97);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(97, 41);
            this.btnFactura.TabIndex = 5;
            this.btnFactura.Text = "Bills";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(680, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "MAIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::APIBarberGenuineFRM.Properties.Resources._709F1B89_5EE4_4D87_8882_7B76B98CE13C;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 488);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelCita);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.panelCreatedAgenda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.pMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelCreatedAgenda.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            this.panelCita.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel pMenu;
        private Button btnProduct;
        private Button btnCita;
        private Button btnCreatedAgenda;
        private Button btnClient;
        private Panel panel2;
        private FlowLayoutPanel panelCreatedAgenda;
        private Button btnConClienteNuevo;
        private Button btnExit;
        private Button btnConClienteExistente;
        private FlowLayoutPanel panelClient;
        private Button btnActualizarClient;
        private Button btnVerTablaCliente;
        private FlowLayoutPanel panelCita;
        private Button btnActualizarEliminarCita;
        private Button btnVerTablaCita;
        private FlowLayoutPanel panelProduct;
        private Button button1;
        private Button btnTablaProduct;
        private Button btnFactura;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox2;
    }
}