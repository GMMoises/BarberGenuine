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
    public partial class frmVentaProduct : frmBase
    {
        public frmVentaProduct()
        {
            InitializeComponent();
        }

        private void frmVentaProduct_Load(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        private static int id = 0;
        List<ProductDto> listProducts = new List<ProductDto>();
        List<FacturaDto> listFacturas = new List<FacturaDto>();
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
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7030/api/Factura"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var students = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<List<FacturaDto>>(students);
                        listFacturas = lista.ToList();
                        var listaFact = lista.LastOrDefault();
                        lblIdFactura.Text = (listaFact.Id + 1).ToString();



                        //dgtvNewClient.DataSource = lista.ToList();

                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de clientes y citas: {response.StatusCode}");
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetProductById(id);
                    lblIdProduct.Text = id.ToString();
                }
            }
        }

        private async void GetProductById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Products", id));
                if (response.IsSuccessStatusCode)
                {
                    var citas = await response.Content.ReadAsStringAsync();
                    ProductDto producDto = JsonConvert.DeserializeObject<ProductDto>(citas);
                    lblIdProduct.Text = producDto.Id.ToString();
                    txtNameProduct.Text = producDto.NameProduct;
                    txtProviders.Text = producDto.Providers;
                    txtUnitInStock.Text = producDto.UnitInStock.ToString();
                    txtUnitPrice.Text = producDto.PriceUnit.ToString();
                    lblIdFactura.Text = producDto.FacturaId.ToString();
                    //listaCitas = clientDto.Citas.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nupUnitSell.Value.ToString());
            if (txtNameProduct.Text==string.Empty||txtProviders.Text== string.Empty
                ||txtUnitInStock.Text== string.Empty||txtUnitPrice.Text== string.Empty
                ||nupUnitSell.Value<=0)
            {
                error.SetError(txtNameProduct, "Seleccione un producto");
                error.SetError(txtProviders, "Seleccione un producto");
                error.SetError(txtUnitInStock, "Seleccione un producto");
                error.SetError(txtUnitPrice, "Seleccione un producto");
                error.SetError(nupUnitSell, "Seleccione un valor mayor a 0");
            }
            else
            {
                error.Clear();

                if (id != 0)
                {
                    VenderProduct();
                }
            }
            
        }
        //operaciones mat
        decimal total = 0;
        int resta = 0;
        private async void VenderProduct()
        {
            ProductUpdateDto productUpdateDto = new ProductUpdateDto();
            FacturaCreateDto facturaCreateDto = new FacturaCreateDto();
            facturaCreateDto.Fecha = DateTime.Now;
            facturaCreateDto.Description = "Venta";
            facturaCreateDto.SoldUnits = int.Parse(nupUnitSell.Value.ToString());
            total = decimal.Parse(txtUnitPrice.Text) * int.Parse(nupUnitSell.Value.ToString());
            facturaCreateDto.Total = total;
            productUpdateDto.Id = id;
            resta = int.Parse(txtUnitInStock.Text.ToString()) - int.Parse(nupUnitSell.Value.ToString());
            productUpdateDto.UnitInStock = resta;
            productUpdateDto.PriceUnit = decimal.Parse(txtUnitPrice.Text);

            using (var client = new HttpClient())
            {
                var facturas = JsonConvert.SerializeObject(facturaCreateDto);
                var content = new StringContent(facturas, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7030/api/Factura", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Factura Creada");
                else
                    MessageBox.Show($"Error al crear la factura: {response.Content.ReadAsStreamAsync().Result}");
            }
            using (var client = new HttpClient())
            {
                var producto = JsonConvert.SerializeObject(productUpdateDto);
                var content = new StringContent(producto, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7030/api/Products", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto Vendido");
                else
                    MessageBox.Show($"Error al vender el producto: {response.StatusCode}");

            }

            Clear();
            GetAllProduct();
        }

        private void Clear()
        {
            txtNameProduct.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtProviders.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            lblIdProduct.Text = string.Empty;
            lblIdFactura.Text = string.Empty;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura = new frmFactura();
            this.Hide();
            frmFactura.ShowDialog();
        }

        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
