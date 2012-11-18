using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtyManager.Models
{
        // test
        public class RealtyRepository : IRealtyRepository
        {
            private List<Realty> realties = new List<Realty>();
            private int _nextIdReal = 1;

            //for profile repository

            //private List<Profile> profiles = new List<Profile>();
            //private int _nextIdProf = 1;

            public RealtyRepository()
            {
               
            }

            public IEnumerable<Realty> GetAll()
            {
                return realties;
            }

            public Realty Get(int id)
            {
                return realties.Find(p => p.RealtyId == id);
            }

            public Realty Add(Realty item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                item.RealtyId = _nextIdReal++;
                realties.Add(item);
                return item;
            }

            public void Delete(int id)
            {
                realties.RemoveAll(p => p.RealtyId == id);
            }

            public Realty Update(Realty item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                int index = realties.FindIndex(p => p.RealtyId == item.RealtyId);
                realties.RemoveAt(index);
                realties.Add(item);
                return item;
            }
        }
    }
