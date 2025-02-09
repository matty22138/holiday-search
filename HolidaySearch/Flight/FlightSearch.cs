public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    public FlightSearch(CustomerRequirements customerRequirements) { }

    public IEnumerable<Flight> ExactSearch()
    {
        throw new NotImplementedException();
    }
}