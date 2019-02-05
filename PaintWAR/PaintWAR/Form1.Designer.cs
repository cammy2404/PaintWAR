namespace PaintWAR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new_game = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.control_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_p2_name = new System.Windows.Forms.Label();
            this.lbl_p1_name = new System.Windows.Forms.Label();
            this.lbl_points_2 = new System.Windows.Forms.Label();
            this.lbl_points_1 = new System.Windows.Forms.Label();
            this.btn_paint_infected = new System.Windows.Forms.Button();
            this.lbl_weapon_choice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_paint_dripping = new System.Windows.Forms.Button();
            this.btn_paint_bomb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.btn_paint_blob = new System.Windows.Forms.Button();
            this.input_group = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_grid_size = new System.Windows.Forms.ComboBox();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_p2_colour = new System.Windows.Forms.Button();
            this.btn_p1_colour = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.winner_group = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_play_again = new System.Windows.Forms.Button();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.control_group.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.input_group.SuspendLayout();
            this.winner_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_new_game,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mi_new_game
            // 
            this.mi_new_game.Name = "mi_new_game";
            this.mi_new_game.Size = new System.Drawing.Size(216, 26);
            this.mi_new_game.Text = "New Game";
            this.mi_new_game.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // control_group
            // 
            this.control_group.Controls.Add(this.tableLayoutPanel1);
            this.control_group.Controls.Add(this.btn_paint_infected);
            this.control_group.Controls.Add(this.lbl_weapon_choice);
            this.control_group.Controls.Add(this.label4);
            this.control_group.Controls.Add(this.btn_paint_dripping);
            this.control_group.Controls.Add(this.btn_paint_bomb);
            this.control_group.Controls.Add(this.label2);
            this.control_group.Controls.Add(this.lbl_player);
            this.control_group.Controls.Add(this.btn_paint_blob);
            this.control_group.Location = new System.Drawing.Point(643, 33);
            this.control_group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.control_group.Name = "control_group";
            this.control_group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.control_group.Size = new System.Drawing.Size(253, 730);
            this.control_group.TabIndex = 1;
            this.control_group.TabStop = false;
            this.control_group.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_p2_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_p1_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_points_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_points_1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 105);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_p2_name
            // 
            this.lbl_p2_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_p2_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2_name.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_p2_name.Location = new System.Drawing.Point(126, 0);
            this.lbl_p2_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p2_name.Name = "lbl_p2_name";
            this.lbl_p2_name.Size = new System.Drawing.Size(115, 28);
            this.lbl_p2_name.TabIndex = 8;
            this.lbl_p2_name.Text = "P2 Name";
            this.lbl_p2_name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_p1_name
            // 
            this.lbl_p1_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_p1_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_name.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_p1_name.Location = new System.Drawing.Point(4, 0);
            this.lbl_p1_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p1_name.Name = "lbl_p1_name";
            this.lbl_p1_name.Size = new System.Drawing.Size(114, 28);
            this.lbl_p1_name.TabIndex = 7;
            this.lbl_p1_name.Text = "P1 Name";
            this.lbl_p1_name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_points_2
            // 
            this.lbl_points_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_points_2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_points_2.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_points_2.Location = new System.Drawing.Point(126, 28);
            this.lbl_points_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_points_2.Name = "lbl_points_2";
            this.lbl_points_2.Size = new System.Drawing.Size(115, 25);
            this.lbl_points_2.TabIndex = 6;
            this.lbl_points_2.Text = "0";
            this.lbl_points_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_points_1
            // 
            this.lbl_points_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_points_1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_points_1.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_points_1.Location = new System.Drawing.Point(4, 28);
            this.lbl_points_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_points_1.Name = "lbl_points_1";
            this.lbl_points_1.Size = new System.Drawing.Size(114, 25);
            this.lbl_points_1.TabIndex = 5;
            this.lbl_points_1.Text = "0";
            this.lbl_points_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_paint_infected
            // 
            this.btn_paint_infected.BackColor = System.Drawing.Color.Tan;
            this.btn_paint_infected.FlatAppearance.BorderSize = 2;
            this.btn_paint_infected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paint_infected.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paint_infected.Location = new System.Drawing.Point(4, 602);
            this.btn_paint_infected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_paint_infected.Name = "btn_paint_infected";
            this.btn_paint_infected.Size = new System.Drawing.Size(237, 73);
            this.btn_paint_infected.TabIndex = 10;
            this.btn_paint_infected.Text = "Infected Paint (x)";
            this.btn_paint_infected.UseVisualStyleBackColor = false;
            this.btn_paint_infected.Click += new System.EventHandler(this.updateWeaponChoice);
            // 
            // lbl_weapon_choice
            // 
            this.lbl_weapon_choice.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weapon_choice.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_weapon_choice.Location = new System.Drawing.Point(4, 202);
            this.lbl_weapon_choice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weapon_choice.Name = "lbl_weapon_choice";
            this.lbl_weapon_choice.Size = new System.Drawing.Size(245, 30);
            this.lbl_weapon_choice.TabIndex = 7;
            this.lbl_weapon_choice.Text = "Paint Blob";
            this.lbl_weapon_choice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(4, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Weapon Selected";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_paint_dripping
            // 
            this.btn_paint_dripping.BackColor = System.Drawing.Color.Tan;
            this.btn_paint_dripping.FlatAppearance.BorderSize = 2;
            this.btn_paint_dripping.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paint_dripping.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paint_dripping.Location = new System.Drawing.Point(8, 485);
            this.btn_paint_dripping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_paint_dripping.Name = "btn_paint_dripping";
            this.btn_paint_dripping.Size = new System.Drawing.Size(237, 73);
            this.btn_paint_dripping.TabIndex = 9;
            this.btn_paint_dripping.Text = "Dripping Paint (x)";
            this.btn_paint_dripping.UseVisualStyleBackColor = false;
            this.btn_paint_dripping.Click += new System.EventHandler(this.updateWeaponChoice);
            // 
            // btn_paint_bomb
            // 
            this.btn_paint_bomb.BackColor = System.Drawing.Color.Tan;
            this.btn_paint_bomb.FlatAppearance.BorderSize = 2;
            this.btn_paint_bomb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paint_bomb.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paint_bomb.Location = new System.Drawing.Point(8, 368);
            this.btn_paint_bomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_paint_bomb.Name = "btn_paint_bomb";
            this.btn_paint_bomb.Size = new System.Drawing.Size(237, 73);
            this.btn_paint_bomb.TabIndex = 8;
            this.btn_paint_bomb.Text = "Paint Bomb (x)";
            this.btn_paint_bomb.UseVisualStyleBackColor = false;
            this.btn_paint_bomb.Click += new System.EventHandler(this.updateWeaponChoice);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Squares Coloured";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_player
            // 
            this.lbl_player.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_player.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_player.Location = new System.Drawing.Point(4, 19);
            this.lbl_player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(245, 43);
            this.lbl_player.TabIndex = 3;
            this.lbl_player.Text = "Player 1";
            this.lbl_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_paint_blob
            // 
            this.btn_paint_blob.BackColor = System.Drawing.Color.Tan;
            this.btn_paint_blob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paint_blob.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paint_blob.Location = new System.Drawing.Point(8, 251);
            this.btn_paint_blob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_paint_blob.Name = "btn_paint_blob";
            this.btn_paint_blob.Size = new System.Drawing.Size(237, 73);
            this.btn_paint_blob.TabIndex = 2;
            this.btn_paint_blob.Text = "Paint Blob (∞)";
            this.btn_paint_blob.UseVisualStyleBackColor = false;
            this.btn_paint_blob.Click += new System.EventHandler(this.updateWeaponChoice);
            // 
            // input_group
            // 
            this.input_group.Controls.Add(this.label10);
            this.input_group.Controls.Add(this.cb_grid_size);
            this.input_group.Controls.Add(this.btn_start_game);
            this.input_group.Controls.Add(this.label9);
            this.input_group.Controls.Add(this.label8);
            this.input_group.Controls.Add(this.btn_p2_colour);
            this.input_group.Controls.Add(this.btn_p1_colour);
            this.input_group.Controls.Add(this.label7);
            this.input_group.Controls.Add(this.label6);
            this.input_group.Controls.Add(this.txt_player2);
            this.input_group.Controls.Add(this.txt_player1);
            this.input_group.Controls.Add(this.label5);
            this.input_group.Controls.Add(this.label3);
            this.input_group.Controls.Add(this.label1);
            this.input_group.Location = new System.Drawing.Point(16, 33);
            this.input_group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_group.Name = "input_group";
            this.input_group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_group.Size = new System.Drawing.Size(619, 471);
            this.input_group.TabIndex = 2;
            this.input_group.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SandyBrown;
            this.label10.Location = new System.Drawing.Point(44, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Grid Size";
            // 
            // cb_grid_size
            // 
            this.cb_grid_size.BackColor = System.Drawing.Color.Tan;
            this.cb_grid_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grid_size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_grid_size.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grid_size.FormattingEnabled = true;
            this.cb_grid_size.Items.AddRange(new object[] {
            "30 x 30",
            "40 x 40",
            "50 x 50",
            "60 x 60",
            "70 x 70"});
            this.cb_grid_size.Location = new System.Drawing.Point(49, 385);
            this.cb_grid_size.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_grid_size.Name = "cb_grid_size";
            this.cb_grid_size.Size = new System.Drawing.Size(201, 33);
            this.cb_grid_size.TabIndex = 13;
            // 
            // btn_start_game
            // 
            this.btn_start_game.BackColor = System.Drawing.Color.Tan;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start_game.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_game.Location = new System.Drawing.Point(348, 354);
            this.btn_start_game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(227, 75);
            this.btn_start_game.TabIndex = 12;
            this.btn_start_game.Text = "Start Game";
            this.btn_start_game.UseVisualStyleBackColor = false;
            this.btn_start_game.Click += new System.EventHandler(this.btn_start_game_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SandyBrown;
            this.label9.Location = new System.Drawing.Point(504, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SandyBrown;
            this.label8.Location = new System.Drawing.Point(504, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Colour";
            // 
            // btn_p2_colour
            // 
            this.btn_p2_colour.Location = new System.Drawing.Point(509, 273);
            this.btn_p2_colour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_p2_colour.Name = "btn_p2_colour";
            this.btn_p2_colour.Size = new System.Drawing.Size(65, 36);
            this.btn_p2_colour.TabIndex = 8;
            this.btn_p2_colour.UseVisualStyleBackColor = true;
            this.btn_p2_colour.Click += new System.EventHandler(this.pickTeamColor);
            // 
            // btn_p1_colour
            // 
            this.btn_p1_colour.Location = new System.Drawing.Point(509, 164);
            this.btn_p1_colour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_p1_colour.Name = "btn_p1_colour";
            this.btn_p1_colour.Size = new System.Drawing.Size(65, 36);
            this.btn_p1_colour.TabIndex = 7;
            this.btn_p1_colour.UseVisualStyleBackColor = true;
            this.btn_p1_colour.Click += new System.EventHandler(this.pickTeamColor);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SandyBrown;
            this.label7.Location = new System.Drawing.Point(207, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(207, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // txt_player2
            // 
            this.txt_player2.BackColor = System.Drawing.Color.Tan;
            this.txt_player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_player2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2.ForeColor = System.Drawing.Color.Black;
            this.txt_player2.Location = new System.Drawing.Point(207, 273);
            this.txt_player2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(277, 34);
            this.txt_player2.TabIndex = 4;
            // 
            // txt_player1
            // 
            this.txt_player1.BackColor = System.Drawing.Color.Tan;
            this.txt_player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_player1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1.ForeColor = System.Drawing.Color.Black;
            this.txt_player1.Location = new System.Drawing.Point(207, 164);
            this.txt_player1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(277, 34);
            this.txt_player1.TabIndex = 3;
            this.txt_player1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.testingCode);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 75);
            this.label5.TabIndex = 2;
            this.label5.Text = "Player 2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "PaintWAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winner_group
            // 
            this.winner_group.Controls.Add(this.btn_exit);
            this.winner_group.Controls.Add(this.btn_play_again);
            this.winner_group.Controls.Add(this.lbl_winner);
            this.winner_group.Controls.Add(this.label18);
            this.winner_group.Location = new System.Drawing.Point(16, 518);
            this.winner_group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.winner_group.Name = "winner_group";
            this.winner_group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.winner_group.Size = new System.Drawing.Size(619, 471);
            this.winner_group.TabIndex = 3;
            this.winner_group.TabStop = false;
            this.winner_group.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Tan;
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(329, 346);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(237, 73);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // btn_play_again
            // 
            this.btn_play_again.BackColor = System.Drawing.Color.Tan;
            this.btn_play_again.FlatAppearance.BorderSize = 2;
            this.btn_play_again.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play_again.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play_again.Location = new System.Drawing.Point(56, 346);
            this.btn_play_again.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_play_again.Name = "btn_play_again";
            this.btn_play_again.Size = new System.Drawing.Size(237, 73);
            this.btn_play_again.TabIndex = 11;
            this.btn_play_again.Text = "Play Again";
            this.btn_play_again.UseVisualStyleBackColor = false;
            this.btn_play_again.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // lbl_winner
            // 
            this.lbl_winner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_winner.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_winner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_winner.Location = new System.Drawing.Point(4, 94);
            this.lbl_winner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(611, 206);
            this.lbl_winner.TabIndex = 1;
            this.lbl_winner.Text = "x Wins!";
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SandyBrown;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(4, 19);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(611, 75);
            this.label18.TabIndex = 0;
            this.label18.Text = "PaintWAR";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1083, 778);
            this.Controls.Add(this.winner_group);
            this.Controls.Add(this.input_group);
            this.Controls.Add(this.control_group);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintWAR";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.control_group.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.input_group.ResumeLayout(false);
            this.input_group.PerformLayout();
            this.winner_group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox control_group;
        private System.Windows.Forms.Button btn_paint_infected;
        private System.Windows.Forms.Button btn_paint_dripping;
        private System.Windows.Forms.Button btn_paint_bomb;
        private System.Windows.Forms.Label lbl_weapon_choice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_points_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Button btn_paint_blob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_points_2;
        private System.Windows.Forms.ToolStripMenuItem mi_new_game;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox input_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_p1_colour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_p2_colour;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.ComboBox cb_grid_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_p2_name;
        private System.Windows.Forms.Label lbl_p1_name;
        private System.Windows.Forms.GroupBox winner_group;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_play_again;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label label18;
    }
}

