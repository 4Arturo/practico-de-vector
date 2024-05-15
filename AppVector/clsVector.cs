using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        // Propiedades del Vector
        private int[] vector;
        private int lg;

        // Conructor -> Inicializar las propiedades
        public clsVector() {
            vector = new int[100];
            lg = 0;
        }

        // Metodos (procedimin¡ento o funciones)
        public void adiccionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }

        // obtener el valor en la posocion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }

        // longitud del vector
        public int longitud() {
            return lg;
        }

        // invertir los elementos del vector
        public void invertir() {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad) {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
        }


        // cantidad de elementos Pares
        public int CantPares() {
            int cont = 0;
            for (int i = 0; i < lg; i++) {
                if (vector[i] % 2 == 0)
                    cont++;
            }
            return cont;
        }


        // odenar los elementos del vector de menor a mayor
        public void OrdenarMenorAmayor() {
            int aux = 0;
            for (int i = 0; i < lg; i++) {
                for (int j = i; j < lg; j++) {
                    if (vector[i] > vector[j]) {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }


        // eliminar el elemento de la pos. P
        public void EliminarElementoPos(int p) {
            for (int i = p - 1; i < lg; i++) {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }



        //cantidad de elemento impares
        public int CantImpares() {
            int cont = 0;
            for (int i = 0; i < lg; i++) {
                if (vector[i] % 2 == 1)
                    cont++;
            }
            return cont;
        }


   
        //cantidad de capicua
        public int ContarCapicua() {
            int cont = 0;
            int invertir = 0;
            int n = 0;
            int aux = 0;

            for (int i = 0; i < lg; i++) {
                n = vector[i];
                invertir = 0; // Reiniciar invertir para cada elemento

                while (n > 0) {
                    aux = n % 10;
                    invertir = invertir * 10 + aux;
                    n = n/10;
                }

                if (vector[i] == invertir){
                    cont++;
                }
            }

            return cont;
        }
        


        public int ContarPrimos() {
            int cont = 0;
            int c = 0;

            for (int i = 0; i < lg; i++){
                cont = 0; // Reiniciar el contador para cada número
                for (int j = 1; j <= vector[i]; j++){
                    if (vector[i] % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2){
                    c++;
                }
            }
            return c;
        }










    }
}
