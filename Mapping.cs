using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Infocity.Entities;

namespace Cityinfo
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<City, Models.CityWithoutPointsOfInterestDto>();
            CreateMap<City, Models.CityDto>();
            CreateMap<PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, PointOfInterest>();
            CreateMap<Models.PointOfInterestForUpdateDto, PointOfInterest>();
            CreateMap<PointOfInterest, Models.PointOfInterestForUpdateDto>();
        }
    }
}
