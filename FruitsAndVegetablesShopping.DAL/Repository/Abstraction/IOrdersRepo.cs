

using MVC_Group7_demo_DAL.Entities;

namespace MVC_Group7_demo_DAL.Repository.Abstraction
{
    public interface IOrdersRepo
    {
        (bool, string?) Create(Orders order);

        (bool, string) Edit(); 

        (Orders?, string?) GetById(int id);

        (List<Orders>?, string?) GetAll();

        (bool, string?) Delete(int id);
    }
}
