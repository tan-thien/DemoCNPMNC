using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    public class Product{
        public long? ProductID {get;set;}

        public String Name {get;set;} = String.Empty;

        public String Description {get;set;} = String.Empty;
        [Column(TypeName ="decimal(8, 2)")]

        public decimal Price {get;set;}

        public String Category {get;set;} = String.Empty;
    }
}