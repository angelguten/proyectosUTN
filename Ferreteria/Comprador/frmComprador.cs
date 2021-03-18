using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaFerreteria;
using Comprador;


namespace Comprador
{
    public partial class frmComprador : Form
    {
        Inventario inventario = new Inventario();
        List<Producto> lista = new List<Producto>();
        List<Image> imagenes = new List<Image>();
        Dictionary<int, Image> codigo_imagen = new Dictionary<int, Image>();



        Producto ProductoBuscado;


        string productoSeleccionado="";
        int codigoProducto = 0;

        Vendedor.Factura frmFactura;

        public frmComprador()
        { 
            InitializeComponent();
        }

        private void frmComprador_Load(object sender, EventArgs e)
        {
            ptbAgregar.Visible = false;
            codigo_imagen.Add(1003, Comprador.Properties.Resources._1003);
            codigo_imagen.Add(1004, Comprador.Properties.Resources._1004);

            btnBuscarTipoDeProducto.Enabled = false;
            btnBuscarPorNombre.Enabled = false;
            btnBuscarMarca.Enabled = false;
            btnBuscarCodigo.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            btnComprar.Enabled = false;
            btnBusquedaCombinada.Enabled = false;
            btnBusquedaPorCriterios.Enabled = false;
            cmbTipoProducto.Visible = false;
            cmbNombre.Visible = false;
            cmbMarca.Visible = false;
            cmbCodigo.Visible = false;

            cmbTipoBusquedaComdinada.Visible = false;
            cmbNombreBusquedaCombinada.Visible = false;
            cmbMarcaBusquedaCombinada.Visible = false;
            cmbCodigoBusquedaCombinada.Visible = false;
        }

        private void btnCargarDatosDeInventario_Click(object sender, EventArgs e)
        {
          
            inventario.AgregarProducto(new Pinturas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"PINTURA","Pintura","Sherwin Williams Latex",1001,250.75,8));
            inventario.AgregarProducto(new Pinturas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"PINTURA", "Pintura","Ace Royal",1002,250.75,2));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA", "Moladora","BOSCH",1003, 450.75,2));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA","Moladora","MAKITA",1004,350.75,29));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA","Moladora","SCHELL",1005,400.75,23));
            inventario.AgregarProducto(new Pinturas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"PINTURA","Pintura","Bher Premium Plus",1006,280.75,8));
            inventario.AgregarProducto(new Pinturas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"PINTURA","Pintura","Benjamin Moore",1007,235.75,2));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA","Moladora","DeWalt",1008,650.75,25));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA","Moladora","Milwaukee",1009, 550.75,20));
            inventario.AgregarProducto(new Herramientas(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"HERRAMIENTA","Moladora","Stanley",1010,800.75, 18));

            inventario.AgregarProducto(new Accesorios(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"ACCESORIO","Broca HSS","Moore",1011,435.75, 20));
            inventario.AgregarProducto(new Accesorios(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"ACCESORIO","Llave Mandril Universal","DeWalt",1012,750.75, 25));
            inventario.AgregarProducto(new Accesorios(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"ACCESORIO","Disco de Sierra Circular","Black & Decker",1013,950.75,22));
            inventario.AgregarProducto(new Accesorios(Producto.Usuario.Experimentado, Producto.Ambito.Profesional,"ACCESORIO","Disco Diamantado","Bauker",1014,900.75,15));




            btnBusquedaCombinada.Enabled = true;
            btnBusquedaPorCriterios.Enabled = true;

            dgvTabla.DataSource = null;
            dgvTabla.DataSource = inventario.ListaProductos;
            dgvTabla.Columns.Add("CANTIDAD","CANTIDAD");//inventario.CANTIDAD;
            
            //Se cargan todos los cmb con los productos que estan en el inventario
            foreach (Producto unProducto in inventario.ListaProductos)
            {
                //Recorro la lista de productos del inventario

                //busco en el cmbCodigo el producto de lista que obtuve en el foreach
                //si no esta devuelve -1, y lo agrega al cmbCodigo
                if ((cmbCodigo.FindString(unProducto.IdDeProducto.ToString())) == -1)
                {
                    cmbCodigo.Items.Add(unProducto.IdDeProducto);
                }

            }


            foreach (Producto unProducto in inventario.ListaProductos)
            {
              
                if ((cmbTipoProducto.FindString(unProducto.TipoDeProducto)) == -1)
                {
                    cmbTipoProducto.Items.Add(unProducto.TipoDeProducto);
                }

            }

            foreach (Producto unProducto in inventario.ListaProductos)
            {

                if ((cmbNombre.FindString(unProducto.NombreDeProducto)) == -1)
                {
                    cmbNombre.Items.Add(unProducto.NombreDeProducto);
                }

            }

            foreach (Producto unProducto in inventario.ListaProductos)
            {

                if ((cmbMarca.FindString(unProducto.MarcaDeProducto)) == -1)
                {
                    cmbMarca.Items.Add(unProducto.MarcaDeProducto);
                }

            }

            btnCargarDatosDeInventario.Enabled = false;

        }
        private void SeleccionarItemDeCombo()
        {
            MessageBox.Show("Despliegue la flecha del combo y eleccione una de las opciones","Seleccionar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnBuscarTipoDeProducto_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoProducto.Text == "")
            {
                this.SeleccionarItemDeCombo();

            }
            if (btnBuscarTipoDeProducto.Enabled == true)
            {
                btnBuscarTipoDeProducto.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.TipoDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;
        }
        private void LimpiarCombos()
        {
            cmbTipoProducto.ResetText();
            cmbNombre.ResetText();
            cmbMarca.ResetText();
            cmbCodigo.ResetText();
        }
        
        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            productoSeleccionado = cmbTipoProducto.SelectedItem.ToString();
            ptbAgregar.Visible = false;
            rtbInstrucciones.Text = "";
           

            if (btnBuscarTipoDeProducto.Enabled == false)
            {
                btnBuscarTipoDeProducto.Enabled = true;
            }




            if (this.cmbTipoProducto.Text == "")
            {
                this.SeleccionarItemDeCombo();

            }
            if (btnBuscarTipoDeProducto.Enabled == true)
            {
                btnBuscarTipoDeProducto.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.TipoDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;

        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {

            if (btnBuscarPorNombre.Enabled == true)
            {
                btnBuscarPorNombre.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.NombreDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            productoSeleccionado = cmbNombre.SelectedItem.ToString();
            ptbAgregar.Visible = false;
            rtbInstrucciones.Text = "";
            

            if (btnBuscarPorNombre.Enabled == false)
            {
               btnBuscarPorNombre.Enabled = true;
            }

            if (btnBuscarPorNombre.Enabled == true)
            {
                btnBuscarPorNombre.Enabled = false;
            }



            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.NombreDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            if (btnBuscarMarca.Enabled == true)
            {
                btnBuscarMarca.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.MarcaDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            productoSeleccionado = cmbMarca.SelectedItem.ToString();
            ptbAgregar.Visible = false;
            rtbInstrucciones.Text = "";
            

            if (btnBuscarMarca.Enabled == false)
            {
                btnBuscarMarca.Enabled = true;
            }


            if (btnBuscarMarca.Enabled == true)
            {
                btnBuscarMarca.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if ((unProducto.MarcaDeProducto == productoSeleccionado))
                {
                    lista.Add(unProducto);
                }
            }
            dgvTabla.DataSource = lista;

        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (btnBuscarCodigo.Enabled==true)
            {
                btnBuscarCodigo.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;
            
            foreach (Producto unProducto in inventario.ListaProductos)
            {           
                if (unProducto.IdDeProducto == codigoProducto)//productoSeleccionado)
                    {
                        lista.Add(unProducto);
                        ProductoBuscado = unProducto;
                        rtbInstrucciones.Text= unProducto.InstruccionesDeUso();

                    }    
            }
            dgvTabla.DataSource = lista;
            //ptbAgregar.Visible = true;
            //ptbAgregar.Show();

            btnAgregar.Enabled = true;

            foreach (KeyValuePair<int, Image> imagen in codigo_imagen)
            {
                if (codigoProducto == imagen.Key)
                {
                    ptbAgregar.Visible = true;
                    ptbAgregar.Image = imagen.Value;
                    ptbAgregar.Visible = true;
                    ptbAgregar.Show();

                    //btnAgregar.Enabled = true;
                }
            }
            
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            codigoProducto = Convert.ToInt32(cmbCodigo.SelectedItem.ToString());
            ptbAgregar.Visible = false;
            rtbInstrucciones.Text = "";
           


            if (btnBuscarCodigo.Enabled == false)
            {
                btnBuscarCodigo.Enabled = true;
            }



            if (btnBuscarCodigo.Enabled == true)
            {
                btnBuscarCodigo.Enabled = false;
            }

            lista.Clear();
            dgvTabla.DataSource = null;

            foreach (Producto unProducto in inventario.ListaProductos)
            {
                if (unProducto.IdDeProducto == codigoProducto)//productoSeleccionado)
                {
                    lista.Add(unProducto);
                    ProductoBuscado = unProducto;
                    rtbInstrucciones.Text = unProducto.InstruccionesDeUso();

                }
            }
            dgvTabla.DataSource = lista;
            //ptbAgregar.Visible = true;
            //ptbAgregar.Show();

            btnAgregar.Enabled = true;

            foreach (KeyValuePair<int, Image> imagen in codigo_imagen)
            {
                if (codigoProducto == imagen.Key)
                {
                    ptbAgregar.Visible = true;
                    ptbAgregar.Image = imagen.Value;
                    //ptbAgregar.Visible = true;
                    ptbAgregar.Show();

                    //btnAgregar.Enabled = true;
                }
            }
        }

        private void rtbInstrucciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusquedaCombinada_Click(object sender, EventArgs e)
        {
            btnBuscarTipoDeProducto.Enabled = false;
            btnBuscarPorNombre.Enabled = false;
            btnBuscarMarca.Enabled = false;
            btnBuscarCodigo.Enabled = false;

            cmbTipoBusquedaComdinada.Visible = true;
            cmbNombreBusquedaCombinada.Visible = true;
            cmbMarcaBusquedaCombinada.Visible = true;
            cmbCodigoBusquedaCombinada.Visible = true;


            cmbTipoProducto.Visible = false;
            cmbNombre.Visible = false;
            cmbMarca.Visible = false;
            cmbCodigo.Visible =false;
        }

        private void btnBusquedaPorCriterios_Click(object sender, EventArgs e)
        {
            cmbTipoBusquedaComdinada.Visible = false;
            cmbNombreBusquedaCombinada.Visible = false;
            cmbMarcaBusquedaCombinada.Visible = false;
            cmbCodigoBusquedaCombinada.Visible = false;

            //btnBuscarTipoDeProducto.Enabled = true;
            //btnBuscarPorNombre.Enabled = true;
            //btnBuscarMarca.Enabled = true;
            //btnBuscarCodigo.Enabled = true;

            btnBuscarTipoDeProducto.Enabled = false;
            btnBuscarPorNombre.Enabled = false;
            btnBuscarMarca.Enabled = false;
            btnBuscarCodigo.Enabled = false;

            cmbTipoProducto.Visible = true;
            cmbNombre.Visible = true;
            cmbMarca.Visible = true;
            cmbCodigo.Visible = true;

        }

        private void gpbMenu_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Enabled==true)
            {
                btnAgregar.Enabled = false;
            }
            if (btnBuscarCodigo.Enabled == false)
            {
                btnBuscarCodigo.Enabled = true;
            }
            if (ProductoBuscado != null)
            { 
                lstCompra.Items.Add(ProductoBuscado.NombreDeProducto);
            }

            new Producto(;
           
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            //foreach(string unProducto in lstCompra.Items)
            //{
            //    foreach (string unProductoSeleccionado in lstCompra.SelectedItems)
            //    {
            //        if (unProductoSeleccionado == unProducto)
            //        {
            //            lstCompra.Items.Remove(lstCompra.item);
            //        }
            //    }
            //}
         }

        private void cmbCodigoBusquedaCombinada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoProducto_Click(object sender, EventArgs e)
        {
            this.LimpiarCombos();
            btnAgregar.Enabled = false;
            this.ptbAgregar.Visible = false;
        }
        private void cmbNombre_Click(object sender, EventArgs e)
        {
            this.LimpiarCombos();
            btnAgregar.Enabled = false;
            ptbAgregar.Visible = false;
        }
        private void cmbMarca_Click(object sender, EventArgs e)
        {
            this.LimpiarCombos();
            btnAgregar.Enabled = false;
            ptbAgregar.Visible = false;
            ptbAgregar.Visible = false;
        }
        private void cmbCodigo_Click(object sender, EventArgs e)
        {
            //this.LimpiarCombos();
            btnAgregar.Enabled = false;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFactura = new Vendedor.Factura();
            BibliotecaFerreteria.Factura unaFactura = new BibliotecaFerreteria.Factura();


            this.cmbTipoDeFactura.Items.Add(Factura.eTipoDeFactura.A.ToString());
            this.cmbTipoDeFactura.Items.Add(Factura.eTipoDeFactura.B.ToString());
            this.cmbTipoDeFactura.Items.Add(Factura.eTipoDeFactura.C.ToString());

            unaFactura.TipoDeFactura = (Factura.eTipoDeFactura)this.cmbTipoDeFactura.SelectedItem;
            unaFactura.FechaDeFactura = this.dtpFechaFactura.Value;
            unaFactura.NroCuit = 201234567;
            this.lblNroCUIT.Text = unaFactura.NroCuit.ToString();
            
            



            this.Hide();
            frmFactura.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblIngresosBrutos_Click(object sender, EventArgs e)
        {

        }

        private void lblInicioDeActividades_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResposableInscripto_Click(object sender, EventArgs e)
        {

        }

        private void lblContado_Click(object sender, EventArgs e)
        {

        }

        private void gpbCondicionesDeVenta_Enter(object sender, EventArgs e)
        {

        }

        private void chkContado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCtaCte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaVto_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
