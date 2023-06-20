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
    public partial class frmDeleted_UpdateCita : frmBase
    {
        public frmDeleted_UpdateCita()
        {
            InitializeComponent();
        }

        private void frmDeleted_UpdateCita_Load(object sender, EventArgs e)
        {
            GetAllCitas();
        }

        private static int id = 0;

        List<CitaDto> listCitas = new List<CitaDto>();
        private async void GetAllCitas()
        {
            dgvUpdateCita.Rows.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Citas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var Citas = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<CitaDto>>(Citas);
                        listCitas = lista.ToList();



                        //dgvUpdateCita.DataSource = lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de citas: {response.StatusCode}");
                    }
                }
            }

            foreach (var item in listCitas)
            {
                int n = dgvUpdateCita.Rows.Add();
                dgvUpdateCita.Rows[n].Cells[0].Value = item.Id;
                dgvUpdateCita.Rows[n].Cells[1].Value = item.Service;
                dgvUpdateCita.Rows[n].Cells[2].Value = item.Dates.ToShortDateString();
                dgvUpdateCita.Rows[n].Cells[3].Value = item.ClientId;

            }

        }

        private void dgvUpdateCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUpdateCita.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetCitaById(id);
                    lblIdCita.Text = id.ToString();
                }
            }
        }

        private async void GetCitaById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Citas", id));
                if (response.IsSuccessStatusCode)
                {
                    var citas = await response.Content.ReadAsStringAsync();
                    CitaDto citaDto = JsonConvert.DeserializeObject<CitaDto>(citas);
                    lblIdCita.Text = citaDto.Id.ToString();
                    cmbServicio.Text = citaDto.Service;
                    lblIdCliente.Text = citaDto.ClientId.ToString();
                    dtpDate.Value = citaDto.Dates;
                    //listaCitas = clientDto.Citas.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la cita: {response.StatusCode}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//Boton Update Cita
        {
            if (cmbServicio.Text==string.Empty)
            {
                error.SetError(cmbServicio, "Seleccione una cita o un servicio");
            }
            else
            {
                error.Clear();
                if (id != 0)
                {
                    UpdateCita();
                }
            }
        }

        private async void UpdateCita()
        {
            CitaUpdateDto citaUpdateDto = new CitaUpdateDto();
            citaUpdateDto.Id = id;
            citaUpdateDto.Service = cmbServicio.Text;
            citaUpdateDto.Dates = dtpDate.Value;
            citaUpdateDto.ClientId = int.Parse(lblIdCliente.Text);
            //clientDto.Citas = listaCitas;

            using (var client = new HttpClient())
            {
                var cita = JsonConvert.SerializeObject(citaUpdateDto);
                var content = new StringContent(cita, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Citas", id), content);
                Console.WriteLine("");
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cita actualizada");
                else
                    MessageBox.Show($"Error al actualizar la Cita: {response.StatusCode}");

            }
            Clear();
            GetAllCitas();
        }

        public  void Clear()
        {
            lblIdCita.Text = string.Empty;
            lblIdCliente.Text = string.Empty;
            cmbServicio.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            txtSearch.Text = string.Empty;
        }

        private void Query(List<CitaDto> listaCitaDto)
        {

            var coso = from cita in listaCitaDto
                       where ((cita.ClientId.ToString()).ToUpper().Contains((txtSearch.Text).ToUpper()))
                       select cita;
            //dgvUpdateClient.DataSource = coso.ToList();
            dgvUpdateCita.Rows.Clear();

            foreach (var item in coso)
            {
                int n = dgvUpdateCita.Rows.Add();
                dgvUpdateCita.Rows[n].Cells[0].Value = item.Id;
                dgvUpdateCita.Rows[n].Cells[1].Value = item.Service;
                dgvUpdateCita.Rows[n].Cells[2].Value = item.Dates.ToShortDateString();
                dgvUpdateCita.Rows[n].Cells[3].Value = item.ClientId;

            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                GetAllCitas();
            }
            else
            {

                Query(listCitas);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Boton Deleted
        {
            if (cmbServicio.Text == string.Empty)
            {
                error.SetError(cmbServicio, "Seleccione una cita o un servicio");
            }
            else
            {
                error.Clear();
                if (id != 0)
                {
                    DeleteCitas(id);
                }
            }
        }

        private async void DeleteCitas(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7030/api/Citas");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7030/api/Citas", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cita eliminada con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar la cita: {response.StatusCode}");
            }
            Clear();
            GetAllCitas();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmTableCitaView frmTableCitaView = new frmTableCitaView();
            this.Hide();
            frmTableCitaView.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
