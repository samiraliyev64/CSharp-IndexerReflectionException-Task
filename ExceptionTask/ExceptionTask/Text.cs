using ExceptionTask.Models.Utilies;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask
{
    class Text
    {
        private string[] myText = new string[4];
        public string this[int index]
        {
            get
            {
                return myText[index];

            }
            set
            {
                if(index < myText.Length)
                {
                    myText[index] = value;
                }

                else
                {
                    throw new OutOfTextException("textin bele bir indexi yoxdur");
                }
            }
        }
    }
}
