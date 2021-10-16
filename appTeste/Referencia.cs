using System;

namespace appTeste
{
    class Referencia
    {
        public static void InverterSemRef(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }

        public static void InverterComRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
