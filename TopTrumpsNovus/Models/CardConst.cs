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

        public CardConst(int _DeckID, String _cardName, String _ImageFilePath, int _StatOne, int _StatTwo, int _StatThree, int _StatFour, int _StatFive, int _StatSix)
        {
            DeckID = _DeckID;
            CardName = _cardName;
            ImageFilePath = _ImageFilePath;
            StatOne = _StatOne;
            StatTwo = _StatTwo; 
            StatThree = _StatThree;
            StatFour = _StatFour;
            StatFive = _StatFive;
            StatSix = _StatSix;
        }

    }
}