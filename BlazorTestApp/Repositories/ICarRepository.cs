using BlazorTestApp.Models;

namespace BlazorTestApp.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetCars();

        Car GetCar(int id);

        void AddCar(Car car);

        void DeleteCar(int id);

        void UpdateCar(Car car);
    }
}
