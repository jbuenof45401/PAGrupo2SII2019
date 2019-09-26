using System;

namespace _25sept2019_1
{
    public class Cliente
    {
        private string nit;
        public string Nit {
            get {
                return nit;
            }
            set{
                nit = value.ToUpper();
            }
        }
        //public string Nit { get; set; }

        public void ObtenerClientexNit() {
        }

        public void ValidarNit(string nit) {

        }

        public Cliente()
        {
            this.nit = "xyz";            
        }        
    }
}
