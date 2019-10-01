using System;

namespace _30sept2019_1.FacturaElectronica
{
    public abstract class DocumentoElectronico
    {
        public int total { get; set; }

        public static DocumentoElectronico CrearDocumentoElctronico(int opcionDocElec) { //opcionDocElec: 1-FVN, 2-NC
            switch (opcionDocElec)
            {
                case 1:
                    return (new FacturaVentaNacional());
                case 2:
                    return (new NotaCredito());
                default:
                    return null;                    
            }            
        }

        public void CalcularTotal() {
            Console.WriteLine("CalcularTotal__DocumentoElectronico");
        }

        public void AsociarDocSoporte() {
            Console.WriteLine("AsociarDocSoporte__DocumentoElectronico");
        }

        public abstract void AnularDocumento();

        public DocumentoElectronico() { }        
    }
}
