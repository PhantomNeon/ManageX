using System;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using ReactiveUI;
using ManageX.Models;

namespace ManageX.ViewModels;

public class UserDataViewModel : ViewModelBase
{
    public ObservableCollection<Data> UserDataList{ get; } = new();

    public UserDataViewModel()
    {
        UserDataList.Add(new Data("somemailid@bing.com", "2020wasactuallygud"));
        UserDataList.Add(new Data("Spotify", "drakeispawg"));
        UserDataList.Add(new Data("SomeApp", "stwongpassword"));
    }
}