using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using AutoMapper;
using API.DTOs;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>()
                .ForMember( dest => dest.ProfilePhotoUrl, opts => opts.MapFrom(
                    src => src.Paintings.FirstOrDefault ( x => x.IsProfile).Url));

            CreateMap<Painting, PaintingDTO>();
        }
    }
}