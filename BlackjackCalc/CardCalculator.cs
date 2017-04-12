using System;
using System.Collections.Generic;

namespace BlackjackCalc
{
    public static class CardCalculator
    {
        public static int Calc(List<Card> cards)
        {
            var output = 0;

            //Calculate stuff here

            foreach (var card in cards)
            {
                if (card.Value == "Q" || card.Value == "K" || card.Value == "J")
                {

                    output += 10;
                }

                else if (card.Value != "A")

                {
                    int val = Convert.ToInt32(card.Value);
                    output += val;

                }





            }

            foreach (var card in cards)
            {
                if (card.Value == "A")
                {
                    if (output <= 10)
                    {
                        output += 11;

                    }
                    else
                    {
                        output += 1;

                    }


                }

            }


            return output;
        }
    }
}
