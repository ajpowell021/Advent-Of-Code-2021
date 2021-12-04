using System;
using System.Collections.Generic;

namespace AdventOfCode2021 {

    public class DayFour {

        public static int getDayFourPartOneSolution() {
            
            List<int> draws = Utilities.GetIntegerInputFromDelimitedList(Utilities.projectPath + "dayFourDrawInput.txt");

            List<int[,]> rawCards = Utilities.get2DArrays(Utilities.projectPath + "dayFourCardInput.txt");
            List<BingoCard> cards = new List<BingoCard>();

            for (int i = 0; i < rawCards.Count; i++) {
                BingoCard bingoCard = new BingoCard();
                bingoCard.board = rawCards[i];
                bingoCard.calledNumbers = new List<int>();

                cards.Add(bingoCard);
            }

            for (int i = 0; i < draws.Count; i++) {
                for (int j = 0; j < cards.Count; j++) {
                    cards[j].addCalledNumber(draws[i]);
                    if (cards[j].hasBingo()) {
                        // Winner!
                        return draws[i] * cards[j].getSumOfAllUnmarked();
                    }    
                }
            }


            return -1;
        }

        public static int getDayFourPartTwoSolution() {
            List<int> draws = Utilities.GetIntegerInputFromDelimitedList(Utilities.projectPath + "dayFourDrawInput.txt");

            List<int[,]> rawCards = Utilities.get2DArrays(Utilities.projectPath + "dayFourCardInput.txt");
            List<BingoCard> cards = new List<BingoCard>();
            
            for (int i = 0; i < rawCards.Count; i++) {
                BingoCard bingoCard = new BingoCard();
                bingoCard.board = rawCards[i];
                bingoCard.calledNumbers = new List<int>();

                cards.Add(bingoCard);
            }

            int lastWinnerIndex = -1;
            int lastWinnerDrawIndex = -1;
            
            for (int i = 0; i < draws.Count; i++) {
                for (int j = 0; j < cards.Count; j++) {
                    if (!cards[j].hasBingo()) {
                        cards[j].addCalledNumber(draws[i]);
                        if (cards[j].hasBingo()) {
                            // This card has won.
                            lastWinnerIndex = j;
                            lastWinnerDrawIndex = i;
                        }
                    }
                }
            }
            
            return draws[lastWinnerDrawIndex] * cards[lastWinnerIndex].getSumOfAllUnmarked();
        }
    }
}
