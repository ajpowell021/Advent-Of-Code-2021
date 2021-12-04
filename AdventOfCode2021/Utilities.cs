using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021 {
    
    public static class Utilities {
        
        public const string projectPath = "D:\\Workspace\\Advent-Of-Code-2021\\AdventOfCode2021\\";

        
        public static List<int> GetIntegerInputs(string fileName) {
            string[] lines = File.ReadAllLines(fileName);
            List<int> returnValues = new List<int>();
            foreach (string line in lines) {
                returnValues.Add(Int32.Parse(line));
            }

            return returnValues;
        }

        public static List<int> GetIntegerInputFromDelimitedList(string fileName) {
            string line = File.ReadAllText(fileName);
            List<string> asStrings = line.Split(",").ToList();
            List<int> asInts = new List<int>();
            foreach (string s in asStrings) {
                asInts.Add(Int32.Parse(s));
            }

            return asInts;
        }

        public static List<TextIntPair> GetTextIntList(string fileName) {
            string[] lines = File.ReadAllLines(fileName);
            List<TextIntPair> returnValues = new List<TextIntPair>();
            foreach (string line in lines) {
                string[] splitLine = line.Split(' ');
                TextIntPair pair = new TextIntPair();
                pair.text = splitLine[0];
                pair.value = Int32.Parse(splitLine[1]);
                returnValues.Add(pair);
            }

            return returnValues;
        }

        public static List<string> GetStringInputs(string fileName) {
            List<string> returnValues = new List<string>();
            string[] lines = File.ReadAllLines(fileName);
            returnValues = lines.ToList();

            return returnValues;
        }

        public static char FindMostCommonByIndex(List<string> list, int index) {
            int zeroCount = 0;
            int oneCount = 0;
            
            foreach (string s in list) {
                if (s[index] == '0') {
                    zeroCount++;
                } else {
                    oneCount++;
                }
            }

            if (zeroCount > oneCount) {
                return '0';
            } else {
                return '1';
            }
        }
        
        public static char FindLeastCommonByIndex(List<string> list, int index) {
            int zeroCount = 0;
            int oneCount = 0;
            
            foreach (string s in list) {
                if (s[index] == '0') {
                    zeroCount++;
                } else {
                    oneCount++;
                }
            }

            if (zeroCount == oneCount) {
                return '0';
            }
            
            if (zeroCount > oneCount) {
                return '1';
            } else {
                return '0';
            }
        }
    }

    public struct TextIntPair {
        public string text;
        public int value;
    }
}
