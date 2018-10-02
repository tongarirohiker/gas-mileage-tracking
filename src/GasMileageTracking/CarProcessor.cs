using System;
using System.Collections.Generic;
using System.Text;

namespace GasMileageTracking
{

	public class Car
	{
		public string Name { get; set; }
	}

    public class CarProcessor : ICarProcessor
    {
	    public Car CreateCar(string name)
	    {
		    return new Car {Name = name};
	    }

	    public Car GetCar(string name)
	    {
		    return new Car { Name = $"{name} {DateTime.UtcNow}" };
	    }
	}
}
