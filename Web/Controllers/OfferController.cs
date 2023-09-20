﻿using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class OfferController : BaseCRUDController<Offer, int, CreateOfferDto, OfferUpdateDTO, OfferInfoDto>
    {
        public OfferController(IBaseService<Offer, OfferInfoDto, int> service) : base(service)
        {
        }
    }
}