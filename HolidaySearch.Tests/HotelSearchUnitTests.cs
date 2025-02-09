namespace HolidaySearch.Tests;

public class HotelSearchUnitTests
{
    [Test]
    public void ExactSearch_WithCustomerRequirments_ReturnsTheExactMatchingHotel()
    {
        var hotelSearch = new HotelSearch(new CustomerRequirements()
        {
            DepartingFrom = "LGW",
            TravelingTo = "AGP",
            DepartureDate = "2023-07-01",
            Duration = 7
        });

        var result = hotelSearch.ExactSearch().First();

        Assert.That(result.Id, Is.EqualTo(9));
        Assert.That(result.Name, Is.EqualTo("Nh Malaga"));
        Assert.That(result.PricePerNight, Is.EqualTo(83));
        Assert.That(result.TotalPrice, Is.EqualTo(581));
    }

    [Test]
    public void ExactSearch_WithDifferentCustomerRequirments_ReturnsTheExactMatchingHotel()
    {
        var hotelSearch = new HotelSearch(new CustomerRequirements()
        {
            DepartingFrom = "MAN",
            TravelingTo = "AGP",
            DepartureDate = "2023-07-05",
            Duration = 10
        });

        var result = hotelSearch.ExactSearch().First();

        Assert.That(result.Id, Is.EqualTo(10));
        Assert.That(result.Name, Is.EqualTo("Barcelo Malaga"));
        Assert.That(result.PricePerNight, Is.EqualTo(45));
        Assert.That(result.TotalPrice, Is.EqualTo(450));
    }

    // [Test]
    // public void ExactSearch_WhereNoHotelsMatchCustomerRequirements_ReturnsNoHotel()
    // {
    //     var holidaySearch = new FlightSearch(new CustomerRequirements()
    //     {
    //         DepartingFrom = "MAN",
    //         TravelingTo = "AGP",
    //         DepartureDate = "2025-10-25",
    //         Duration = 7
    //     });

    //     var results = holidaySearch.ExactSearch();

    //     Assert.That(results, Is.Empty);
    // }
}