using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public Brand(int brandId, string brandName)
        {
            BrandId = brandId;
            BrandName = brandName;
        }

        public Brand()
        {

        }
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
