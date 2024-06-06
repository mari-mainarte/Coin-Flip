using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        //public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            //JogarCommand = new Command
        }

        public void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();
            Resultado = Escolha == coin.LadoSorteado ? "Você venceu" : "Você perdeu";

        }
    }  
}
