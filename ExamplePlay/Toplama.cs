using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlay
{
    public class Toplama
    {
        //iki sayıyı toplayabiliyormu?
        static public string Topla(int x1, int x2)
        {
            int result = x1 + x2;

            return result.ToString();
        }
        
        //Gelen ifadeler gerçekten tam sayiya dönüşüyormu? (Bu örnekte zaten int deger yolladigimiz icin sacma
        //görünüyor ama önemi yok sadece testimizden başarılı bir şekilde geçiyormu bunun kontrolünü yapalım)
        public static bool TamSayiDonusum(int sayi1,int sayi2)
        {
            bool value = false;
            int dondu;
            value = int.TryParse(Topla(sayi1, sayi2),out dondu);
            if (value)
            {
                return value;
            }
            return value;
        }
    }
}
