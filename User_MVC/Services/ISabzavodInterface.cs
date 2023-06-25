using User_MVC.Models;

namespace User_MVC.Services
{
    public interface ISabzavodInterface
    {
        List<Sabzavot> GetAllsabz();
        Sabzavot GetById(int id);
        Sabzavot Add_S(Sabzavot newsabzavot);
        bool Update_S(Sabzavot sabzavot);
        bool DeleteById(int id);
    }
}
