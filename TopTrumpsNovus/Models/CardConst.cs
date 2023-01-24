using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;

namespace TopTrumpsNovus.Models
{

    public class CardConst
    {
        [Name("DeckID")]
        public int DeckID { get; set; }

        [Name("CardName")]
        public String? CardName { get; set; }
        [Name("CardName")]
        public String? ImageFilePath { get; set; }
        [Name("StatOne")]
        public int StatOne { get; set; }
        [Name("StatTwo")]
        public int StatTwo { get; set; }
        [Name("StatThree")]
        public int StatThree { get; set; }
        [Name("StatFour")]
        public int StatFour { get; set; }
        [Name("StatFive")]
        public int StatFive { get; set; }
        [Name("StatSix")]
        public int StatSix { get; set; }


    }
}