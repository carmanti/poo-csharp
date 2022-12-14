//ALmacenar en un archivo tipo json a los objetos tipo usuario que vamos creando
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        var listUsers = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if (listUsers == null)
            listUsers = new List<object>();

        listUsers.Add(user);
        JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

        json = JsonConvert.SerializeObject(listUsers, settings);

        File.WriteAllText(filePath, json); // Write escribe

        //Esto es para un solo objeto
        // string json = "";
        // //Serializando
        // json = JsonConvert.SerializeObject(user);

        // File.WriteAllText(filePath, json);
    }

    public static List<User> GetNewUsers()
    {
        string usersInFile = "";
        var listUsers = new List<User>();

        if (File.Exists(filePath))
            usersInFile = File.ReadAllText(filePath);

        var listObject = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if (listObject == null)
            return listUsers;

        foreach (object obj in listObject)
        {
            User newUser;
            JObject user = (JObject)obj;

            if (user.ContainsKey("TaxRegime"))
                newUser = user.ToObject<Client>();
            else
                newUser = user.ToObject<Employee>();

            listUsers.Add(newUser);
        }

        var newUserList = listUsers.Where(user => user.GetRegisterDate().Date.Equals(DateTime.Today)).ToList();
        return newUserList;
    }
}