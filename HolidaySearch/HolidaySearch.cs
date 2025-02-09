
namespace HolidaySearch;

public class HolidaySearch
{
    private readonly CustomerRequirements _customerRequirements;
    private readonly IFlightSearch _flightSearch;

    public HolidaySearch(CustomerRequirements customerRequirements, IFlightSearch flightSearch = null)
    {
        _customerRequirements = customerRequirements;
        _flightSearch = flightSearch;
    }

    public IEnumerable<SearchResult> Search()
    {
        //Exact match
        //HotelSearch
        //FlightSearch
        //Total price
        var matchingFlight = _flightSearch.Search().First();

        return new List<SearchResult> {
            new SearchResult
            {
                Flight = matchingFlight
            }
        };
    }
}