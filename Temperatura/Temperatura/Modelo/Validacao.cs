using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(string temp) : base(temp)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.temperatura = Convert.ToDouble(this.temp);
            }
            catch (Exception)
            {
                this.mensagem = "Erro de conversão";
            }
        }
    }
}
