using APIBarberGenuine.Models;
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
    public partial class frmUpdateClient : frmBase
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            GetAllClient();
        }

        private static int id = 0;
        private void dgvUpdateClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUpdateClient.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetClientById(id);
                    lblIdClient.Text=id.ToString();
                }
            }
        }

        List<Cita> listaCitas = new List<Cita>();
        private async void GetClientById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Clients", id));
                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadAsStringAsync();
                    ClientDto clientDto = JsonConvert.DeserializeObject<ClientDto>(student);
                    lblIdClient.Text = clientDto.Id.ToString();
                    txtName.Text = clientDto.Name;
                    txtApellido.Text = clientDto.LastName;
                    txtNumberPhone.Text = clientDto.Phone;
                    //listaCitas = clientDto.Citas.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el estudiante: {response.StatusCode}");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text==string.Empty||txtName.Text== string.Empty
                ||txtNumberPhone.Text== string.Empty)
            {
                error.SetError(txtApellido,"Seleccione un cliente, campo vacio");
                error.SetError(txtName, "Seleccione un cliente, campo vacio");
                error.SetError(txtNumberPhone, "Seleccione un cliente, campo vacio");
            }
            else
            {
                error.Clear();

                if (id != 0)
                {
                    UpdateClient();
                }
            }
        }

        private async void UpdateClient()
        {
            ClientUpdateDto clientDto = new ClientUpdateDto();
            clientDto.Id = id;
            clientDto.Name = txtName.Text;
            clientDto.Phone = txtNumberPhone.Text;
            clientDto.LastName = txtApellido.Text;
            //clientDto.Citas = listaCitas;

            using (var client = new HttpClient())
            {
                var cliente = JsonConvert.SerializeObject(clientDto);
                var content = new StringContent(cliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Clients", id), content);
                Console.WriteLine("");
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Cliente: {response.StatusCode}");

            }
            Clear();
            GetAllClient();

        }

        private void Clear()
        {
            txtName.Text=string.Empty;
            txtApellido.Text=string.Empty;
            txtNumberPhone.Text=string.Empty;
            txtSearch.Text=string.Empty;
            lblIdClient.Text=string.Empty;
            id=0;
        }

        List<ClientDto> listClients = new List<ClientDto>();
        private async void GetAllClient()
        {
            dgvUpdateClient.Rows.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Clients"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var clientes = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<ClientDto>>(clientes);
                        listClients = lista.ToList();
                        //var lastClient = lista.LastOrDefault();
                        //lblIdClient.Text = (lastClient.Id + 1).ToString();
                        // dgtvNewClient.DataSource=lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Clientes : {response.StatusCode}");
                    }
                }
            }
            
            foreach (var item in listClients)
            {
                int n = dgvUpdateClient.Rows.Add();
                dgvUpdateClient.Rows[n].Cells[0].Value = item.Id;
                dgvUpdateClient.Rows[n].Cells[1].Value = item.Name;
                dgvUpdateClient.Rows[n].Cells[2].Value = item.LastName;
                dgvUpdateClient.Rows[n].Cells[3].Value = item.Phone;
                
            }
        }

        private void Query(List<ClientDto> listaClientDto)
        {
            
            var coso = from client in listaClientDto
                       where ((client.Name).ToUpper().Contains((txtSearch.Text).ToUpper()))
                       select client;
            //dgvUpdateClient.DataSource = coso.ToList();
            dgvUpdateClient.Rows.Clear();
            foreach (var item in coso)
            {
                int n = dgvUpdateClient.Rows.Add();
                dgvUpdateClient.Rows[n].Cells[0].Value = item.Id;
                dgvUpdateClient.Rows[n].Cells[1].Value = item.Name;
                dgvUpdateClient.Rows[n].Cells[2].Value = item.LastName;
                dgvUpdateClient.Rows[n].Cells[3].Value = item.Phone;

            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtSearch.Text == string.Empty)
            {
                GetAllClient();
            }
            else
            {

                Query(listClients);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmTableClientView frmTableClientView = new frmTableClientView();
            this.Hide();
            frmTableClientView.ShowDialog();
        }

        public static void ValidarRangoDeCaracteres(TextBox txt, int n)
        {
            if (txt.Text.Length > n)
            {
                MessageBox.Show("Solo se permiten " + n + " caracteres en este campo");
                txt.Text = String.Empty;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtName, 30);
            txtName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
            txtName.SelectionStart = txtName.Text.Length;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtApellido, 30);
            txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtApellido.SelectionStart = txtApellido.Text.Length;
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            ValidarRangoDeCaracteres(txtNumberPhone, 8);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
