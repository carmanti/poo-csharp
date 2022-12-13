using BankConsole;

User james = new User(1, "James", "james@gmail.com", 4000);
//Esto con encapsulacion ya no se puede hacer
// james.Id = 1;
// james.Name = "James";
// james.Email = "james@gmail.com";
// // james.Balance = 1000;
// james.RegisterDate = DateTime.Now;

james.SetBalance(-20);

System.Console.WriteLine(james.ShowData("Bienvenido"));
Storage.AddUser(james);

User pedro = new User(2, "Pedro", "pedro@correo.com", 2500);

System.Console.WriteLine(pedro.ShowData());

