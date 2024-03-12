using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFixacaoVetores02
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $" Nome: {Name} " +
                        $"e-mail: {Email}";
        }

    }
}
