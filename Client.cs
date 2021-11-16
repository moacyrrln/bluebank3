using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoZero2
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public Client(string name, string cpf)
        {
            Name = name;
            CPF = cpf;
        }
        public Client() {}
    }
}
