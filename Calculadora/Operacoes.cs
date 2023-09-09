using System;
namespace Calculadora
{
    public class Operacoes
    {
        // Mudei o tipo de int para long para poder suportar valores maiores que o limite do int
        public long valorA {get;set;}
        public char operador { get; set; }
        public long valorB { get; set; }
        public decimal resultado { get; set; }

    }
}
