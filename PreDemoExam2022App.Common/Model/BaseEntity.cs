using PreDemoExam2022App.Common.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Model
{
    public abstract class BaseEntity : NotifyPropertyChanged
    {
        private int _id;
        private bool _isDeleted;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public bool IsDeleted
        {
            get => _isDeleted;
            set
            {
                _isDeleted = value;
                OnPropertyChanged();
            }
        }
    }
}
