using System;
using System.Drawing;
using System.Windows.Forms;

namespace KesselRun.Business.AllPunters
{
    public abstract class Punter
    {
        public string PunterName { get; set; }
        public int Ships { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public Label LabelWinner { get; set; }

        public Color MyColor { get; set; }
        string FavoriteDrink { get; set; }

        int WildCard { get; set; }

    }
}
