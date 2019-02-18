using AutoMapper;
using GeekBurger.Productions.Contract;
using GeekBurger.Productions.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GeekBurger.Productions
{
    public class AutomapperProfile :Profile
    {
        public AutomapperProfile()
        {            
            CreateMap<Production, ProductionToGet>();         
            CreateMap<EntityEntry<Production>, ProductionAreaChanged>()
            .ForMember(dest => dest.Production, opt => opt.MapFrom(src => src.Entity));
        }
    }
}
