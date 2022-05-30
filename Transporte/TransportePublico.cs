using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public abstract class TransportePublico

    {
        private readonly int cantidadPasajeros;
        public int CantidadPasajeros => this.cantidadPasajeros; 

        public TransportePublico (int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
