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
    public partial class frmFactura : frmBase
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            GetAllFactura();
        }

        private async void GetAllFactura()
        {
            List<FacturaDto> listFacturas = new List<FacturaDto>();
            List<ProductDto> listProductos = new List<ProductDto>();
            dgvFacturas.Rows.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Factura"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var facturas = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<FacturaDto>>(facturas);
                        listFacturas = lista.ToList();
                        //dgvFacturas.DataSource = lista.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la factura: {response.StatusCode}");
                    }
                }
            }
            //using (var client = new HttpClient())
            //{
            //    using (var response = await client.GetAsync("https://localhost:7030/api/Products"))
            //    {
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var productos = await response.Content.ReadAsStringAsync();
            //            var lista = JsonConvert.DeserializeObject<List<ProductDto>>(productos);
            //            listProductos = lista.ToList();
            //        }
            //        else
            //        {
            //            MessageBox.Show($"No se puede obtener la Factura {response.StatusCode}");
            //        }
            //    }
            //}
            foreach (var item in listFacturas)
            {
                int n = dgvFacturas.Rows.Add();

                dgvFacturas.Rows[n].Cells[0].Value = item.Id;
                dgvFacturas.Rows[n].Cells[1].Value = item.Fecha;
                dgvFacturas.Rows[n].Cells[2].Value = item.Description;
                dgvFacturas.Rows[n].Cells[3].Value = item.SoldUnits;
                dgvFacturas.Rows[n].Cells[4].Value = item.Total;

            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
        }
    }
}
