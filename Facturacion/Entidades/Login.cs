﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public string CodigoUsuario { get; set; }

        public  string Contraseña { get; set; }

        public  string Rol { get; set; }

        public Login()
        {
        }

        public Login(string codigoUsuario, string contraseña, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
