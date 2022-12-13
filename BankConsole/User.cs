using Newtonsoft.Json;
namespace BankConsole;

public class User
{
    [JsonProperty]
    private int Id { get; set; }

    [JsonProperty]
    private string Name { get; set; }

    [JsonProperty]
    private string Email { get; set; }

    [JsonProperty]
    private decimal Balance { get; set; }

    [JsonProperty]
    private DateTime RegisterDate { get; set; }

    public User()
    {
        this.Balance = 1000;
    }
    public User(int Id, string Name, string Email, decimal Balance)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        // this.Balance = Balance;
        SetBalance(Balance);
        this.RegisterDate = DateTime.Now;
    }

    public void SetBalance(decimal amount)
    {
        decimal quantity = 0;
        if (amount < 0)
            quantity = 0;
        else
            quantity = amount;

        this.Balance += quantity;
    }

    public string ShowData()
    {
        // return "Nombre: " + this.Name + ", Correo: " + this.Email + ", Saldo: " + this.Balance + ", Fecha de registro: " + this.RegisterDate;
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}";
    }

    public string ShowData(string initialMessage)
    {
        return $"{initialMessage} -> Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}";
    }
}