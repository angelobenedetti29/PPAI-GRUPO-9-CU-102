using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Tarifa
    {
        private int montoAdicionalGuia;
        
        public int MontoAdicionalGuia
        {
            get => montoAdicionalGuia;
            set => montoAdicionalGuia = value;
        }
    }
}
