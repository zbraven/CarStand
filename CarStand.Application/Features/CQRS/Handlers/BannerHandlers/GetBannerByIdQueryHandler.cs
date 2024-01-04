﻿using CarStand.Application.Features.CQRS.Queries.AboutQueries;
using CarStand.Application.Features.CQRS.Queries.BannerQueries;
using CarStand.Application.Features.CQRS.Results.AboutResult;
using CarStand.Application.Features.CQRS.Results.BannerResults;
using CarStand.Application.Interfaces;
using CarStand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
            BannerID = values.BannerID,
            Title = values.Title,
            Description = values.Description,
            VideoDescription = values.VideoDescription,
            VideoUrl = values.VideoUrl,

            };
        }
    }
}
