using System.Windows;
using Microsoft.Windows.Controls.Ribbon;
using NFe.View;
using NFe.ViewModel;

namespace NFe.View
{

    public partial class NFeMenu : RibbonWindow
    {
        ViewModelBase ViewModel = new ViewModelBase();
        public static Window JanelaLogin;
        public static Window JanelaSpedFiscal;

        public NFeMenu()
        {
            InitializeComponent();
            dockModulo.Children.Clear();
            dockModulo.Children.Add(new NFePrincipal());
            DoLogin();
        }

        private void DoLogin()
        {
            /*
            Login Janela = new Login();
            Window Window = new Window()
            {
                Title = "Login",
                ShowInTaskbar = false,
                Topmost = false,
                ResizeMode = ResizeMode.NoResize,
                Width = 450,
                Height = 230,
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen
            };
            Window.Content = Janela;
            JanelaLogin = Window;
            Window.ShowDialog();

            if (Login.Logado == false)
            {
                MessageBox.Show("Aplicação será Encerrada.", "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                Application.Current.Shutdown();
            }
             */ 
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair do Sistema?", "Sair do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void BotaoNFe_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.NovaPagina(new NFeView(), "Nota Fiscal Eletrônica");
        }

        private void BotaoSpedFiscal_Click(object sender, RoutedEventArgs e)
        {
            /*
            SpedFiscalPrincipal janela = new SpedFiscalPrincipal();
            Window window = new Window()
            {
                Title = "Sped Fiscal",
                ShowInTaskbar = false,
                Topmost = false,
                ResizeMode = ResizeMode.NoResize,
                Width = 510,
                Height = 390,
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen
            };
            window.Content = janela;
            JanelaSpedFiscal = window;
            window.ShowDialog();
             */ 
        }



        // EXERCICIO
        // Busque em todo o projeto:
        // Verifique se a camada View está sendo devidamente preenchida com propriedades ou comandos, expostos pela ViewModel. Corrija o que for necessário.
        // Verifique se a ViewModel está referenciando a View, pois a ViewModel não deve ter conhecimento sobre a View. Corrija o que for necessário.


    }
}
