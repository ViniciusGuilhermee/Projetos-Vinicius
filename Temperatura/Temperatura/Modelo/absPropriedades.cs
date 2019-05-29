using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        protected String mensagem;
        protected String resposta;
        protected Double resultado;
        protected String temp;
        protected Double temperatura;
        protected String tipo;

        public string Resposta { get => resposta; set => resposta = value; }
        public double Resultado { get => resultado; }
        public double Temperatura { get => temperatura; }
        public string Mensagem { get => mensagem;  }

        protected absPropriedades(double temperatura)
        {
            this.temperatura = temperatura;
            Executar();
        }

        protected absPropriedades(string temp)
        {
            this.temp = temp;
            Executar();
        }

        public absPropriedades(string temp, string tipo)
        {
            this.temp = temp;
            this.tipo = tipo;
            Executar();
        }

        public abstract void Executar();


        public override string ToString()
        {
            return this.resposta;
        }

    }
}
