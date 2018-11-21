using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEscritorio
{
    class Notas
    {
        public string NombreDeEstudiante { get; set; }

        public string Parcial1 { get; set; }

        public string Parcial2 { get; set; }

        public string Proyecto { get; set; }

        public string Talleres { get; set; }

        public string Participacion { get; set; }

        public string Git { get; set; }

        public override string ToString()
        {
            return $"{NombreDeEstudiante};{Parcial1};{Parcial2};{Proyecto};{Talleres};{Participacion};{Git}";
        }
    }
}
