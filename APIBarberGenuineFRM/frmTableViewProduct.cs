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
    public partial class frmTableViewProduct : frmBase
    {
        public frmTableViewProduct()
        {
            InitializeComponent();
        }

        private void frmTableViewProduct_Load(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        List<ProductDto> listProducts = new List<ProductDto>();
        private async void GetAllProduct()
        {
            dgvProduct.Rows.Clear();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Products"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productos = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<ProductDto>>(productos);
                        listProducts = lista.ToList();



                        //dgvUpdateCita.DataSource = lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de citas: {response.StatusCode}");
                    }
                }
            }

            foreach (var item in listProducts)
            {
                int n = dgvProduct.Rows.Add();
                dgvProduct.Rows[n].Cells[0].Value = item.Id;
                dgvProduct.Rows[n].Cells[1].Value = item.NameProduct;
                dgvProduct.Rows[n].Cells[2].Value = item.PriceUnit;
                dgvProduct.Rows[n].Cells[3].Value = item.Providers;
                dgvProduct.Rows[n].Cells[4].Value = item.UnitInStock;
            }

        }

        private void Query(List<ProductDto> listaClientDto)
        {
            var coso = from producto in listaClientDto
                       where ((producto.NameProduct).ToUpper().Contains((txtSearch.Text).ToUpper()))
                       select producto;
            //dgvProduct.DataSource = coso.ToList();
            dgvProduct.Rows.Clear();
            foreach (var item in coso)
            {
                int n = dgvProduct.Rows.Add();
                dgvProduct.Rows[n].Cells[0].Value = item.Id;
                dgvProduct.Rows[n].Cells[1].Value = item.NameProduct;
                dgvProduct.Rows[n].Cells[2].Value = item.PriceUnit;
                dgvProduct.Rows[n].Cells[3].Value = item.Providers;
                dgvProduct.Rows[n].Cells[4].Value = item.UnitInStock;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text==string.Empty)
            {
                GetAllProduct();
            }
            else
            {
                Query(listProducts);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura = new frmFactura();
            this.Hide();
            frmFactura.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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
