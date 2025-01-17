﻿using AutoMapper;
using ECommerceService.Models;
using ECommerceWebsite.Models;
using ECommerceWebsite.Models.Admin;
using System;

namespace ECommerceWebsite.Mapping
{
    public class AutoMapperWeb
    {
        public MapperConfiguration Configuration;
        public AutoMapperWeb()
        {
            Configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<AccountViewModel, UserDTO>()
                    .ForMember(src => src.FirstName, opt => opt.MapFrom(dest => dest.FirstName))
                    .ForMember(src => src.LastName, opt => opt.MapFrom(dest => dest.LastName))
                    .ForMember(src => src.Email, opt => opt.MapFrom(dest => dest.Email))
                    .ForMember(src => src.DateOfBirth, opt => opt.MapFrom(dest =>
                        new DateTime(
                            Convert.ToInt32(dest.DateOfBirthYear),
                           Convert.ToInt32(dest.DateOfBirthMonth),
                           Convert.ToInt32(dest.DateOfBirthDay))))
                    .ForMember(src => src.IsSubscribed, opt => opt.MapFrom(dest => dest.IsSubscribed))
                    .ForMember(src => src.Password, opt => opt.Ignore())
                    .ReverseMap();
                cfg.CreateMap<UserViewModel, UserDTO>().ReverseMap();
                cfg.CreateMap<ProductItemViewModel, CartSummaryItemViewModel>().ReverseMap();
                cfg.CreateMap<CartViewModel, CartSummaryViewModel>().ReverseMap();
                cfg.CreateMap<CarouselItemViewModel, ProductImageDTO>().ReverseMap();
                cfg.CreateMap<CarouselItemViewModel, ProductDTO>().ReverseMap();
                cfg.CreateMap<MenuItemViewModel, CategoryDTO>().ReverseMap();
                cfg.CreateMap<CheckoutViewModel, PaymentDetailDTO>().ReverseMap();
                cfg.CreateMap<CheckoutViewModel, CartViewModel>().ReverseMap();
                cfg.CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
                cfg.CreateMap<BrandViewModel, BrandDTO>().ReverseMap();               
                cfg.CreateMap<ProductTypeViewModel, ProductTypeDTO>().ReverseMap();
                cfg.CreateMap<AddToCartViewModel, ProductTypeDTO>().ReverseMap();
                cfg.CreateMap<ProductImageViewModel, ProductImageDTO>().ReverseMap();
                cfg.CreateMap<ProductSizeViewModel, ProductSizeDTO>().ReverseMap();
                cfg.CreateMap<CategoryItemViewModel, CategoryDTO>().ReverseMap();
                cfg.CreateMap<CategoryProductItemViewMoel, ProductDTO>().ReverseMap()
                    .ForMember(src => src.ImageSrc, opt => opt.MapFrom(dest => $"data:image/jpeg;base64,{Convert.ToBase64String(dest.Images[0].Image)}" ));
                cfg.CreateMap<LatestTransactionsDTO, LatestTransactionsViewModel>()
                    .ReverseMap();
                cfg.CreateMap<LatestTransactionsDTO, LatestTransactionsViewModel>()
                    .ReverseMap();
                cfg.CreateMap<FinancialInformationDTO, FinancialInformationViewModel>()
                    .ReverseMap();  
                cfg.CreateMap<ProductStockDTO, ProductStockViewModel>()
                    .ReverseMap();
                cfg.CreateMap<NewUserDTO, NewUserViewModel>()
                    .ReverseMap();
            });
        }
    }
}