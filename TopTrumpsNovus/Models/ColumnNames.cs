namespace TopTrumpsNovus.Models
{
    public class ColumnNames
    {

        string[] getColumnNames(int deckID)
        {
            if (deckID == 1)
            {
                return new string[] { "Physical", "Speed", "Passing", "Defence", "Stamina", "Shot" };
            }
            else if (deckID == 2)
            {
                return new string[] { "Physical", "Speed", "Passing", "Defence", "Stamina", "Shot" };
            }
            else if (deckID == 3)
            {
                return new string[] { "Power", "Physical Strength", "Intelligence", "Speed", "Popularity", "Weapons" };
            }
            else if (deckID == 4)
            {
                return new string[] { "Strength", "Intelligence", "Speed", "Durability", "Plot Armour", "Hax" };
            }
            else if (deckID == 5)
            {
                return new string[] { "The Force", "Wisdom", "Intelligence", "Diplomacy", "Fighting", "Flying" };
            }
            else
            {
                return new string[] { };
            }
        }



        }


]

    }
}
