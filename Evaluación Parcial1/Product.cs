using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Parcial1
{
    public class Product
    {
        private string descripcion;
        private int id;
        private decimal precio;
        private decimal impuesto;
        public Product()
        {
            descripcion = null;
            id = 0;
            precio = 0;
            impuesto = 0;
        }
        public Product(string descripcion, int id, decimal precio, decimal impuesto )
        {
            descripcion = ValidateDescripcion(descripcion);
            id = ValidateId(id);
            precio = ValidatePrecio(precio);
            impuesto = ValidateImpuesto(impuesto);
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = ValidateDescripcion(value);
        }
        public int Id
        {
            get => id;
            set => id = ValidateId(value);
        }
        public decimal Precio
        {
            get => precio;
            set => precio = ValidatePrecio(value);
        }
        public decimal Impuesto
        {
            get => impuesto;
            set => impuesto = ValidateImpuesto(value);
        }
        public override string ToString()
        {
            return $"{Id, 4:0000}/{Precio, 5:00000}/{Impuesto, 2:00}";
        }


        private decimal ValidateImpuesto(decimal impuesto)
        {
            if(impuesto <= 0 )
            {
                throw new ArgumentException("Sin impuesto ");
            }
            return impuesto;
        }

        private decimal ValidatePrecio(decimal precio)
        {
            if (precio <= 0)
            {
                throw new ArgumentException("Precio no válido");
            }
            return precio;
        }

        private int ValidateId(int id)
        {
            if( id < 0 )
            {
                throw new ArgumentException("Id no válido");
            }
            return id;
        }

        private string ValidateDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new ArgumentException();
            }
            return descripcion;
            
        }
    }
}
