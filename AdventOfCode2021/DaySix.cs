using System;
using System.Collections.Generic;

namespace AdventOfCode2021 {
    
    public class DaySix {

        public static int getDaySixPartOneSolution() {

            List<int> fish = Utilities.GetIntegerInputFromDelimitedList(Utilities.projectPath + "daySixInput.txt");

            int dayCount = 80;

            for (int i = 0; i < dayCount; i++) {
                for (int j = 0; j < fish.Count; j++) {
                    fish[j]--;
                    if (fish[j] == -1) {
                        fish[j] = 6;
                        fish.Add(9);
                    }
                }
            }

            return fish.Count;
        }

        public static long getDaySixPartTwoSolution() {
            List<int> fish = Utilities.GetIntegerInputFromDelimitedList(Utilities.projectPath + "daySixInput.txt");

            long[] fishByAge = new long[9];
            
            foreach (int i in fish) {
                fishByAge[i]++;
            }
            
            int dayCount = 256;

            for (int i = 0; i < dayCount; i++) {
                long oldestFish = fishByAge[0];
                fishByAge[0] = fishByAge[1];
                fishByAge[1] = fishByAge[2];
                fishByAge[2] = fishByAge[3];
                fishByAge[3] = fishByAge[4];
                fishByAge[4] = fishByAge[5];
                fishByAge[5] = fishByAge[6];
                fishByAge[6] = fishByAge[7] + oldestFish;
                fishByAge[7] = fishByAge[8];
                fishByAge[8] = oldestFish;
            }

            long fishCount = 0;
            for (int i = 0; i < 9; i++) {
                fishCount += fishByAge[i];
            }

            return fishCount;
        }
    }
}
