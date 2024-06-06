using AVFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        private string LadoEscolhido { get; set; }
        private string LadoSorteado {  get; set; }

        //Método construtor 
        public Coin()
        {
            
        }
        //Método Jogar a moeda. Retorna o lado sorteado como uma string
        public string Jogar()
        {
            LadoSorteado = (new Random().Next(2) == 0) ? "Cara" : "Coroa";
            return (LadoSorteado);
        }
       
    }
}
