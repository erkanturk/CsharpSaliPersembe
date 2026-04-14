using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Ado.Net.Models
{
    public class Ogretmen
    {//Öğretmen tarafı veritabanında benim tablom
        //Sütunları ise property de belirttiğim alan
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Brans { get; set; }
    }
}
