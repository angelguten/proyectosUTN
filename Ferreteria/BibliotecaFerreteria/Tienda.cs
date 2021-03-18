using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public static class Tienda
    {
        public static List<Pedido> listasDePedidos;
        public static Inventario actualizacionDeInventario;

        private static List<Pedido> AgregarUnPedidoEnListasDePedidos(Pedido nuevoPedido,Inventario inventario)
        {
            foreach (Pedido pedido in listasDePedidos)
            {
                listasDePedidos.Add(nuevoPedido);
                //debo RESTAR los productos de ese PEDIDO del INVENTARIO
                inventario = Tienda.RemoverDeInventario(nuevoPedido, inventario);

                Tienda.ActualizacionDeInventario = Tienda.RemoverDeInventario(nuevoPedido, inventario);
            }

            return listasDePedidos;
        }
        public static Inventario RemoverDeInventario(Pedido unPedido,Inventario inventario )
        {
            foreach(Producto unProducto in unPedido.ListaDePedido)
            {
                if (inventario == unProducto)
                {
                    Console.WriteLine("\n\nSe pudo BORRAR el producto del Inventario\n\n");
                }
                else
                {
                    Console.WriteLine("\n\nSe pudo descontar el producto del STOCK\n\n");
                }
            }


            return inventario;
        }
        public static Inventario ActualizacionDeInventario
        {
           
            get
                {
                  return Tienda.actualizacionDeInventario;
                }
            set
            {               
                Tienda.actualizacionDeInventario = value;
            }
        }

    }
}
