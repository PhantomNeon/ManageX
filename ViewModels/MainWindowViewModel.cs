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
    private UserDataView userDataView = new();
    private HomeView homeView = new();

    public MainWindowViewModel()
    {
        userDataView.DataContext = new UserDataViewModel();
    }
    public void HomeButton()
    {
        ActiveUserControl = homeView;

    }

    public void UserDataButton()
    {
        ActiveUserControl = userDataView;
    }
}