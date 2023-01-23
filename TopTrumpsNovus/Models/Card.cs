namespace TopTrumpsNovus.Models
{

    public class Card
    {
        public int deckID { get; set; }

        int statOne { get; set; }
        int statTwo { get; set; }
        int statThree { get; set; }
        int statFour { get; set; }
        int statFive { get; set; }
        int statSix { get; set; }

        public Card(int _deckID, int _statOne, int _statTwo, int _statThree, int _statFour, int _statFive, int _statSix)
        {
            deckID = _deckID;
            statOne = _statOne;
            statTwo = _statTwo;
            statThree = _statThree;
            statFour = _statFour;
            statFive = _statFive;
            statSix = _statSix;
        }

    }
}
