using System;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using ReactiveUI;
using ManageX.Models;

namespace ManageX.ViewModels;

public class UserDataViewModel : ViewModelBase
{
    UserDataModel userDataModel = new();
    ObservableCollection<string> Application { get => Application; set => this.RaiseAndSetIfChanged(ref application, value); }
    ObservableCollection<string> application = new();

    public UserDataViewModel()
    {
        Application = userDataModel.Application;
    }
}