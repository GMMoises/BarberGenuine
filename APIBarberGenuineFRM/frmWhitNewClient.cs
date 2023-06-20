using APIBarberGenuine.Models.Dto;
using APIBarberGenuine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APIBarberGenuineFRM
{
    public partial class frmWhitNewClient : frmBase
    {
        public frmWhitNewClient()
        {
            InitializeComponent();
            //No modifica el ComboBox
            cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            //lblClient.Parent = pictureBox1;
            //lblClient.BackColor = Color.Transparent;
        }
        private void frmWhitNewClient_Load(object sender, EventArgs e)
        {
            //lblClient.Parent = pictureBox1;
            //lblClient.BackColor = Color.Transparent;
            //lblIdClient.Parent = pictureBox1;
            //lblIdClient.BackColor = Color.Transparent;
            GetAllClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtApellidoClient.Text==string.Empty || txtNameClient.Text == string.Empty || txtPhone.Text == string.Empty 
                || cmbServicios.Text==string.Empty)
            {
                error.SetError(txtApellidoClient,"Campo vacio");
                error.SetError(txtNameClient, "Campo vacio");
                error.SetError(txtPhone, "Campo vacio");
                error.SetError(cmbServicios, "Campo sin seleccionar");
                error.SetError(dtpFecha, "Seleccione otra fecha");

            }
            else
            {
                error.Clear();
                AddClientyCita();

            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmTableClientView frmTableClientView = new frmTableClientView();
            this.Hide();
            frmTableClientView.ShowDialog();
        }



        //Metodos
        
        private void Clear()
        {
            txtApellidoClient.Text=string.Empty;
            txtNameClient.Text=string.Empty;
            txtPhone.Text=string.Empty;
            cmbServicios.Text=string.Empty;
            dtpFecha.Value=DateTime.Now;
            
        }
        
        private async void GetAllClient()
        {
            List<ClientDto> listClients = new List<ClientDto>();
            List<CitaDto> listCitas = new List<CitaDto>();
            dgtvNewClient.Rows.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Clients"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var students = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<ClientDto>>(students);
                        listClients = lista.ToList();
                        var lastClient = lista.LastOrDefault();
                        lblIdClient.Text = (lastClient.Id+1).ToString();
                       // dgtvNewClient.DataSource=lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Clientes y citas: {response.StatusCode}");
                    }
                }
            }
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Citas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var students = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<CitaDto>>(students);
                        listCitas = lista.ToList();

                        

                        //dgtvNewClient.DataSource = lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de clientes y citas: {response.StatusCode}");
                    }
                }
            }
            foreach (var item in listClients)
            {
                foreach (var item2 in listCitas)
                {
                    if (item.Id == item2.ClientId)
                    {
                        int n = dgtvNewClient.Rows.Add();

                        dgtvNewClient.Rows[n].Cells[0].Value = item.Id;
                        dgtvNewClient.Rows[n].Cells[1].Value = item.Name;
                        dgtvNewClient.Rows[n].Cells[2].Value = item.LastName;
                        dgtvNewClient.Rows[n].Cells[3].Value = item.Phone;
                        dgtvNewClient.Rows[n].Cells[4].Value = item2.Id;
                        dgtvNewClient.Rows[n].Cells[5].Value = item2.Service;
                        dgtvNewClient.Rows[n].Cells[6].Value = item2.Dates.ToShortDateString();

                    }
                }
            }
        }

        private async void AddClientyCita()
        {
            ClientCreateDto aclient = new ClientCreateDto();
            CitaCreateDto acita = new CitaCreateDto();
            aclient.Name = txtNameClient.Text;
            aclient.LastName = txtApellidoClient.Text;
            aclient.Phone = txtPhone.Text;
            acita.Service = cmbServicios.Text;
            acita.Dates = dtpFecha.Value;
            acita.ClientId = Convert.ToInt32(lblIdClient.Text);

            using (var client = new HttpClient())
            {
                var serializedClient = JsonConvert.SerializeObject(aclient);
                var content = new StringContent(serializedClient, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7030/api/Clients", content);
                if (response.IsSuccessStatusCode) 
                {
                    MessageBox.Show("Cliente y cita Agregado");
                }
                else
                {
                    MessageBox.Show($"Error al guardar al Cliente y la cita: {response.Content.ReadAsStringAsync().Result}");
                }
                   
                
            }

            using (var client = new HttpClient())
            {
                var serializedCita = JsonConvert.SerializeObject(acita);
                var content = new StringContent(serializedCita, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7030/api/Citas", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("");
                else
                    MessageBox.Show($"");
            }

            Clear();
            GetAllClient();
        }

        private void cmbServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbServicios.Text = "";
            MessageBox.Show("Seleccione un servicio");
            cmbServicios.Text = "";
        }

        private void cmbServicios_KeyUp(object sender, KeyEventArgs e)
        {
            cmbServicios.Text = "";
        }

        public static void ValidarRangoDeCaracteres(TextBox txt, int n)
        {
            if (txt.Text.Length > n)
            {
                MessageBox.Show("Solo se permiten " + n + " caracteres en este campo");
                txt.Text = String.Empty;
            }
        }

        private void txtNameClient_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtNameClient, 30);
            txtNameClient.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNameClient.Text);
            txtNameClient.SelectionStart = txtNameClient.Text.Length;
        }

        private void txtApellidoClient_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtApellidoClient, 30);
            txtApellidoClient.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellidoClient.Text);
            txtApellidoClient.SelectionStart = txtApellidoClient.Text.Length;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtPhone, 8);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <=47)|| (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)|| (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
