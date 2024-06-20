using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

        //ICommand - cria um comando
        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }


        public void Jogar()
        {
            //cria uma moeda
            Coin coin = new Coin();
            
            //chama o método jogar da moeda
            coin.Jogar();

            Imagem = $"{coin.LadoSorteado}.png";

            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "\nVocê venceu\n";
            }
            else
            {
                Resultado = "\nVocê perdeu\n";
            }


        }
    }  
}
