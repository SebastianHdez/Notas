using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VentasEscritorio
{
    class GuardadoDeArchivos
    {
        public const string RUTA = @"D:\Temporal\Notas.txt";

        public static bool Guardar(Notas Notas)
        {
            FileInfo archivo = new FileInfo(RUTA);
            if (archivo.Exists == false)
            {
                FileStream nuevoFs = archivo.Create();
                StreamWriter nuevoWriter = new StreamWriter(nuevoFs);
                nuevoWriter.Write("");
                nuevoWriter.Flush();
                nuevoWriter.Close();
                nuevoFs.Close();
            }
            StreamWriter writer = archivo.AppendText();
            writer.WriteLine(Notas.ToString());
            writer.Flush();
            writer.Close();

            return true;
        }


        public static List<Notas> Obtener()
        {
            List<Notas> lasNotas = new List<Notas>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Notas nuevo = new Notas
                {
                    NombreDeEstudiante = datos[0],
                    Parcial1 = datos[1],
                    Parcial2 = datos[2],
                    Proyecto = datos[3],
                    Talleres = datos[4],
                    Participacion = datos[5],
                    Git = datos[6],
                };
                lasNotas.Add(nuevo);
            }
            file.Close();
            return lasNotas;
        }
    }
}
