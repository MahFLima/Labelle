using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Salao
{
    public class Caixa
    {
        public static int TotalDeContasCriadas { get; private set; }
        private string _tipo;
        private double _valor;
        public string responsavel;

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                _tipo = value;
            }
        }

        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _valor = value;
            }
        }

        public Caixa(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;

            TotalDeContasCriadas++;
        }
    }
}
