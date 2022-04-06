using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Models.Utilies
{
    class OutOfTextException:Exception
    {
        public OutOfTextException(string message):base(message)
        {

        }
    }
}
