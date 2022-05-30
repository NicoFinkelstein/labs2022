using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Bus : TransportePublico
    {
        public Bus(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar()
        {
           return String.Format("El Bus lleva {0} pasajeros", CantidadPasajeros);
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }

}
