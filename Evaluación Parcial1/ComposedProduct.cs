using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Parcial1
{
    public class ComposedProduct
    {
        private string producto;
        private decimal descuento;

        public ComposedProduct()
        {
            descuento = 0;
            producto = null;
        }
        public ComposedProduct(decimal descuento, string producto);
        {
            producto = private ValidateProducto(producto);
            descuento = private ValidateDescuento(descuento);
        }
        public string Producto
        {
        get => producto;
        set => producto = ValidateProducto(value);
         }
         public decimal Descuento
         {
        get => descuento;
        set => descuento = ValidateDescuento(value);
         }
    private string  ValidateProducto(string producto)
    {
        if (string.IsNullOrEmpty(producto));
        {
            throw new ArgumentException("Producto no válido");
        }
        return producto;
    }
    private decimal ValidateDescuento(string descuento)
    {
        if (descuento >= 0) ;
        {
            throw new ArgumentException("Descuento no válido");
        }
        return descuento;
    }


}
}
