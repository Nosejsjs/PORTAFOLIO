using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T8_EDCG_1009823
{
    internal class Programa8
    {
        static void Main(string[] args)
        {
            Char signn = ' ';
            int a = 0;
            int messi = 0;
            int cr7 = 0;
            int suma = 0;
            Console.WriteLine("Ingrese una de las opciones en mayusculas");
            Console.WriteLine(" A \n B \n C");
            signn = Convert.ToChar(Console.ReadLine());

            if (signn == 'A' || signn == 'B' || signn == 'C')
            {
                switch (signn)
                {

                    case 'A':
                        Console.WriteLine("Ingres un valor");
                        messi = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            cr7++;
                            suma = suma + cr7;

                        } while (cr7 < messi);
                        break;

                    case 'B':
                        Console.WriteLine("Ingres un valor");
                        messi = Convert.ToInt32(Console.ReadLine());
                        int jh = 0;
                        for (int nose = 0; nose <= 10; jh++)
                        {
                            jh = messi * nose;
                            Console.WriteLine(messi + " * " + nose + " = " + jh);
                        }

                        break;

                    case 'C':
                        Console.WriteLine("Ingres un valor");
                        messi = Convert.ToInt32(Console.ReadLine());
                        int siu = 0;
                        int div = messi;
                        if (messi > 0)
                        {
                            Console.Write(messi + " =");
                            do
                            {
                                siu++;
                                div = messi % siu;
                                if (div == 0 && !(siu == messi))
                                {
                                    Console.Write(siu + ", ");
                                }


                            } while (siu < messi);
                        }
                        else
                        {
                            Console.WriteLine("valor incorrecto");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("el valor no pertenece al menu");
            }
            Console.ReadKey();
        }
    }
}