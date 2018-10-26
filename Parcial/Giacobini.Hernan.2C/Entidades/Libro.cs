using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        private static int altoHoja;
        private static int anchoHoja;
        private List<string> pagina;
        private float tamanioLetra;
        private string titulo;
        public enum ETipoImpresion { Color, BlancoNegro, Mixto }
        
        public int AltoHoja
        {
            get
            {
                return altoHoja;
            }
        }

        public int AnchoHoja
        {
            get
            {
                return anchoHoja;
            }
        }

        public int CantidadPaginas
        {
            get
            {

            }
        }

        public float TamanioLetra
        {
            get
            {

            }
            set
            {
                int sumaAltoAncho = altoHoja + altoHoja;
                float diezPorCiento = (10 * sumaAltoAncho) / 100;

                if (TamanioLetra<sumaAltoAncho)
                {
                    this.tamanioLetra = TamanioLetra;
                }
                else
                {
                    this.tamanioLetra = 12;
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return pagina[index];
            }
            set
            {
                this.pagina.Add("" + pagina.Count + 1);
            }
        }

        public abstract ETipoImpresion TipoImpresion
        {
            get;
        }


        private Libro()
        {
            pagina = null;
        }

        public Libro(string titulo, float tamanioLetra, int ancho, int alto)
        {

        }

        public virtual string Mostrar()
        {
            return this.titulo;
        }
    }
}
