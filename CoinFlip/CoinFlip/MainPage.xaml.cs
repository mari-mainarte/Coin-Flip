namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            CoinPicker.SelectedIndex = 0;
        }

        private void CoinBtn_Clicked(object sender, EventArgs e)
        {
            int randomCoin = new Random().Next(0, 2);
            if (randomCoin == 0){
                CoinImage.Source = "cara.png";
                if (CoinPicker.SelectedIndex == 0)
                {
                    UserMessage.Text = "Você venceu!";
                }
                else
                {
                    UserMessage.Text = "Você perdeu!";
                }
            }else if (randomCoin == 1)
            {
                CoinImage.Source = "coroa.png";
                if (CoinPicker.SelectedIndex == 1)
                {
                    UserMessage.Text = "Você venceu!";
                }
                else
                {
                    UserMessage.Text = "Você perdeu!";
                }
            }
        }
    }

}
