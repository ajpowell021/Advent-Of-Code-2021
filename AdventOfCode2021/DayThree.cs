using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021 {
    
    public class DayThree {
    
        public static int getDayThreePartOneSolution() {

            List<string> dayThreeInput = Utilities.GetStringInputs(Utilities.projectPath + "dayThreeInput.txt");

            int zeroCount = 0;
            int oneCount = 0;

            string mostCommon = "";
            string leastCommon = "";
            
            for (int i = 0; i < 12; i++) {
                foreach (string s in dayThreeInput) {
                    if (s[i] == '0') {
                        zeroCount++;
                    } else {
                        oneCount++;
                    }
                }

                if (zeroCount > oneCount) {
                    mostCommon += "0";
                    leastCommon += "1";
                } else {
                    mostCommon += "1";
                    leastCommon += "0";
                }

                zeroCount = 0;
                oneCount = 0;
            }
            
            int mostCommonInt = Convert.ToInt32(mostCommon, 2);
            int leastCommonInt = Convert.ToInt32(leastCommon, 2);

            return mostCommonInt * leastCommonInt;
        }

        public static int getDayThreePartTwoSolution() {
            
            List<string> dayThreeInput = Utilities.GetStringInputs(Utilities.projectPath + "dayThreeInput.txt");

            List<string> mostCommonSortedList = new List<string>();
            for (int i = 0; i < 12; i++) {
                if (i == 0) {
                    foreach (string s in dayThreeInput) {
                        if (s[i] == Utilities.FindMostCommonByIndex(dayThreeInput, i)) {
                            mostCommonSortedList.Add(s);
                        }
                    }
                } else {
                    char charToRemove = Utilities.FindMostCommonByIndex(mostCommonSortedList, i);
                    foreach (string s in mostCommonSortedList.ToList()) {
                        if (s[i] != charToRemove) {
                            mostCommonSortedList.Remove(s);
                            if (mostCommonSortedList.Count == 1) {
                                break;
                            }
                        }
                    }
                }

                if (mostCommonSortedList.Count == 1) {
                    break;
                }
            }
            
            List<string> leastCommonSortedList = new List<string>();
            for (int i = 0; i < 12; i++) {
                if (i == 0) {
                    foreach (string s in dayThreeInput) {
                        if (s[i] == Utilities.FindLeastCommonByIndex(dayThreeInput, i)) {
                            leastCommonSortedList.Add(s);
                        }
                    }
                } else {
                    char charToRemove = Utilities.FindLeastCommonByIndex(leastCommonSortedList, i);
                    foreach (string s in leastCommonSortedList.ToList()) {
                        if (s[i] != charToRemove) {
                            leastCommonSortedList.Remove(s);
                            if (leastCommonSortedList.Count == 1) {
                                break;
                            }
                        }
                    }
                }

                if (leastCommonSortedList.Count == 1) {
                    break;
                }
            }
            
            int mostCommonInt = Convert.ToInt32(mostCommonSortedList[0], 2);
            int leastCommonInt = Convert.ToInt32(leastCommonSortedList[0], 2);

            return leastCommonInt * mostCommonInt;
        }
    }
}
