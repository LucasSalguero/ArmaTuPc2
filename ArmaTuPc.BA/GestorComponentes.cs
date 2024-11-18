using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaTuPc.BA
{
    public class GestorComponentes
    {
        public List<Procesador> CargarProcesadores()
        {
            List<Procesador> procesadores = new List<Procesador>
            {
                new Procesador("Intel")
                {
                    Modelos = new List<Componentes>
                    {
                        new Componentes("Intel Core i3-12100F", 25000),
                        new Componentes("Intel Core i5-12400F", 45000),
                        new Componentes("Intel Core i7-12700K", 90000),
                        new Componentes("Intel Core i9-12900K", 150000),
                        new Componentes("Intel Pentium Gold G6400", 1500)

                    }

                },
                new Procesador("AMD")
                {
                    Modelos = new List<Componentes>
                    {
                        new Componentes("AMD Ryzen 3 5300G", 30000),
                        new Componentes("AMD Ryzen 5 5600X", 55000),
                        new Componentes("AMD Ryzen 7 5800X", 85000),
                        new Componentes("AMD Ryzen 9 5900X", 130000),
                        new Componentes("AMD Athlon 3000G", 10000)

                    }
                }
            };
            return procesadores;
        }
        public List<Componentes> CargarPlacaMadre(string marca)
        {
            if (marca == "Intel")
            {
                return new List<Componentes>
                {
                    new Componentes("ASUS ROG Strix Z490-E Gaming", 60000),
                    new Componentes("MSI MPG Z490 Gaming Plus", 45000),
                    new Componentes("Gigabyte Z490 AORUS Elite", 50000),
                    new Componentes("ASRock Z490 Taichi", 75000),
                    new Componentes("Intel DX5580", 40000)
                };
            }
            else if (marca == "AMD")
            {
                return new List<Componentes>
                {
                    new Componentes("ASUS ROG Strix B550-F Gaming", 50000),
                    new Componentes("MSI B550 Gaming Edge WiFi", 55000),
                    new Componentes("Gigabyte B550 AORUS Elite", 45000),
                    new Componentes("ASRock B550M Steel Legend", 40000),
                    new Componentes("ASUS TUF Gaming X570-Plus", 70000)
                };
            }
            return new List<Componentes>();
        }
        public List<Componentes> CargarMemoria()
        {
            return new List<Componentes>
            {
                new Componentes("Corsair Vengeance LPX 8GB DDR4 2400MHz", 5500),
                new Componentes("G.Skill Ripjaws V 16GB DDR4 3200MHz", 12000),
                new Componentes("Kingston HyperX Fury 32GB DDR4 2666MHz", 24000),
                new Componentes("Crucial Ballistix 16GB DDR4 3000MHz", 11800),
                new Componentes("ADATA XPG GAMMIX D30 8GB DDR4 3200MHz", 5200)
            };
        }
        public List<Componentes> CargarAlmacenamiento()
        {
            return new List<Componentes>
            {
                new Componentes("Seagate Barracuda 1TB HDD", 9000),
                new Componentes("WD Blue 2TB HDD", 12500),
                new Componentes("Samsung 970 EVO Plus 500GB NVMe SSD", 18000),
                new Componentes("Crucial MX500 1TB SSD", 15000),
                new Componentes("Kingston A2000 1TB NVMe SSD", 14500)
            };
        }
        public List<Componentes> CargarGPU()
        {
            return new List<Componentes>
            {
                new Componentes("NVIDIA GeForce GTX 1660 Super", 45000),
                new Componentes("AMD Radeon RX 580 8GB", 40000),
                new Componentes("NVIDIA GeForce RTX 3060 12GB", 90000),
                new Componentes("AMD Radeon RX 6700 XT", 115000),
                new Componentes("NVIDIA GeForce RTX 3080 10GB", 18000)
            };
        }
        public List<Componentes> CargarFuente()
        {
            return new List<Componentes>
            {
                new Componentes("Corsair CV450 450W 80 Plus Bronze", 10000),
                new Componentes("Cooler Master MWE 550W 80 Plus Bronze", 12000),
                new Componentes("Thermaltake Smart 600W 80 Plus", 11500),
                new Componentes("EVGA 600 W1 600W", 13000),
                new Componentes("Antec VP650 650W 80 Plus", 14000)
            };
        }
        public List<Componentes> CargarGabinete()
        {
            return new List<Componentes>
            {
                new Componentes("Cooler Master MasterBox Q300L", 12000),
                new Componentes("Thermaltake Versa H21", 10500),
                new Componentes("NZXT H510", 15000),
                new Componentes("Gigabyte C200 GLASS", 11000),
                new Componentes("Corsair Carbide Series 275R", 14000),
            };
        }
    }
}
