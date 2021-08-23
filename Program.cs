using System;

namespace Ejercicio_clase_scrip_v2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Pruebas resultados = new Pruebas();
            int[] numeroganador = new int[]
            {
                rnd.Next(0,10), rnd.Next(0,10), rnd.Next(0,10), rnd.Next(0,10)

            };
            int[] apuesta = new int[4];

            Console.WriteLine("Numero ganador: " + numeroganador[0] + "" + numeroganador[1] + "" + numeroganador[2] + "" + numeroganador[3]);
            Console.WriteLine("Porfavor ingresar los 4 digitos del numero que desea apostar uno por uno");
            Console.WriteLine("primer digito");
            apuesta[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo digito");
            apuesta[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("tercer digito");
            apuesta[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("cuarto digito");
            apuesta[3] = int.Parse(Console.ReadLine());
           
            Console.Clear();

            Console.WriteLine("Si da con 4 numeros en su orden ganara 4500 veces lo apostado,si acierta 4 numeros pero en desorden, ganara 200 veces lo apostado," +
              "si acierta las ultimas 3 en orden ganara 400 veces lo apostado,si acierta las dos ultimas ganara 50 veces lo apostado, y si acierta solo la ultima" +
              "ganara 5 veces lo apostado");

            Console.WriteLine("Ingrese cuanto desea apostar");
            int dineroApostado = int.Parse(Console.ReadLine());
            if (resultados.Prueba1(numeroganador, apuesta))
            {   
                Console.WriteLine("Ganador del primer premio!"+"ganaste :"+ dineroApostado * 4500);
            }
            else if (resultados.Prueba2(numeroganador, apuesta))
            {
                Console.WriteLine("Ganador del segundo premio!" + "ganaste :" + dineroApostado * 200);
            }
            else if (resultados.Prueba3(numeroganador, apuesta))
            {
                Console.WriteLine("Ganador del tercer premio!" + "ganaste :" + dineroApostado * 400);
            }
            else if (resultados.Prueba4(numeroganador, apuesta))
            {
                Console.WriteLine("Ganador del cuarto premio!" + "ganaste :" + dineroApostado *50);
            }
            else if (resultados.Prueba5(numeroganador, apuesta))
            {
                Console.WriteLine("Ganador del quinto premio!" + "ganaste :" + dineroApostado *5);
            }
            else 
            {
                Console.WriteLine("lo lamentamos pero tu suerte no te sonrio el dia de hoy");
            }
            
            Console.ReadLine();
        }
       

    }
    public class Pruebas
    {
       
        public bool Prueba1(int[] numeroganador, int[] apuesta)
        {
         
            return (numeroganador[0] == apuesta[0] && numeroganador[1] == apuesta[1] && numeroganador[2] == apuesta[2] && numeroganador[3] == apuesta[3]);

        }
        public bool Prueba2(int[] numeroganador, int[] apuesta)
        {
            int[] ganador = new int[4];
            for (int x=0; x < apuesta.Length; x++) 
            {
                for (int y = 0; y < apuesta.Length; y++)
                {





                    if(numeroganador[x] == apuesta[y] && ganador[y] != -1)
                    {
                        ganador[y] = -1;
                        break;
                    }
                }
            }
          
            return (ganador[0] == -1 && ganador[1] == -1 && ganador[2] == -1 && ganador[3] == -1); 
        }
    
        public bool Prueba3(int[] numeroganador, int[] apuesta)
        {
          
            return (numeroganador[1] == apuesta[1] && numeroganador[2] == apuesta[2] && numeroganador[3] == apuesta[3]);
        }

        public bool Prueba4(int[] numeroganador, int[] apuesta)
        {
          
            return (numeroganador[2] == apuesta[2] && numeroganador[3] == apuesta[3]);
        }

        public bool Prueba5(int[] numeroganador, int[] apuesta)
        {
            
            return (numeroganador[3] == apuesta[3]);
        }
    }
}
