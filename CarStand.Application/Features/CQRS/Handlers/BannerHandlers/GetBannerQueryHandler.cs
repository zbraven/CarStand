﻿using CarStand.Application.Features.CQRS.Results.BannerResults;
using CarStand.Application.Interfaces;
using CarStand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerID = x.BannerID,
                Title = x.Title,
                Description = x.Description,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}
