namespace ManageX.Models;

public class Data
{
    public string Application { get; set; } = "";
    public string Password { get; set; } = "";

    public Data(string application, string password)
    {
        Application = application;
        Password = password;
    }
}