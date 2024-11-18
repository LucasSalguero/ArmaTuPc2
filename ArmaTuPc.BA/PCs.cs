using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaTuPc.BA
{
    public class PCsArmada
    {
        public DataTable ListaPC { get; set; }

        public PCsArmada()
        {
            ListaPC = new DataTable();
            ListaPC.TableName = "Productos";
            ListaPC.Columns.Add("Procesador");
            ListaPC.Columns.Add("Placa Madre");
            ListaPC.Columns.Add("Memoria RAM");
            ListaPC.Columns.Add("Almacenamiento");
            ListaPC.Columns.Add("GPU");
            ListaPC.Columns.Add("Fuente de poder");
            ListaPC.Columns.Add("Gabinete");
            ListaPC.Columns.Add("Precio Total");

            LeerArchivo();
        }
        private void LeerArchivo()
        {
            if (System.IO.File.Exists("PCsArmada.xml"))
            {
                ListaPC.ReadXml("PcsArmada.xml");
            }
        }

        public void Insert(PC componentes)
        {
            ListaPC.Rows.Add();
            int NuevoRenglon = ListaPC.Rows.Count - 1;
            ListaPC.Rows[NuevoRenglon]["Procesador"] = componentes.Procesador;
            ListaPC.Rows[NuevoRenglon]["Placa Madre"] = componentes.PlacaMadre;
            ListaPC.Rows[NuevoRenglon]["Memoria Ram"] = componentes.RAM;
            ListaPC.Rows[NuevoRenglon]["Almacenamiento"] = componentes.Almacenamiento;
            ListaPC.Rows[NuevoRenglon]["GPU"] = componentes.GPU;
            ListaPC.Rows[NuevoRenglon]["Fuente de Poder"] = componentes.FuentePoder;
            ListaPC.Rows[NuevoRenglon]["Gabinete"] = componentes.Gabinete;


            decimal total = componentes.Procesador.Precio + componentes.PlacaMadre.Precio +
                   componentes.RAM.Precio + componentes.Almacenamiento.Precio +
                   componentes.GPU.Precio + componentes.FuentePoder.Precio +
                   componentes.Gabinete.Precio;

            ListaPC.Rows[NuevoRenglon]["Precio Total"] = total;


            ListaPC.WriteXml("PcsArmada.xml");
        }
    }
}
