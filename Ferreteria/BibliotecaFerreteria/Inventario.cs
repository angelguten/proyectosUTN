using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFerreteria
{
    public class Inventario
    {
        private List<Producto> listaDeProductos;
        public int CANTIDAD;


        public List<Producto> ListaProductos
        {
            get
            {
                return this.listaDeProductos;
            }
            //set
            //{
            //    //value= new List<Producto>();
            //    this.listaDeProductos = new List<Producto>();// value;
            //}
        }

        public Inventario()
        {
            this.listaDeProductos =new List<Producto>(); //this.ListaProductos;
        }

        public Inventario AgregarProducto(Producto unProducto)
        {
            if (this == unProducto)
            {
               unProducto.StockDeProducto++;
              
            }
            else
            {
                this.listaDeProductos.Add(unProducto);
            }


            return this;
        }
        public static List<Producto> RemoverProducto(List<Producto> lista, Producto unProducto)
        {
            unProducto.StockDeProducto--;
            lista.Remove(unProducto);
            return lista;
        }

    
        public static bool operator ==(Inventario inventario, Producto unProducto)
        {
            bool esIgual = false;

            foreach (Producto producto in inventario.ListaProductos)//pide buscar por nombre,...pero podria buscar por ID PRODUCTO
            {
                //if ((producto.NombreDeProducto == unProducto.NombreDeProducto) && (producto.AmbitoRecomendado == unProducto.AmbitoRecomendado)&& (producto.MarcaDeProducto == unProducto.marcaDeProducto) && (producto.UsuarioRecomendado == unProducto.UsuarioRecomendado)&& (producto.NombreProducto == unProducto.NombreProducto) && (producto.TipoDeProducto == unProducto.TipoDeProducto))
                if (producto == unProducto)
                {
                    esIgual = true;
                
                if (unProducto.StockDeProducto != 0)
                    {
                        producto.StockDeProducto=producto.StockDeProducto + unProducto.StockDeProducto;
                        
                    }
                if (unProducto.StockDeProducto == 0)
                    {
                        //inventario.listaDeProductos.Add(unProducto);
                        inventario.listaDeProductos.Remove(unProducto);
                        //producto = null;
                    }
                    //else
                    //{
                    //    //    // esIgual = true;
                    //    //    unProducto.ToString();
                    //   //inventario.listaDeProductos.Remove(unProducto);//Inventario.RemoverProducto(lista,unProducto);

                    //}

                }
                //else
                //{
                //    inventario.listaDeProductos.Add(unProducto);//Inventario.AgregarProducto(lista,unProducto);
                //}
            }
           
            return esIgual;
        }
        public static bool operator !=(Inventario inventario, Producto unProducto)
        {
            return (!(inventario == unProducto));
        }


    }
}
