using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(3, 2);
            bool p = lista.borraElto(5);
        }
    }

    
    public class Lista
    {
        private class Nodo
        {
            public int dato;
            public Nodo sig;
            public Nodo(int e)
            {
                dato = e;
            }
        }
        Nodo pri;
        public Lista(int limite, int rep)
        {
            pri = null;

            for (int i = 0; i < rep; i++)
            {
                for (int j = 1; j <= limite; j++)
                {
                    insertaFin(j);
                }
            }
        }

        public void insertaFin(int e)
        {
            Nodo aux = pri;
            Nodo n = new Nodo(e);
            

            if (aux != null)
            {
                while (aux.sig != null)
                {
                    aux = aux.sig;
                }
                aux.sig = n;
                n.sig = null;
            }
            else
            {
                pri = n;
                n.sig = null;
            }

        }

        public int cuentaEltos()
        {
            int eltos = 0;

            Nodo aux = pri;

            while(aux != null)
            {
                aux = aux.sig;
                eltos++;
            }

            return eltos;
        }

        public bool borraElto(int e)
        {

            Nodo aux = pri;
            Nodo anterior = null;

            bool deleted = false;

            if(pri != null)
            {
                if(aux == pri && aux.dato == e)
                {
                    
                    pri = aux.sig;
                    deleted = true;
                    
                    
                }else
                {
                    
                    while(aux.sig != null && aux.sig.dato != e)
                    {
                        aux = aux.sig;
                    }

                    if (aux.sig != null)
                    {
                        anterior = aux;
                        aux = aux.sig;
                        anterior.sig = aux.sig;
                        deleted = true;
                    }
                    else deleted = false;
                        
                    
                }
            }

            return deleted;
        }

        public int nEsimo(int n)
        {
            Nodo aux = pri;

            int cont = 0;
            int dato = 0;

            if(aux == null ||  n < 0 || n > cuentaEltos())
            {
                throw new Exception("ERROR : Valor fuera de los limites");
            }

            while(aux != null)
            {

                if(cont == n)
                {
                    dato = aux.dato;
                }
                aux = aux.sig;
                cont++;

            }

            return dato;
        }

        public string aCadena()
        {
            Nodo aux;

            string cadena = null;

            aux = pri;

            while(aux != null)
            {
                cadena = cadena + aux.dato;
                aux = aux.sig;
            }

            return cadena;
        }
    }

}
