using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BibliotecaFerreteria
{
    //public delegate double delegadoCalcularImporte(double valor);

    public abstract class Producto
    {
        //public delegate double delegadoCalcularImporte(double valor);

        #region ENUMERADOS
        public enum Ambito
        {
            Profesional, Hogar
        }
        public enum Usuario
        {
            Principiante, Experimentado, Experto
        }
        public enum eProcedencia
        {
            Importado,Nacional
        }
        #endregion

        #region ATRIBUTOS

        protected Ambito ambito;
        protected Usuario usuario;
        protected eProcedencia procedenciaDeProducto;

        public string tipoDeProducto;
        public string marcaDeProducto;
        protected int idDeProducto;
        protected string nombreDeProducto;

        protected double precioDeProducto;
        protected int cantidadDeProductos;
        protected double ivaDeProducto;
        protected double impuestoDeProducto;
        protected double subtotalConImpuesto;
        protected double total;

        protected int stockDeProducto;

        #endregion

        #region PROPIEDADES

        public abstract Ambito AmbitoRecomendado { get; set; }
        public abstract Usuario UsuarioRecomendado { get; set; }
        public abstract eProcedencia ProcedenciaDeProducto { get; set; }

        public abstract string TipoDeProducto { get; set; }
        public abstract string NombreDeProducto { get; set; }
        public abstract string MarcaDeProducto { get; set; }

        public abstract int IdDeProducto { get; set; }
        public abstract double PrecioDeProducto { get; set; }
        public abstract int CantidadDeProductos { get; set; }
        public abstract double IvaDeProducto { get; set; }
        public abstract double ImpuestoDeProducto { get; set; }
        public abstract double SubtotalConImpuesto { get; set; }
        public abstract double Total { get; set; }

        public abstract int StockDeProducto { get; set; }

        #endregion
        public Producto()
        {

        }
        public Producto(int idProducto, string nombre, double precio, int cantidad, double iva,
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

        #region METODOS
        /// <summary>
        /// El metodo abstracto llamado CalcularMargenGanancias:
        /// En las clases hijas, devolverá la ganancia calculada
        /// teniendo en cuenta el precio del producto y
        /// los siguientes márgenes de gananciaserán:
        /// Clase 1: 10%
        /// Clase 2: 13%
        /// Clase 3: 16%
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularMargenGanancias();
        public abstract string InstruccionesDeUso();

        public abstract double CalcularIva(double precio);
        public abstract double CalcularImpuesto(double precio);
        public abstract double CalcularSubtotalConImpuesto();
        public abstract double CalcularTotal();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ID Producto: " + this.idDeProducto);
            sb.AppendLine("Nombre: " + this.nombreDeProducto);
            sb.AppendLine("Ambito: " + this.ambito);
            sb.AppendLine("Usuario: " + this.usuario);
            sb.AppendLine("Precio: " + this.precioDeProducto);
            sb.AppendLine("IVA: " + this.ivaDeProducto);
            sb.AppendLine("Impuesto: " + this.impuestoDeProducto);
            sb.AppendLine("SubTotal con Impuesto: " + this.subtotalConImpuesto);
            sb.AppendLine("Total: " + this.total );
            sb.AppendLine("Stock: " + this.stockDeProducto);


            return sb.ToString();
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1.Equals(p2))
            {
                if (p1.idDeProducto==p2.idDeProducto)
                {
                    retorno = true;
                }  
            }
            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return (!(p1 == p2));
        }
        public static Producto operator +(Producto p1, Producto p2)
        {
            if (p1==p2)
            {
                p1.stockDeProducto += p2.CantidadDeProductos;
            }
            return p1;
        }
        public static Producto operator -(Producto p1, Producto p2)
        {
            if (p1 == p2)
            {
                p1.stockDeProducto -= p2.CantidadDeProductos;
            }
            return p1;
        }
        #endregion
    }
}
