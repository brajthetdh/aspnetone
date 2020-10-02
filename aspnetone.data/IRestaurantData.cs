using aspnetone.core;
using System.Collections.Generic;
using System.Text;

namespace aspnetone.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetByName(string name);
        Restaurant GetById(int id);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Update(Restaurant updateRestaurant);
        int Commit();
    }
}
