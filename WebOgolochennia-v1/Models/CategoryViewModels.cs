using System.ComponentModel.DataAnnotations;

namespace WebOgolochennia_v1.Models
{
    //Ввід даних
    public class CategoryCreateViewModels
    {
        [Display(Name="Рубрика")]
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
    }
    //Відображення даних
    public class CategoryItemViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Рубрика")]
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
    }

}
