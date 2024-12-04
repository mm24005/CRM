﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DTOs.ProuctDTOs
{
    public class SearchQueryProductDTO
    {

        [Display(Name = "Nombre")]
        public string? Name_Like { get; set; }

        [Display(Name = "Precio")]
        public string?  Price_Like { get; set; }
        
        [Display(Name = "Pagina")]
        public int Skip { get; set; }

        [Display(Name = "CantReg X Pagina")]
        public int Take { get; set; }
        /// <summary>
        /// 1 = No se cuenta los resultados de la busqueda
        /// 2= Cuenta los resultados de la busqueda
        /// </summary>
        public byte SendRowCount { get; set; }
    }
}

