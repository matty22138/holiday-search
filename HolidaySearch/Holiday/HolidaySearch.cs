﻿
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

    public IEnumerable<Holiday> ExactSearch()
    {
        var matchingFlights = _flightSearch.ExactSearch();
        var matchingHotels = _hotelSearch.ExactSearch();

        if (!matchingHotels.Any() || !matchingFlights.Any())
        {
            return Enumerable.Empty<Holiday>();
        }

        var bestHotel = matchingHotels.First();
        var bestFlight = matchingFlights.First();

        return new List<Holiday> {
            new Holiday
            {
                Flight = bestFlight,
                Hotel = bestHotel,
                TotalPrice = bestFlight.Price + bestHotel.TotalPrice
            }
        };
    }
}