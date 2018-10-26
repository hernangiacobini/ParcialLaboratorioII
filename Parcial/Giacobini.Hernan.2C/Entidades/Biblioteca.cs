using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private short cantidad;
        private List<Libro> libros;

        static Biblioteca()
        {

        }

        private Biblioteca()
        {
            cantidad = 0;
        }

        public Biblioteca(short cantidad)
        {

        }

        //public static List<Libro> operator List<Libro>(Biblioteca b)
        
        public static Biblioteca operator +(Biblioteca b,Libro l)
        {

        }
    }
}
