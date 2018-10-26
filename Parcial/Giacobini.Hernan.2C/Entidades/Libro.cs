using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        private int altoHoja;
        private int anchoHoja;
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
                  return this.pagina.Count;
            }
        }

        public float TamanioLetra
        {
            get
            {
                return this.tamanioLetra;
            }
            set
            {
                int sumaAltoAncho = altoHoja + altoHoja;
                float diezPorCiento = (10 * sumaAltoAncho) / 100;

                if (value < sumaAltoAncho)
                {
                    this.tamanioLetra = value;
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
                if (index > pagina.Count)
                    return "";
                else
                    return pagina[index];
            }
            set
            {
                this.pagina.Add(value);
            }
        }

        public abstract ETipoImpresion TipoImpresion
        {
            get;
        }


        private Libro()
        {
            pagina = new List<string>();
        }

        public Libro(string titulo, float tamanioLetra, int ancho, int alto):this()
        {
            this.titulo = titulo;
            this.TamanioLetra=tamanioLetra;
            this.anchoHoja = ancho;
            this.altoHoja = alto;
            
      
        }

        public virtual string Mostrar()
        {
            return this.titulo;
        }
    }
}
