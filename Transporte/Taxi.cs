using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Taxi : TransportePublico
    {
        
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
            
        }

        public override string Avanzar()
        {
            return $"El taxi carga a {CantidadPasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }

    }

}

