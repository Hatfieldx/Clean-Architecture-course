using System;
using MediatR;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Models;

namespace CleanArch.Domain.ComandHandlers
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private ICourseRepository _repo;
        public CreateCourseCommandHandler(ICourseRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course {
            Name = request.Name,
            Description = request.Description,
            ImageUrl = request.ImageUrl
            };

            return await _repo.AddAsync(course);
        }
    }
}

