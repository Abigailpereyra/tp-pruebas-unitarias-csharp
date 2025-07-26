using System;

namespace PFO2
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ProductManager();

            Console.WriteLine("=== Sistema de Gestión de Productos ===");

            var p1 = new Product(1, "Celular", 1000m, "Electrónica");
            var p2 = new Product(2, "Manzana", 20m, "Alimentos");

            manager.AddProduct(p1);
            manager.AddProduct(p2);

            Console.WriteLine("\nProductos agregados:");
            foreach (var prod in manager.GetAllProducts())
            {
                Console.WriteLine($"- {prod.Name} ({prod.Category}) - ${prod.Price}");
            }

            Console.WriteLine("\nBuscando producto por nombre: 'Manzana'");
            var encontrado = manager.FindProductByName("Manzana");
            if (encontrado != null)
            {
                var totalConImpuestos = manager.CalculateTotalPrice(encontrado);
                Console.WriteLine($"Producto encontrado: {encontrado.Name} - Precio con impuestos: ${totalConImpuestos}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}
