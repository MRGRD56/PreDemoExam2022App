using PreDemoExam2022App.Common.Common;
using PreDemoExam2022App.Common.Events;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Services;
using PreDemoExam2022App.Mvvm;
using PreDemoExam2022App.Pages.LoginPage;
using PreDemoExam2022App.Utils;

namespace PreDemoExam2022App.Windows.MainWindow
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly AppAuthService _appAuthService = Singleton<AppAuthService>.GetInstance();

        private string _title = "App";

        public MainWindowViewModel()
        {
            //_appAuthService.OnAuth += HandleAuth;
        }

        public AppAuthService Auth => _appAuthService;

        //private void HandleAuth(object sender, AppAuthEventArgs e)
        //{
        //    OnPropertyChanged(nameof(User));
        //}

        //public User User
        //{
        //    get => _appAuthService.User;
        //    set => _appAuthService.User = value;
        //}

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public Command<object> LogoutCommand => new(_ =>
        {
            Auth.User = null;
            App.NavigationFrame.Navigate<LoginPage>();
        }, _ => Auth.IsAuthenticated);

        public Command<object> GoBackCommand => new(_ => 
        {
            App.NavigationFrame.GoBack();
        }, _ => App.NavigationFrame?.CanGoBack == true);
    }
}
