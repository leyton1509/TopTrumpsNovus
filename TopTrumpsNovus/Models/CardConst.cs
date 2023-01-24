using System.ComponentModel.DataAnnotations;

namespace TopTrumpsNovus.Models
{

    public class CardConst
    {
       
        public int DeckID { get; set; }

        public String? CardName { get; set; }

        public String? ImageFilePath { get; set; }

        public int StatOne { get; set; }

        public int StatTwo { get; set; }

        public int StatThree { get; set; }

        public int StatFour { get; set; }

        public int StatFive { get; set; }

        public int StatSix { get; set; }

        public CardConst(int DeckID, String CardName, String ImageFilePath, int StatOne, int StatTwo, int StatThree, int StatFour, int StatFive, int StatSix)
        {
            this.DeckID = DeckID;
            this.CardName = CardName;
            this.ImageFilePath = ImageFilePath;
            this.StatOne = StatOne;
            this.StatTwo = StatTwo;
            this.StatThree = StatThree;
            this.StatFour = StatFour;
            this.StatFive = StatFive;
            this.StatSix = StatSix;
        }

    }
}