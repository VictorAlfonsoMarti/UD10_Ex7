using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex7
{
    class Raices
    {
        // ATRIBUTOS
        private double a;
        private double b;
        private double c;

        //GETTERS Y SETTERS 
        public double _a
        {
            get { return a; }
            set { a = value; }
        }
        public double _b
        {
            get { return b; }
            set { b = value; }
        }
        public double _c
        {
            get { return c; }
            set { c = value; }
        }

        // CONSTRUCTOR
        public Raices(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        //METODOS
        public override string ToString()
        {
            Console.WriteLine("a = {0}", _a);
            Console.WriteLine("b = {0}", _b);
            Console.WriteLine("c = {0}", _c);
            return "";
        }

        public void calcular() // METODO PRINCIPAL // llama a las variables pertinentes
        {
            // mostrara por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
            if (tieneRaices()) 
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("No existe solución con los número introducidos.");
            }
        }

        public void obtenerRaices() // imprime las 2 posibles soluciones
        {
            double discriminante = getDiscriminante();
            double x, y, z, posible;
            if (discriminante > 0) // 2 soluciones con numeros reales
            {
                y = (-_b + System.Math.Sqrt(discriminante)) / (2 * _a);
                z = (-_b - System.Math.Sqrt(discriminante)) / (2 * _a);
                Console.WriteLine("Dos posible soluciones: {0} o {1}", y, z);
            }
            else if (discriminante < 0) // soluciones irreales, no tiene solucion al dar numero negativo
            {
                discriminante = -discriminante;
                x = -_b / (2 * _a);
                posible = System.Math.Sqrt(discriminante) / (2 * _a);
                Console.WriteLine("Dos posibles soluciones irreales (discriminante negativo): {0} +/- {1} o {2} +/- {3}", x, posible, x, posible);
            }
        }

        public void obtenerRaiz() // imprime única raíz, que será cuando solo tenga una solución posible.
        {
            double discriminante = getDiscriminante();
            double x;
            x = (-b + System.Math.Sqrt(discriminante)) / (2 * _a);
            Console.WriteLine("Solución: {0}", x);
        }


        public double getDiscriminante() // devuelve el valor del discriminante (double), el discriminante tiene la siguiente formula, (b ^ 2) 4*a* c
        {
            return (_b * _b - 4 * _a * _c); // el discriminante es el numero que indica cuantas posibles soluciones hay.
        }


        public Boolean tieneRaices() // devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
        {
            double discriminante = getDiscriminante(); 
            if (discriminante > 0 || discriminante < 0) // tiene dos soluciones, una positiva y otra negativa
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean tieneRaiz() // devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
        {
            double discriminante = getDiscriminante(); // tiene una solucion real
            if (discriminante == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
