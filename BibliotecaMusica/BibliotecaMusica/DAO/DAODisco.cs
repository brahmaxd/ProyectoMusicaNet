using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    class DAODisco
    {
        public static DataTable sqlLeerTodas(int cuantos, String rut, string nombre, char sexo, String apePaterno, String apeMaterno, String direccion)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            // dt= bd.sqlSelect("select * from clientes");
            String sql = "select * from disco where 1=1";
            //if (rut.Trim() != "") sql += String.Format(" and rut like '%{0}'", rut);
            //if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}'", nombre);
            //if (apePaterno.Trim() != "") sql += String.Format(" and apePaterno like '%{0}'", apePaterno);
            //if (apeMaterno.Trim() != "") sql += String.Format(" and apeMaterno like '%{0}'", apeMaterno);
            //if (direccion.Trim() != "") sql += String.Format(" and direccion like '%{0}'", direccion);
            //if (sexo != ' ') sql += String.Format(" and sexo like '%{0}'", sexo);
            //if (apeMaterno.Trim() != "") sql += String.Format(" and apeMaterno like '%{0}'", apeMaterno);
            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Disco sqlLeer(Disco disco)
        {
            String sql = "select * disco from where id = '" + disco.Id + "'";
             BD bd = Conexion.BD.getInstance();
             return disco;
        }

        public static Boolean sqlInsert(Disco disco)
        {
            String sql = "insert into disco (id, nombre) values ('" + disco.Id + "','" + disco.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return true;
        }

        public static Boolean sqlDelete(Disco disco)
        {
            String sql = "Delete from disco where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        public static Boolean sqlUpdate(Disco disco)
        {
            string sql = "update disco set nombre '" + disco.Nombre + "' where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
         
    }
}
