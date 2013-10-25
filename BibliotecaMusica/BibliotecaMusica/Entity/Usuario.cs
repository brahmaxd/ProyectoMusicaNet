using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    class Usuario
    {
        private String usuario;
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private int esAdmin;

        public int EsAdmin
        {
            get { return esAdmin; }
            set { esAdmin = value; }
        }

        public Usuario()
        {
            Usuario = "";

        }
        public Usuario(String usuario, String clave, int esAdmin)
        {
            Usuario = usuario;
            Clave = clave;
            EsAdmin = esAdmin;
        }
    }
}

    }
}
/*
 * -﻿using System;
-using System.Collections.Generic;
-using System.Linq;
-using System.Text;
-
-namespace BibliotecaMusica.Entity
-{
-    class Usuarios
-    {
-        
-
-        public String Usuario
-        {
-            get { return usuario; }
-            set { usuario = value; }
-        }
-        private String clave;
-
-        public String Clave
-        {
-            get { return clave; }
-            set { clave = value; }
-        }
-        private int esAdmin;
-
-        public int EsAdmin
-        {
-            get { return esAdmin; }
-            set { esAdmin = value; }
-        }
-
-        public Usuarios()
-        {
-            Usuario = "";
-
-        }
-        public Usuarios(String usuario, String clave, int esAdmin)
-        {
-            Usuario = usuario;
-            Clave = clave;
-            EsAdmin = esAdmin;
-        }
-    }
-}
 * */
