using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaTuPc.BA
{
    public class Procesador
    {
        public string Marca { get; set; }
        public List<Componentes> Modelos { get; set; }
        public Procesador(string marca)
        {
            Marca = marca;
            Modelos = new List<Componentes>();
        }
    }
}
