using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_3
{
    public interface ICalisan
    {
        int SgkNo { get; set; }
        int Maas { get; set; }
        int MaasHesapla();
    }
}
