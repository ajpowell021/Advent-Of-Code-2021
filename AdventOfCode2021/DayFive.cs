using System;
using System.Collections.Generic;

namespace AdventOfCode2021 {
    
    public class DayFive {

        static Dictionary<(int, int), int> coords = new Dictionary<(int, int), int>();
        
        public static int getDayFivePartOneSolution() {

            coords.Clear();
            List<VentLine> ventLines = Utilities.getVentLines(Utilities.projectPath + "dayFiveInput.txt");
            
            foreach (VentLine ventLine in ventLines) {
                if (ventLine.x1 == ventLine.x2) {
                    if (ventLine.y1 < ventLine.y2) {
                        for (int i = ventLine.y1; i < ventLine.y2 + 1; i++) {
                            addToCoords(ventLine.x1, i);
                        }    
                    } else {
                        for (int i = ventLine.y2; i < ventLine.y1 + 1; i++) {
                            addToCoords(ventLine.x1, i);
                        } 
                    }
                } else if (ventLine.y1 == ventLine.y2) {
                    if (ventLine.x1 < ventLine.x2) {
                        for (int i = ventLine.x1; i < ventLine.x2 + 1; i++) {
                            addToCoords(i, ventLine.y1);
                        }    
                    } else {
                        for (int i = ventLine.x2; i < ventLine.x1 + 1; i++) {
                            addToCoords(i, ventLine.y1);
                        } 
                    }
                }
            }

            int dangerPoints = 0;
            foreach (var keyValuePair in coords) {
                if (keyValuePair.Value > 1) {
                    dangerPoints++;
                }
            }

            return dangerPoints;
        }

        public static int getDayFivePartTwoSolution() {
            
            coords.Clear();
            List<VentLine> ventLines = Utilities.getVentLines(Utilities.projectPath + "dayFiveInput.txt");
            
            foreach (VentLine ventLine in ventLines) {
                if (ventLine.x1 == ventLine.x2) {
                    if (ventLine.y1 < ventLine.y2) {
                        for (int i = ventLine.y1; i < ventLine.y2 + 1; i++) {
                            addToCoords(ventLine.x1, i);
                        }    
                    } else {
                        for (int i = ventLine.y2; i < ventLine.y1 + 1; i++) {
                            addToCoords(ventLine.x1, i);
                        } 
                    }
                } else if (ventLine.y1 == ventLine.y2) {
                    if (ventLine.x1 < ventLine.x2) {
                        for (int i = ventLine.x1; i < ventLine.x2 + 1; i++) {
                            addToCoords(i, ventLine.y1);
                        }    
                    } else {
                        for (int i = ventLine.x2; i < ventLine.x1 + 1; i++) {
                            addToCoords(i, ventLine.y1);
                        } 
                    }
                } else if (MathF.Abs(ventLine.x1 - ventLine.x2) == MathF.Abs(ventLine.y1 - ventLine.y2)) {
                    // Is diagonal.
                    if (ventLine.x1 < ventLine.x2 && ventLine.y1 < ventLine.y2) {
                        // Diagonal Up Right
                        int yIndex = 0;
                        for (int i = ventLine.x1; i < ventLine.x2 + 1; i++) {
                            addToCoords(i, ventLine.y1 + yIndex);
                            yIndex++;
                        }
                    }
                    else if (ventLine.x1 > ventLine.x2 && ventLine.y1 < ventLine.y2) {
                        // Diagonal Up Left
                        int yIndex = 0;
                        for (int i = ventLine.x2; i < ventLine.x1 + 1; i++) {
                            addToCoords(i, ventLine.y2 - yIndex);
                            yIndex++;
                        }
                    }
                    else if (ventLine.x1 < ventLine.x2 && ventLine.y1 > ventLine.y2) {
                        // Diagonal Down Right
                        int yIndex = 0;
                        for (int i = ventLine.x1; i < ventLine.x2 + 1; i++) {
                            addToCoords(i, ventLine.y1 - yIndex);
                            yIndex++;
                        }
                    }
                    else if (ventLine.x1 > ventLine.x2 && ventLine.y1 > ventLine.y2) {
                        // Diagonal Down Left
                        int yIndex = 0;
                        for (int i = ventLine.x2; i < ventLine.x1 + 1; i++) {
                            addToCoords(i, ventLine.y2 + yIndex);
                            yIndex++;
                        }
                    }
                }
                
            }

            int dangerPoints = 0;
            foreach (var keyValuePair in coords) {
                if (keyValuePair.Value > 1) {
                    dangerPoints++;
                }
            }

            return dangerPoints;
        }

        private static void addToCoords(int x, int y) {
            if (coords.ContainsKey((x, y))) {
                coords[(x, y)]++;
            } else {
                coords.Add((x, y), 1);
            }
        }
    }
}
