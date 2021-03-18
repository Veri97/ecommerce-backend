using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;
        private int _pageIndex = 1;
        private int _pageSize = 6;

        public int PageSize 
        {
            get => _pageSize;
            set => _pageSize = (value) > MaxPageSize ? MaxPageSize : value;
        }

        public int PageIndex
        {
            get => _pageIndex;
            set => _pageIndex = (value) <= 0 ? 1 : value;
        }

        public int? BrandId { get; set; }
        public int? TypeId { get; set; }

        public string Sort { get; set; }

        private string _search { get; set; }

        public string Search 
        { 
            get => _search;
            set => _search = value.ToLower();
        }
    }
}
