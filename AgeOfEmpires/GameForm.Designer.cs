
namespace AgeOfEmpires0
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resourceTimer = new System.Windows.Forms.Timer(this.components);
            this.villagerTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.stoneTextBox = new System.Windows.Forms.TextBox();
            this.woodTextBox = new System.Windows.Forms.TextBox();
            this.goldCollectorsTextBox = new System.Windows.Forms.TextBox();
            this.foodCollectorsTextBox = new System.Windows.Forms.TextBox();
            this.stoneCollectorsTextBox = new System.Windows.Forms.TextBox();
            this.woodCollectorsTextBox = new System.Windows.Forms.TextBox();
            this.subtractGoldCollectorButton = new System.Windows.Forms.Button();
            this.addGoldCollectorButton = new System.Windows.Forms.Button();
            this.addFoodCollectorsButton = new System.Windows.Forms.Button();
            this.subtractFoodCollectorsButton = new System.Windows.Forms.Button();
            this.addStoneCollectorsButton = new System.Windows.Forms.Button();
            this.subtractStoneCollectorsButton = new System.Windows.Forms.Button();
            this.addWoodCollectorsButton = new System.Windows.Forms.Button();
            this.subtractWoodCollectorsButton = new System.Windows.Forms.Button();
            this.addVillagerButton = new System.Windows.Forms.Button();
            this.goldPictureBox = new System.Windows.Forms.PictureBox();
            this.foodPictureBox = new System.Windows.Forms.PictureBox();
            this.stonePictureBox = new System.Windows.Forms.PictureBox();
            this.woodPictureBox = new System.Windows.Forms.PictureBox();
            this.populationLabel = new System.Windows.Forms.Label();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.houseButton = new System.Windows.Forms.Button();
            this.createInfantryButton = new System.Windows.Forms.Button();
            this.ironPictureBox = new System.Windows.Forms.PictureBox();
            this.addIronCollectorsButton = new System.Windows.Forms.Button();
            this.subtractIronCollectorsButton = new System.Windows.Forms.Button();
            this.ironCollectorsTextBox = new System.Windows.Forms.TextBox();
            this.ironTextBox = new System.Windows.Forms.TextBox();
            this.createBarracksButton = new System.Windows.Forms.Button();
            this.createCavalryButton = new System.Windows.Forms.Button();
            this.createCatapultButton = new System.Windows.Forms.Button();
            this.infantryTextBox = new System.Windows.Forms.TextBox();
            this.cavalryTextBox = new System.Windows.Forms.TextBox();
            this.artilleryTextBox = new System.Windows.Forms.TextBox();
            this.notEnoughResourcesLabel = new System.Windows.Forms.Label();
            this.enemyBaseProgressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attackEnemyBase = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerHPProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyAttackLabel = new System.Windows.Forms.Label();
            this.infantryLabel = new System.Windows.Forms.Label();
            this.cavalryLabel = new System.Windows.Forms.Label();
            this.catapultLabel = new System.Windows.Forms.Label();
            this.villagerLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.barracksLabel = new System.Windows.Forms.Label();
            this.playerBaseHPLabel = new System.Windows.Forms.Label();
            this.enemyBaseHPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // resourceTimer
            // 
            this.resourceTimer.Enabled = true;
            this.resourceTimer.Interval = 500;
            this.resourceTimer.Tick += new System.EventHandler(this.ResourceTimer_Tick);
            // 
            // villagerTextBox
            // 
            this.villagerTextBox.Enabled = false;
            this.villagerTextBox.Location = new System.Drawing.Point(67, 442);
            this.villagerTextBox.Name = "villagerTextBox";
            this.villagerTextBox.ReadOnly = true;
            this.villagerTextBox.Size = new System.Drawing.Size(85, 23);
            this.villagerTextBox.TabIndex = 1;
            // 
            // goldTextBox
            // 
            this.goldTextBox.Enabled = false;
            this.goldTextBox.Location = new System.Drawing.Point(67, 568);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.ReadOnly = true;
            this.goldTextBox.Size = new System.Drawing.Size(66, 23);
            this.goldTextBox.TabIndex = 3;
            // 
            // foodTextBox
            // 
            this.foodTextBox.Enabled = false;
            this.foodTextBox.Location = new System.Drawing.Point(189, 568);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.ReadOnly = true;
            this.foodTextBox.Size = new System.Drawing.Size(66, 23);
            this.foodTextBox.TabIndex = 5;
            // 
            // stoneTextBox
            // 
            this.stoneTextBox.Enabled = false;
            this.stoneTextBox.Location = new System.Drawing.Point(318, 568);
            this.stoneTextBox.Name = "stoneTextBox";
            this.stoneTextBox.ReadOnly = true;
            this.stoneTextBox.Size = new System.Drawing.Size(66, 23);
            this.stoneTextBox.TabIndex = 7;
            // 
            // woodTextBox
            // 
            this.woodTextBox.Enabled = false;
            this.woodTextBox.Location = new System.Drawing.Point(441, 568);
            this.woodTextBox.Name = "woodTextBox";
            this.woodTextBox.ReadOnly = true;
            this.woodTextBox.Size = new System.Drawing.Size(66, 23);
            this.woodTextBox.TabIndex = 9;
            // 
            // goldCollectorsTextBox
            // 
            this.goldCollectorsTextBox.Enabled = false;
            this.goldCollectorsTextBox.Location = new System.Drawing.Point(86, 597);
            this.goldCollectorsTextBox.Name = "goldCollectorsTextBox";
            this.goldCollectorsTextBox.ReadOnly = true;
            this.goldCollectorsTextBox.Size = new System.Drawing.Size(24, 23);
            this.goldCollectorsTextBox.TabIndex = 10;
            // 
            // foodCollectorsTextBox
            // 
            this.foodCollectorsTextBox.Enabled = false;
            this.foodCollectorsTextBox.Location = new System.Drawing.Point(211, 597);
            this.foodCollectorsTextBox.Name = "foodCollectorsTextBox";
            this.foodCollectorsTextBox.ReadOnly = true;
            this.foodCollectorsTextBox.Size = new System.Drawing.Size(24, 23);
            this.foodCollectorsTextBox.TabIndex = 11;
            // 
            // stoneCollectorsTextBox
            // 
            this.stoneCollectorsTextBox.Enabled = false;
            this.stoneCollectorsTextBox.Location = new System.Drawing.Point(340, 597);
            this.stoneCollectorsTextBox.Name = "stoneCollectorsTextBox";
            this.stoneCollectorsTextBox.ReadOnly = true;
            this.stoneCollectorsTextBox.Size = new System.Drawing.Size(24, 23);
            this.stoneCollectorsTextBox.TabIndex = 12;
            // 
            // woodCollectorsTextBox
            // 
            this.woodCollectorsTextBox.Enabled = false;
            this.woodCollectorsTextBox.Location = new System.Drawing.Point(462, 598);
            this.woodCollectorsTextBox.Name = "woodCollectorsTextBox";
            this.woodCollectorsTextBox.ReadOnly = true;
            this.woodCollectorsTextBox.Size = new System.Drawing.Size(24, 23);
            this.woodCollectorsTextBox.TabIndex = 13;
            // 
            // subtractGoldCollectorButton
            // 
            this.subtractGoldCollectorButton.Location = new System.Drawing.Point(57, 598);
            this.subtractGoldCollectorButton.Name = "subtractGoldCollectorButton";
            this.subtractGoldCollectorButton.Size = new System.Drawing.Size(23, 23);
            this.subtractGoldCollectorButton.TabIndex = 14;
            this.subtractGoldCollectorButton.Text = "-";
            this.subtractGoldCollectorButton.UseVisualStyleBackColor = true;
            this.subtractGoldCollectorButton.Click += new System.EventHandler(this.SubtractGoldCollectorButton_Click);
            // 
            // addGoldCollectorButton
            // 
            this.addGoldCollectorButton.Location = new System.Drawing.Point(116, 597);
            this.addGoldCollectorButton.Name = "addGoldCollectorButton";
            this.addGoldCollectorButton.Size = new System.Drawing.Size(23, 23);
            this.addGoldCollectorButton.TabIndex = 15;
            this.addGoldCollectorButton.Text = "+";
            this.addGoldCollectorButton.UseVisualStyleBackColor = true;
            this.addGoldCollectorButton.Click += new System.EventHandler(this.AddGoldCollectorButton_Click);
            // 
            // addFoodCollectorsButton
            // 
            this.addFoodCollectorsButton.Location = new System.Drawing.Point(241, 596);
            this.addFoodCollectorsButton.Name = "addFoodCollectorsButton";
            this.addFoodCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.addFoodCollectorsButton.TabIndex = 17;
            this.addFoodCollectorsButton.Text = "+";
            this.addFoodCollectorsButton.UseVisualStyleBackColor = true;
            this.addFoodCollectorsButton.Click += new System.EventHandler(this.AddFoodCollectorsButton_Click);
            // 
            // subtractFoodCollectorsButton
            // 
            this.subtractFoodCollectorsButton.Location = new System.Drawing.Point(181, 596);
            this.subtractFoodCollectorsButton.Name = "subtractFoodCollectorsButton";
            this.subtractFoodCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.subtractFoodCollectorsButton.TabIndex = 16;
            this.subtractFoodCollectorsButton.Text = "-";
            this.subtractFoodCollectorsButton.UseVisualStyleBackColor = true;
            this.subtractFoodCollectorsButton.Click += new System.EventHandler(this.SubtractFoodCollectorsButton_Click);
            // 
            // addStoneCollectorsButton
            // 
            this.addStoneCollectorsButton.Location = new System.Drawing.Point(370, 597);
            this.addStoneCollectorsButton.Name = "addStoneCollectorsButton";
            this.addStoneCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.addStoneCollectorsButton.TabIndex = 19;
            this.addStoneCollectorsButton.Text = "+";
            this.addStoneCollectorsButton.UseVisualStyleBackColor = true;
            this.addStoneCollectorsButton.Click += new System.EventHandler(this.AddStoneCollectorsButton_Click);
            // 
            // subtractStoneCollectorsButton
            // 
            this.subtractStoneCollectorsButton.Location = new System.Drawing.Point(310, 597);
            this.subtractStoneCollectorsButton.Name = "subtractStoneCollectorsButton";
            this.subtractStoneCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.subtractStoneCollectorsButton.TabIndex = 18;
            this.subtractStoneCollectorsButton.Text = "-";
            this.subtractStoneCollectorsButton.UseVisualStyleBackColor = true;
            this.subtractStoneCollectorsButton.Click += new System.EventHandler(this.SubtractStoneCollectorsButton_Click);
            // 
            // addWoodCollectorsButton
            // 
            this.addWoodCollectorsButton.Location = new System.Drawing.Point(492, 598);
            this.addWoodCollectorsButton.Name = "addWoodCollectorsButton";
            this.addWoodCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.addWoodCollectorsButton.TabIndex = 21;
            this.addWoodCollectorsButton.Text = "+";
            this.addWoodCollectorsButton.UseVisualStyleBackColor = true;
            this.addWoodCollectorsButton.Click += new System.EventHandler(this.AddWoodCollectorsButton_Click);
            // 
            // subtractWoodCollectorsButton
            // 
            this.subtractWoodCollectorsButton.Location = new System.Drawing.Point(433, 598);
            this.subtractWoodCollectorsButton.Name = "subtractWoodCollectorsButton";
            this.subtractWoodCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.subtractWoodCollectorsButton.TabIndex = 20;
            this.subtractWoodCollectorsButton.Text = "-";
            this.subtractWoodCollectorsButton.UseVisualStyleBackColor = true;
            this.subtractWoodCollectorsButton.Click += new System.EventHandler(this.SubtractWoodCollectorsButton_Click);
            // 
            // addVillagerButton
            // 
            this.addVillagerButton.BackColor = System.Drawing.Color.Transparent;
            this.addVillagerButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Settler_aoe3de;
            this.addVillagerButton.Location = new System.Drawing.Point(67, 351);
            this.addVillagerButton.Name = "addVillagerButton";
            this.addVillagerButton.Size = new System.Drawing.Size(85, 85);
            this.addVillagerButton.TabIndex = 22;
            this.addVillagerButton.UseVisualStyleBackColor = false;
            this.addVillagerButton.Click += new System.EventHandler(this.AddVillagerButton_Click);
            // 
            // goldPictureBox
            // 
            this.goldPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.goldPictureBox.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Aoe2de_gold;
            this.goldPictureBox.Enabled = false;
            this.goldPictureBox.InitialImage = global::AgeOfEmpires0.Properties.Resources.Aoe2de_gold;
            this.goldPictureBox.Location = new System.Drawing.Point(67, 496);
            this.goldPictureBox.Name = "goldPictureBox";
            this.goldPictureBox.Size = new System.Drawing.Size(66, 66);
            this.goldPictureBox.TabIndex = 23;
            this.goldPictureBox.TabStop = false;
            // 
            // foodPictureBox
            // 
            this.foodPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.foodPictureBox.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Aoe2de_food;
            this.foodPictureBox.Location = new System.Drawing.Point(189, 496);
            this.foodPictureBox.Name = "foodPictureBox";
            this.foodPictureBox.Size = new System.Drawing.Size(66, 66);
            this.foodPictureBox.TabIndex = 24;
            this.foodPictureBox.TabStop = false;
            // 
            // stonePictureBox
            // 
            this.stonePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.stonePictureBox.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Aoe2de_stone;
            this.stonePictureBox.Location = new System.Drawing.Point(318, 499);
            this.stonePictureBox.Name = "stonePictureBox";
            this.stonePictureBox.Size = new System.Drawing.Size(66, 66);
            this.stonePictureBox.TabIndex = 25;
            this.stonePictureBox.TabStop = false;
            // 
            // woodPictureBox
            // 
            this.woodPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.woodPictureBox.Image = global::AgeOfEmpires0.Properties.Resources.Aoe2de_wood;
            this.woodPictureBox.Location = new System.Drawing.Point(441, 499);
            this.woodPictureBox.Name = "woodPictureBox";
            this.woodPictureBox.Size = new System.Drawing.Size(66, 66);
            this.woodPictureBox.TabIndex = 26;
            this.woodPictureBox.TabStop = false;
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.BackColor = System.Drawing.Color.Transparent;
            this.populationLabel.Location = new System.Drawing.Point(42, 294);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(68, 15);
            this.populationLabel.TabIndex = 27;
            this.populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.Enabled = false;
            this.populationTextBox.Location = new System.Drawing.Point(116, 291);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.ReadOnly = true;
            this.populationTextBox.Size = new System.Drawing.Size(100, 23);
            this.populationTextBox.TabIndex = 28;
            // 
            // houseButton
            // 
            this.houseButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Iron_Age_House1;
            this.houseButton.Location = new System.Drawing.Point(116, 220);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(100, 65);
            this.houseButton.TabIndex = 29;
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // createInfantryButton
            // 
            this.createInfantryButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Centurion1;
            this.createInfantryButton.Enabled = false;
            this.createInfantryButton.Location = new System.Drawing.Point(717, 487);
            this.createInfantryButton.Name = "createInfantryButton";
            this.createInfantryButton.Size = new System.Drawing.Size(75, 75);
            this.createInfantryButton.TabIndex = 30;
            this.createInfantryButton.UseVisualStyleBackColor = true;
            this.createInfantryButton.Visible = false;
            this.createInfantryButton.Click += new System.EventHandler(this.CreateInfantryButton_Click);
            // 
            // ironPictureBox
            // 
            this.ironPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ironPictureBox.Image = global::AgeOfEmpires0.Properties.Resources.Iron_Ore_JE6_BE4;
            this.ironPictureBox.Location = new System.Drawing.Point(569, 499);
            this.ironPictureBox.Name = "ironPictureBox";
            this.ironPictureBox.Size = new System.Drawing.Size(66, 66);
            this.ironPictureBox.TabIndex = 35;
            this.ironPictureBox.TabStop = false;
            // 
            // addIronCollectorsButton
            // 
            this.addIronCollectorsButton.Location = new System.Drawing.Point(620, 597);
            this.addIronCollectorsButton.Name = "addIronCollectorsButton";
            this.addIronCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.addIronCollectorsButton.TabIndex = 34;
            this.addIronCollectorsButton.Text = "+";
            this.addIronCollectorsButton.UseVisualStyleBackColor = true;
            this.addIronCollectorsButton.Click += new System.EventHandler(this.AddIronCollectorsButton_Click);
            // 
            // subtractIronCollectorsButton
            // 
            this.subtractIronCollectorsButton.Location = new System.Drawing.Point(561, 597);
            this.subtractIronCollectorsButton.Name = "subtractIronCollectorsButton";
            this.subtractIronCollectorsButton.Size = new System.Drawing.Size(23, 23);
            this.subtractIronCollectorsButton.TabIndex = 33;
            this.subtractIronCollectorsButton.Text = "-";
            this.subtractIronCollectorsButton.UseVisualStyleBackColor = true;
            this.subtractIronCollectorsButton.Click += new System.EventHandler(this.SubtractIronCollectorsButton_Click);
            // 
            // ironCollectorsTextBox
            // 
            this.ironCollectorsTextBox.Enabled = false;
            this.ironCollectorsTextBox.Location = new System.Drawing.Point(590, 598);
            this.ironCollectorsTextBox.Name = "ironCollectorsTextBox";
            this.ironCollectorsTextBox.ReadOnly = true;
            this.ironCollectorsTextBox.Size = new System.Drawing.Size(24, 23);
            this.ironCollectorsTextBox.TabIndex = 32;
            // 
            // ironTextBox
            // 
            this.ironTextBox.Enabled = false;
            this.ironTextBox.Location = new System.Drawing.Point(569, 568);
            this.ironTextBox.Name = "ironTextBox";
            this.ironTextBox.ReadOnly = true;
            this.ironTextBox.Size = new System.Drawing.Size(66, 23);
            this.ironTextBox.TabIndex = 31;
            // 
            // createBarracksButton
            // 
            this.createBarracksButton.BackColor = System.Drawing.Color.Transparent;
            this.createBarracksButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Roman_Barracks;
            this.createBarracksButton.FlatAppearance.BorderSize = 0;
            this.createBarracksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBarracksButton.Location = new System.Drawing.Point(842, 337);
            this.createBarracksButton.Name = "createBarracksButton";
            this.createBarracksButton.Size = new System.Drawing.Size(150, 114);
            this.createBarracksButton.TabIndex = 36;
            this.createBarracksButton.UseVisualStyleBackColor = false;
            this.createBarracksButton.Click += new System.EventHandler(this.CreateBarracksButton_Click);
            // 
            // createCavalryButton
            // 
            this.createCavalryButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Cataphract;
            this.createCavalryButton.Enabled = false;
            this.createCavalryButton.Location = new System.Drawing.Point(883, 487);
            this.createCavalryButton.Name = "createCavalryButton";
            this.createCavalryButton.Size = new System.Drawing.Size(75, 75);
            this.createCavalryButton.TabIndex = 37;
            this.createCavalryButton.UseVisualStyleBackColor = true;
            this.createCavalryButton.Visible = false;
            this.createCavalryButton.Click += new System.EventHandler(this.CreateCavalryButton_Click);
            // 
            // createCatapultButton
            // 
            this.createCatapultButton.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.HeavyCatapult;
            this.createCatapultButton.Enabled = false;
            this.createCatapultButton.Location = new System.Drawing.Point(1049, 490);
            this.createCatapultButton.Name = "createCatapultButton";
            this.createCatapultButton.Size = new System.Drawing.Size(75, 75);
            this.createCatapultButton.TabIndex = 38;
            this.createCatapultButton.UseVisualStyleBackColor = true;
            this.createCatapultButton.Visible = false;
            this.createCatapultButton.Click += new System.EventHandler(this.CreateCatapultButton_Click);
            // 
            // infantryTextBox
            // 
            this.infantryTextBox.Enabled = false;
            this.infantryTextBox.Location = new System.Drawing.Point(717, 568);
            this.infantryTextBox.Name = "infantryTextBox";
            this.infantryTextBox.Size = new System.Drawing.Size(75, 23);
            this.infantryTextBox.TabIndex = 39;
            this.infantryTextBox.Visible = false;
            // 
            // cavalryTextBox
            // 
            this.cavalryTextBox.Enabled = false;
            this.cavalryTextBox.Location = new System.Drawing.Point(883, 568);
            this.cavalryTextBox.Name = "cavalryTextBox";
            this.cavalryTextBox.Size = new System.Drawing.Size(75, 23);
            this.cavalryTextBox.TabIndex = 40;
            this.cavalryTextBox.Visible = false;
            // 
            // artilleryTextBox
            // 
            this.artilleryTextBox.Enabled = false;
            this.artilleryTextBox.Location = new System.Drawing.Point(1049, 571);
            this.artilleryTextBox.Name = "artilleryTextBox";
            this.artilleryTextBox.Size = new System.Drawing.Size(75, 23);
            this.artilleryTextBox.TabIndex = 41;
            this.artilleryTextBox.Visible = false;
            // 
            // notEnoughResourcesLabel
            // 
            this.notEnoughResourcesLabel.AutoSize = true;
            this.notEnoughResourcesLabel.BackColor = System.Drawing.Color.Transparent;
            this.notEnoughResourcesLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notEnoughResourcesLabel.ForeColor = System.Drawing.Color.Red;
            this.notEnoughResourcesLabel.Location = new System.Drawing.Point(241, 451);
            this.notEnoughResourcesLabel.Name = "notEnoughResourcesLabel";
            this.notEnoughResourcesLabel.Size = new System.Drawing.Size(215, 28);
            this.notEnoughResourcesLabel.TabIndex = 42;
            this.notEnoughResourcesLabel.Text = "Not Enough Resources!";
            this.notEnoughResourcesLabel.Visible = false;
            // 
            // enemyBaseProgressBar
            // 
            this.enemyBaseProgressBar.BackColor = System.Drawing.Color.Red;
            this.enemyBaseProgressBar.ForeColor = System.Drawing.Color.Red;
            this.enemyBaseProgressBar.Location = new System.Drawing.Point(1007, 306);
            this.enemyBaseProgressBar.Maximum = 2000;
            this.enemyBaseProgressBar.Name = "enemyBaseProgressBar";
            this.enemyBaseProgressBar.Size = new System.Drawing.Size(218, 23);
            this.enemyBaseProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemyBaseProgressBar.TabIndex = 43;
            this.enemyBaseProgressBar.Value = 2000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Buildings_prev;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 139);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // attackEnemyBase
            // 
            this.attackEnemyBase.Location = new System.Drawing.Point(1064, 117);
            this.attackEnemyBase.Name = "attackEnemyBase";
            this.attackEnemyBase.Size = new System.Drawing.Size(111, 29);
            this.attackEnemyBase.TabIndex = 45;
            this.attackEnemyBase.Text = "Attack!";
            this.attackEnemyBase.UseVisualStyleBackColor = true;
            this.attackEnemyBase.Click += new System.EventHandler(this.AttackEnemyBase_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.Buildings_prev;
            this.pictureBox2.Location = new System.Drawing.Point(273, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 139);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // playerHPProgressBar
            // 
            this.playerHPProgressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playerHPProgressBar.ForeColor = System.Drawing.Color.Red;
            this.playerHPProgressBar.Location = new System.Drawing.Point(272, 297);
            this.playerHPProgressBar.Maximum = 2000;
            this.playerHPProgressBar.Name = "playerHPProgressBar";
            this.playerHPProgressBar.Size = new System.Drawing.Size(218, 23);
            this.playerHPProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHPProgressBar.TabIndex = 47;
            this.playerHPProgressBar.Value = 2000;
            // 
            // enemyAttackTimer
            // 
            this.enemyAttackTimer.Interval = 1000;
            this.enemyAttackTimer.Tick += new System.EventHandler(this.EnemyAttackTimer_Tick);
            // 
            // enemyAttackLabel
            // 
            this.enemyAttackLabel.AutoSize = true;
            this.enemyAttackLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyAttackLabel.Location = new System.Drawing.Point(272, 131);
            this.enemyAttackLabel.Name = "enemyAttackLabel";
            this.enemyAttackLabel.Size = new System.Drawing.Size(0, 15);
            this.enemyAttackLabel.TabIndex = 48;
            // 
            // infantryLabel
            // 
            this.infantryLabel.AutoSize = true;
            this.infantryLabel.BackColor = System.Drawing.Color.Transparent;
            this.infantryLabel.Location = new System.Drawing.Point(696, 454);
            this.infantryLabel.Name = "infantryLabel";
            this.infantryLabel.Size = new System.Drawing.Size(115, 30);
            this.infantryLabel.TabIndex = 49;
            this.infantryLabel.Text = "Cost: 50 iron 50 gold\r\n        10 damage";
            this.infantryLabel.Visible = false;
            // 
            // cavalryLabel
            // 
            this.cavalryLabel.AutoSize = true;
            this.cavalryLabel.BackColor = System.Drawing.Color.Transparent;
            this.cavalryLabel.Location = new System.Drawing.Point(857, 454);
            this.cavalryLabel.Name = "cavalryLabel";
            this.cavalryLabel.Size = new System.Drawing.Size(125, 30);
            this.cavalryLabel.TabIndex = 50;
            this.cavalryLabel.Text = "Cost: 50 food 100 gold\r\n          20 damage";
            this.cavalryLabel.Visible = false;
            // 
            // catapultLabel
            // 
            this.catapultLabel.AutoSize = true;
            this.catapultLabel.BackColor = System.Drawing.Color.Transparent;
            this.catapultLabel.Location = new System.Drawing.Point(998, 457);
            this.catapultLabel.Name = "catapultLabel";
            this.catapultLabel.Size = new System.Drawing.Size(177, 30);
            this.catapultLabel.TabIndex = 51;
            this.catapultLabel.Text = "Cost: 50 stone 50 gold 100 wood\r\n                50 damage";
            this.catapultLabel.Visible = false;
            // 
            // villagerLabel
            // 
            this.villagerLabel.AutoSize = true;
            this.villagerLabel.BackColor = System.Drawing.Color.Transparent;
            this.villagerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.villagerLabel.Location = new System.Drawing.Point(164, 382);
            this.villagerLabel.Name = "villagerLabel";
            this.villagerLabel.Size = new System.Drawing.Size(102, 21);
            this.villagerLabel.TabIndex = 52;
            this.villagerLabel.Text = "Cost: 50 food";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.BackColor = System.Drawing.Color.Transparent;
            this.houseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.houseLabel.Location = new System.Drawing.Point(116, 196);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(118, 21);
            this.houseLabel.TabIndex = 53;
            this.houseLabel.Text = "Cost: 100 wood";
            // 
            // barracksLabel
            // 
            this.barracksLabel.AutoSize = true;
            this.barracksLabel.BackColor = System.Drawing.Color.Transparent;
            this.barracksLabel.Location = new System.Drawing.Point(842, 335);
            this.barracksLabel.Name = "barracksLabel";
            this.barracksLabel.Size = new System.Drawing.Size(141, 15);
            this.barracksLabel.TabIndex = 54;
            this.barracksLabel.Text = "Cost: 100 wood 100 stone";
            // 
            // playerBaseHPLabel
            // 
            this.playerBaseHPLabel.AutoSize = true;
            this.playerBaseHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerBaseHPLabel.Location = new System.Drawing.Point(318, 323);
            this.playerBaseHPLabel.Name = "playerBaseHPLabel";
            this.playerBaseHPLabel.Size = new System.Drawing.Size(107, 15);
            this.playerBaseHPLabel.TabIndex = 55;
            this.playerBaseHPLabel.Text = "playerBaseHPLabel";
            // 
            // enemyBaseHPLabel
            // 
            this.enemyBaseHPLabel.AutoSize = true;
            this.enemyBaseHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyBaseHPLabel.Location = new System.Drawing.Point(1064, 332);
            this.enemyBaseHPLabel.Name = "enemyBaseHPLabel";
            this.enemyBaseHPLabel.Size = new System.Drawing.Size(111, 15);
            this.enemyBaseHPLabel.TabIndex = 56;
            this.enemyBaseHPLabel.Text = "enemyBaseHPLabel";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgeOfEmpires0.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.enemyBaseHPLabel);
            this.Controls.Add(this.playerBaseHPLabel);
            this.Controls.Add(this.barracksLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.villagerLabel);
            this.Controls.Add(this.catapultLabel);
            this.Controls.Add(this.cavalryLabel);
            this.Controls.Add(this.infantryLabel);
            this.Controls.Add(this.enemyAttackLabel);
            this.Controls.Add(this.playerHPProgressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.attackEnemyBase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemyBaseProgressBar);
            this.Controls.Add(this.notEnoughResourcesLabel);
            this.Controls.Add(this.artilleryTextBox);
            this.Controls.Add(this.cavalryTextBox);
            this.Controls.Add(this.infantryTextBox);
            this.Controls.Add(this.createCatapultButton);
            this.Controls.Add(this.createCavalryButton);
            this.Controls.Add(this.createBarracksButton);
            this.Controls.Add(this.ironPictureBox);
            this.Controls.Add(this.addIronCollectorsButton);
            this.Controls.Add(this.subtractIronCollectorsButton);
            this.Controls.Add(this.ironCollectorsTextBox);
            this.Controls.Add(this.ironTextBox);
            this.Controls.Add(this.createInfantryButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.woodPictureBox);
            this.Controls.Add(this.stonePictureBox);
            this.Controls.Add(this.foodPictureBox);
            this.Controls.Add(this.goldPictureBox);
            this.Controls.Add(this.addVillagerButton);
            this.Controls.Add(this.addWoodCollectorsButton);
            this.Controls.Add(this.subtractWoodCollectorsButton);
            this.Controls.Add(this.addStoneCollectorsButton);
            this.Controls.Add(this.subtractStoneCollectorsButton);
            this.Controls.Add(this.addFoodCollectorsButton);
            this.Controls.Add(this.subtractFoodCollectorsButton);
            this.Controls.Add(this.addGoldCollectorButton);
            this.Controls.Add(this.subtractGoldCollectorButton);
            this.Controls.Add(this.woodCollectorsTextBox);
            this.Controls.Add(this.stoneCollectorsTextBox);
            this.Controls.Add(this.foodCollectorsTextBox);
            this.Controls.Add(this.goldCollectorsTextBox);
            this.Controls.Add(this.woodTextBox);
            this.Controls.Add(this.stoneTextBox);
            this.Controls.Add(this.foodTextBox);
            this.Controls.Add(this.goldTextBox);
            this.Controls.Add(this.villagerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Of Empires 0";
            ((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer resourceTimer;
        private System.Windows.Forms.TextBox villagerTextBox;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.TextBox stoneTextBox;
        private System.Windows.Forms.TextBox woodTextBox;
        private System.Windows.Forms.TextBox goldCollectorsTextBox;
        private System.Windows.Forms.TextBox foodCollectorsTextBox;
        private System.Windows.Forms.TextBox stoneCollectorsTextBox;
        private System.Windows.Forms.TextBox woodCollectorsTextBox;
        private System.Windows.Forms.Button subtractGoldCollectorButton;
        private System.Windows.Forms.Button addGoldCollectorButton;
        private System.Windows.Forms.Button addFoodCollectorsButton;
        private System.Windows.Forms.Button subtractFoodCollectorsButton;
        private System.Windows.Forms.Button addStoneCollectorsButton;
        private System.Windows.Forms.Button subtractStoneCollectorsButton;
        private System.Windows.Forms.Button addWoodCollectorsButton;
        private System.Windows.Forms.Button subtractWoodCollectorsButton;
        private System.Windows.Forms.Button addVillagerButton;
        private System.Windows.Forms.PictureBox goldPictureBox;
        private System.Windows.Forms.PictureBox foodPictureBox;
        private System.Windows.Forms.PictureBox stonePictureBox;
        private System.Windows.Forms.PictureBox woodPictureBox;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button createInfantryButton;
        private System.Windows.Forms.PictureBox ironPictureBox;
        private System.Windows.Forms.Button addIronCollectorsButton;
        private System.Windows.Forms.Button subtractIronCollectorsButton;
        private System.Windows.Forms.TextBox ironCollectorsTextBox;
        private System.Windows.Forms.TextBox ironTextBox;
        private System.Windows.Forms.Button createBarracksButton;
        private System.Windows.Forms.Button createCavalryButton;
        private System.Windows.Forms.Button createCatapultButton;
        private System.Windows.Forms.TextBox infantryTextBox;
        private System.Windows.Forms.TextBox cavalryTextBox;
        private System.Windows.Forms.TextBox artilleryTextBox;
        private System.Windows.Forms.Label notEnoughResourcesLabel;
        private System.Windows.Forms.ProgressBar enemyBaseProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button attackEnemyBase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar playerHPProgressBar;
        private System.Windows.Forms.Timer enemyAttackTimer;
        private System.Windows.Forms.Label enemyAttackLabel;
        private System.Windows.Forms.Label infantryLabel;
        private System.Windows.Forms.Label cavalryLabel;
        private System.Windows.Forms.Label catapultLabel;
        private System.Windows.Forms.Label villagerLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label barracksLabel;
        private System.Windows.Forms.Label playerBaseHPLabel;
        private System.Windows.Forms.Label enemyBaseHPLabel;
    }
}

