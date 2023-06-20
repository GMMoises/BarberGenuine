namespace APIBarberGenuineFRM
{
    partial class frmVentaProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Providers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVender = new System.Windows.Forms.Button();
            this.nupUnitSell = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProviders = new System.Windows.Forms.TextBox();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 60);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(11, 371);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(851, 400);
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.PriceUnit,
            this.Providers,
            this.UnitInStock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(142, 192);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(543, 246);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "Id Product";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Name Product";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // PriceUnit
            // 
            this.PriceUnit.HeaderText = "Price Unit";
            this.PriceUnit.Name = "PriceUnit";
            this.PriceUnit.ReadOnly = true;
            // 
            // Providers
            // 
            this.Providers.HeaderText = "Providers";
            this.Providers.Name = "Providers";
            this.Providers.ReadOnly = true;
            // 
            // UnitInStock
            // 
            this.UnitInStock.HeaderText = "UnitInStock";
            this.UnitInStock.Name = "UnitInStock";
            this.UnitInStock.ReadOnly = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(696, 402);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(72, 31);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // nupUnitSell
            // 
            this.nupUnitSell.BackColor = System.Drawing.Color.Black;
            this.nupUnitSell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupUnitSell.ForeColor = System.Drawing.Color.White;
            this.nupUnitSell.Location = new System.Drawing.Point(810, 102);
            this.nupUnitSell.Name = "nupUnitSell";
            this.nupUnitSell.Size = new System.Drawing.Size(120, 23);
            this.nupUnitSell.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(421, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unid in stock :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name Product :";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.Black;
            this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Location = new System.Drawing.Point(221, 102);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(153, 23);
            this.txtNameProduct.TabIndex = 9;
            this.txtNameProduct.TextChanged += new System.EventHandler(this.txtNameProduct_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(440, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Providers :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Black;
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(221, 153);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(153, 23);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(140, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit Price :";
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.BackColor = System.Drawing.Color.Black;
            this.txtUnitInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitInStock.Enabled = false;
            this.txtUnitInStock.Location = new System.Drawing.Point(523, 148);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(153, 23);
            this.txtUnitInStock.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(699, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Units to choose :";
            // 
            // txtProviders
            // 
            this.txtProviders.BackColor = System.Drawing.Color.Black;
            this.txtProviders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProviders.Enabled = false;
            this.txtProviders.Location = new System.Drawing.Point(523, 102);
            this.txtProviders.Name = "txtProviders";
            this.txtProviders.Size = new System.Drawing.Size(153, 23);
            this.txtProviders.TabIndex = 17;
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.BackColor = System.Drawing.Color.Black;
            this.lblIdProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdProduct.ForeColor = System.Drawing.Color.White;
            this.lblIdProduct.Location = new System.Drawing.Point(184, 73);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(18, 17);
            this.lblIdProduct.TabIndex = 45;
            this.lblIdProduct.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(116, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Id Product :";
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.BackColor = System.Drawing.Color.Black;
            this.lblIdFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdFactura.ForeColor = System.Drawing.Color.White;
            this.lblIdFactura.Location = new System.Drawing.Point(350, 73);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(18, 17);
            this.lblIdFactura.TabIndex = 47;
            this.lblIdFactura.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(282, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Id Factura :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APIBarberGenuineFRM.Properties.Resources.CB608634_4741_4612_83A8_4CB00F2CEC95;
            this.pictureBox1.Location = new System.Drawing.Point(108, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(844, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "PRODUCTS";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmVentaProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIdFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIdProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProviders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupUnitSell);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmVentaProduct";
            this.Text = "frmVentaProduct";
            this.Load += new System.EventHandler(this.frmVentaProduct_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dgvProduct, 0);
            this.Controls.SetChildIndex(this.btnVender, 0);
            this.Controls.SetChildIndex(this.nupUnitSell, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNameProduct, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtUnitPrice, 0);
            this.Controls.SetChildIndex(this.txtUnitInStock, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtProviders, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblIdProduct, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblIdFactura, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProduct;
        private Button btnVender;
        private NumericUpDown nupUnitSell;
        private Label label1;
        private Label label2;
        private TextBox txtNameProduct;
        private Label label3;
        private TextBox txtUnitPrice;
        private Label label4;
        private TextBox txtUnitInStock;
        private Label label5;
        private TextBox txtProviders;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn PriceUnit;
        private DataGridViewTextBoxColumn Providers;
        private DataGridViewTextBoxColumn UnitInStock;
        private Label lblIdProduct;
        private Label label7;
        private Label lblIdFactura;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label6;
        private ErrorProvider error;
    }
}