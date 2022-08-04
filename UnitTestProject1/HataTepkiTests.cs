using ExamplePlay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class HataTepkiTests
    {
        [TestMethod]
        //Exeption hataların atası olduğu için tek başına bir hata olarak belirtilemez.
        //Eger Exeption olarak gelen hatada tipini özel olarak bulmasını istiyorsak AllowDerivedTypes özelliğini
        //true haline getiririz.
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)] //=>Burada gelen hatayı otomatik tanıttık ve testi geçirdik.

        //Bizzat hangi hata olduğunu belirttiğimizde sadece o hatayı tanıyacaktır ve testi başarı ile
        // geçecektir. ArgumentExeption, Exeption türlerinden 1i olduğu için bu şekilde kabul edecektir.
        // [ExpectedException(typeof(ArgumentException))]
        public void TM1()
        {
            bool beklenen = true;
            bool gelen = HataTepki.Hata();
            Assert.AreEqual(beklenen,gelen);
        }
    }
}
