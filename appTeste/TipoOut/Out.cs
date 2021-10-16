using System;

namespace appTeste.TipoOut
{
    class Out
    {
        public void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }
    }
}
