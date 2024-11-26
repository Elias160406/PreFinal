
using PrefinalProgramacionPunto3D.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PrefinalProgramacionPunto3D.Datos
{
    public class RepositorioPuntos
    {

        private List<Punto3D> puntos;
        private string nombreArchivo = "Rombos.txt";
        private string rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public RepositorioPuntos()
        {
            puntos = new List<Punto3D>();
        }
        public int GetCantidad(Color? color = null)
        {
            if (color is null)
            {
                return puntos.Count;
            }

            return puntos.Count;
        }
        
        public void Borrar(Punto3D punto)
        {
            puntos.Remove(punto);
        }


        public bool AgregarPunto(Punto3D nuevoPunto)
        {
            if (puntos.Any(p => p.X == nuevoPunto.X && p.Y == nuevoPunto.Y && p.Z == nuevoPunto.Z))
            {
                return false;
            }

            puntos.Add(nuevoPunto);
            return true;
        }


        public int CantidadDePuntos()
        {
            return puntos.Count;
        }


        public List<Punto3D> ObtenerPuntos()
        {
            return new List<Punto3D>(puntos);
        }
        public void GuardarPuntos()
        {
            using (var escritor = new StreamWriter(rutaCompletaArchivo!))
            {
                foreach (var punto in puntos)
                {
                    string linea = ConstruirLinea(punto);
                    escritor.WriteLine(linea);
                }
            }
        }
        private List<Punto3D> LeerDatos()
        {
            var lista = new List<Punto3D>();


            if (!File.Exists(rutaCompletaArchivo))
            {
                return lista;
            }

            using (var lector = new StreamReader(rutaCompletaArchivo!))
            {
                while (!lector.EndOfStream)
                {

                    string? lineaLeida = lector.ReadLine();


                    if (!string.IsNullOrEmpty(lineaLeida))
                    {

                        Punto3D punto = ConstruirPunto(lineaLeida);


                        lista.Add(punto);
                    }
                }
            }

            return lista;
        }
        private Punto3D ConstruirPunto(string? lineaLeida)
        {
            var campos = lineaLeida!.Split(',');

            int x = int.Parse(campos[0]);
            int y = int.Parse(campos[1]);
            int z = int.Parse(campos[2]);


            string color = campos[3];


            return new Punto3D(x, y, z, color);
        }
        private string ConstruirLinea(Punto3D punto)
        {

            return $"{punto.X},{punto.Y},{punto.Z},{punto.Color}";
        }
        public List<Punto3D>? GetPuntos()
        {
            return puntos;
        }
    }


}






