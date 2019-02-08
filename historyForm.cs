using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PaintWAR
{
    public partial class Form4 : Form
    {
        

        public Form4()
        {
            InitializeComponent();
            printToLeaderboard();

        }

        public void printToLeaderboard()
        {
            int lineCount = File.ReadLines("History.csv").Count();

            Console.WriteLine("Number of lines " + lineCount + 1);

            try
            {
                var line = File.ReadAllLines("History.csv");

                for (int i = lineCount; i > -1; i--)
                {

                    string lines = line.ElementAtOrDefault(i-1); // null if there are less lines
                    
                    string[] words = lines.Split(',');                   

                    foreach (string word in words)
                    {
                        Console.WriteLine("WORD: " + word);
                        //write the lie to console window
                        textBox1.Text += word;
                        textBox1.Text += "\t";

                    }
                    textBox1.Text += "\r\n";
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void sortLeaderboard(string userInput)
        {
            int lineCount = File.ReadLines("History.csv").Count();

            Console.WriteLine("Number of lines " + lineCount + 1);

            Console.WriteLine("WORKS-------------------------");

            try
            {
                var line = File.ReadAllLines("History.csv");

                for (int i = lineCount; i > -1; i--)
                {

                    string lines = line.ElementAtOrDefault(i - 1); // null if there are less lines

                    if (lines.Contains(userInput))
                    {
                        string[] words = lines.Split(',');

                    
                        foreach (string word in words)
                        {
                            Console.WriteLine("WORD: " + word);
                            //write the lie to console window
                            string print = word + "\t";
                            textBox1.Text += print;
                            

                        }
                        textBox1.Text += "\r\n";
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            string gridSize;
            if (comboBox5.SelectedItem == "Sort Ascending")
            {
                gridSize = "30x30";
                sortLeaderboard(gridSize);
                gridSize = "40x40";
                sortLeaderboard(gridSize);
                gridSize = "50x50";
                sortLeaderboard(gridSize);
                gridSize = "60x60";
                sortLeaderboard(gridSize);
                gridSize = "70x70";
                sortLeaderboard(gridSize);

            }
            else if (comboBox5.SelectedItem == "Sort Descending")
            {
                gridSize = "70x70";
                sortLeaderboard(gridSize);
                gridSize = "60x60";
                sortLeaderboard(gridSize);
                gridSize = "50x50";
                sortLeaderboard(gridSize);
                gridSize = "40x40";
                sortLeaderboard(gridSize);
                gridSize = "30x30";
                sortLeaderboard(gridSize);

            }
            else
            {

            }
        }


        

        

        private void btn_find_player_Click(object sender, EventArgs e)
        {

            if (playerSearch.Text == "")
            {
                MessageBox.Show("You must enter a name to search.", "Player Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                textBox1.Clear();
                sortLeaderboard(playerSearch.Text);
            }
        }

        
    }
}
    



