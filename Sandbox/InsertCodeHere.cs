using System;

namespace Sandbox
{
    public class InsertCodeHere
    {

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Calculator c = new Calculator();
            Console.WriteLine("Skriv tal, som 20 skal divideres med: ");
            int tal = int.Parse(Console.ReadLine());

            try
            {
                int resultat = c.Division(20, tal);
                Console.WriteLine($"Resultatet er {resultat}");
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Fejl i division- du har forsøgt at dividere med 0");
            }
            catch (TooLargeNumberException tex)
            {
                Console.WriteLine($"Der skete en fejl {tex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der skete en generel fejl");
            }
            finally
            {
                Console.WriteLine("Nu er divisionen forsøgt gennemført - denne del udføres altid");
            }

            


            Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}