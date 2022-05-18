using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Common;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Repository;
using PreDemoExam2022App.Common.Services;
using PreDemoExam2022App.Mvvm;
using PreDemoExam2022App.Utils;
using PreDemoExam2022App.Windows.UserEditWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PreDemoExam2022App.Pages.UsersPage
{
    internal class UsersPageViewModel : ViewModel
    {
        private readonly UserService _userService = Singleton<UserService>.GetInstance();

        private User _selectedUser;

        public ObservableCollection<User> Users { get; }

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public UsersPageViewModel()
        {
            Users = new ObservableCollection<User>(_userService.GetUsers());
        }

        public Command<object> AddCommand => new(_ => 
        {
            new UserEditWindow().ShowDialog();
        });

        public Command<object> EditCommand => new(async _ => 
        {
            var editedUser = (User)SelectedUser.Clone();
            editedUser.FullName += "2";

            await _userService.SaveUserAsync(editedUser);
            //new UserEditWindow(SelectedUser).ShowDialog();
        }, _ => SelectedUser != null);

        public Command<object> DeleteCommand => new(async _ =>
        {
            var result = MessageBox.Show("Удалить выбранного пользователя?", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (result != MessageBoxResult.OK)
            {
                return;
            }

            await _userService.DeleteUserAsync(SelectedUser);
        }, _ => SelectedUser != null);
    }
}
