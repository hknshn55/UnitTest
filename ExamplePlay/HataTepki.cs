using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlay
{
    public static class HataTepki
    {
        //Bir metodumuz olsun ve bu metodun işlemlerinden biri hata döndürmek olsun.
        //Bu metod üzerinde bilerek hata verdirdiğimizde test ten başarısız sonucunu alırız.
        //Yani bilerek verdirdiğimiz hatayı tanıtmamız gereklidir. Burada hata vermesi normal
        //şeklinde bildirmemiz gerekiyor.

        public static bool Hata()
        {
            bool value = false;
            if (value)
            {
                return value;
            }
            throw new Exception($"{value} true olmalıdır.");
        }
    }
}
