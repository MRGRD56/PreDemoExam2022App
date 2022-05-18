using PreDemoExam2022App.Common.Common;
using PreDemoExam2022App.Common.Exceptions;
using PreDemoExam2022App.Common.Services;
using PreDemoExam2022App.Mvvm;
using PreDemoExam2022App.Utils;
using System.Windows;
using System.Windows.Controls;

namespace PreDemoExam2022App.Pages.LoginPage
{
    internal class LoginPageViewModel : ViewModel
    {
        private readonly AppAuthService _appAuthService = Singleton<AppAuthService>.GetInstance();

        public string Login { get; set; } = "";

        public Command<PasswordBox> LoginCommand => new(async passwordBox =>
        {
            var login = Login.Trim();
            var password = passwordBox.Password;

            var user = await _appAuthService.AuthenticateUserAsync(login, password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            App.NavigationFrame.Navigate<UsersPage.UsersPage>();
        });
    }
}
