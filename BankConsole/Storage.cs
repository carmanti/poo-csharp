//ALmacenar en un archivo tipo json a los objetos tipo usuario que vamos creando
using Newtonsoft.Json;

namespace BankConsole;

public static class Storage
{
    static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\user.json";

    public static void AddUser(User user)
    {
        //PAra varios objetos
        string json = "", usersInFile = "";
        if (File.Exists(filePath))
            usersInFile = File.ReadAllText(filePath); //Read lee

        var listUsers = JsonConvert.DeserializeObject<List<User>>(usersInFile);

        if (listUsers == null)
            listUsers = new List<User>();

        listUsers.Add(user);

        json = JsonConvert.SerializeObject(listUsers);

        File.WriteAllText(filePath, json); // Write escribe

        //Esto es para un solo objeto
        // string json = "";
        // //Serializando
        // json = JsonConvert.SerializeObject(user);

        // File.WriteAllText(filePath, json);
    }
}