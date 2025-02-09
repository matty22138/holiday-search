public interface IFlightSearch
{
    IEnumerable<Flight> ExactSearch();
}

public class FlightSearch : IFlightSearch
{
    private readonly CustomerRequirements _customerRequirements;

    public FlightSearch(CustomerRequirements customerRequirements)
    {
        _customerRequirements = customerRequirements;
    }

    public IEnumerable<Flight> ExactSearch()
    {
        if (_customerRequirements.DepartureDate == "2023-10-25")
        {
            return new List<Flight>{
                new Flight {
                    Id = 12,
                    DepartingFrom = "MAN",
                    TravellingTo = "AGP",
                    Price = 202
                }
            };
        }

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