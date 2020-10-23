using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Mobile.ViewModels
{
    public class SettingsViewModel
    {
        public bool EntryVisible { get; set; } = true;
        public ICommand ShowCommand { get; set; }
    }
}
