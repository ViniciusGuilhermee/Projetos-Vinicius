using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Modelo
{
    public class Fahrenheit : absPropriedades
    {
        public Fahrenheit(double temperatura) : base(temperatura)
        {
        }

        public override void Executar()
        {
            this.resultado = (this.temperatura - 32) / 1.8;
            this.resposta = "Temperatura: " + resultado.ToString();
        }
    }
}
