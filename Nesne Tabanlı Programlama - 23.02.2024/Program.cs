using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama___23._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 265;
            //byte b;
            //checked || Veri kaybını önler.

            //b = (byte)i;   //integer değerine çevirmeye çalıştığımız için hata verdi.

            //Console.WriteLine(b);
            //Console.ReadLine();

            //--Bu kısım ayrı--//

            //byte i = 254;
            //int j = 500;
            //byte b, c;

            //checked
            //{
            //    b = (byte)i;
            //    Console.WriteLine(b);
            //}

            //unchecked
            //{
            //    c = (byte)i;
            //    Console.WriteLine(c);
            //}
            //   Console.ReadLine();

            //--Bu kısım ayrı--//

            //Boxing kutulama, bilinçsiz tür dönüşümü.

            //int a = 500;
            //object b = a;
            //Console.WriteLine(b);
            //Console.ReadLine();

            //Bilinçli tür dönüşümü. 

            //int a = 500;
            //object b = (object)a;
            //Console.WriteLine();
            //Console.ReadLine();

            //--Bu kısım ayrı--//

            //int i = 15;
            //object o = i; //Boxing
            //int j = (short)o; +unboxing (integer veri türünü short türüne çevirmeye çalıştığımız için hata verdi.
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.ReadLine();

            //--Bu kısım ayrı--//

            string s1, s2, s3;
            int i1, i2, i3;
            Console.WriteLine("1.Sayıyı gir.");
            s1 = Console.ReadLine();

            Console.WriteLine("2.Sayıyı gir");
            s2 = Console.ReadLine();

            Console.WriteLine("3.Sayıyı gir");
            s3 = Console.ReadLine();

            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);
            i3 = Convert.ToInt32(s3);

            i3 = i1 + i2 + i3;
            Console.WriteLine("Toplam: " + i3);
            Console.ReadLine();
              



        }
    }
}
