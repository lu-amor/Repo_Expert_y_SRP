using System;
using System.Linq;
using System.Text;
namespace Library
{
    public class IdUtils
    {
        public static bool IdIsValid(string id)
        {
            long tempOut; 

            id = id.Replace(".", "");
            id = id.Replace("-", "");

            if (id.Length == 8 && long.TryParse(id, out tempOut))
            {
                var idAsCharArray = id.ToCharArray().ToArray();
                var idAsIntArray = idAsCharArray.Select(c => int.Parse(c.ToString())).ToArray();
                var referenceArray = "2987634".ToArray().Select(c => int.Parse(c.ToString())).ToArray();
                var inputCheckDigit = idAsIntArray[7];

                int checkSum = 0;
                for (int i = 0; i < referenceArray.Length; i++)
                {
                    checkSum = checkSum + (idAsIntArray[i] * referenceArray[i]);
                }

                int checkDigit = 10 - (checkSum % 10);

                if (checkDigit == 10)
                {
                    checkDigit = 0;
                }

                if (checkDigit != inputCheckDigit)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
        public static bool NombreValid(string name)
        {
            if (name == "") 
            {
                return false;
            }
                return true;
        }
        public static bool EdadValid(int Edad)
        {
            if ((Edad >= 0) || (Edad <= 120))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PhoneNumberValid(string PhoneNumber)
        {
            if((PhoneNumber.Length == 8) || (PhoneNumber.Length == 9))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}