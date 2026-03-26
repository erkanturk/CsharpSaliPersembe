using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_OOP_Encapsulation_3
{
    internal class Ogrenci
    {
        private string Ad { get; set; }
        private int Yas { get; set; }
        private string Iban { get; set; }
        public string _Ad
        {
            get { return Ad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.StartsWith("A"))
                    {
                        Ad = value;
                        Console.WriteLine(Ad);
                    }
                    else
                    {
                        Console.WriteLine("A ile başlamalıdır");
                    }
                }
                else
                {
                    Console.WriteLine("Ad kısmını doldurun");
                }
            }
        }
        public int _Yas
        {
            get { return Yas; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Yaş 18 den küçük olamaz");
                }
                else
                {
                    Yas = value;
                    Console.WriteLine(Yas);
                }
            }

        }
        public string _Iban
        {
            get { return Iban; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string ibanNo = value.Substring(2);
                    long Iban;
                    if (long.TryParse(ibanNo, out Iban) && ibanNo.Length == 16)
                    {
                        this.Iban = Iban.ToString();
                        Console.WriteLine("EU" + this.Iban);
                    }
                    else
                    {
                        Console.WriteLine("16 Karakter uzunluğunda tanımlama yapılmalıdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Bir değer giriniz");
                }

            }
        }
    }
}
