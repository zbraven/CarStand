﻿using CarStand.Application.Features.CQRS.Results.AboutResult;
using CarStand.Application.Interfaces;
using CarStand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public List<GetAboutQueryResult> Handle()
        {
            var values = _repository.GetAllAsync().Result;
            return values.Select(x => new GetAboutQueryResult
            {          
               AboutID = x.AboutID, 
               Description  = x.Description,
               Title = x.Title,
               ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
