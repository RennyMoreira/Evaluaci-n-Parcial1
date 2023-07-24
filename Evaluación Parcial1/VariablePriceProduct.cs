using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Parcial1
{
    public class VariablePriceProduct
    {
        private decimal medicion;
        private int cuantitativamente;
        public VariablePriceProduct()
        {
            medicion = 0;
            cuantitativamente = 0;
        }

        public VariablePriceProduct(decimal medicion, int cuantitativamente)
        {
            medicion = ValidateMedicion(medicion);
            cuantitativamente = ValidateCuantitativamente(cuantitativamente);
        }
        public decimal Medicion
        {
            get => medicion;
            set => medicion = ValidateMedicion(value);
        }
        public int Cuantitativamente
        {
            get => cuantitativamente;
            set => cuantitativamente = ValidateCuantitativamente(value);
        }
        public override string ToString()
        {
            return $"{Cuantitativamente, 3:000}";
        }


        private int ValidateCuantitativamente(int cuantitativamente)
        {
            if(cuantitativamente < 0)
            {
                throw new ArgumentException("Sin cantidad");
            }
            return cuantitativamente;
        }

        private decimal ValidateMedicion(decimal medicion)
        {
            if(medicion <= 0)
            {
                throw new ArgumentException("Peso no válido");
            }
            return medicion;
        }
    }
}
