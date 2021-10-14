using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareamiguel
{
    class Program
    {
        static void Main(string[] args)
        {


            int n1, n2, n3, n4;
            String n11 = null, n22 = null, n33 = null, n44 = null;

            Console.WriteLine("Digite un numero en el rango de 1 al 9999: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10)
            {

                n1 = num;

                switch (n1)
                {
                    case 1:
                        n11 = "UNO";
                        break;

                    case 2:
                        n11 = "DOS";
                        break;

                    case 3:
                        n11 = "TRES";
                        break;

                    case 4:
                        n11 = "CUATRO";
                        break;

                    case 5:
                        n11 = "CINCO";
                        break;

                    case 6:
                        n11 = "SEIS";
                        break;

                    case 7:
                        n11 = "SIETE";
                        break;

                    case 8:
                        n11 = "OCHO";
                        break;

                    case 9:
                        n11 = "NUEVE";
                        break;
                }

                Console.WriteLine("Numero convertido a letra: " + n11);
            }



            else if (num > 9 && num < 100)
            {
                n1 = num / 10;
                n2 = num % 10;


			
            



                switch (n1)
                {
                    case 1:
                        n11 = "DIEZ";
                        break;

                    case 2:
                        n11 = "VEINTE";
                        break;

                    case 3:
                        n11 = "TREINTA";
                        break;

                    case 4:
                        n11 = "CUARENTA";
                        break;

                    case 5:
                        n11 = "CINCUENTA";
                        break;

                    case 6:
                        n11 = "SESENTA";
                        break;

                    case 7:
                        n11 = "SETENTA";
                        break;

                    case 8:
                        n11 = "OCHENTA";
                        break;

                    case 9:
                        n11 = "NOVENTA";
                        break;
                }

                switch (n2)
                {
                    case 1:
                        n22 = "UNO";
                        break;

                    case 2:
                        n22 = "DOS";
                        break;

                    case 3:
                        n22 = "TRES";
                        break;

                    case 4:
                        n22 = "CUATRO";
                        break;

                    case 5:
                        n22 = "CINCO";
                        break;

                    case 6:
                        n22 = "SEIS";
                        break;

                    case 7:
                        n22 = "SIETE";
                        break;

                    case 8:
                        n22 = "OCHO";
                        break;

                    case 9:
                        n22 = "NUEVE";
                        break;
                }






                Console.WriteLine("Numero convertido a letra: " + n11 + " Y " + n22);

            }























            else if (num > 99 && num < 1000)
            {
                n1 = (num / 100);
                n2 = (num % 100) / 10;
                n3 = (num % 10);


                switch (n1)
                {
                    case 1:
                        n11 = "CIENTO";
                        break;

                    case 2:
                        n11 = "DOSCIENTOS";
                        break;

                    case 3:
                        n11 = "TRESCIENTOS";
                        break;

                    case 4:
                        n11 = "CUATROSCIENTOS";
                        break;

                    case 5:
                        n11 = "QUINIENTOS";
                        break;

                    case 6:
                        n11 = "SEISCIENTOS";
                        break;

                    case 7:
                        n11 = "SETESCIENTOS";
                        break;

                    case 8:
                        n11 = "OCHOSCIENTOS";
                        break;

                    case 9:
                        n11 = "NOVECIENTOS";
                        break;
                }

                switch (n2)
                {
                    case 1:
                        n22 = "DIEZ";
                        break;

                    case 2:
                        n22 = "VEINTE";
                        break;

                    case 3:
                        n22 = "TREINTA";
                        break;

                    case 4:
                        n22 = "CUARENTA";
                        break;

                    case 5:
                        n22 = "CINCUENTA";
                        break;

                    case 6:
                        n22 = "SESENTA";
                        break;

                    case 7:
                        n22 = "SETENTA";
                        break;

                    case 8:
                        n22 = "OCHENTA";
                        break;

                    case 9:
                        n22 = "NOVENTA";
                        break;
                }

                switch (n3)
                {
                    case 1:
                        n33 = "UNO";
                        break;

                    case 2:
                        n33 = "DOS";
                        break;

                    case 3:
                        n33 = "TRES";
                        break;

                    case 4:
                        n33 = "CUATRO";
                        break;

                    case 5:
                        n33 = "CINCO";
                        break;

                    case 6:
                        n33 = "SEIS";
                        break;

                    case 7:
                        n33 = "SIETE";
                        break;

                    case 8:
                        n33 = "OCHO";
                        break;

                    case 9:
                        n33 = "NUEVE";
                        break;
                }



                Console.WriteLine("Numero convertido a letra: " + n11 + " " + n22 + " Y " + " " + n33);
            }



















            else if (num > 999)
            {
                n1 = (num / 1000);
                n2 = (num % 1000) / 100;
                n3 = (num % 100) / 10;
                n4 = (num % 10);




                switch (n1)
                {
                    case 1:
                        n11 = "MIL";
                        break;

                    case 2:
                        n11 = "DOSMIL";
                        break;

                    case 3:
                        n11 = "TRESMIL";
                        break;

                    case 4:
                        n11 = "CUATROMIL";
                        break;

                    case 5:
                        n11 = "CINCOMIL";
                        break;

                    case 6:
                        n11 = "SEISMIL";
                        break;

                    case 7:
                        n11 = "SIETEMIL";
                        break;

                    case 8:
                        n11 = "OCHOMIL";
                        break;

                    case 9:
                        n11 = "NUEVEMIL";
                        break;
                }
                switch (n2)
                {
                    case 1:
                        n22 = "CIENTO";
                        break;

                    case 2:
                        n22 = "DOSCIENTOS";
                        break;

                    case 3:
                        n22 = "TRESCIENTOS";
                        break;

                    case 4:
                        n22 = "CUATROSCIENTOS";
                        break;

                    case 5:
                        n22 = "QUINIENTOS";
                        break;

                    case 6:
                        n22 = "SEISCIENTOS";
                        break;

                    case 7:
                        n22 = "SETESCIENTOS";
                        break;

                    case 8:
                        n22 = "OCHOSCIENTOS";
                        break;

                    case 9:
                        n22 = "NOVECIENTOS";
                        break;
                }
                switch (n3)
                {
                    case 1:
                        n33 = "DIEZ";
                        break;

                    case 2:
                        n33 = "VEINTE";
                        break;

                    case 3:
                        n33 = "TREINTA";
                        break;

                    case 4:
                        n33 = "CUARENTA";
                        break;

                    case 5:
                        n33 = "CINCUENTA";
                        break;

                    case 6:
                        n33 = "SESENTA";
                        break;

                    case 7:
                        n33 = "SETENTA";
                        break;

                    case 8:
                        n33 = "OCHENTA";
                        break;

                    case 9:
                        n33 = "NOVENTA";
                        break;
                }

                switch (n4)
                {
                    case 1:
                        n44 = "UNO";
                        break;

                    case 2:
                        n44 = "DOS";
                        break;

                    case 3:
                        n44 = "TRES";
                        break;

                    case 4:
                        n44 = "CUATRO";
                        break;

                    case 5:
                        n44 = "CINCO";
                        break;

                    case 6:
                        n44 = "SEIS";
                        break;

                    case 7:
                        n44 = "SIETE";
                        break;

                    case 8:
                        n44 = "OCHO";
                        break;

                    case 9:
                        n44 = "NUEVE";
                        break;
                }

                Console.WriteLine("Numero convertido a letra: " + n11 + " " + n22 + " " + " " + n33 + " " + "Y" + " " + n44);

            }

            Console.ReadKey();
        
        }
    
    
    }
}

