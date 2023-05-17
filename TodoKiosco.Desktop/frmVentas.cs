using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoKiosco.Entities;
using TodoKiosco.BusinessLogic; 

namespace TodoKiosco.Desktop
{
    public partial class frmVentas : Form
    {

        List<Cliente> _listadoClientes;
        List<Denominacion> _listadoDenominacion;
        List<VentaDetalle> _listadoVentaDetalle;


        AutoCompleteStringCollection clientes;
        AutoCompleteStringCollection tarjeta;

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            clientes = new AutoCompleteStringCollection();
            tarjeta = new AutoCompleteStringCollection();

            textBoxClienteId.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxClienteId.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxTarjetaId.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxTarjetaId.AutoCompleteSource = AutoCompleteSource.CustomSource;

            CompletarTxt();

            textBoxClienteId.AutoCompleteCustomSource = clientes;
            textBoxTarjetaId.AutoCompleteCustomSource = tarjeta;

        }

        private void UpdateGrid()
        {
            _listadoClientes = ClienteBL.Instance.SelectAll();
            _listadoDenominacion = DenominacionBL.Instance.SelectAll();
        }

        private void CompletarTxt()
        {
            foreach (Cliente item in _listadoClientes)
            {
                clientes.Add(item.Nombre + " " + item.Apellido + " | " + item.ClienteId);
            }

            foreach (Denominacion item in _listadoDenominacion)
            {
                tarjeta.Add(item.Nombre + " | " + item.DenominacionId);
            }
        }

        int clienteId = 0;
        private void textBoxClienteId_Validated(object sender, EventArgs e)
        {
            if (textBoxClienteId.Text != "")
            {


                int pos = textBoxClienteId.Text.IndexOf("|");
                clienteId = int.Parse(textBoxClienteId.Text.Substring(pos+2));
            }

        }

        string tarjetaId = "";
        decimal precio = 0;
        private void textBoxTarjetaId_Validated(object sender, EventArgs e)
        {
            int pos = textBoxTarjetaId.Text.IndexOf("|");

            tarjetaId = textBoxTarjetaId.Text.Substring(pos+2);

            

            Denominacion entity = _listadoDenominacion.FirstOrDefault(x=>x.DenominacionId.Equals(tarjetaId));

           
                precio = entity.Precio;
                textBoxPrecio.Text = precio.ToString();
                subtotal = precio * numericUpDown1.Value;
                textBoxSubtotal.Text = subtotal.ToString();
            



        }

        decimal subtotal = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            precio = decimal.Parse(textBoxPrecio.Text);
            subtotal = precio * numericUpDown1.Value;
            textBoxSubtotal.Text = subtotal.ToString();
        }

        List<DetalleGrid> _listaDetalleGrid = new List<DetalleGrid>();
        decimal total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleGrid detalle = new DetalleGrid()
            {
                TarjetaId = tarjetaId,
                Precio = precio,
                Cantidad = Convert.ToInt32(numericUpDown1.Value ),
                SubTotal = subtotal
            };

            _listaDetalleGrid.Add(detalle);

            dataGridView1.DataSource = _listaDetalleGrid.ToList();

            total = _listaDetalleGrid.Sum(x => x.SubTotal);
            textBoxTotal.Text = total.ToString();
        }


        List<VentaDetalle> _ventaDetalles = new List<VentaDetalle>();
        private void button2_Click(object sender, EventArgs e)
        {

            Venta venta = new Venta()
            {
                VentaId = 0,
                Fecha = DateTime.Now,
                Total =decimal.Parse( textBoxTotal.Text),
                ClienteId =clienteId,
                Email = "samuel.galicia@miempresa.com"
            };


            //Se asigna los detalles d ela venta POCO
            for (int i = 0; i < _listaDetalleGrid.Count; i++)
            {
                VentaDetalle _detalleVenta = new VentaDetalle()
                {
                    VentaId = 0,
                    DenominacionId = _listaDetalleGrid[i].TarjetaId,
                    Cantidad = _listaDetalleGrid[i].Cantidad,
                    Subtotal = _listaDetalleGrid[i].SubTotal
                };

                _ventaDetalles.Add(_detalleVenta);
            }

            VentaBL.Instance.Insert(venta, _ventaDetalles);



            




        }
    }


    public class DetalleGrid
    {
        public string TarjetaId { get; set; }
        public decimal Precio{ get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }


}
