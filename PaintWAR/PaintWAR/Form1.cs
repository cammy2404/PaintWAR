using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWAR
{
    public partial class Form1 : Form
    {
        // Create array of buttons
        Button[,] newBtn;
        player p1;
        player p2;

        int player_turn = 1;
        int gameBorder;
        int black_squares;

        int counter = 0;


        //============================================================================================================================
        private void testingVals()
        {
            p1 = new player(Color.Purple, "Cammy");
            p2 = new player(Color.Green, "Steven");
            newBtn = new Button[25, 25];
            gameBorder = newBtn.GetLength(0) - 1;
            input_group.Visible = false;
            startGame();
        }


        //============================================================================================================================
        // Form Setup
        //============================================================================================================================
        public Form1()
        {
            InitializeComponent();
        }


        //============================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set location for each of the control groups
            input_group.Location = new Point(174, 125);
            winner_group.Location = new Point(174, 125);

            // Disable the new game button as no game has been set up yet
            mi_new_game.Enabled = false;
        }


        //============================================================================================================================
        // Game Setup
        //============================================================================================================================
        private void initGame()
        {

            // Check that the user has entered a name into both of the player name fields
            if (txt_player1.Text == "" || txt_player2.Text == "")
            {
                // Display error message
                MessageBox.Show("You must enter 2 names to start the game.", "Player Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check that the user has selected a colour for each player
            if (btn_p1_colour.BackColor.Name.ToString() == "ff404040" || btn_p2_colour.BackColor.Name.ToString() == "ff404040")
            {
                // Display error message
                MessageBox.Show("You must select a colour for each player to start the game.", "Player Colour Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check that the user has enetered two different colours for the players as
            // game will become imposible to play if they are the same colour
            if (btn_p1_colour.BackColor == btn_p2_colour.BackColor)
            {
                MessageBox.Show("You must select different colours for each player to start the game.", "Player Colour Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initilise the two player objects with the colours and names entered
            p1 = new player(btn_p1_colour.BackColor, txt_player1.Text.ToString());
            p2 = new player(btn_p2_colour.BackColor, txt_player2.Text.ToString());

            // Check that the user has selected one of the grid sizes for the game
            if (cb_grid_size.Text.ToString() != "")
            {
                // Recieve the size of the grid from the drop down box
                int grid_size_x = Convert.ToInt32(cb_grid_size.Text.ToString().Substring(0, 2));
                int grid_size_y = Convert.ToInt32(cb_grid_size.Text.ToString().Substring(5, 2));
                
                // Initilise the array of buttons to the size chosen by the user
                newBtn = new Button[grid_size_x, grid_size_y];

                // Set the game border to the width of the grid - 1. This will be used to ensure
                // the placing of paint squares works as intended
                gameBorder = grid_size_x - 1;
            }
            else
            {
                // Display error message
                MessageBox.Show("You must select a grid size to start the game.", "Grid Size Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Make sure the input box and winner box are hidden for now
            input_group.Visible = false;
            winner_group.Visible = false;

            // Activate the new game button as a game has been set up
            mi_new_game.Enabled = true;

            // Start the game
            startGame();
        }


        //============================================================================================================================
        private void startGame()
        {
            // Set up variables
            int w = 600 / newBtn.GetLength(0);
            int h = 600 / newBtn.GetLength(1);
            int yOffSet = 28;
            int xOffSet = 2;

            control_group.Location = new Point(610, 27);
            control_group.Visible = true;

            // Create grid of buttons
            for (int x = 0; x < newBtn.GetLength(0); x++)
            {
                for (int y = 0; y < newBtn.GetLength(1); y++)
                {
                    // Create each button and initilise for the start of the game
                    btnCoords coords = new btnCoords(x, y);
                    newBtn[x, y] = new Button();
                    newBtn[x, y].SetBounds((x * w) + xOffSet, (y * h) + yOffSet, w, h);
                    newBtn[x, y].BackColor = Color.Honeydew;
                    newBtn[x, y].FlatStyle = FlatStyle.Flat;
                    newBtn[x, y].Tag = coords;
                    newBtn[x, y].Click += new EventHandler(buttonClicked);
                    Controls.Add(newBtn[x, y]);
                }
            }

            // Ensure the players points are reset to 0
            p1.setPoints(0);
            p2.setPoints(0);

            black_squares = 0;

            // Update the GUI with the names of the players
            lbl_p1_name.Text = p1.getName();
            lbl_p2_name.Text = p2.getName();

            updateStats();
        }


        //============================================================================================================================
        // Functions
        //============================================================================================================================
        private void newGame()
        {
            player_turn = 1;

            // Loop over all the buttons in the grid and reset them all back to the original settings
            for (int x = 0; x < newBtn.GetLength(0); x++)
            {
                for (int y = 0; y < newBtn.GetLength(1); y++)
                {
                    newBtn[x, y].BackColor = Color.Honeydew;
                    newBtn[x, y].Enabled = true;
                }
            }

            // Ensure the players points are reset to 0
            p1.setPoints(0);
            p2.setPoints(0);

            // Reset the black square counter
            black_squares = 0;

            winner_group.Visible = false;

            updateStats();
        }


        //============================================================================================================================
        private Color getPlayerColour()
        {
            // Check whos turn it is (Player 1 = 1 --> Player 2 = -1)
            // Return the colour of the appropriate player
            if (player_turn > 0) { return p1.getColor(); }
            else { return p2.getColor(); }
        }


        //============================================================================================================================
        private void updateStats()
        {
            // Check whos turn it is (Player 1 = 1 --> Player 2 = -1)
            if (player_turn > 0)
            {
                // Display the name of player 1
                lbl_player.Text = p1.getName();
                // Change the item count on each of the weapon buttons
                btn_paint_bomb.Text = ("Paint Bomb (" + p1.getBombs() + ")");
                btn_paint_dripping.Text = ("Dripping Paint (" + p1.getDripping() + ")");
                btn_paint_infected.Text = ("Infected Paint (" + p1.getInfected() + ")");
            }
            else
            {
                // Display the name of player 2
                lbl_player.Text = p2.getName();
                // Change the item count on each of the weapon buttons
                btn_paint_bomb.Text = ("Paint Bomb (" + p2.getBombs() + ")");
                btn_paint_dripping.Text = ("Dripping Paint (" + p2.getDripping() + ")");
                btn_paint_infected.Text = ("Infected Paint (" + p2.getInfected() + ")");
            }

            // Get the current points from each of the players and update the display 
            lbl_points_1.Text = Convert.ToString(p1.getPoints());
            lbl_points_2.Text = Convert.ToString(p2.getPoints());
        }


        //============================================================================================================================
        private void addPoints(int points)
        {
            // Check whos turn it is (Player 1 = 1 --> Player 2 = -1)
            // Add points the the current player
            if (player_turn > 0) { p1.addPoints(points); }
            else { p2.addPoints(points); }
        }


        //============================================================================================================================
        private void subPoints(int points, int plr)
        {
            if (plr > 0)
            {
                p2.subPoints(points);
            }
            else
            {
                p1.subPoints(points);
            }
        }


        //============================================================================================================================
        public bool weaponCanUse(string weapon)
        {
            if (player_turn > 0)
            {
                if (p1.checkWeapon(weapon) > 0)
                {
                    return true;
                }
            }
            else
            {
                if (p2.checkWeapon(weapon) > 0)
                {
                    return true;
                }
            }

            return false;
        }


        //============================================================================================================================
        public void weaponUsed(string weapon)
        {
            if (player_turn > 0)
            {
                p1.useWeapon(weapon);
            }
            else
            {
                p2.useWeapon(weapon);
            }
        }


        //============================================================================================================================
        private void checkWinState()
        {
            int total = (newBtn.GetLength(0) * newBtn.GetLength(1)) - black_squares;
            int p_total = (p1.getPoints() + p2.getPoints());
            Console.WriteLine("Black Squares --> " + black_squares + "        Total (Not Black) --> " + total + "       Total (Coloured) --> " + p_total);

            if (total == p_total)
            {
                String win_message = " Wins!";
                if (p1.getPoints() > p2.getPoints())
                {
                    lbl_winner.Text = p1.getName() + win_message;
                    Console.WriteLine("Winner is --> " + p1.getName());
                }
                else
                {
                    lbl_winner.Text = p2.getName() + win_message;
                    Console.WriteLine("Winner is --> " + p2.getName());
                }
                winner_group.Visible = true;
                winner_group.BringToFront();
            }
        }


        //============================================================================================================================
        // Event Handlers
        //============================================================================================================================
        private void buttonClicked(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            btnCoords coords = (btnCoords)clicked.Tag;

            bool success = true;

            string weapon_choice = lbl_weapon_choice.Text;

            int x = coords.getX();
            int y = coords.getY();

            if (weapon_choice == "Infected Paint")
            {
                if (weaponCanUse("infected") == true)
                {
                    clicked.Enabled = false;
                    clicked.BackColor = Color.Black;

                    infectedPaint(x, y);
                    weaponUsed("infected");

                    player_turn *= -1;
                    black_squares += 25;
                    updateStats();
                    checkWinState();
                    return;
                }
                else
                {
                    MessageBox.Show("Not enough infected paint to use this", "Out of infected paint", MessageBoxButtons.OK);
                }
            }

            if (clicked.BackColor == Color.Honeydew)
            {
                clicked.Enabled = false;
                clicked.BackColor = Color.Black;

                switch (weapon_choice)
                {
                    case "Paint Blob":
                        paintBlob(x, y);
                        break;

                    case "Paint Bomb":
                        if (weaponCanUse("bomb") == true)
                        {
                            paintBomb(x, y);
                            weaponUsed("bomb");
                        }
                        else
                        {
                            MessageBox.Show("Not enough bombs to use this", "Out of bombs", MessageBoxButtons.OK);
                            success = false;
                        }
                        break;

                    case "Dripping Paint":
                        if (weaponCanUse("dripping") == true)
                        {
                            weaponUsed("dripping");
                        }
                        else
                        {
                            MessageBox.Show("Not enough dripping paint to use this", "Out of dripping paint", MessageBoxButtons.OK);
                            success = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Error --> Weapon Switch Statement");
                        break;
                }

                if (success == true)
                {
                    player_turn *= -1;
                    black_squares++;
                    updateStats();
                    checkWinState();
                } else
                {
                    clicked.Enabled = true;
                    clicked.BackColor = Color.Honeydew;
                }
                
            }
            else
            {
                Console.WriteLine("Error --> Painted Square Clicked");
            }

        }


        //============================================================================================================================
        private void updateWeaponChoice(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            lbl_weapon_choice.Text = clicked.Text.Substring(0, (clicked.Text.Length - 4));
        }


        //============================================================================================================================
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //============================================================================================================================
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }


        //============================================================================================================================
        private void pickTeamColor(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                clicked.BackColor = colorDialog1.Color;
            }
        }


        //============================================================================================================================
        private void btn_start_game_Click(object sender, EventArgs e)
        {
            initGame();
        }


        //============================================================================================================================
        private void testingCode(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.T))
            {
                testingVals();
            }
        }


        //============================================================================================================================
        // Weapons
        //============================================================================================================================
        private void paintBlob(int x, int y)
        {
            Color paintColour = getPlayerColour();

            int[,] paintPoints = { { 0, 3 }, { 0, 2 }, { 0, 1 }, { 0, -3 }, { 0, -2 }, { 0, -1 },
                                   { 1, 2 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 1, -2 },
                                   { 2, 1 }, { 2, 0 }, { 2, -1 },
                                   { 3, 0 },
                                   { -1, 2 }, { -1, 1 }, { -1, 0 }, { -1, -1 }, { -1, -2 },
                                   { -2, 1 }, { -2, 0 }, { -2, -1 },
                                   { -3, 0 }
                                 };

            string p1_colour = p1.getColor().Name.ToString();
            string p2_colour = p2.getColor().Name.ToString();

            for (int i = 0; i < paintPoints.GetLength(0); i++)
            {
                int newx = x + paintPoints[i, 0];
                int newy = y + paintPoints[i, 1];

                if (!((newx < 0) || (newy < 0) || (newx > gameBorder) || (newy > gameBorder)))
                {
                    //Console.WriteLine(Convert.ToString("X - " + newx + "  y - " + newy

                    Color btnColor = (Color)newBtn[newx, newy].BackColor;
                    string c = btnColor.Name;

                    if (c == p1_colour)
                    {
                        if (player_turn == -1)
                        {
                            subPoints(1, player_turn);
                            newBtn[newx, newy].BackColor = paintColour;
                            addPoints(1);
                        }
                    }
                    else if (c == p2_colour)
                    {
                        if (player_turn == 1)
                        {
                            subPoints(1, player_turn);
                            newBtn[newx, newy].BackColor = paintColour;
                            addPoints(1);
                        }
                    }
                    else if (c == "Honeydew")
                    {
                        newBtn[newx, newy].BackColor = paintColour;
                        addPoints(1);
                    }
                    else
                    {
                        Console.WriteLine("Error -- > " + btnColor.Name + " Square Cant Be Painted");
                    }
                }
            }
            //Console.WriteLine();
        }


        //============================================================================================================================
        private void paintBomb(int x, int y)
        {
            int[,] paintPoints = { { 0, 3 }, { 0, 2 }, { 0, 1 }, { 0, -3 }, { 0, -2 }, { 0, -1 },
                                   { 1, 1 }, { 1, 0 }, { 1, -1 },
                                   { 2, 2 }, { 2, 0 }, { 2, -2 },
                                   { 3, -3 }, { 3, 0 }, { 3, 3},
                                   { -1, -1 }, { -1, 0 }, { -1, 1 },
                                   { -2, -2 }, { -2, 0 }, { -2, 2 },
                                   { -3, -3 }, { -3, 0 }, { -3, 3 }
                                 };

            string p1_colour = p1.getColor().Name.ToString();
            string p2_colour = p2.getColor().Name.ToString();

            for (int i = 0; i < paintPoints.GetLength(0); i++)
            {
                int newx = x + paintPoints[i, 0];
                int newy = y + paintPoints[i, 1];

                if (!((newx < 0) || (newy < 0) || (newx > gameBorder) || (newy > gameBorder)))
                {
                    //Console.WriteLine(Convert.ToString("X - " + newx + "  y - " + newy));

                    Color btnColor = (Color)newBtn[newx, newy].BackColor;
                    string c = btnColor.Name;

                    if (c == p1_colour)
                    {
                        subPoints(1, -1);
                        newBtn[newx, newy].BackColor = Color.Honeydew;
                    }
                    else if (c == p2_colour)
                    {
                        subPoints(1, 1);
                        newBtn[newx, newy].BackColor = Color.Honeydew;
                    }
                }
            }
            //Console.WriteLine();
        }


        //============================================================================================================================
        private void infectedPaint(int x, int y)
        {
            Color paintColour = Color.Black;

            Console.WriteLine("Infected Paint called");

            int[,] paintPoints = { { 0, 3 }, { 0, 2 }, { 0, 1 }, { 0, -3 }, { 0, -2 }, { 0, -1 },
                                   { 1, 2 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 1, -2 },
                                   { 2, 1 }, { 2, 0 }, { 2, -1 },
                                   { 3, 0 },
                                   { -1, 2 }, { -1, 1 }, { -1, 0 }, { -1, -1 }, { -1, -2 },
                                   { -2, 1 }, { -2, 0 }, { -2, -1 },
                                   { -3, 0 }
                                 };

            string p1_colour = p1.getColor().Name.ToString();
            string p2_colour = p2.getColor().Name.ToString();

            for (int i = 0; i < paintPoints.GetLength(0); i++)
            {
                int newx = x + paintPoints[i, 0];
                int newy = y + paintPoints[i, 1];

                if (!((newx < 0) || (newy < 0) || (newx > gameBorder) || (newy > gameBorder)))
                {
                    //Console.WriteLine(Convert.ToString("X - " + newx + "  y - " + newy));

                    Color btnColor = (Color)newBtn[newx, newy].BackColor;
                    string c = btnColor.Name;

                    newBtn[newx, newy].BackColor = paintColour;
                    newBtn[newx, newy].Enabled = false;

                    if (c == p1_colour)
                    {
                        // Player parameter is inverted due to a stupid function
                        subPoints(1, -1);
                    }
                    else if (c == p2_colour)
                    {
                        // Player parameter is inverted due to a stupid function
                        subPoints(1, 1);
                    }

                }
            }
            //Console.WriteLine();

        }

    }
}
