﻿using CityInfoCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoCoreApi
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new Models.CityDto()
                {
                    Id = 1,
                     Name = "New York City",
                     Description = "The one with that big park.",
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                },
                new Models.CityDto()
                {
                    Id= 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                }
            };
        }
    }
}
