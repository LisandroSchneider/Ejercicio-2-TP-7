using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccionEstablecimiento,eleccionEncuesta;
            float promedioPrivado=0,promedioPublico=0,encuestados=0,alumnoPublico=0,alumnoPrivado=0;
            
            do
            {
              Console.Clear();
           
            
            Console.WriteLine("¿Desea realizar una encuesta?");
            Console.WriteLine("Presione 1 para SI");
            Console.WriteLine("Presione 2 para NO");
            eleccionEncuesta = Convert.ToInt32(Console.ReadLine());

            if(eleccionEncuesta == 1 )
            {
                Console.WriteLine("¿Usted concurre a un establecimiento Privado o Publico?");
                Console.WriteLine("Presione 1 para Privado");
                Console.WriteLine("Presione 2 para Publico");

                eleccionEstablecimiento = Convert.ToInt32(Console.ReadLine());

                    if(eleccionEstablecimiento == 1)
                    {
                        alumnoPrivado = alumnoPrivado + 1;
                    }

                    if(eleccionEstablecimiento == 2)
                    {
                        alumnoPublico = alumnoPublico + 1;
                    }
                encuestados = encuestados + 1;
                
            }
            
                promedioPrivado = (alumnoPrivado/encuestados)*100;
                promedioPublico = (alumnoPublico/encuestados)*100;

            } while (eleccionEncuesta == 1);

            Console.Clear();
             
            

            Console.WriteLine("Cantidad de encuestados:{0}",encuestados);
            Console.WriteLine("Cantidad de concurrentes a establecimientos Privados:{0} Porcentaje:{1}%",alumnoPrivado,promedioPrivado);
            Console.WriteLine("Cantidad de concurrentes a establecimientos Publicos:{0} Porcentaje:{1}%",alumnoPublico,promedioPublico);
            




        }
    }
}
