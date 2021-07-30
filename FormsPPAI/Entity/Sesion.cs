using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Sesion
    {
        private int fechaFin;
        private int fechaInicio;
        private int horaFin;
        private int horaInicio;

        public int FechaFin 
        {
            get => fechaFin;
            set => fechaFin = value;
        }
        public int FechaInicio
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }
        public int HoraFin
        {
            get => horaFin;
            set => horaFin = value;
        }
        public int HoraInicio
        {
            get => horaInicio;
            set => HoraInicio = value;
        }
    }
}