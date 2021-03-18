using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    
    //public double delegate delegadoCalcularImporte();
    public class Pinturas:Producto
    {
        #region PROPIEDADES
        public override Ambito AmbitoRecomendado
        {
            get
            {
                return this.ambito;
            }
            set
            {
                this.ambito = value;
            }
        }
        public override Usuario UsuarioRecomendado
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }
        public override eProcedencia ProcedenciaDeProducto
        {
            get
            {
                return this.procedenciaDeProducto;
            }
            set
            {
                this.procedenciaDeProducto = value;
            }
        }

        public override string TipoDeProducto
        {
            get
            {
                return this.tipoDeProducto;
            }

            set
            {
                this.tipoDeProducto = value;
            }
        }
        public override string NombreDeProducto
        {
            get
            {
                return this.nombreDeProducto;
            }
            set
            {
                this.nombreDeProducto = value;
            }
        }
        public override string MarcaDeProducto
        {
            get
            {
                return this.marcaDeProducto;
            }

            set
            {
                this.marcaDeProducto = value;
            }
        }

        public override int IdDeProducto
        {
            get
            {
                return this.idDeProducto;
            }
            set
            {
                this.idDeProducto = value;
            }
        }

        public override double PrecioDeProducto
        {
            get
            {
                return this.precioDeProducto;
            }
            set
            {
                this.precioDeProducto = value;
            }
        }
        public override int CantidadDeProductos
        {
            get
            {
                return this.cantidadDeProductos;
            }
            set
            {
                this.cantidadDeProductos = value;
            }
        }
        public override double IvaDeProducto
        {
            get
            {
                return this.CalcularIva(this.PrecioDeProducto);
            }
            set
            {
                this.ivaDeProducto = value;
            }
        }
        public override double ImpuestoDeProducto
        {
            get
            {
                return this.CalcularImpuesto(this.PrecioDeProducto);
            }
            set
            {
                this.impuestoDeProducto = value;
            }
        }
        public override double SubtotalConImpuesto
        {
            get
            {
                return this.CalcularSubtotalConImpuesto();
            }
            set
            {
                this.subtotalConImpuesto = value;
            }
        }
        public override double Total
        {
            get
            {
                return this.CalcularTotal();
            }
            set
            {
                this.total = value;
            }
        }

        public override int StockDeProducto
        {
            get
            {
                return this.stockDeProducto;
            }
            set
            {
                this.stockDeProducto = value;
            }
        }

        #endregion

        #region CONSTRUCTORES
        public Pinturas()
        { }
        public Pinturas(Usuario usuario, Ambito ambito):this()
        {
            this.usuario = usuario;
            this.ambito = ambito;
        }
        /// <summary>
        /// protected int idProducto;
        ///protected float precio;
        ///protected int stock;
        /// </summary>
        public Pinturas(Usuario usuario, Ambito ambito,string tipoDeProducto,string nombreDeProducto,string marcaDeProducto,int idProducto,
            double precio, int stock):this(usuario,ambito)
        {
            this.tipoDeProducto = tipoDeProducto;
            this.nombreDeProducto = nombreDeProducto;
            this.marcaDeProducto = marcaDeProducto;

            this.idDeProducto = idProducto;
            this.precioDeProducto = precio;
            //this.ivaDeProducto = this.IvaDeProducto;
            //this.impuestoDeProducto = this.ImpuestoDeProducto;
            //this.subtotalConImpuesto = this.SubtotalConImpuesto;
            //this.total = this.Total;
            this.stockDeProducto = stock;
        }

        public Pinturas(int idProducto, string nombre, double precio, int cantidad, double iva,
                            double impuesto, double subtotalConImpuesto, double total, int stock)
        {
            this.idDeProducto = idProducto;
            this.nombreDeProducto = nombre;
            this.cantidadDeProductos = cantidad;
            this.precioDeProducto = precio;
            this.ivaDeProducto = iva;
            this.impuestoDeProducto = impuesto;
            this.subtotalConImpuesto = subtotalConImpuesto;
            this.total = total;
        }

        #endregion

        #region METODOS
        /// La Propiedad abstracta llamada CalcularMargenGanancias:
        /// En las clases hijas, devolverá la ganancia calculada
        /// teniendo en cuenta el precio del producto y
        /// los siguientes márgenes de gananciaserán:
        /// Clase 1: 10%
        /// Clase 2: 13%
        /// Clase 3: 16%
        /// </summary>
        /// <returns></returns>
        public override double CalcularMargenGanancias()
        {
            return this.precioDeProducto * 0.16;
        }
        public override string InstruccionesDeUso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\n\n Se recomienda que el procuto {0} ID {1} sea utilizado a nivel {2} por un {3}\n\n", this.nombreDeProducto, this.idDeProducto, this.ambito, this.ambito, this.usuario);
            return sb.ToString();
        }

        public override string ToString()
        {
           
            return base.ToString();
        }

        public override double CalcularIva(double precio)
        {
            return this.precioDeProducto * 0.21;
        }
        public override double CalcularImpuesto(double precio)
        {
            return this.precioDeProducto * 0.35;
        }

        public override double CalcularSubtotalConImpuesto()
        {
            return this.precioDeProducto + this.ImpuestoDeProducto + this.IvaDeProducto;
        }

        public override double CalcularTotal()
        {
            double retorno = 0;

            if (this.ProcedenciaDeProducto == eProcedencia.Nacional)
            {
                retorno = this.PrecioDeProducto + this.IvaDeProducto;
            }
            if(this.ProcedenciaDeProducto == eProcedencia.Importado)
            {
                retorno = this.CalcularSubtotalConImpuesto();
            }
                
            return retorno;
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES
        public override bool Equals(object obj)
        {
            return (obj is Pinturas);
        }
        #endregion
    }
}
