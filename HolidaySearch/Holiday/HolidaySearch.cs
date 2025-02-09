
namespace HolidaySearch;

public class HolidaySearch
{
    private readonly CustomerRequirements _customerRequirements;
    private readonly IFlightSearch _flightSearch;
    private readonly IHotelSearch _hotelSearch;

    public HolidaySearch(
        CustomerRequirements customerRequirements,
        IFlightSearch flightSearch,
        IHotelSearch hotelSearch)
    {
        _customerRequirements = customerRequirements;
        _flightSearch = flightSearch;
        _hotelSearch = hotelSearch;
    }

    public IEnumerable<Holiday> Search()
    {
        var matchingFlights = _flightSearch.Search();

        if (!matchingFlights.Any())
        {
            return Enumerable.Empty<Holiday>();
        }

        var matchingFlight = matchingFlights.First();

        var matchingHotel = _hotelSearch.Search().First();

        return new List<Holiday> {
            new Holiday
            {
                Flight = matchingFlight,
                Hotel = matchingHotel,
                TotalPrice = matchingFlight.Price + matchingHotel.TotalPrice
            }
        };
    }
}