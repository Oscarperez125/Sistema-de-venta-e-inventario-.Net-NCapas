using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NIngreso
    {
        //Metodo Insertar que llama al metodo insertar de la clase Dingreso de la capa datos

        public static string Insertar(int idtrabajador, int idproveedor, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo, decimal igv, 
            string estado, DataTable dtDetalle)
        {
            DIngreso Obj = new DIngreso();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            Obj.Estado = estado;
            List<DDetalle_Ingreso> detalle = new List<DDetalle_Ingreso>();
            foreach (DataRow row in dtDetalle.Rows)
            {
                DDetalle_Ingreso detalles = new DDetalle_Ingreso();
                detalles.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalles.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalles.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalles.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalles.Stock_Actual = Convert.ToInt32(row["stock_incial"].ToString());
                detalles.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalles.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalle.Add(detalles);
            }

            return Obj.Insertar(Obj,detalle);
        }

        //Metodo Mostrar que llama al metodo anular de la clase Dingreso de la capa datos
        public static string Anular(int idingreso)
        {
            DIngreso Obj = new DIngreso();
            Obj.Idingreso= idingreso;

            return Obj.Anular(Obj); 
        }

        //Metodo Mostrar que llama al metodo mostrar de la clase Dingreso de la capa datos

        public static DataTable Mostrar()
        {
            return new DIngreso().Mostrar();
        }

        //Metodo Buscar por fechas que llama al metodo buscar de la clase Dingreso de la capa datos

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DIngreso Obj = new DIngreso();            
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //Metodo mostrar detalle que llama al metodo buscar detalle de la clase Dingreso de la capa datos

        public static DataTable MostrarDetalle(string textobuscar)
        {
            DIngreso Obj = new DIngreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
