﻿using Application.Features.Categories.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Queries.GetList
{
    public class GetListCategoryQueryHandler : IRequestHandler<GetListCategoryQuery, CategoryListModel>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetListCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryListModel> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
        {
            //index ve size Core katmanından geliyor
            Paginate<Category> categories= await _categoryRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
            CategoryListModel categoryModel = _mapper.Map<CategoryListModel>(categories);
            return categoryModel;

        }
    }
}
