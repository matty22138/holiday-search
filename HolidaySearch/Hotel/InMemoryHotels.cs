public class InMemoryHotels
{
    public IEnumerable<Hotel> GetAll()
    {
        return new List<Hotel>
        {
            new Hotel {
                Id= 1,
                Name= "Iberostar Grand Portals Nous",
                ArrivalDate= "2022-11-05",
                PricePerNight= 100,
                LocalAirports= ["TFS"],
                Nights= 7
            },
            new Hotel{
                Id= 2,
                Name= "Laguna Park 2",
                ArrivalDate= "2022-11-05",
                PricePerNight= 50,
                LocalAirports= ["TFS"],
                Nights= 7
            },
            new Hotel{
                Id= 3,
                Name= "Sol Katmandu Park & Resort",
                ArrivalDate= "2023-06-15",
                PricePerNight= 59,
                LocalAirports= ["PMI"],
                Nights= 14
            },
            new Hotel{
                Id= 4,
                Name= "Sol Katmandu Park & Resort",
                ArrivalDate= "2023-06-15",
                PricePerNight= 59,
                LocalAirports= ["PMI"],
                Nights= 14
            },
            new Hotel{
                Id= 5,
                Name= "Sol Katmandu Park & Resort",
                ArrivalDate= "2023-06-15",
                PricePerNight= 60,
                LocalAirports= ["PMI"],
                Nights= 10
            },
            new Hotel{
                Id= 6,
                Name= "Club Maspalomas Suites and Spa",
                ArrivalDate= "2022-11-10",
                PricePerNight= 75,
                LocalAirports= ["LPA"],
                Nights= 14
            },
            new Hotel{
                Id= 7,

                Name= "Club Maspalomas Suites and Spa",
                ArrivalDate= "2022-09-10",
                PricePerNight= 76,
                LocalAirports= ["LPA"],
                Nights= 14
            },
            new Hotel{
                Id= 8,
                Name= "Boutique Hotel Cordial La Peregrina",
                ArrivalDate= "2022-10-10",
                PricePerNight= 45,
                LocalAirports= ["LPA"],
                Nights= 7
            },
            new Hotel{
                Id= 9,
                Name= "Nh Malaga",
                ArrivalDate= "2023-07-01",
                PricePerNight= 83,
                LocalAirports= ["AGP"],
                Nights= 7
            },
            new Hotel{
                Id= 10,
                Name= "Barcelo Malaga",
                ArrivalDate= "2023-07-05",
                PricePerNight= 45,
                LocalAirports= ["AGP"],
                Nights= 10
            },
            new Hotel{
                Id= 11,
                Name= "Parador De Malaga Gibralfaro",
                ArrivalDate= "2023-10-16",
                PricePerNight= 100,
                LocalAirports= ["AGP"],
                Nights= 7
            },
            new Hotel{
                Id= 12,
                Name= "MS Maestranza Hotel",
                ArrivalDate= "2023-07-01",
                PricePerNight= 45,
                LocalAirports= ["AGP"],

                Nights= 14
            },
            new Hotel {
                Id= 13,
                Name= "Jumeirah Port Soller",
                ArrivalDate= "2023-06-15",
                PricePerNight= 295,
                LocalAirports= ["PMI"],
                Nights= 10
            }
        };
    }
}