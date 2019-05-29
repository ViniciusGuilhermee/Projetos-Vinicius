using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string temp, string tipo) : base(temp, tipo)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(this.temp);
            if (validacao.Mensagem.Equals(""))
            {
                if (this.tipo.Equals("CF"))
                {
                    absPropriedades celsius = new Celsius(validacao.Temperatura);
                    this.resposta = celsius.ToString();
                }
                if (this.tipo.Equals("FC"))
                {
                    absPropriedades fahrenheit = new Fahrenheit(validacao.Temperatura);
                    this.resposta = fahrenheit.ToString();
                }
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }
    }
}
