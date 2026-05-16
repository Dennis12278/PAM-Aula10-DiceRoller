using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller.ViewModels
{
    public partial class DadoViewModel : ObservableObject
    {
        [ObservableProperty]
        private int qtdLados;
        [ObservableProperty]
        private int ladoSorteado;

        public DadoViewModel()
        {
           
            LadoSorteado = 0;

        }

        public void RolarUmDadeo()
        {
            Dado dado = new Dado();
            dado.SorteiaNumero();
            LadoSorteado = dado.NumeroSorteado;
        }

    }
}
