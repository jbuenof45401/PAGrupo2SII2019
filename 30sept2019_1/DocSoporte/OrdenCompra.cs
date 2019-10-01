using System;

namespace _30sept2019_1.FacturaElectronica
{
    public class OrdenCompra : DocSoporte, IOpercionDocElectronico
    {
        public OrdenCompra() {
        }

        public void CalcularCUDE()
        {
            NotaCredito notaCredito = null;

            notaCredito = new NotaCredito();
            notaCredito.CalcularCUDE();
        }
    }
}
