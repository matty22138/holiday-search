
namespace HolidaySearch;

public class HolidaySearch
{
    public HolidaySearch(CustomerRequirements customerRequirements) { }

    public IEnumerable<SearchResult> GetResults()
    {
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