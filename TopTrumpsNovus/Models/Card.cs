using System.ComponentModel.DataAnnotations;

namespace TopTrumpsNovus.Models
{

    public class Card
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "DeckID")]
        public int DeckID { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Card's Name")]
        public String CardName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Image File Path")]
        public String ImageFilePath { get; set; }

        [Required]
        [Display(Name = "Stat One")]
        public int StatOne { get; set; }
        [Required]
        [Display(Name = "Stat Two")]
        public int StatTwo { get; set; }
        [Required]
        [Display(Name = "StatThree ")]
        public int StatThree { get; set; }
        [Required]
        [Display(Name = "Stat Four")]
        public int StatFour { get; set; }
        [Required]
        [Display(Name = "Stat Five")]
        public int StatFive { get; set; }
        [Required]
        [Display(Name = "Stat Six")]
        public int StatSix { get; set; }

    }
}