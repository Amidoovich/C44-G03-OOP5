using S5.Class;
using S5.Interface;

namespace S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Circle circle = new Circle();
            //circle.Radius = 10;
            //circle.Area = circle.Radius * 3.14f;
            //circle.DisplayShapeInfo();
            //Rectangle rectangle = new Rectangle();
            //rectangle.Height = 5;
            //rectangle.Width = 5;
            //rectangle.Area = rectangle.Width * rectangle.Height;
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Q2
            //IAuthenticationService authenticationService = new BasicAuthenticationService();

            //do
            //{
            //    string? UserName, password, Role;
            //    int choice;
            //    Console.WriteLine("1.To Ayhenticate");
            //    Console.WriteLine("2.To Authorize");
            //    Console.WriteLine("3.Exit");
            //    bool isParse = int.TryParse(Console.ReadLine(), out choice);
            //    if (choice == 3)
            //        break;
            //    else if(choice == 1)
            //    {

            //        do
            //        {
            //            Console.Write("please Enter username : ");
            //            UserName = Console.ReadLine();
            //        }
            //        while (UserName is null);
            //        do
            //        {
            //            Console.Write("please Enter password : ");
            //            password = Console.ReadLine();
            //        }
            //        while (password is null);
            //        if (authenticationService.AuthenticateUser(UserName,password))
            //            Console.WriteLine("the Account is right");
            //        else
            //            Console.WriteLine("the Username or password is Wrong");
            //    }
            //    else if(choice == 2)
            //    {
            //        do
            //        {
            //            Console.Write("please Enter username : ");
            //            UserName = Console.ReadLine();
            //        }
            //        while (UserName is null);
            //        do
            //        {
            //            Console.Write("please Enter Role : ");
            //            Role = Console.ReadLine();
            //        }
            //        while (Role is null);
            //        if (authenticationService.AuthorizeUser(UserName,Role))
            //            Console.WriteLine("the role is wright");
            //        else
            //            Console.WriteLine("the Username or role is Wrong");
            //    }    
            //}
            //while (true);
            #endregion
            #region Q3
            //EmailNotificationService emailNotificationService = new EmailNotificationService();
            //emailNotificationService.SendNotification("Ahmed","Hello My Friend");
            //Console.WriteLine();
            //SmsNotificationServices smsNotificationServices = new SmsNotificationServices();
            //smsNotificationServices.SendNotification("Ahmed","Hello My Friend");
            //Console.WriteLine();
            //PushNotificationService pushNotificationService = new PushNotificationService();
            //pushNotificationService.SendNotification("Ahmed", "Hello My Friend");    
            #endregion
        }
    }
}
