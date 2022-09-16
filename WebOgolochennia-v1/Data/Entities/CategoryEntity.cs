using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebOgolochennia_v1.Data.Entities
{
    [Table("tblCategories")]
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        public string Advertisement { get; set; }
        public double Price { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Other { get; set; }
        public bool PublicInNewspaper { get; set; }
        public string InicialData { get; set; }
        public string FinalData { get; set; }
        public bool Highlighted { get; set; }
        public bool Frame { get; set; }
        public bool Background { get; set; }
        public bool PublicInSite { get; set; }
        public int InitialWeek { get; set; }
        public bool Up { get; set; }
        public bool Paid { get; set; }
        public bool IsDelete { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
    }
}
