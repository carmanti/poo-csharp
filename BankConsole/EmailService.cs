using MailKit.Net.Smtp;
using MimeKit;

namespace BankConsole;

public static class EmailService
{
    public static void SendMail()
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("James Aranda", "jamesaranda@gmail.com"));
        message.To.Add(new MailboxAddress("Admin", "jmes_fdsfsd@gmail.com"));
        message.Subject = "BankConsole: Usuarios nuevos";

        message.Body = new TextPart("plain")
        {
            Text = GetEmailText()
        };

        using (var client = new SmtpClient())
        {
            client.Connect("smpt.gmail.com", 587, false);
            client.Authenticate("jamesaranda@gmail.com", "111111111111111");
            client.Send(message);
            client.Disconnect(true);
        }
    }

    private static string GetEmailText()
    {
        List<User> newUsers = Storage.GetNewUsers();

        if (newUsers.Count == 0)
            return "NO hay usuarios nuevos";

        string emailText = "Usuarios agergados hoy: \n";

        foreach (User user in newUsers)
            emailText += "\t+ " + user.ShowData() + "\n";

        return emailText;
    }
}