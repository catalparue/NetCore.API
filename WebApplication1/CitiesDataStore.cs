using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Taipei",
                    Description = "food is good",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1, 
                            Name = "Night Market",
                            Description = "best food ever is in Taipei night market"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Taipei 101",
                            Description = "watch new years eve firework here"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Hong Kong",
                    Description = "crowded city",

                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Disney Park",
                            Description = "probably the only thing you can do in HK"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "London",
                    Description = "Tired of London, tired of life",                    
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Saint Paul",
                            Description = "Nice working area, posh"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Elephant and Castle",
                            Description = "cheap and afforable place in London"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Bromlay South",
                            Description = "You have kids? move here for better school"
                        }
                    }
                }
            };
        }
    }
}
