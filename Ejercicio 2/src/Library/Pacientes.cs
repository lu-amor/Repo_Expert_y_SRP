using System;
using System.Text;

namespace Library
{
    public class Pacientes
    {   
        public string Name;
        public string Id;
        public int Edad;
        public string PhoneNumber;

        public Pacientes(string name, string id, int edad, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.Edad = edad;
            this.PhoneNumber = phoneNumber;
        }
        public void SetName(string name)
        { 
            if (IdUtils.NombreValid(name) == true)
            { 
                this.Name = name;
            }
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetId(string id)
        {
            if (IdUtils.IdIsValid(id) == true)
            {
                this.Id = id;
            }
        }
        public string GetId()
        {
            return this.Id;
        }
        public void SetEdad(int edad)
        {
            if(IdUtils.EdadValid(edad) == true)
            {
                this.Edad = edad;
            }
        }
        public int GetEdad()
        {
            return this.Edad;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            if (IdUtils.PhoneNumberValid(phoneNumber) == true)
            {
                this.PhoneNumber = phoneNumber;
            }
        }
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
    }
}


