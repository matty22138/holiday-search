
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

    public IEnumerable<SearchResult> GetResults()
    {
        //Exact match
        //HotelSearch
        //FlightSearch
        //Total price

        var matchingFlight = _flightSearch.GetResults().First();

        return new List<SearchResult> {
            new SearchResult
            {
                Flight = matchingFlight
            }
        };

        // if (_customerRequirements.TravelingTo == "LPA")
        // {
        //     return new List<SearchResult> {
        //         new SearchResult {
        //             Flight = new Flight {
        //                 Id = 1,
        //                 DepartingFrom = "MAN",
        //                 TravellingTo = "LPA",
        //                 Price = "£125.00"
        //             }
        //         }
        //     };
        // }

        // return new List<SearchResult> {
        //     new SearchResult {
        //         Flight = new Flight {
        //             Id = 1,
        //             DepartingFrom = "MAN",
        //             TravellingTo = "TFS",
        //             Price = "£470.00"
        //         }
        //     }
        // };
    }
}