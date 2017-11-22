using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{

    public class Juego
    {
        static string palabra;
        int intentos;
        char[] letras;

        public Juego()
        {

        }

        public string Palabra { get => palabra; set => palabra = value; }
        public int Intentos { get => intentos; set => intentos = value; }
        public char[] Letras { get => letras; set => letras = value; }

        public bool Arriesgar(string p)
        {
            bool rta = String.Equals(palabra, p);
            if (!rta)
                SumarIntento();
            return rta;
        }

        public void IngresarPalabra(string p)
        {
            Palabra = p;
            Letras = new char[Palabra.Length];
            for (int i = 0; i < Palabra.Length; i++)
            {
                Letras.SetValue('_', i);
            }
        }

        internal void SumarIntento()
        {
            Intentos++;
        }

        public bool ArriesgarLetra(char letra)
        {
            char[] arrayPalabra = Palabra.ToCharArray();
            bool rta = false;
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (letra == arrayPalabra[i])
                {
                    Letras.SetValue(letra, i);
                    rta = true;
                }
                if (!rta) SumarIntento();

            }
            return rta;
        }
    }
}
