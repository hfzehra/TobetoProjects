using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommand : IRequest<CreatedCategoryResponse>
    {
        public string Name { get; set; }
    }
}
