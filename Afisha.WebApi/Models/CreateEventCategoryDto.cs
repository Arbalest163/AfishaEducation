using Afisha.Application.EventCategories.Commands.CreateEventCategory;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.WebApi.Models
{
    public class CreateEventCategoryDto
    {
        [Required]
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateEventCategoryDto, CreateEventCategoryCommand>()
                .ForMember(cC => cC.Name, opt => opt.MapFrom(cD => cD.Name));
        }

    }
}
