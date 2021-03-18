using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public class Vendedor:Persona
    {
        public override int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni= value;
            }

        }
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
        public override string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }

        }
        public override string Localidad
        {
            get
            {
                return this.localidad;
            }
            set
            {
                this.localidad = value;
            }

        }

        //public override int NroCuit
        //{
        //    get
        //    {
        //        return this.nroDeCuit;
        //    }
        //    set
        //    {
        //        this.nroDeCuit = value;
        //    }

        //}
       public Vendedor(int dni,string nombre,string direccion,string localidad):base(dni,nombre,direccion,localidad)
        {

        }


    }
}
