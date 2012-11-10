using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
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
                Profile owner1 = new Profile { Name = "Almafa", Email = "alma@alma.hu", Phone_N = "+36301234567"};
                Add(new Realty { Address = "Budapest, Irinyi Jozsef 42, 1117", Owner = owner1, Price = 1.39M, Room = 2.5, Size = 69.5, });

                Profile owner2 = new Profile { Name = "Kortefa", Email = "korte@korte.hu", Phone_N = "+36301234567" };
                Add(new Realty { Address = "Budapest, Rozsadomb, 1097", Owner = owner2, Price = 133.39M, Room = 24.5, Size = 659.5, });
                
            }

            public IEnumerable<Realty> GetAll()
            {
                return realties;
            }

            public Realty Get(int id)
            {
                return realties.Find(p => p.Id == id);
            }

            public Realty Add(Realty item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                item.Id = _nextIdReal++;
                realties.Add(item);
                return item;
            }

            public void Delete(int id)
            {
                realties.RemoveAll(p => p.Id == id);
            }

            public Realty Update(Realty item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                int index = realties.FindIndex(p => p.Id == item.Id);
                realties.RemoveAt(index);
                realties.Add(item);
                return item;
            }
        }
    }
