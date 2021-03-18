using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Specifications
{
    //this specification class is used only to return the number of items that will be used for pagination, 
    //after filters have been applied
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)
            : base(x =>
                    (string.IsNullOrEmpty(productParams.Search) || (x.Name.ToLower().Contains(productParams.Search))) &&
                    (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                    (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
                 )
        {

        }
    }
}
