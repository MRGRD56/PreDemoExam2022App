using PreDemoExam2022App.Common.Common;
using PreDemoExam2022App.Common.Events;
using PreDemoExam2022App.Common.Exceptions;
using PreDemoExam2022App.Common.Model;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Services
{
    public class AppAuthService : NotifyPropertyChanged
    {
        private readonly UserService _userService = Singleton<UserService>.GetInstance();

        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnAuth?.Invoke(this, new AppAuthEventArgs(value));
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsAuthenticated));
            }
        }

        public bool IsAuthenticated => User != null;

        public event AppAuthEventHandler OnAuth;

        /// <summary>
        /// Authenticates the user by the login and the password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Successfuly authenticated user or null</returns>
        public async Task<User> AuthenticateUserAsync(string login, string password)
        {
            var user = await _userService.GetUserByCredentialsAsync(login, password);
            if (user != null)
            {
                User = user;
            }

            return user;
        }
    }
}
