using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        //Handler -> Alıcı demek 
        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new Brand();
            brand.Name = request.Name;
            brand.Id = Guid.NewGuid();
            var createdBrand = await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = createdBrand.Id;
            createdBrandResponse.Name = createdBrand.Name;
            createdBrandResponse.CreatedDate = createdBrand.CreatedDate;


            return createdBrandResponse;
        }
    }

   // public static class ApplicationServiceRegistration { public static IServiceCollection AddApplicationServices(this IServiceCollection services) { services.AddMe diatR(configuration => { configuration.Regis terServicesFromAssembly(Assembly.GetExecutingAssembly()); }); return services; } }
}
