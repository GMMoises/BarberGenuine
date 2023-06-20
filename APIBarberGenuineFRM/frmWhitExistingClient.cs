using APIBarberGenuine.Models.Dto;
using Newtonsoft.Json;
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
    public partial class frmWhitExistingClient : frmBase
    {
        public frmWhitExistingClient()
        {
            InitializeComponent();
            //No modifica el ComboBox
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmWhitExistingClient_Load(object sender, EventArgs e)
        {
            //lblCita.Parent = pictureBox1;
            //lblCita.BackColor = Color.Transparent; lblCita.ForeColor = Color.White;
            GetAllClient();
        }
        private void button1_Click(object sender, EventArgs e)//btn guardar
        {
            if (txtNameClient.Text==string.Empty||txtLastName.Text==string.Empty
                ||cmbIdClient.Text==string.Empty||cmbServicio.Text==string.Empty)
            {
                error.SetError(txtLastName, "No ha seleccionado un Cliente");
                error.SetError(txtNameClient, "No ha seleccionado un Cliente");
                error.SetError(cmbServicio, "Seleccione un servicio");
                error.SetError(cmbIdClient, "No ha seleccionado un Cliente");

            }
            else
            {
                error.Clear();
                AddExistingClientInCita();
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
            txtLastName.Text = string.Empty;
            txtNameClient.Text = string.Empty;
            //txtPhone.Text = string.Empty;
            cmbServicio.Text = string.Empty;
            dtmpDate.Value = DateTime.Now;
        }


        List<ClientDto> listClients = new List<ClientDto>();
        private async void GetAllClient()
        {
            List<CitaDto> listCitas = new List<CitaDto>();
            List<int> idList = new List<int>();
            dgtvExistingClient.Rows.Clear();

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
                        //lblIdCita.Text = (lastClient.Id + 1).ToString();
                        // dgtvNewClient.DataSource=lista.ToList();
                        idList = lista.Select(x => x.Id).ToList();
                        cmbIdClient.DataSource = idList;

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
                        var lastCita = lista.LastOrDefault();
                        lblIdCita.Text = (lastCita.Id + 1).ToString();



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
                        int n = dgtvExistingClient.Rows.Add();

                        dgtvExistingClient.Rows[n].Cells[0].Value = item.Id;
                        dgtvExistingClient.Rows[n].Cells[1].Value = item.Name;
                        dgtvExistingClient.Rows[n].Cells[2].Value = item.LastName;
                        dgtvExistingClient.Rows[n].Cells[3].Value = item.Phone;
                        dgtvExistingClient.Rows[n].Cells[4].Value = item2.Id;
                        dgtvExistingClient.Rows[n].Cells[5].Value = item2.Service;
                        dgtvExistingClient.Rows[n].Cells[6].Value = item2.Dates.ToShortDateString();

                    }
                }
            }
        }

        private void cmbIdClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteU = listClients.Where(x => x.Id == int.Parse(cmbIdClient.Text)).Select(x => x);
            txtNameClient.Text = clienteU.FirstOrDefault().Name;
            txtLastName.Text = clienteU.FirstOrDefault().LastName;
            
        }

        public async void AddExistingClientInCita()
        {
            
            CitaCreateDto acita = new CitaCreateDto();
            acita.Service = cmbServicio.Text;
            acita.Dates = dtmpDate.Value;
            acita.ClientId = Convert.ToInt32(cmbIdClient.Text);

            using (var client = new HttpClient())
            {
                var serializedCita = JsonConvert.SerializeObject(acita);
                var content = new StringContent(serializedCita, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7030/api/Citas", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cita Agregado");
                }
                else
                {
                    MessageBox.Show($"Error al guardar la Cita: {response.Content.ReadAsStringAsync().Result}");
                }
            }

            Clear();
            GetAllClient();
        }

        private void cmbServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbServicio.Text = "";
            MessageBox.Show("Seleccione un servicio");
            cmbServicio.Text = "";
        }

        private void cmbServicio_KeyUp(object sender, KeyEventArgs e)
        {
            cmbServicio.Text = "";
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
            txtNameClient.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToUpper(txtNameClient.Text);
            txtNameClient.SelectionStart = txtNameClient.Text.Length;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtLastName, 30);
            txtLastName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToUpper(txtLastName.Text);
            txtLastName.SelectionStart = txtLastName.Text.Length;
        }

        private void txtNameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
