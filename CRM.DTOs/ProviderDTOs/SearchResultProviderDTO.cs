﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DTOs.ProviderDTOs
{
    public class SearchResultProviderDTO
    {
        public int CountRow { get; set; }
        public List<ProviderDTO> Data { get; set; }
        public class ProviderDTO
        {
            public int Id { get; set; }

            [Display(Name = "Nombre")]
            public string Name { get; set; }

            [Display(Name = "Empresa")]
            public string Empresa { get; set; }

            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Telefono")]
            public string Phone { get; set; }
        }
    }
}