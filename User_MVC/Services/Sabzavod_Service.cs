using User_MVC.Models;

namespace User_MVC.Services
{
    public class Sabzavod_Service : ISabzavodInterface
    {
        List<Sabzavot> allsabz;
        public Sabzavod_Service()
        {
            allsabz = new List<Sabzavot>()
            {
                new Sabzavot()
                {
                Id = 1,
                Name = "Karam",
                Price=7000
                }

            };

                        
        }

        public List<Sabzavot> GetAllsabz()
        {
            return allsabz;
        }

        public Sabzavot GetById(int id)
        {
            return allsabz.FirstOrDefault(b => b.Id == id);
        }

        public Sabzavot Add_S(Sabzavot newsabzavot)
        {
            allsabz.Add(newsabzavot);
            return newsabzavot;
        }

        bool ISabzavodInterface.Update_S(Sabzavot sabzavot)
        {
            try
            {
                foreach (var b in allsabz)
                {
                    if (b.Id == sabzavot.Id)
                    {
                        b.Id = sabzavot.Id;
                        b.Name = sabzavot.Name;
                        b.Price = sabzavot.Price;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool ISabzavodInterface.DeleteById(int id)
        {
            try
            {
                var sabzId = allsabz.FirstOrDefault(b => b.Id == id);
                allsabz.Remove(sabzId);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
