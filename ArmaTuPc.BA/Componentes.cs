using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaTuPc.BA
{
    public class Componentes
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Componentes(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;

        }
        public override string ToString()
        {
            return $"{Nombre} - ${Precio}";
        }
    }

    public class PC
    {
        public Componentes Procesador { get; set; }
        public Componentes PlacaMadre { get; set; }
        public Componentes RAM { get; set; }
        public Componentes Almacenamiento { get; set; }
        public Componentes GPU { get; set; }
        public Componentes FuentePoder { get; set; }
        public Componentes Gabinete { get; set; }
        public decimal PrecioTotal()
        {
            decimal total = 0;
            if (Procesador != null) total += Procesador.Precio;
            if (PlacaMadre != null) total += PlacaMadre.Precio;
            if (RAM != null) total += RAM.Precio;
            if (Almacenamiento != null) total += Almacenamiento.Precio;
            if (GPU != null) total += GPU.Precio;
            if (FuentePoder != null) total += FuentePoder.Precio;
            if (Gabinete != null) total += Gabinete.Precio;
            return total;
        }
        public string Resumen()
        {
            return $"Configuración de la PC:\n" +
               $"Procesador: {Procesador?.ToString()}\n" +
               $"Placa Madre: {PlacaMadre?.ToString()}\n" +
               $"RAM: {RAM?.ToString()}\n" +
               $"Almacenamiento: {Almacenamiento?.ToString()}\n" +
               $"GPU: {GPU?.ToString()}\n" +
               $"Fuente de Poder: {FuentePoder?.ToString()}\n" +
               $"Gabinete: {Gabinete?.ToString()}\n" +
               $"Precio Total: ${PrecioTotal()}";
        }
    }

}
