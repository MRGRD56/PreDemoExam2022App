﻿using PreDemoExam2022App.Common.Common;
using PreDemoExam2022App.Common.Events;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Services;
using PreDemoExam2022App.Mvvm;

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
    }
}