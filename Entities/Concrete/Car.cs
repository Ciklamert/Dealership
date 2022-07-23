using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public Car(int id, int brandId, int colorId, int modelYear,decimal dailyPrice,string description) 
        {
            Id = id;
            BrandId = brandId;
            ColorId = colorId;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
        }
        public Car()
        {

        }
        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color{ get; set; }
    }
}
