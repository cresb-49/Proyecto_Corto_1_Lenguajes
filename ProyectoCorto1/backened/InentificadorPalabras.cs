using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCorto1
{
    class InentificadorPalabras
    {
        public InentificadorPalabras()
        {

        }
        public void pocesarTexto(List<String> palabrasEncotradas)
        {
            Console.WriteLine("Hola como estas");
        }
        private int contadorEspacios(String cadenaProcesar)
        {
            int inicio = 0;
            int cantidadEspacios = 0;
            while (cadenaProcesar.IndexOf(" ", inicio) != -1)
            {
                if (cadenaProcesar.IndexOf(" ", inicio) > -1)
                {
                    cantidadEspacios++;
                    inicio = cadenaProcesar.IndexOf(" ", inicio) + 1;
                }
            }
            return cantidadEspacios;
        }
        public List<String> palabrasEncontadas(String arreglo)
        {
            List<String> palabras = new List<String>();
            int inicio = 0;
            int fin = 0;
            fin = arreglo.IndexOf(" ") - 1;
            for (int i = 0; i < contadorEspacios(arreglo); i++)
            {
                palabras.Add(extraerTexto(arreglo, inicio, fin));
                inicio = fin + 2;
                fin = arreglo.IndexOf(" ", inicio) - 1;
            }
            fin = (arreglo.Length) - 1;
            palabras.Add(extraerTexto(arreglo, inicio, fin));
            return palabras;
        }
        private String extraerTexto(String cadena, int inicio, int fin)
        {
            String temporal = "";
            for (int i = inicio; i <= fin; i++)
            {
                temporal = temporal + cadena.Substring(i, 1);
            }
            return temporal;
        }
        public String clasificacionCadena(String cadenaAnalizar)
        {
            String resultado = "no reconocido";

            int L = 0;
            int N = 0;
            int S = 0;

            for(int i = 0; i < cadenaAnalizar.Length; i++)
            {
                int acii = System.Convert.ToInt32(Convert.ToChar(cadenaAnalizar.Substring(i, 1)));
                if( (acii>=65&&acii<=90) || (acii >= 97 && acii <= 122))
                {
                    L++;
                }
                if ((acii >= 48 && acii <= 57))
                {
                    N++;
                }
                if((acii>=33&&acii<=47) || (acii >= 58 && acii <= 63) || (acii >= 123 && acii <= 126))
                {
                    S++;
                }
            }
            Console.WriteLine($"Letras :{L}, Numeros: {N}, Signos: {S}");
            if (L == 0 && N == 0 && S > 0)
            {
                return resultado;
            }
            if (L == 1 && N==0 && S==0)
            {
                return "letra";
            }
            if (L>0 && N==0 && S==0)
            {
                return "palabra";
            }
            if(L == 0 && N > 0 && S == 0)
            {
                return "cantidad numerica entera";
            }
            if (L == 0 && N > 0 && S == 1)
            {
                if (cadenaAnalizar.IndexOf(".") > -1)
                { 
                    if (cadenaAnalizar.IndexOf(".") == 0) {
                        return resultado;
                    }
                    else
                    {
                        if (cadenaAnalizar.IndexOf(".") == (cadenaAnalizar.Length-1))
                        {
                            return resultado;
                        }
                        else
                        {
                            return "cantidad numerica decimal";
                        }
                    }
                }
                else
                {
                    return resultado;
                }
            }

            if (L == 1 && N > 0 && S == 0)
            {
                if (cadenaAnalizar.IndexOf("Q") == 0)
                {
                    return "Cantidad Monetaria en numero entero";
                }
                else
                {
                    return resultado;
                }
            }
            if (L == 1 && N > 0 && S == 1)
            {
                if(cadenaAnalizar.IndexOf(".") > -1)
                {
                    if (cadenaAnalizar.IndexOf("Q") == 0)
                    {
                        if((cadenaAnalizar.IndexOf(".") > 1)&&(cadenaAnalizar.IndexOf(".") <cadenaAnalizar.Length-1))
                        {
                            return "Cantidad Monetaria en numero decimal";
                        }
                    }
                    else
                    {
                        return resultado;
                    }
                }
                else
                {
                    return resultado;
                }
            }
            if(L>0 && N>0 && S > 0)
            {
                return resultado;
            }

            return resultado;
        }
    }
}
