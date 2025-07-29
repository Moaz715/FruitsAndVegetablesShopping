using MVC_Group7_demo_DAL.Entities;


namespace MVC_Group7_demo_DAL.Repository.Abstraction
{
    public interface ICartRepo
    {
        (bool, string?) Create(Cart cart);

        //(bool, string) Edit(); //ynf3 aslan a3ml edit l Order?

        (Cart?, string?) GetById(int id);

        (List<Cart>?, string?) GetAll();

        (bool, string?) Delete(int id);

        
    }
}
