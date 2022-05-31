using Avalonia.ReactiveUI;
using System.Reactive;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ManageX.Models;
public class UserDataModel
{
    public ObservableCollection<string>? Application { get; set; }
    public ObservableCollection<string>? UserName { get; set; }
    public ObservableCollection<string>? Password { get; set; }

    private void GetUserData()
    {
        dynamic? jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("Services/UserData.json"));

        Application = JArrayToOC(jsonFile![0]);
        UserName = JArrayToOC(jsonFile![1]);
        Password = JArrayToOC(jsonFile![2]);
    }

    public static ObservableCollection<T> JArrayToOC<T>(JArray array)
    {
        ObservableCollection<T> collection = new();

        foreach (dynamic element in array)
        {
            collection.Add(element);
        }

        return collection;
    }
}