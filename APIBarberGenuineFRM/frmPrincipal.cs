using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIBarberGenuineFRM
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Form formActivo = null;
        private void AbrirNewForm(Form newForm)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e) //Boton crear agenda
        {
            if (!panelCreatedAgenda.Visible)
            {
                panelCreatedAgenda.Visible = true;
                panelClient.Visible = false;
                panelCita.Visible = false;
                panelProduct.Visible = false;

            }
            else
            {
                panelCreatedAgenda.Visible = false;
                panelCita.Visible = false;
                panelClient.Visible = false;
                panelProduct.Visible = false;
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (!panelClient.Visible)
            {
                panelClient.Visible = true;
                panelCreatedAgenda.Visible = false;
                panelCita.Visible = false;
                panelProduct.Visible = false;
            }
            else
            {
                panelClient.Visible = false;
                panelCreatedAgenda.Visible = false;
                panelCita.Visible = false;
                panelProduct.Visible = false;
            }
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            if (!panelCita.Visible)
            {
                panelCita.Visible = true;
                panelClient.Visible = false;
                panelCreatedAgenda.Visible = false;
                panelProduct.Visible = false;
            }
            else
            {
                panelCita.Visible = false;
                panelClient.Visible = false;
                panelCreatedAgenda.Visible = false;
                panelProduct.Visible = false;
            }
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!panelProduct.Visible)
            {
                panelProduct.Visible = true;
                panelCita.Visible = false;
                panelClient.Visible = false;
                panelCreatedAgenda.Visible = false;
            }
            else
            {
                panelProduct.Visible = false;
                panelCita.Visible = false;
                panelClient.Visible = false;
                panelCreatedAgenda.Visible = false;
            }
        }
        
        private void button6_Click(object sender, EventArgs e)//Con cliente nuevo
        {
            frmWhitNewClient frmNewClient = new frmWhitNewClient();
            this.Hide();
            frmNewClient.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//cliente existentes
        {
            frmWhitExistingClient existingClient = new frmWhitExistingClient();
            this.Hide();
            existingClient.ShowDialog();
        }

        private void btnActualizarClient_Click(object sender, EventArgs e)
        {
            frmUpdateClient frmUpdateClient = new frmUpdateClient();
            this.Hide();
            frmUpdateClient.ShowDialog();
        }

        private void btnVerTablaCliente_Click(object sender, EventArgs e)
        {
            frmTableClientView  frmTableClientView = new frmTableClientView();
            this.Hide();
            frmTableClientView.ShowDialog();
        }

        private void btnActualizarEliminarCita_Click(object sender, EventArgs e)
        {
            frmDeleted_UpdateCita frmUpdate_DeletedCita = new frmDeleted_UpdateCita();
            this.Hide();
            frmUpdate_DeletedCita.ShowDialog();
        }

        private void btnVerTablaCita_Click(object sender, EventArgs e)
        {
            frmTableCitaView frmTableCitaView = new frmTableCitaView();
            this.Hide();
            frmTableCitaView.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)//Boton Venta de Productos
        {
            frmVentaProduct frmVentaProduct = new frmVentaProduct();
            this.Hide();
            frmVentaProduct.ShowDialog();
        }

        private void btnTablaProduct_Click(object sender, EventArgs e)
        {
            frmTableViewProduct frmTableViewProduct = new frmTableViewProduct();
            this.Hide();
            frmTableViewProduct.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura = new frmFactura();
            this.Hide();
            frmFactura.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodo de botones
        Panel p = new Panel();

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.Black;
            p.Size = new Size(75, 5);
            p.Location = new Point(btn.Location.X,btn.Location.Y+ 40 );
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }

        int posX=0;
        int posY=0;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);

                Top = Top + (e.Y - posY);
            }
        }


        ////Metodos MultiForm
        //public void OcultarSubMenu(Panel panelito)
        //{
        //    if (panelito.Visible == true)
        //    {
        //        panelito.Visible = false;
        //    }

        //}

        //public void MostrarSubmenu(Panel submen)
        //{
        //    if (submen.Visible == false)
        //    {
        //        OcultarSubMenu(submen);
        //        submen.Visible = true;
        //    }
        //    else
        //    {
        //        submen.Visible = false;
        //    }
        //}
    }
}
