using System;
using System.Collections.Generic;

namespace AdventOfCode2021 {
    
    public class DayTwo {

        public static int getDayTwoPartOneSolution() {

            List<TextIntPair> dayTwoInput = Utilities.GetTextIntList(Utilities.projectPath + "dayTwoInput.txt");

            int depthValue = 0;
            int horizontalValue = 0;
            
            foreach (TextIntPair pair in dayTwoInput) {
                if (pair.text == "forward") {
                    horizontalValue += pair.value;
                }
                else if (pair.text == "up") {
                    depthValue -= pair.value;
                } 
                else if (pair.text == "down") {
                    depthValue += pair.value;
                } else {
                    Console.WriteLine("Bad input: " + pair.text);
                }
            }

            return depthValue * horizontalValue;
        }

        public static int getDayTwoPartTwoSolution() {
            
            List<TextIntPair> dayTwoInput = Utilities.GetTextIntList(Utilities.projectPath + "dayTwoInput.txt");

            int aim = 0;
            int horizontalValue = 0;
            int depthValue = 0;
            
            foreach (TextIntPair pair in dayTwoInput) {
                if (pair.text == "forward") {
                    horizontalValue += pair.value;
                    depthValue += aim * pair.value;
                }
                else if (pair.text == "up") {
                    aim -= pair.value;
                } 
                else if (pair.text == "down") {
                    aim += pair.value;
                } else {
                    Console.WriteLine("Bad input: " + pair.text);
                }
            }

            return depthValue * horizontalValue;
        }
    }
}
