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
    public partial class frmTableCitaView : frmBase
    {
        public frmTableCitaView()
        {
            InitializeComponent();
        }

        private void frmTableCitaView_Load(object sender, EventArgs e)
        {
            GetAllCitas();
        }

        List<CitaDto> listCitas = new List<CitaDto>();
        private async void GetAllCitas()
        {
            dgvGetAllCitas.Rows.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Citas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var Citas = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<CitaDto>>(Citas);
                        listCitas = lista.ToList();



                        dgvGetAllCitas.DataSource = lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de citas: {response.StatusCode}");
                    }
                }
            }
        }

        private void Query(List<CitaDto> listaClientDto)
        {
            var coso = from citas in listaClientDto
                       where ((citas.Id.ToString()).ToUpper().Contains((txtSearch.Text).ToUpper()))
                       select citas;
            dgvGetAllCitas.DataSource = coso.ToList();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Query(listCitas);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
