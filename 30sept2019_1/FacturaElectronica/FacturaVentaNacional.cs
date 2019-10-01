using System;

namespace _30sept2019_1.FacturaElectronica
{
    public class FacturaVentaNacional : DocumentoElectronico
    {
        public void CalcularCUFE() {
            Console.WriteLine("CalcularCUFE__FacturaVentaNacional");
        }

        public override void AnularDocumento()
        {
            Console.WriteLine("AnularDocumento__FacturaVentaNacional");
        }

        public FacturaVentaNacional() {            
        }
    }
}
