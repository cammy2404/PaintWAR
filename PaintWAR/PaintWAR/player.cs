using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintWAR
{
    public class player
    {

        private int points;
        private string name;
        private Color colour;
        private int bombs;
        private int dripping;
        private int infected;

        // Constructor with default values
        public player()
        {
            points = 0;
            bombs = 2;
            dripping = 2;
            infected = 1;
            colour = Color.Black;
            name = "Nothing";
        }

        // Constructor with default weapon values and user defined name/colour
        public player(Color incolour, string inname)
        {
            points = 0;
            bombs = 2;
            dripping = 2;
            infected = 9;

            // User defined
            name = inname;
            colour = incolour;
        }

        // Getter and setter methods for points
        public void setPoints(int p) { points = p; }
        public int getPoints() { return points; }

        // Add and subtract one from the players points
        public void addPoints(int p) { points += p; }
        public void subPoints(int p) { points -= p; }

        public string getName() { return name; }
        public void setName(string inname) { name = inname; }

        //==============================================================
        // Weapon functions
        //==============================================================
        public int getBombs() { return bombs; }
        public int getDripping() { return dripping; }
        public int getInfected() { return infected; }

        public int checkWeapon(string weapon)
        {
            switch (weapon)
            {
                case "bomb":
                    return bombs;

                case "dripping":
                    return dripping;

                case "infected":
                    return infected;
            }

            return -1;
        }

        public void useWeapon(string weapon)
        {
            switch (weapon)
            {
                case "bomb":
                    Console.Write("Weapon --> Bomb = " + bombs);
                    bombs--;
                    Console.WriteLine(" --> New Bomb Count = " + bombs);
                    break;

                case "dripping":
                    Console.Write("Weapon --> Dripping = " + dripping);
                    dripping--;
                    Console.WriteLine(" --> New Dripping Count = " + dripping);
                    break;

                case "infected":
                    Console.Write("Weapon --> Infected = " + infected);
                    infected--;
                    Console.WriteLine(" --> New Infected Count = " + infected);
                    break;

                default:
                    Console.WriteLine("Error --> Invalid Weapon While Removing 1");
                    break;
            }
        }

        //==============================================================
        // Color functions
        //==============================================================
        public Color getColor() { return colour; }
        public void setColour(Color incolour) { colour = incolour; }

    }
}
