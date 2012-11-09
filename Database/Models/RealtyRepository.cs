using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
{
 
        public class RealtyRepository : IRealtyRepository
        {
            private List<Realty> realties = new List<Realty>();
            private int _nextId = 1;

            public RealtyRepository()
            {
                Add(new Realty { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
                Add(new Realty { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
                Add(new Realty { Name = "Hammer", Category = "Hardware", Price = 16.99M });
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
                item.Id = _nextId++;
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
