using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public abstract class Persona
    {
        protected int dni;
        //protected string nombre;
        protected string direccion;
        protected string localidad;
        //private int nroDeCuit;
        //public override int ID
        //{
        //    get
        //    {
        //       return  base.id;
        //    }
        //    set
        //    {
        //        base.id=value;
        //    }
        //}
        //public override eTipoDeCliente TipoDeCliente
        //{
        //    get
        //    {
        //        return base.tipoDeCliente ;
        //    }
        //    set
        //    {
        //       base.tipoDeCliente=value ;
        //    }
        //}
        public abstract int Dni { get; set; }

        //public override string Nombre
        //{
        //    get
        //    {
        //        return this.nombre;
        //    }
        //    set
        //    {
        //        base.nombre = value;
        //    }

        //}

        public abstract string Direccion { get; set; }

        public abstract string Localidad { get; set; }

        //public abstract int NroCuit { get; set; }
        public Persona()
        { }
        public Persona(int dni, string nombre, string direccion, string localidad):this()
           //int nroDeCuit)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
            this.localidad = localidad;
            //this.nroDeCuit = nroDeCuit;

        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.dni.ToString());
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.direccion);
            sb.AppendLine(this.localidad);
            //sb.AppendLine(this.nroDeCuit.ToString());

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            bool retorno = false;

            if (p1.Equals(p2))
            {
                if (p1.Dni == p2.Dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return (!(p1==p2));
        }

        public override bool Equals(object obj)
        {
            return(obj is Persona);
        }
    }
}
