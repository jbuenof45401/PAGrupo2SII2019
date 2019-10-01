using System;
using _30sept2019_1.FacturaElectronica;

namespace _30sept2019_1.Cliente
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Prueba_DocElecDIAN();          
        }

        private static void Prueba_DocElecDIAN() {
            short opcionDocElect = 0;
            decimal porcentajeComision = 0.0M;
            decimal comision = 0.0M;
            DocumentoElectronico de = null;

            Console.Write("Entre tipo Doc Electronico [1-FVN,2-NC]:");
            if(!Int16.TryParse(Console.ReadLine(),out opcionDocElect))
                throw new ArgumentException("Valor para OPCION no valida!");
            Console.Write("Entre % de comision:");
            if(!Decimal.TryParse(Console.ReadLine(),out porcentajeComision))
                throw new ArgumentException("Valor para COMISION no valida!");

            //de = new DocumentoElectronico(); //REMAAAAAL!!!
            //BUENA PRACTICA!
            de = DocumentoElectronico.CrearDocumentoElctronico(opcionDocElect);
            comision = CalcularTotalComision(de, porcentajeComision);

            //Un RE-JUNIOR, Caso 1°            
            FacturaVentaNacional facVenNac = null;
            NotaCredito notaCredito = null;

            if(opcionDocElect == 1) { //FVN
                facVenNac = new FacturaVentaNacional();
                facVenNac.CalcularTotal();
                comision = facVenNac.total * 0.20M;
            } else if(opcionDocElect == 2) { //NC
                notaCredito = new NotaCredito();
                notaCredito.CalcularTotal();
                comision = notaCredito.total * 0.10M;
            } else if(opcionDocElect == 3) { //ND
                notaCredito = new NotaCredito();
                notaCredito.CalcularTotal();
                comision = notaCredito.total * 0.50M;
            }
        }

        private static decimal CalcularTotalComision(DocumentoElectronico documentoElectronico, decimal porcentajeComsion) {
            decimal comision = 0.0M;
            FacturaVentaNacional facVenNac = null;
            NotaCredito notaCredito = null;

            documentoElectronico.CalcularTotal();
            comision = documentoElectronico.total * porcentajeComsion;

            if(documentoElectronico.GetType() == typeof(FacturaVentaNacional)) {
                facVenNac = (FacturaVentaNacional)documentoElectronico;
                facVenNac.CalcularCUFE();
            } else if(documentoElectronico.GetType() == typeof(NotaCredito)) {
                notaCredito = (NotaCredito)documentoElectronico;
                notaCredito.CalcularCUDE();
            }

            return (comision);
        }

        //Un RE-JUNIOR, Caso 2°
        private static int CalcularTotalComision_FVN(FacturaVentaNacional facVenNac, int porcentajeComsion) {
            facVenNac.CalcularTotal();

            return (facVenNac.total * porcentajeComsion);
        }
        private static int CalcularTotalComision_NC(NotaCredito nc, int porcentajeComsion) {
            nc.CalcularTotal();

            return (nc.total * porcentajeComsion);
        }
    }
}
