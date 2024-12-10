using static System.Net.Mime.MediaTypeNames;

namespace JogarMoeda
{
    public partial class MainPage : ContentPage
    {
        private object cara;

        public MainPage()
        {
            InitializeComponent();
        }

        class Moeda
        {
            private string ladoSorteado;
                public string ladoSprte {  get; set; }

            
           
        }

         public void SortearLado(string ladoSorteado)
        {
            int lado = new Random().Next(2);

            if (lado == 0) ladoSorteado = "cara";

            else ladoSorteado = "coroa";
        }

     

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            Moeda moeda = new Moeda();
            String selecao = SelecionarPicker.ItemsSource.ToString();

            if (selecao == moeda.ladoSorteado)

                Label.Resultado.text = $"Parabens, voce escolheu {cara} e deu {moeda.ladoSorteado}";
        else
                Label.Resultado.text = $"Que pena";
            Moeda.Image.Sauere = $"{moeda.ladoSorteado}.jpg";
        }

      //  private string 
    }

}
