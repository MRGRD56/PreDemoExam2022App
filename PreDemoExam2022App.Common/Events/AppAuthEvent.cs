using PreDemoExam2022App.Common.Model;
using System;

namespace PreDemoExam2022App.Common.Events
{
    public class AppAuthEventArgs : EventArgs
    {
        public User NewUser { get; }

        public AppAuthEventArgs(User newUser)
        {
            NewUser = newUser;
        }
    }

    public delegate void AppAuthEventHandler(object sender, AppAuthEventArgs e);
}
