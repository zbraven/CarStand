using CarStand.Application.Features.CQRS.Commands.AboutCommands;
using CarStand.Application.Features.CQRS.Commands.BannderCommands;
using CarStand.Application.Interfaces;
using CarStand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);

            values.Title = command.Title;
            values.Description = command.Description;
            values.VideoDescription = command.VideoDescription;
            values.VideoUrl = command.VideoUrl;

            await _repository.UpdateAsync(values);
        }
    }
}
