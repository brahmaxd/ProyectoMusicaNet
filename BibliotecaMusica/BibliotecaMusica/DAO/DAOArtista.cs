using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    class DAOArtista
    {
        public static DataTable sqlLeerTodas(int cuantos, int id, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
           
            String sql = "select * from artista where 1=1";
            if (id.Trim() != "") sql += String.Format("and rut like '%{0}'", rut);
            if (nombre.Trim != "") sql += String.Format("and nombre like '%{0}'", nombre);
            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Disco sqlLeer(Artista artista)
        {
            String sql = "select * disco from where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return disco;
        }

        public static Boolean sqlInsert(Artista artista)
        {
            String sql = "insert into disco (id, nombre) values ('" + artista.Id + "','" + artista.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return true;
        }

        public static Boolean sqlDelete(Artista artista)
        {
            String sql = "Delete from disco where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        public static Boolean sqlUpdate(Artista artista)
        {
            string sql = "update disco set nombre '" + artista.Nombre + "' where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        //No se si esta bien el Leer todos
    }

}
