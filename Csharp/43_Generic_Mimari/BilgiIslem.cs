using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generic_Mimari
{
    internal class BilgiIslem : Personel, IPersonel<BilgiIslem>
    {
        public string DonanimAdi { get; set; }

        public void Delete(BilgiIslem entity)
        {
            throw new NotImplementedException();
        }

        public List<BilgiIslem> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(BilgiIslem entity)
        {
           
        }

        public void Update(BilgiIslem entity)
        {
            entity.DonanimAdi = "";
            entity.Tc = "";
            entity.Id = 1;
            entity.SgkGirisTarihi = DateTime.Now;
            entity.Update(this);

        }
    }
}
