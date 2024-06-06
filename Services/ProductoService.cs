using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc4_leonardo.Models;

namespace pc4_leonardo.Services
{
    public class ProductoService
    {
        // Productos populares
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 3, ProductoNombre = "Camiseta Básica Blanca"  },
                new Producto { ProductoId = 5, ProductoNombre = "Jeans Ajustados Azules" },
                new Producto { ProductoId = 9, ProductoNombre = "Zapatillas Deportivas Negras" }
            };

            return result;
        }

        // Todos los productos disponibles
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Camiseta Básica Negra" },
                new Producto { ProductoId = 2, ProductoNombre = "Chaqueta de Cuero Marrón" },
                new Producto { ProductoId = 3, ProductoNombre = "Camiseta Básica Blanca" },
                new Producto { ProductoId = 4, ProductoNombre = "Vestido de Verano Rojo" },
                new Producto { ProductoId = 5, ProductoNombre = "Jeans Ajustados Azules" },
                new Producto { ProductoId = 6, ProductoNombre = "Suéter de Lana Gris" },
                new Producto { ProductoId = 7, ProductoNombre = "Falda Plisada Negra" },
                new Producto { ProductoId = 8, ProductoNombre = "Abrigo Largo Camel" },
                new Producto { ProductoId = 9, ProductoNombre = "Zapatillas Deportivas Negras" },
                new Producto { ProductoId = 10, ProductoNombre = "Sombrero de Paja Beige" }
            };

            return result;
        }
    }
}
