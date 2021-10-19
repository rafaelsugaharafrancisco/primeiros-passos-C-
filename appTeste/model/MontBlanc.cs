using System;

namespace appTeste.model
{
    class MontBlanc : Relogio
    {
        public TimeSpan MostrarHora()
        {
            return DateTime.Now.TimeOfDay;
        }
    }
}
