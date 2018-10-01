using Xunit;

namespace GasMileageTracking.Tests
{
    public class CarProcessorTest
    {
	    [Fact]
	    public void CreateCar()
	    {
		    var name = "Chevy";
			var processor = new CarProcessor();
		    var result = processor.CreateCar(name);
			Assert.NotNull(result);
			Assert.Equal(name, result.Name);
	    }

	    [Fact]
	    public void GetCar()
	    {
		    var name = "Chevy";
		    var processor = new CarProcessor();
		    var result = processor.GetCar(name);
		    Assert.NotNull(result);
		    Assert.Equal(name, result.Name);
	    }
	}
}
