
namespace HolidaySearch;

public class HolidaySearch
{
    private readonly CustomerRequirements _customerRequirements;
    private readonly IFlightSearch _flightSearch;
    private readonly IHotelSearch _hotelSearch;

    public HolidaySearch(
        CustomerRequirements customerRequirements,
        IFlightSearch flightSearch = null,
        IHotelSearch hotelSearch = null)
    {
        _customerRequirements = customerRequirements;
        _flightSearch = flightSearch;
        _hotelSearch = hotelSearch;
    }

    public IEnumerable<SearchResult> Search()
    {
        //Exact match
        //HotelSearch
        //FlightSearch
        //Total price
        var matchingFlight = _flightSearch.Search().First();
        _hotelSearch.Search();

        return new List<SearchResult> {
            new SearchResult
            {
                Flight = matchingFlight
            }
        };
    }
}