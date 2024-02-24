﻿using Application.Features.Categories.Models;
using Core.Persistence.Paging;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Dtos
{
    public class CategoryListDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
