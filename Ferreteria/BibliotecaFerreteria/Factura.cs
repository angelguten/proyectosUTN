using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public class Factura
    {
        public enum eTipoDeFactura
        {
            A, B, C
        }

        private int nroDeFactura;
        private int nroDeRemito;
        private eTipoDeFactura tipoDeFactura;
        private DateTime fechaDeFactura;
        private int nroCuit;
        private int nroDeIngresosBrutos;
        private DateTime fechaDeInicioDeActividades;
        private bool responsableInscripto;

        private string nombreComprador;
        private string direccionComprador;
        private string localidadComprador;
        private int nroDeCuitDelComprador;
        private DateTime fechaDeVto;

        private List<Producto> listaDeProductosSolicitados;

        public int NroDeFactura
        {
            get
            {
                return this.nroDeFactura;
            }
            set
            {
                this.nroDeFactura = value;
            }

        }
        public int NroDeRemito
        {
            get
            {
                return this.nroDeRemito;
            }
            set
            {
                this.nroDeRemito = value;
            }

        }
        public eTipoDeFactura TipoDeFactura
        {
            get
            {
                return this.tipoDeFactura;
            }
            set
            {
                this.tipoDeFactura = value;
            }

        }
        public DateTime FechaDeFactura
        {
            get
            {
                return this.fechaDeFactura;
            }
            set
            {
                this.fechaDeFactura = value;
            }

        }
        public int NroCuit
        {
            get
            {
                return this.nroCuit;
            }
            set
            {
                this.nroCuit = value;
            }

        }
        public int NroDeIngresosBrutos
        {
            get
            {
                return this.nroDeIngresosBrutos;
            }
            set
            {
                this.nroDeIngresosBrutos = value;
            }

        }
        public DateTime FechaDeInicioDeActividades
        {
            get
            {
                return this.FechaDeInicioDeActividades;
            }
            set
            {
                this.fechaDeInicioDeActividades = value;
            }

        }
        public bool ResponsableInscripto
        {
            get
            {
                return this.responsableInscripto;
            }
            set
            {
                this.responsableInscripto = value;
            }

        }

        

        public string NombreDelComprador
        {
            get
            {
                return this.nombreComprador;
            }
            set
            {
                this.nombreComprador = value;
            }

        }
        public string DireccionDelComprador
        {
            get
            {
                return this.direccionComprador;
            }
            set
            {
                this.direccionComprador = value;
            }

        }
        public string LocalidadDelComprador
        {
            get
            {
                return this.localidadComprador;
            }
            set
            {
                this.localidadComprador = value;
            }

        }
        public int NroCuitDelComprador
        {
            get
            {
                return this.nroDeCuitDelComprador;
            }
            set
            {
                this.nroDeCuitDelComprador = value;
            }

        }
        public DateTime FechaDeVto
        {
            get
            {
                return this.fechaDeVto;
            }
            set
            {
                this.fechaDeVto = value;
            }

        }

        public List<Producto> ListDeProductosSolicitados
        {
            get
            {
                return this.listaDeProductosSolicitados;
            }
            set
            {
                this.listaDeProductosSolicitados = value;
            }

        }

        
        //public float Subtotal
        //{
        //    get
        //    {
        //        return this.CalcularSubtotal();
        //    }
        //}
        //public float SubtotalConImpuesto
        //{
        //    get
        //    {
        //        return this.CalcularSubtotalConImpuesto();
        //    }
        //}
        //public float Iva
        //{
        //    get
        //    {
        //        return this.CalcularIva();
        //    }
        //}
        //public float Total
        //{
        //    get
        //    {
        //        return this.CalcularTotal();
        //    }
        //}


        public Factura()
        {
            this.listaDeProductosSolicitados = new List<Producto>();
        }
        public  Factura(int nroFactura,int nroRemito,eTipoDeFactura tipoFactura,DateTime fechaFactura,
            int nroCuit,int nroIngresosBrutos,DateTime fechaInicioActividades,bool responsableInscripto,  
            string nombreComprador, string direccionComprador, string localidadComprador,int nroCuitComprador, DateTime fechaVto,
            float subtotal,float subtotalConImpuesto, float iva, float total):this()
        {
            this.nroDeFactura = nroFactura;
            this.nroDeRemito = NroDeFactura;
            this.tipoDeFactura = tipoFactura;
            this.fechaDeFactura = fechaFactura;
            this.nroCuit = nroCuit;
            this.nroDeIngresosBrutos = nroIngresosBrutos;
            this.fechaDeFactura = fechaInicioActividades;
            this.responsableInscripto = responsableInscripto;
            this.nombreComprador = nombreComprador;
            this.direccionComprador = direccionComprador;
            this.localidadComprador = localidadComprador;
            this.NroCuitDelComprador = nroCuitComprador;
            this.fechaDeVto = fechaVto;



        }

        //public float CalcularSubtotal()
        //{
        //    float retorno = 0;
        //    foreach (Producto unProducto in this.listaDeProductosSolicitados)
        //    { 
        //        retorno =unProducto.PrecioProducto* Vendedor.Factura.dgvProductosSolicitados.
        //    }
        //    return retorno;
        //}
        //public float CalcularSubtotalConImpuesto()
        //{
        //    float retorno = 0;

        //    return retorno;
        //}
        //public float CalcularIva()
        //{
        //    float retorno = 0;

        //    return retorno;
        //}
        //public float CalcularTotal()
        //{
        //    float retorno = 0;

        //    return retorno;
        //}
    }
}
