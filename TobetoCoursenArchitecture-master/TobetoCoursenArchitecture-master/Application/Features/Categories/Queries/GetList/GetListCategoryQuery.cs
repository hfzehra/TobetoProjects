using Application.Features.Categories.Dtos;
using Application.Features.Categories.Models;
using Core.Persistence.Paging;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Application.Request;

namespace Application.Features.Categories.Queries.GetList
{
    public partial class GetListCategoryQuery :IRequest<CategoryListModel>
    {
        //her zaman kullanabileceğim için core katmanında
        public PageRequest PageRequest { get; set; }
    }
}
