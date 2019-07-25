using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NVenta
    {
        //Metodo Insertar que llama al metodo insertar de la clase Dventa de la capa datos

        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo, decimal igv,
            DataTable dtDetalle)
        {
            DVenta Obj = new DVenta();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            List<DDetalle_Venta> detalle = new List<DDetalle_Venta>();
            foreach (DataRow row in dtDetalle.Rows)
            {
                DDetalle_Venta detalles = new DDetalle_Venta();
                detalles.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalles.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalles.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalles.Descuento = Convert.ToDecimal(row["descuento"].ToString());                
                detalle.Add(detalles);
            }

            return Obj.Insertar(Obj, detalle);
        }

        //Metodo Mostrar que llama al metodo eliminar de la clase Dingreso de la capa datos
        public static string Eliminar(int idventa)
        {
            DVenta Obj = new DVenta();
            Obj.Idventa = idventa;

            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo mostrar de la clase Dventa de la capa datos

        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }

        //Metodo Buscar por fechas que llama al metodo buscar de la clase Dventa de la capa datos

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //Metodo mostrar detalle que llama al metodo buscar detalle de la clase Dventa de la capa datos

        public static DataTable MostrarDetalle(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarDetalle(textobuscar);
        }

        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        }

        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticulo_Venta_Codigo(textobuscar);
        }
    }
}
