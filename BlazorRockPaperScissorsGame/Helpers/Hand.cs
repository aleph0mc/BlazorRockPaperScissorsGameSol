using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRockPaperScissorsGame.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string ImageName { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
                return GameStatus.Draw;

            if (LosesAgainst == opponentHand.Selection)
                return GameStatus.Loss;


            return GameStatus.Victory;
        }
    }
}
