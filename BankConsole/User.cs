using Newtonsoft.Json;
namespace BankConsole;

public class User
{
    [JsonProperty]
    protected private int Id { get; set; }

    [JsonProperty]
    protected private string Name { get; set; }

    [JsonProperty]
    protected private string Email { get; set; }

    [JsonProperty]
    protected private decimal Balance { get; set; }

    [JsonProperty]
    protected private DateTime RegisterDate { get; set; }

    public User() { }

    public User(int Id, string Name, string Email, decimal Balance)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        // this.Balance = Balance;
        // SetBalance(Balance);
        this.RegisterDate = DateTime.Now;
    }

    public DateTime GetRegisterDate()
    {
        return RegisterDate;
    }

    public virtual void SetBalance(decimal amount)
    {
        decimal quantity = 0;
        if (amount < 0)
            quantity = 0;
        else
            quantity = amount;

        this.Balance += quantity;
    }

    public virtual string ShowData()
    {
        // return "Nombre: " + this.Name + ", Correo: " + this.Email + ", Saldo: " + this.Balance + ", Fecha de registro: " + this.RegisterDate;
        return $"ID: {this.Id}, Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate.ToShortDateString()}";
    }

    public string ShowData(string initialMessage)
    {
        return $"{initialMessage} -> Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}";
    }

    // public string GetName()
    // {
    //     return Name;
    // }

    // public string GetCountry()
    // {
    //     return "Mexico";
    // }

    //Clase abstracta 
    // public override string GetName()
    // {
    //     return Name;
    // }
}