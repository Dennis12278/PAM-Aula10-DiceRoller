

using DiceRoller.Models;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        
        
        
        
        private void SorteioButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                int lados = Convert.ToInt16(LadosEntry.Text);
                Dado dado = new Dado(lados);
                ResultadoLabel.Text = Convert.ToString(dado.SorteiaNumero());

                DadoImage.Source = $"dado{dado.NumeroSorteado}.png";


            }
            catch (Exception ex)
            {

            }
            /*
            //Sortear um número aleatório
            Random aleatorio = new Random();
            int numeroSorteado = aleatorio.Next(1,7);
            // Exibe os valores na tela
            resultadoLabel.Text = numeroSorteado.ToString();
            DadoImage.Source = $"dado{numeroSorteado}.png";
            
            private void LadosEntry_TextChanged(object sender, TextChangedEventArgs e)
            {
            if (string.IsNullOrEmpty(LadosEntry.Text)) return;

            if (!e.NewTextValue.All(char.IsDigit))
            {
                ((Entry)sender).Text = new string(e.NewTextValue.Where(char.IsDigit).ToArray());
            }
            */


        }
    }
}
