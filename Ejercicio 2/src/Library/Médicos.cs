using System;
using System.Text;

namespace Library
{
    public class Médicos 
    {
        public string MName { get; set; }
        public string Especialidad { get; set; }
        public Médicos(string mName, string especialidad)
        {
            this.MName = mName; 
            this.Especialidad = especialidad;
        }
    }
}

