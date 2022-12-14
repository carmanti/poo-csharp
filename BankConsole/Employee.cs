namespace BankConsole;

public class Employee : User, IPerson
{

    public string Departamento { get; set; }

    public Employee() { }

    public Employee(int Id, string Name, string Email, decimal Balance, string Departamento) : base(Id, Name, Email, Balance)
    {
        this.Departamento = Departamento;
        SetBalance(Balance);
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if (Departamento.Equals("IT"))
            Balance += (amount * 0.05m);
    }

    public override string ShowData()
    {
        return base.ShowData() + $", Departamento: {this.Departamento}";
    }

    public string GetName()
    {
        return Name + "!";
    }

    public string GetCountry()
    {
        throw new NotImplementedException();
    }
}