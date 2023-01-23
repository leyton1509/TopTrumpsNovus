namespace TopTrumpsNovus.Models
{

    public class Card
    {
        public int deckID { get; set; }

        public String cardName { get; set; }

        public String imageFilePath { get; set; }

        int statOne { get; set; }
        int statTwo { get; set; }
        int statThree { get; set; }
        int statFour { get; set; }
        int statFive { get; set; }
        int statSix { get; set; }

        public Card(int _deckID, string _cardName, int _statOne, int _statTwo, int _statThree, int _statFour, int _statFive, int _statSix, String _imageFilePath)
        {
            deckID = _deckID;
            cardName = _cardName;
            statOne = _statOne;
            statTwo = _statTwo;
            statThree = _statThree;
            statFour = _statFour;
            statFive = _statFive;
            statSix = _statSix;
            imageFilePath = _imageFilePath;
        }

    }
}
