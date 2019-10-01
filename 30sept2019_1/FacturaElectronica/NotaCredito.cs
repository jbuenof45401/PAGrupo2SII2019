using System;

namespace _30sept2019_1.FacturaElectronica
{
    public class NotaCredito : DocumentoElectronico, IOpercionDocElectronico
    {
        public void CalcularCUDE() {
            Console.WriteLine("CalcularCUDE__NotaCredito");
        }

        public override void AnularDocumento()
        {
            Console.WriteLine("AnularDocumento__NotaCredito");
        }

        public NotaCredito() {
        }
    }
}
