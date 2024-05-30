using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HusSagLib
{
    public class HusSagRepository
    {
        public int _nextId = 6;

        public List<HusSag> husSager = new(){
        new HusSag(){Id=1,Vej="Askvangen",HusNr=80,By="Allerød",Pris=3000000},
        new HusSag(){Id=2,Vej="Rosklildevej",HusNr=130,By="Rosklilde",Pris=2000000},
        new HusSag(){Id=3,Vej="Københavevej",HusNr=80,By="københavn",Pris=4000000},
        new HusSag(){Id=4,Vej="ligustervangen",HusNr=2,By="Allerød",Pris=4500000},
        new HusSag(){Id=5,Vej="Magelgåsvej",HusNr=12,By="Roskilde",Pris=5000000}
        };


        public void Add(HusSag husSag)
        {
            husSag.Id = _nextId++;
            husSager.Add(husSag);
        }

        public List<HusSag> GetAll()
        {
            return new List<HusSag>(husSager);
        }

        public HusSag? GetById(int id)
        {
            return husSager.FirstOrDefault(h => h.Id == id);
        }

     

      
    }
}
