using System.Collections.Generic;

namespace AdventOfCode2021 {
    
    public class DayOne {
        
        // Finds how many times the next int is bigger
        // than the previous for a list of ints.
        public static int getDayOnePartOneSolution() {
            
            List<int> dayOneInput = Utilities.GetIntegerInputs(Utilities.projectPath + "dayOneInput.txt");

            int increaseCount = 0;
            
            for (int i = 1; i < dayOneInput.Count; i++) {
                if (dayOneInput[i] > dayOneInput[i - 1]) {
                    increaseCount++;
                }
            }
            
            return increaseCount;
        }

        // Finds How many times the 3 day sliding window
        // increases compared to the previous.
        public static int getDayOnePartTwoSolution() {
            
            List<int> dayOneInput = Utilities.GetIntegerInputs(Utilities.projectPath + "dayOneInput.txt");

            int increaseCount = 0;

            for (int i = 2; i < dayOneInput.Count - 1; i++) {
                int previousWindowValue = (dayOneInput[i - 2]) + (dayOneInput[i - 1]) + (dayOneInput[i]);
                int currentWindowValue = (dayOneInput[i - 1]) + (dayOneInput[i]) + (dayOneInput[i + 1]);

                if (currentWindowValue > previousWindowValue) {
                    increaseCount++;
                }
            }

            return increaseCount;
        }
    }
}
