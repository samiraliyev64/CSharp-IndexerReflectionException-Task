using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerReflectionException
{
    class EmailSender : MessageSender
    {
        public override void SendMessage(string email)
        {
            Console.WriteLine($"\nEmail mesajiniz gonderildi!\n\nMesaji gonderdiyiniz email : {email}");
        }
    }
}
