using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        private readonly CategoryBusinessRules _categoryBusinessRules;

        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
        {
            _repository = repository;
            _mapper = mapper;
            _categoryBusinessRules = categoryBusinessRules;
        }


        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            //Category category = new Category();
            //category.Id = Guid.NewGuid();
            //category.Name = request.Name;

            //var createdCategory = await _repository.AddAsync(category);

            //CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            //createdCategoryResponse.Id = createdCategory.Id;
            //createdCategoryResponse.Name = createdCategory.Name;
            //createdCategoryResponse.CreatedDate = createdCategory.CreatedDate;

            await _categoryBusinessRules.CategoryNameCanNotBeDuplicatedWhenInserted(request.Name);

            Category category = _mapper.Map<Category>(request);
            var createdCategory = await _repository.AddAsync(category);
            CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return createdCategoryResponse;

            


        }
    }
}
