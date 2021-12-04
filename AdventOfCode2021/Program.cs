using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021 {

    static class Program {
        
        static void Main() {
            int dayOnePartOneSolution = DayOne.getDayOnePartOneSolution();
            Console.WriteLine("D1 P1: " + dayOnePartOneSolution);

            int dayOnePartTwoSolution = DayOne.getDayOnePartTwoSolution();
            Console.WriteLine("D1 P2: " + dayOnePartTwoSolution);

            int dayTwoPartOneSolution = DayTwo.getDayTwoPartOneSolution();
            Console.WriteLine("D2 P1: " + dayTwoPartOneSolution);

            int dayTwoPartTwoSolution = DayTwo.getDayTwoPartTwoSolution();
            Console.WriteLine("D2 P2: " + dayTwoPartTwoSolution);

            int dayThreePartOneSolution = DayThree.getDayThreePartOneSolution();
            Console.WriteLine("D3 P1: " + dayThreePartOneSolution);

            int dayThreePartTwoSolution = DayThree.getDayThreePartTwoSolution();
            Console.WriteLine("D3 P2: " + dayThreePartTwoSolution);

            int dayFourPartOneSolution = DayFour.getDayFourPartOneSolution();
            Console.WriteLine("D4 P1: " + dayFourPartOneSolution);

            int dayFourPartTwoSolution = DayFour.getDayFourPartTwoSolution();
            Console.WriteLine("D4 P2: " + dayFourPartTwoSolution);
        }
    }
}
