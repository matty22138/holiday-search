namespace HolidaySearch.Tests;

public class HolidaySearchUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetResults_WithCustomerRequirments_ReturnsTheBestFlightInTheResults()
    {
        var holidaySearch = new HolidaySearch(new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "TFS",
            DepartureDate = "2023/07/01",
            Duration = 7
        });

        var result = holidaySearch.GetResults().First();

        Assert.That(result.Flight.Id, Is.EqualTo(1));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo("MAN"));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo("TFS"));
        Assert.That(result.Flight.Price, Is.EqualTo("£470.00"));
    }

    [Test]
    public void GetResults_WithDifferentCustomerRequirments_ReturnsTheBestFlightInTheResults()
    {
        var holidaySearch = new HolidaySearch(new CustomerRequirements
        {
            DepartingFrom = "MAN",
            TravelingTo = "LPA",
            DepartureDate = "2022-11-10",
            Duration = 7
        });

        var result = holidaySearch.GetResults().First();

        Assert.That(result.Flight.Id, Is.EqualTo(1));
        Assert.That(result.Flight.DepartingFrom, Is.EqualTo("MAN"));
        Assert.That(result.Flight.TravellingTo, Is.EqualTo("LPA"));
        Assert.That(result.Flight.Price, Is.EqualTo("£125.00"));
    }
}
