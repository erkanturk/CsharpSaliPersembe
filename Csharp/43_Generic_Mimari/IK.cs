using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generic_Mimari
{
    internal class IK : Personel, IPersonel<IK>
    {
        public void Delete(IK entity)
        {
            throw new NotImplementedException();
        }

        public List<IK> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(IK entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IK entity)
        {
            throw new NotImplementedException();
        }
    }
}
