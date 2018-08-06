using System;
using System.Collections.Generic;

namespace Parcial1_logic
{
    public class TestObject
    {
        public static void Main(string[] args)
        {
            //Puede hacer llamados aquí para probar su código, aunque se recomienda correr las pruebas.

            Console.ReadKey();
        }

        #region DATA_STRUCTURES

        /*
         * Esta sección del examen evalúa el dominio de las estructuras de datos lineales básicas.
         * VALOR: 2.5 (0.625 cada ejercicio)
         */

        /// <summary>
        /// Reemplaza todas las ocurrencias del número 'lookupValues'
        /// con el valor de 'replaceValue'.
        /// La cola debe retornarse en el mismo orden entregado.
        /// </summary>
        /// <param name="inputQueue">La cola con los valores originales</param>
        /// <param name="lookupValue">Número a reemplazar</param>
        /// <param name="replaceValue">Nuevo valor a insertar</param>
        /// <returns>La lista de entrada con los valores modificados</returns>
        public Queue<int> ReplaceInQueue(Queue<int> inputQueue, int lookupValue, int replaceValue)
        {
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            

            int distancia = inputQueue.Count;
            Queue<int> temp = new Queue<int>(distancia);

            for (int i = 0; i< distancia; i++)
            {
                int tempValue = inputQueue.Dequeue();

                if(tempValue == lookupValue)
                {
                    temp.Enqueue(replaceValue);
                }
                else
                {
                    temp.Enqueue(tempValue);
                    
                }
            }


            return temp;
        }

        /// <summary>
        /// Invierte el contenido de la pila 'stack'
        /// </summary>
        /// <param name="stack">La pila de entrada</param>
        /// <returns>Una pila con los valores de 'stack' invertidos</returns>
        public Stack<string> InverseStack(Stack<string> stack)
        {
            int distancia = stack.Count;
            Stack<string> temp = new Stack<string>();

            for(int i =0; i<distancia; i++)
            {
                temp.Push(stack.Pop());
            }
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            return temp;
        }

        /// <summary>
        /// Intercala igual número de elementos de 'stack' y 'queue' en una lista.
        /// La mezcla empieza insertando un elemento de 'stack', luego uno de 'queue' y así sucesivamente.
        /// </summary>
        /// <param name="stack">La pila que contiene parte de los datos</param>
        /// <param name="queue">La cola que contiene parte de los datos</param>
        /// <returns>Una lista con datos intercalados de 'stack' y 'queue'</returns>
        public List<string> MixData(Stack<string> stack, Queue<string> queue)
        {
            int distancia1 = stack.Count;
            int distancia2 = queue.Count;
            int distancia;
            List<string> temp = new List<string>();
            if(distancia1 > distancia2)
            {
                distancia = distancia2;
            }
            else
            {
                distancia = distancia1;
            }
                       
            for(int i=0; i<distancia; i++)
            {
                temp.Add(stack.Pop());
                temp.Add(queue.Dequeue());
            }
            
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            return temp;
        }

        /// <summary>
        /// Retorna el conteo de las llaves en el diccionario 'dict' que tienen como valor a 'lookupValue'.
        /// Retorna 0 si 'lookupValue' no está presente en el diccionario.
        /// Type1 y Type2 son dos clases cualquiera.
        /// </summary>
        /// <param name="dict">Diccionario con los datos</param>
        /// <param name="lookupValue">El valor a buscar en el diccionario</param>
        /// <returns></returns>
        public int RepeatedTimesInDictionary<Type1, Type2>(Dictionary<Type1, Type2> dict, Type2 lookupValue)
        {
            int cantidad = 0;
            int distancia = dict.Count;
            if (dict.ContainsValue(lookupValue))
            {
                foreach(var element in dict)
                {
                    cantidad++;
                
                }
            }
            else
            {
                return 0;
            }


           
            
    

            return cantidad;
        }

        #endregion DATA_STRUCTURES

        #region BONUS

        /*
         * Este ejercicio de bonificación agrega 0.5 sobre la nota original obtenida,
         * siempre que la nota sea de 3.5 o superior.
         *
         *
         */

        #endregion BONUS
    }
}