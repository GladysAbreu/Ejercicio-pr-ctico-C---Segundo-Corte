using System;

namespace CORTE_2
{
    class Program
    {
        static void Main(string[] args)
        {
          string cadena="";
          int edad=0;
          double altura=0.0;

          Console.WriteLine("Bienvenido a ExtremeAdventures, por favor indiquenos su edad:");
          cadena=Console.ReadLine();
          edad= Convert.ToInt32(cadena);

          if (edad>=12)
          {
            Console.WriteLine("Bienvenido puedes disfrutar de todas las atracciones, dependiendo de tu altura.");
          }
          if (edad<=11)
          {
            Console.WriteLine("No puedes entrar a ciertas atracciones ya que no cumples con la edad estimada."); 
          }

          Console.WriteLine("Por favor, para disfrutar de una mayor experiencia en nuestro parque, indiquenos su altura en metros:");
          cadena=Console.ReadLine();
          altura= Convert.ToDouble(cadena);

          if (altura>=1.4 && edad>=12)
          Console.WriteLine("Puedes disfrutar de atracciones como la montaña rusa, los columpios voladores, el barco, y muchas más.");
          else if (altura<=1.4 && edad>=12)
          Console.WriteLine("Puedes disfrutar de atracciones como los columpios voladores, los carritos chocones, la noria y demás tanto infantiles como en general, excepto algunas como la montaña rusa ya que no cumples con la estatura.");
          else if (altura>=0.8 && edad<=11)
          Console.WriteLine("Puedes disfrutar de atracciones como el gusanito, el carrusel, los carritos chocones, y demás atracciones infantiles.");


          
          
            





              
                    
                


              
             

            
               



            



            
        }
    }
}
