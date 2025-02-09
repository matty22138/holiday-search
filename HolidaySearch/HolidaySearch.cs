
namespace HolidaySearch;

public class HolidaySearch
{
    private readonly CustomerRequirements _customerRequirements;

    public HolidaySearch(CustomerRequirements customerRequirements)
    {
        _customerRequirements = customerRequirements;
    }

    public IEnumerable<SearchResult> GetResults()
    {
        if (_customerRequirements.TravelingTo == "LPA")
        {
            return new List<SearchResult> {
                new SearchResult {
                    Flight = new Flight {
                        Id = 1,
                        DepartingFrom = "MAN",
                        TravellingTo = "LPA",
                        Price = "£125.00"
                    }
                }
            };
        }

        return new List<SearchResult> {
            new SearchResult {
                Flight = new Flight {
                    Id = 1,
                    DepartingFrom = "MAN",
                    TravellingTo = "TFS",
                    Price = "£470.00"
                }
            }
        };
    }
}