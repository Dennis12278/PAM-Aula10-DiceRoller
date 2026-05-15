using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller.Models
{
    public class Dado
    {
        public Dado()
        {
            NumeroDeLados = 6;
        }

        public Dado(int numero)
        {
            NumeroDeLados = numero;
        }

        public int NumeroSorteado { get; set; }
        public int NumeroDeLados{ get; set; }

        
        public int SorteiaNumero() {
            Random aleatorio = new Random();
            NumeroSorteado = aleatorio.Next(1, NumeroDeLados + 1 );
            return NumeroSorteado;
        }
    }
}
