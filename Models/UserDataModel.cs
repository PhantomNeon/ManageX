using Avalonia.ReactiveUI;
using System.Reactive;
using System.Collections.ObjectModel;
using ManageX.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ManageX.Models;
public class UserDataModel
{
    public void GetUserDataFromJson()
    {
        dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText("Services/UserData.json"))!;

        ObservableCollection<string>? Headers = JArrayToObservableCollection(jsonData["Header"]);
        Console.WriteLine(Headers[0]);
    }

    private static ObservableCollection<dynamic> JArrayToObservableCollection(JArray array)
    {
        ObservableCollection<dynamic> collection = new();

        foreach(dynamic element in array)
        {
            collection.Add(element);
        }

        return collection;
    }
}