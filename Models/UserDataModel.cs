using Avalonia.ReactiveUI;
using System.Reactive;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ManageX.Models;
public class UserDataModel
{
    public ObservableCollection<string> Headers { get; set; }
    public ObservableCollection<ObservableCollection<string>> HeaderData { get; set; }

    public UserDataModel()
    {
        Headers = JArrayToObservableCollection<string>(GetDataFromJson("Header"));
        GetIndividualDataFromJson();
    }

    public JArray GetDataFromJson(string title)
    {
        dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText("Services/UserData.json"))!;
        return jsonData[title];
    }

    public void GetIndividualDataFromJson()
    {
        foreach (string header in Headers)
        {
            HeaderData.Add(JArrayToObservableCollection<string>(GetDataFromJson("header")));
        }
    }
    

    private static ObservableCollection<T> JArrayToObservableCollection<T>(JArray array)
    {
        ObservableCollection<T> collection = new();

        foreach(dynamic element in array)
        {
            collection.Add(element);
        }

        return collection;
    }
}