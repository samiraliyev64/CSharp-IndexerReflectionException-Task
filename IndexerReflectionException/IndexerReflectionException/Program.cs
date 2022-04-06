using System;

namespace IndexerReflectionException
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender email1 = new EmailSender();
            SmsSender sms1 = new SmsSender();


            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit\n");

            Console.Write("Menyuya uygun olaraq seciminizi edin : ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input == 1)
            {
                string emailAdress = "samir_aliyev_2001@bk.ru";
                Console.Write("\nMesajinizi daxil edin : ");
                string myEmailMessage = Console.ReadLine();
                email1.SendMessage(emailAdress+$"\nMesajiniz : {myEmailMessage}");
                
            }

            else if(input == 2)
            {
                string phoneNumber = "0555232741";
                Console.Write($"\nMesajinizi daxil edin : ");
                string SMS = Console.ReadLine();
                sms1.SendMessage(phoneNumber+$"\nMesajiniz : {SMS}");
            }

            else if(input == 0)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\nDaxil etdiyiniz input menyudaki secimlerle uygun gelmedi");
            }
        }
    }
}
