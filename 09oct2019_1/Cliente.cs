using System;

namespace _09oct2019_1 {
    public class Cliente {
        public int nit { get; set; }
        public string nombre { get; set; }

        public Cliente(int nit, string nombre) {
            this.nit = nit;
            this.nombre = nombre;
        }

        public override int GetHashCode() {
            int resultado = 0;
            int primo = 31;

            resultado = primo + nit.GetHashCode();
            resultado = (primo * resultado) + nombre.GetHashCode();

            return Math.Abs(resultado);
        }

        public override bool Equals(object obj) {
            bool sonIguales = false;

            if(obj!=null && this.GetHashCode() == obj.GetHashCode()) {
                sonIguales = true;
            }

            return sonIguales;
        }

        public override string ToString() {
            return $"nit:{nit} nombre:{nombre}";
        }
    }
}
