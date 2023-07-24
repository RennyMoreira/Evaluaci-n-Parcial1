// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Evaluación_Parcial1;
try
{ Console.WriteLine("PRODUCTS");
    Console.WriteLine("---------------------------------------------------");
    Product producto1 = new Product()
    {
        Descripcion = "Vino Gato Negro",
        Id = 1010,
        Precio = 4600,
        Impuesto = 0.19,

    };
    Product producto2 = new Product()
    {
        Descripcion = "Pan Bimbo Artesanal",
        Id = 2020,
        Precio = 1560,
        Impuesto = 0.19,
    };
    Product producto3 = new VariablePriceProduct()
    {
        Descripcion = "Queso Holandes",
        Id = 3030,
        Medicion = "Kilo",
        Precio = 1560,
        Cuantitativamente= 0.389,
        Impuesto = 0.19,
    };
    Product producto4 = new VariablePriceProduct()
    {
        Descripcion = "Cabano",
        Id = 4040,
        Medicion = "Kilo",
        Precio = 1800,
        Cuantitativamente= 0.389,
        Impuesto = 0.19,
    };
    Product producto5 = new ComposedProduct()
    {
        Descripcion = "Ancheta 1",
        Descuento = 0.12,
        Id = 5050,
        Medicion = "Kilo",
        Product = new  List<Product> () { producto1, producto2, producto3,producto4}
    };
    Console.WriteLine(producto1);
    Console.WriteLine(producto2);
    Console.WriteLine(producto3);
    Console.WriteLine(producto4);
    Console.WriteLine(producto5);

    Invoice invoice = new Invoice();
    invoice.AddProduct(producto1);
    invoice.AddProduct(producto3);
    invoice.AddProduct(producto5);
    Console.WriteLine(invoice);


}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine("Sigo en Pie..!");