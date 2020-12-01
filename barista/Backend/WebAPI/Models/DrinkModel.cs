using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("DrinkModel")]
    public class DrinkModel
    {
        public Guid Id{get; set;}
        public int DrinkType{get; set;}

        public string Name{get; set;}
        public string Style{get; set;}
        public int SizeInMl{get; set;}
        public double AlcContent{get; set;}
        public double Price{get; set;}

        public string Company{get; set;}
        public string CompanyLocation{get; set;}
        public string Description{get; set;}
        public string Image{get; set;}
        public DateTime LastUpdatedOn { get; set;}
        public int LastUpdatedBy {get; set;}
    }
}