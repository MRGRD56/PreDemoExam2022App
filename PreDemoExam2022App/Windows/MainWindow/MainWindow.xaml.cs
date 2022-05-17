using PreDemoExam2022App.Pages.LoginPage;
using PreDemoExam2022App.Utils;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PreDemoExam2022App.Windows.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = this.GetDataContext<MainWindowViewModel>();
            App.NavigationFrame.Navigate<LoginPage>();
        }

        private void HandleMainFrameNavigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is Page page) {
                _viewModel.Title = page.Title;
            }
        }
    }
}
