using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using ReactiveUI;
using ManageX.Views;

namespace ManageX.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
    public UserControl ActiveUserControl { get => activeUserControl; set => this.RaiseAndSetIfChanged(ref activeUserControl, value); }
    private UserControl activeUserControl = new HomeView();

    public void HomeButton()
    {
        ActiveUserControl = new HomeView();
    }

    public void PasswordsButton()
    {
        ActiveUserControl = new UserDataView()!;
        ActiveUserControl.DataContext = new UserDataViewModel();    
    }
}