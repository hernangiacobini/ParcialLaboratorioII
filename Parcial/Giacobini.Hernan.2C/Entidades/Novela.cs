using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        private int cantPaginas;

        public override ETipoImpresion TipoImpresion
        {
            get
            {
                return ETipoImpresion.BlancoNegro;
            }
        }

        public override string Mostrar()
        {
            
            return string.Format("{0} {1} {2}",base.Mostrar(),cantPaginas,TipoImpresion);
        }

        public Novela(int cantPaginas, string titulo, float tamanioLetra, int ancho, int alto):base(titulo,tamanioLetra,ancho,alto)
        {
            this.cantPaginas = cantPaginas;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
          return !(n1 == n2);
        }

        public static bool operator ==(Novela n1, Novela n2)
        {
      if (n1.Mostrar() == n2.Mostrar())
        return true;
      else
        return false;
        }
    }
}
