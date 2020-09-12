using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Salao
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string Telefone { get; set; }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

    }
}
