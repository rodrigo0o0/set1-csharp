using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1_csharp.Entities
{
    internal class ClientLog
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public ClientLog(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public ClientLog(string  text) 
        {
            string [] clientLog = text.Split(' ');
            Name = clientLog[0];
            Date = DateTime.Parse(clientLog[1]);
        }
        public override string ToString()
        {
            return Name + " " + Date.ToShortDateString();
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is ClientLog))
            {
                return false;
            }
            ClientLog other = obj as ClientLog;

            return this.Name.Equals(other.Name);
        }
    }
}
