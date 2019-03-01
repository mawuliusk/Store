using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Store.Web.ViewModels;
using Store.Model;

namespace Store.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Gadget, GadgetViewModel>();
        }
    }
}