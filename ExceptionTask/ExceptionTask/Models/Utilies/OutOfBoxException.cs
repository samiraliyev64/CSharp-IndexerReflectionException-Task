using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Models.Utilies
{
    public class OutOfBoxException:Exception
    {
        public OutOfBoxException(string msg):base(msg)
        {

        }
    }
}
