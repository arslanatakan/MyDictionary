using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //**** Eğer hali hazırdaki dictionary'ı kullansaydık bu şekilde kullanırdık:
            //Dictionary<int, string> plakaSehir = new Dictionary<int, string>();
            //plakaSehir.Add(34, "İstanbul");
            //plakaSehir.Add(68, "Aksaray");
            //plakaSehir.Add(38, "Kayseri");
            //plakaSehir.Add(32, "Isparta");

            //foreach (var sehirler in plakaSehir)
            //{
            //    Console.WriteLine(sehirler);
            //}

            //"""" Ancak biz kendi dictionary metodumuzu yazacağımız için:

            MyDictionary<int, string> plakaSehir2 = new MyDictionary<int, string>();
            plakaSehir2.Add(34, "İstanbul");
            plakaSehir2.Add(68, "Aksaray");
            plakaSehir2.Add(38, "Kayseri");
            plakaSehir2.Add(32, "Isparta");
            Console.WriteLine(plakaSehir2.Count); //--> 4 sonucunu verdi. Yani başarıyla 4 adet veri ekleyebildik.


         

        }
    }



    class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;
        K[] _tempKey;
        V[] _tempValue;
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K item1, V item2)
        {
            _tempKey = _key;
            _tempValue = _value;
           
            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];
           
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = item1;
            _value[_value.Length - 1] = item2;
        }
       

        public int Count
        {
            get { return _key.Length; }
            
        }



    }
}
