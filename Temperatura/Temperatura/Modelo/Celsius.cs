using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Modelo
{
    public class Celsius : absPropriedades
    {
        public Celsius(double temperatura) : base(temperatura)
        {
        }

        public override void Executar()
        {
            this.resultado = this.temperatura * 1.8 + 32;
            this.resposta = "Temperatura: " + resultado.ToString();

        }
    }
}
