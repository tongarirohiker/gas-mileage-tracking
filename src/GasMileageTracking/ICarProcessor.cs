namespace GasMileageTracking
{
    interface ICarProcessor
    {
	    Car CreateCar(string name);

	    Car GetCar(string name);
    }
}
