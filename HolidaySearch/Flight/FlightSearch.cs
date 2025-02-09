public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    public FlightSearch(CustomerRequirements customerRequirements) { }

    public IEnumerable<Flight> ExactSearch()
    {
        return new List<Flight>{
            new Flight {
                Id = 10,
                DepartingFrom = "LGW",
                TravellingTo = "AGP",
                Price = 225
            }
        };
    }
}