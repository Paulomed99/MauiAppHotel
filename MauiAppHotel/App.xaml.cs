using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                descricao = "Suíte Super Luxo",
                valorDiariaAdulto = 110.0,
                valorDiariaCrianca = 55.0,
                caminhoFotoQuarto = "superluxo.jpg",
                maxAdultos = 6,
                maxCriancas = 2,
            },
            new Quarto()
            {
                descricao = "Suíte Luxo",
                valorDiariaAdulto = 80.0,
                valorDiariaCrianca = 40.0,
                caminhoFotoQuarto = "luxo.jpg",
                maxAdultos = 4,
                maxCriancas = 2,
            },
            new Quarto()
            {
                descricao = "Suíte Single",
                valorDiariaAdulto = 50.0,
                valorDiariaCrianca = 25.0,
                caminhoFotoQuarto = "single.jpg",
                maxAdultos = 2,
                maxCriancas = 1,
            },
            new Quarto()
            {
                descricao = "Suíte Crise",
                valorDiariaAdulto = 25.0,
                valorDiariaCrianca = 12.5,
                caminhoFotoQuarto = "crise.jpg",
                maxAdultos = 2,
                maxCriancas = 1,
            }
        };
              

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new AppShell());

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}