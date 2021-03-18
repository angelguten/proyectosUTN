using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public class Pedido
    {
        private int id_Pedido;
        private int dni_Compradador;
        private List<Producto> listaDePedido;

        public List<Producto> ListaDePedido
        {
            get
            {
                return this.listaDePedido;
            }
        }

        public static Pedido operator +(Pedido pedido,Producto unProducto)
        {
            pedido.listaDePedido.Add(unProducto);
            return pedido;       
        }
        public static Pedido operator -(Pedido pedido, Producto unProducto)
        {
            pedido.listaDePedido.Remove(unProducto);
            return pedido;
        }
    }
}
