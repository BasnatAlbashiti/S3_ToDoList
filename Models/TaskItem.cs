using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Models
{
    internal class TaskItem : ViewModels.ViewModelBase
    {
        private string _title = "";
        private bool _isDone;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(); // ding! IsDone changed
            }

        }

        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                _isDone = value;
                OnPropertyChanged();
            }



        }
    }
}

