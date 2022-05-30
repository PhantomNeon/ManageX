using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ManageX.ViewModels;

public class UserDataViewModel : ViewModelBase
{
    public ObservableCollection<ObservableCollection<string>> PasswordData;
    public PasswordsViewModel()
    {
        
    }
}