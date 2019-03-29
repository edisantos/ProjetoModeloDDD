﻿using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}