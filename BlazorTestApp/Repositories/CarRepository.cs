using BlazorTestApp.Models;

namespace BlazorTestApp.Repositories
{
	public class CarRepository : ICarRepository
	{

		private List<Car> Cars;
		private int nextId;

		public CarRepository()
		{
			Cars = new List<Car>();

			var car = new Car()
			{
				Name = "Octane",
				CurrentBoost = 0,
				HitboxType = HitboxType.Octane,
			};

			AddCar(car);

			nextId = 1;
		}


		public void AddCar(Car car)
		{
			car.Id = nextId;
			Cars.Add(car);
			nextId++;
		}

		public void DeleteCar(int id)
		{
			Cars.RemoveAll(v => v.Id == id);
		}

		public Car GetCar(int id)
		{
			return Cars.Find(v => v.Id == id);
		}

		public List<Car> GetCars()
		{
			return Cars;
		}

		public void UpdateCar(Car car)
		{
			DeleteCar(car.Id);
			Cars.Add(car);
		}
	}
}
