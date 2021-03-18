using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public abstract class Cliente:Persona
    {
        public enum eTipoDeCliente
        {
            Empresa,Persona
        }

        protected int id;
        protected eTipoDeCliente tipoDeCliente;
        protected string nombre;

        public abstract int ID { get; set; }
        public abstract eTipoDeCliente TipoDeCliente { get; set; }
        public abstract string Nombre { get; set; }

        public Cliente()
        { }

        public Cliente(int id, eTipoDeCliente tipoDeCliente,string nombre)
        {
            this.id = id;
            this.tipoDeCliente = tipoDeCliente;
            this.nombre = nombre;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;

            if (c1.Equals(c2))
            {
                if (c1.id == c2.id)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return (!(c1 == c2));
        }
    }
}
