using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerReflectionException
{
    class SmsSender : MessageSender
    {
        public override void SendMessage(string phoneNum)
        {
            Console.WriteLine($"\nMesajiniz gonderildi!\n\nMesaji gonderdiyiniz nomre : {phoneNum}");
        }
    }
}
