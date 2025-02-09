public class InMemoryFlights
{
    public IEnumerable<Flight> GetAll()
    {
        return new List<Flight>
        {
            new Flight {
                Id= 1,
                Airline= "First Class Air",
                DepartingFrom= "MAN",
                TravellingTo= "TFS",
                Price= 470,
                DepartureDate= "2023-07-01"
            },
            new Flight {
                Id= 2,
                Airline= "Oceanic Airlines",
                DepartingFrom= "MAN",
                TravellingTo= "AGP",
                Price= 245,
                DepartureDate= "2023-07-01"
            },
            new Flight {
                Id= 3,
                Airline= "Trans American Airlines",
                DepartingFrom= "MAN",
                TravellingTo= "PMI",
                Price= 170,
                DepartureDate= "2023-06-15"
            },
            new Flight{
                Id= 4,
                Airline= "Trans American Airlines",
                DepartingFrom= "LTN",
                TravellingTo= "PMI",
                Price= 153,
                DepartureDate= "2023-06-15"
            },
            new Flight{
                Id= 5,
                Airline= "Fresh Airways",
                DepartingFrom= "MAN",
                TravellingTo= "PMI",
                Price= 130,
                DepartureDate= "2023-06-15"
            },
            new Flight{
                Id= 6,
                Airline= "Fresh Airways",
                DepartingFrom= "LGW",
                TravellingTo= "PMI",
                Price= 75,
                DepartureDate= "2023-06-15"
            },
            new Flight{
                Id= 7,
                Airline= "Trans American Airlines",
                DepartingFrom= "MAN",
                TravellingTo= "LPA",
                Price= 125,
                DepartureDate= "2022-11-10"
            },
            new Flight{
                Id= 8,
                Airline= "Fresh Airways",
                DepartingFrom= "MAN",
                TravellingTo= "LPA",
                Price= 175,
                DepartureDate= "2023-11-10"
            },
            new Flight{
                Id= 9,
                Airline= "Fresh Airways",
                DepartingFrom= "MAN",
                TravellingTo= "AGP",
                Price= 140,
                DepartureDate= "2023-04-11"
            },
            new Flight{
                Id= 10,
                Airline= "First Class Air",
                DepartingFrom= "LGW",
                TravellingTo= "AGP",
                Price= 225,
                DepartureDate= "2023-07-01"
            },
            new Flight{
                Id= 11,
                Airline= "First Class Air",
                DepartingFrom= "LGW",
                TravellingTo= "AGP",
                Price= 155,
                DepartureDate= "2023-07-01"
            },
            new Flight{
                Id= 12,
                Airline= "Trans American Airlines",
                DepartingFrom= "MAN",
                TravellingTo= "AGP",
                Price= 202,
                DepartureDate= "2023-10-25"
            }
        };
    }
}