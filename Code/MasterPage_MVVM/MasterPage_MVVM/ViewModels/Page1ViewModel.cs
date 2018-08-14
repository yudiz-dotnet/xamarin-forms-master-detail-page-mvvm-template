using System;
using System.Collections.Generic;
using System.Text;

namespace MasterPage_MVVM.ViewModels
{
    public class Page1ViewModel :BaseViewModel
    {
        private string _LabelText;

        public string LabelText
        {
            get { return _LabelText; }
            set { _LabelText = value; NotifyPropertyChanged("LabelText"); }
        }

        public Page1ViewModel()
        {
            LabelText = "Page 1";
        }
    }
}
