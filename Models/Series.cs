using System;
using System.ComponentModel.DataAnnotations;

namespace Strona.Models
{
    public class Series
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "To pole nie może być puste")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data premiery")]
        [Required(ErrorMessage = "To pole nie może być puste")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek")]
        [Required(ErrorMessage = "To pole nie może być puste")]
        public string Genre { get; set; }
        [Display(Name = "Ocena od 1-10")]
        [Range(1, 10)]
        [Required(ErrorMessage = "To pole nie może być puste i musi zawierać liczbę od 1 do 10")]
        // Data validation with error message in Polish
        public byte Rating { get; set; }
    }
}
