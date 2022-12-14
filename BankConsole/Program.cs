using BankConsole;


// User james = new User(1, "James", "james@gmail.com", 4000);
//Esto con encapsulacion ya no se puede hacer
// james.Id = 1;
// james.Name = "James";
// james.Email = "james@gmail.com";
// // james.Balance = 1000;
// james.RegisterDate = DateTime.Now;

// System.Console.WriteLine(james.ShowData());
// Storage.AddUser(james); // Para agregar al documento

// User pedro = new User(2, "Pedro", "pedro@correo.com", 2500);
// Storage.AddUser(pedro); // Para agregar al documento
Client james = new Client(1, "James", "james@gmail.com", 4000, 'M');
// james.SetBalance(2000);
// System.Console.WriteLine(james.ShowData());

Employee pedro = new Employee(2, "Pedro", "pedro@correo.com", 3000, "IT");
// pedro.SetBalance(2000);
// System.Console.WriteLine(pedro.ShowData());

Storage.AddUser(james);
Storage.AddUser(pedro);

