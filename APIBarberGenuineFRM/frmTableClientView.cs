using APIBarberGenuine.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIBarberGenuineFRM
{
    public partial class frmTableClientView : frmBase
    {
        public frmTableClientView()
        {
            InitializeComponent();
        }

        private void frmTableClientView_Load(object sender, EventArgs e)
        {
            GetAllClient();
        }

        List<ClientDto> listClients = new List<ClientDto>();
        private async void GetAllClient()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Clients"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var clients = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<ClientDto>>(clients);
                        //listClients = lista.ToList();
                        listClients = lista.ToList();
                        //var lastClient = lista.LastOrDefault();
                        //lblIdClient.Text = (lastClient.Id + 1).ToString();
                        dgtvAllClient.DataSource=lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de clientes: {response.StatusCode}");
                    }
                }
            }
        }

        private void Query(List<ClientDto> listaClientDto)
        {
            var coso = from client in listaClientDto 
                       where((client.Name).ToUpper().Contains((txtSearchClient.Text).ToUpper()))
                       select client;
            dgtvAllClient.DataSource=coso.ToList();
        }

        private void txtSearchClient_KeyUp(object sender, KeyEventArgs e)
        {
            Query(listClients);
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
        }

        private void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
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
