using Avalonia.Reactive;
using ReactiveUI;

namespace ManageX.Services;
public class UserData : ReactiveObject
{
    public string ApplicationName { get => ApplicationName; set => applicationName = value; }
    public string applicationName = "";
    public string UserName { get; init; } = "";
    public string Password { get; init; } = "";

    public UserData(){}

    public UserData(string _applicationName, string _userName, string _password)
    {
        ApplicationName = _applicationName;
        UserName = _userName;
        Password = _password;
    }
}