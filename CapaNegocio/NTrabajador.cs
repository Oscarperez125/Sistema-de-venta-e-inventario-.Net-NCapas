using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTrabajador
    {
        //Metodos para comunicarnos con la capa datos 
        //Metodo Insertar que llama al metodo insertar de la clase DTrabajador de la capa datos

        public static string Insertar(string nombre, string apellidos, string sexo,
            DateTime fechanacimiento, string num_documento, string direccion, string telefono, 
            string email, string acceso, string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.FechaNacimiento = fechanacimiento;            
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }

        //Metodo Editar que llama al metodo insertar de la clase DTrabajador de la capa datos

        public static string Editar(int idtrabajador, string nombre, string apellidos, string sexo,
            DateTime fechanacimiento, string num_documento, string direccion, string telefono,
            string email, string acceso, string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.FechaNacimiento = fechanacimiento;            
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Editar(Obj);
        }

        //Metodo Eliminar que llama al metodo insertar de la clase DTrabajador de la capa datos

        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;

            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo insertar de la clase Dtrabajador de la capa datos

        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }

        //Metodo Buscar apellidos que llama al metodo insertar de la clase Dtrabajador de la capa datos

        public static DataTable BuscarApellidos(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Metodo numero documento que llama al metodo insertar de la clase DTrabajador de la capa datos

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        //Metodo login de trabajador

        public static DataTable Login(string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
}
