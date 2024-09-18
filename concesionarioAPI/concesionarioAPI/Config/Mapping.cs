﻿using AutoMapper;
using concesionarioAPI.Models.Auto;
using concesionarioAPI.Models.Auto.Dto;

namespace concesionarioAPI.Config
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Para no convertir los atributos 'int?' a 0 en la conversion de los 'null'
            // valor defecto int -> 0
            CreateMap<int?, int>().ConvertUsing((src, dest) => src ?? dest);

            // Aqui es necesario hacer esto con bool? ya que tampoco devuelve el tipo 'null'.
            // valor defecto bool -> false
            CreateMap<bool?, bool>().ConvertUsing((src, dest) => src ?? dest);

            //PD: Esta solución hay que aplicarla para todos aquellos tipos que no tengan como valor por defecto 'null'

            CreateMap<Auto, AutosDTO>().ReverseMap();
            CreateMap<Auto, CreateAutoDTO>().ReverseMap();

            // Actualizar y no parsear los valores 'NULL'
            CreateMap<UpdateAutoDTO, Auto>()
                .ForAllMembers(opts =>
                {
                    opts.Condition((src, dest, srcMember) => srcMember != null);
                });

        }
    }
}
