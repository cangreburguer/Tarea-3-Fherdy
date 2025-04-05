
using System;
using System.Collections.Generic;
using T3_Crud.Models;

namespace T3_Crud.Logic
{
    public class Crud
    {
        private List<Producto> productos = new List<Producto>();

        public void Crear(string nombre, double precio)
        {
            productos.Add(new Producto
            {
                Id = productos.Count + 1,
                Nombre = nombre,
                Precio = precio
            });
        }

        public List<Producto> Leer()
        {
            if (productos.Count == 0)
            {
                string[] nombres = { "Leche", "Coca Cola", "Jugo", "Lays", "Pan", "Agua", "Galletas", "Yogur", "Cereal", "Snickers" };
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    string nombre = nombres[rnd.Next(nombres.Length)];
                    double precio = Math.Round(rnd.NextDouble() * 10 + 1, 2);
                    Crear(nombre, precio);
                }
            }

            return productos;
        }

        public bool Actualizar(int id, string nombre, double precio)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.Precio = precio;
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto != null)
            {
                productos.Remove(producto);
                return true;
            }
            return false;
        }
    }
}