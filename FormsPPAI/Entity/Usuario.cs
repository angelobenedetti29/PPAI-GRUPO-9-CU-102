using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Usuario
    {
        private int caducidad;
        private int contraseña;
        private int nombre;

        public int Caducidad
        {
            get => caducidad;
            set => caducidad = value;
        }
        public int Contraseña
        {
            get => contraseña;
            set => contraseña = value;
        }
        public int Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}