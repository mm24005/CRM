﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DTOs.CategoryDTOs
{
    public class SearchResultCategoryDTO
    {
        public int CountRow { get; set; }
        public List<CategoryDTO> Data { get; set; }
        public class CategoryDTO
        {
            public int Id { get; set; }

            [Display(Name = "Nombre")]
            public string Name { get; set; }

        }
    }
}