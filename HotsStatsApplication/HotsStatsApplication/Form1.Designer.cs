namespace HotsStatsApplication
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
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeroComboBox = new System.Windows.Forms.ComboBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.HeroSelectLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.SpellPowerModifierLabel = new System.Windows.Forms.Label();
            this.SpellPowerComboBox = new System.Windows.Forms.ComboBox();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroTitleLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthVarLabel = new System.Windows.Forms.Label();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.ManaVarLabel = new System.Windows.Forms.Label();
            this.QAbilityNameLabel = new System.Windows.Forms.Label();
            this.WAbilityNameLabel = new System.Windows.Forms.Label();
            this.EAbilityNameLabel = new System.Windows.Forms.Label();
            this.R1AbilityNameLabel = new System.Windows.Forms.Label();
            this.R2AbilityNameLabel = new System.Windows.Forms.Label();
            this.R3AbilityNameLabel = new System.Windows.Forms.Label();
            this.TraitAbilityNameLabel = new System.Windows.Forms.Label();
            this.QDamageVarLabel = new System.Windows.Forms.Label();
            this.WDamageVarLabel = new System.Windows.Forms.Label();
            this.EDamageVarLabel = new System.Windows.Forms.Label();
            this.R1DamageVarLabel = new System.Windows.Forms.Label();
            this.R2DamageVarLabel = new System.Windows.Forms.Label();
            this.R3DamageVarLabel = new System.Windows.Forms.Label();
            this.TraitDamageVarLabel = new System.Windows.Forms.Label();
            this.QHealingVarLabel = new System.Windows.Forms.Label();
            this.WHealingVarLabel = new System.Windows.Forms.Label();
            this.EHealingVarLabel = new System.Windows.Forms.Label();
            this.R1HealingVarLabel = new System.Windows.Forms.Label();
            this.R2HealingVarLabel = new System.Windows.Forms.Label();
            this.R3HealingVarLabel = new System.Windows.Forms.Label();
            this.TraitHealingVarLabel = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HeroPicture = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.HelpMenuItem,
            this.OptionsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenuItem.Text = "Options";
            // 
            // HeroComboBox
            // 
            this.HeroComboBox.FormattingEnabled = true;
            this.HeroComboBox.Items.AddRange(new object[] {
            "Auriel",
            "Dehaka",
            "Kael\'thas"});
            this.HeroComboBox.Location = new System.Drawing.Point(84, 120);
            this.HeroComboBox.Name = "HeroComboBox";
            this.HeroComboBox.Size = new System.Drawing.Size(142, 21);
            this.HeroComboBox.TabIndex = 2;
            this.HeroComboBox.SelectedIndexChanged += new System.EventHandler(this.HeroComboBox_SelectedIndexChanged);
            // 
            // HeroSelectLabel
            // 
            this.HeroSelectLabel.AutoSize = true;
            this.HeroSelectLabel.Location = new System.Drawing.Point(12, 120);
            this.HeroSelectLabel.Name = "HeroSelectLabel";
            this.HeroSelectLabel.Size = new System.Drawing.Size(66, 13);
            this.HeroSelectLabel.TabIndex = 4;
            this.HeroSelectLabel.Text = "Hero Select:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(12, 153);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(36, 13);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level:";
            this.LevelLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.LevelComboBox.Location = new System.Drawing.Point(84, 153);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(142, 21);
            this.LevelComboBox.TabIndex = 6;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            // 
            // SpellPowerModifierLabel
            // 
            this.SpellPowerModifierLabel.AutoSize = true;
            this.SpellPowerModifierLabel.Location = new System.Drawing.Point(12, 191);
            this.SpellPowerModifierLabel.Name = "SpellPowerModifierLabel";
            this.SpellPowerModifierLabel.Size = new System.Drawing.Size(123, 13);
            this.SpellPowerModifierLabel.TabIndex = 7;
            this.SpellPowerModifierLabel.Text = "Spell Power Modifier % : ";
            // 
            // SpellPowerComboBox
            // 
            this.SpellPowerComboBox.FormattingEnabled = true;
            this.SpellPowerComboBox.Items.AddRange(new object[] {
            "-50",
            "-40",
            "-35",
            "-25",
            "-20",
            "-15",
            "0",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.SpellPowerComboBox.Location = new System.Drawing.Point(134, 191);
            this.SpellPowerComboBox.Name = "SpellPowerComboBox";
            this.SpellPowerComboBox.Size = new System.Drawing.Size(142, 21);
            this.SpellPowerComboBox.TabIndex = 8;
            this.SpellPowerComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellPowerComboBox_SelectedIndexChanged);
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoSize = true;
            this.HeroNameLabel.Location = new System.Drawing.Point(504, 120);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(61, 13);
            this.HeroNameLabel.TabIndex = 9;
            this.HeroNameLabel.Text = "Hero Name";
            this.HeroNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // HeroTitleLabel
            // 
            this.HeroTitleLabel.AutoSize = true;
            this.HeroTitleLabel.Location = new System.Drawing.Point(504, 140);
            this.HeroTitleLabel.Name = "HeroTitleLabel";
            this.HeroTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.HeroTitleLabel.TabIndex = 11;
            this.HeroTitleLabel.Text = "Hero Title";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(429, 161);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(41, 13);
            this.HealthLabel.TabIndex = 12;
            this.HealthLabel.Text = "Health:";
            // 
            // HealthVarLabel
            // 
            this.HealthVarLabel.AutoSize = true;
            this.HealthVarLabel.Location = new System.Drawing.Point(476, 161);
            this.HealthVarLabel.Name = "HealthVarLabel";
            this.HealthVarLabel.Size = new System.Drawing.Size(64, 13);
            this.HealthVarLabel.TabIndex = 13;
            this.HealthVarLabel.Text = "Health Here";
            // 
            // ManaLabel
            // 
            this.ManaLabel.AutoSize = true;
            this.ManaLabel.Location = new System.Drawing.Point(429, 191);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(37, 13);
            this.ManaLabel.TabIndex = 14;
            this.ManaLabel.Text = "Mana:";
            // 
            // ManaVarLabel
            // 
            this.ManaVarLabel.AutoSize = true;
            this.ManaVarLabel.Location = new System.Drawing.Point(476, 191);
            this.ManaVarLabel.Name = "ManaVarLabel";
            this.ManaVarLabel.Size = new System.Drawing.Size(60, 13);
            this.ManaVarLabel.TabIndex = 15;
            this.ManaVarLabel.Text = "Mana Here";
            // 
            // QAbilityNameLabel
            // 
            this.QAbilityNameLabel.AutoSize = true;
            this.QAbilityNameLabel.Location = new System.Drawing.Point(429, 218);
            this.QAbilityNameLabel.Name = "QAbilityNameLabel";
            this.QAbilityNameLabel.Size = new System.Drawing.Size(48, 13);
            this.QAbilityNameLabel.TabIndex = 16;
            this.QAbilityNameLabel.Text = "Q Ability:";
            // 
            // WAbilityNameLabel
            // 
            this.WAbilityNameLabel.AutoSize = true;
            this.WAbilityNameLabel.Location = new System.Drawing.Point(429, 259);
            this.WAbilityNameLabel.Name = "WAbilityNameLabel";
            this.WAbilityNameLabel.Size = new System.Drawing.Size(51, 13);
            this.WAbilityNameLabel.TabIndex = 19;
            this.WAbilityNameLabel.Text = "W Ability:";
            // 
            // EAbilityNameLabel
            // 
            this.EAbilityNameLabel.AutoSize = true;
            this.EAbilityNameLabel.Location = new System.Drawing.Point(429, 303);
            this.EAbilityNameLabel.Name = "EAbilityNameLabel";
            this.EAbilityNameLabel.Size = new System.Drawing.Size(47, 13);
            this.EAbilityNameLabel.TabIndex = 22;
            this.EAbilityNameLabel.Text = "E Ability:";
            // 
            // R1AbilityNameLabel
            // 
            this.R1AbilityNameLabel.AutoSize = true;
            this.R1AbilityNameLabel.Location = new System.Drawing.Point(429, 350);
            this.R1AbilityNameLabel.Name = "R1AbilityNameLabel";
            this.R1AbilityNameLabel.Size = new System.Drawing.Size(80, 13);
            this.R1AbilityNameLabel.TabIndex = 25;
            this.R1AbilityNameLabel.Text = "Heroic 1 Ability:";
            // 
            // R2AbilityNameLabel
            // 
            this.R2AbilityNameLabel.AutoSize = true;
            this.R2AbilityNameLabel.Location = new System.Drawing.Point(429, 398);
            this.R2AbilityNameLabel.Name = "R2AbilityNameLabel";
            this.R2AbilityNameLabel.Size = new System.Drawing.Size(77, 13);
            this.R2AbilityNameLabel.TabIndex = 28;
            this.R2AbilityNameLabel.Text = "Heroic 2 Ability";
            // 
            // R3AbilityNameLabel
            // 
            this.R3AbilityNameLabel.AutoSize = true;
            this.R3AbilityNameLabel.Location = new System.Drawing.Point(429, 452);
            this.R3AbilityNameLabel.Name = "R3AbilityNameLabel";
            this.R3AbilityNameLabel.Size = new System.Drawing.Size(80, 13);
            this.R3AbilityNameLabel.TabIndex = 31;
            this.R3AbilityNameLabel.Text = "Heroic 3 Ability:";
            // 
            // TraitAbilityNameLabel
            // 
            this.TraitAbilityNameLabel.AutoSize = true;
            this.TraitAbilityNameLabel.Location = new System.Drawing.Point(429, 498);
            this.TraitAbilityNameLabel.Name = "TraitAbilityNameLabel";
            this.TraitAbilityNameLabel.Size = new System.Drawing.Size(61, 13);
            this.TraitAbilityNameLabel.TabIndex = 34;
            this.TraitAbilityNameLabel.Text = "Trait Ability:";
            // 
            // QDamageVarLabel
            // 
            this.QDamageVarLabel.AutoSize = true;
            this.QDamageVarLabel.Location = new System.Drawing.Point(533, 218);
            this.QDamageVarLabel.Name = "QDamageVarLabel";
            this.QDamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.QDamageVarLabel.TabIndex = 37;
            this.QDamageVarLabel.Text = "Damage";
            // 
            // WDamageVarLabel
            // 
            this.WDamageVarLabel.AutoSize = true;
            this.WDamageVarLabel.Location = new System.Drawing.Point(533, 259);
            this.WDamageVarLabel.Name = "WDamageVarLabel";
            this.WDamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.WDamageVarLabel.TabIndex = 38;
            this.WDamageVarLabel.Text = "Damage";
            // 
            // EDamageVarLabel
            // 
            this.EDamageVarLabel.AutoSize = true;
            this.EDamageVarLabel.Location = new System.Drawing.Point(533, 303);
            this.EDamageVarLabel.Name = "EDamageVarLabel";
            this.EDamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.EDamageVarLabel.TabIndex = 39;
            this.EDamageVarLabel.Text = "Damage";
            // 
            // R1DamageVarLabel
            // 
            this.R1DamageVarLabel.AutoSize = true;
            this.R1DamageVarLabel.Location = new System.Drawing.Point(535, 350);
            this.R1DamageVarLabel.Name = "R1DamageVarLabel";
            this.R1DamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.R1DamageVarLabel.TabIndex = 40;
            this.R1DamageVarLabel.Text = "Damage";
            // 
            // R2DamageVarLabel
            // 
            this.R2DamageVarLabel.AutoSize = true;
            this.R2DamageVarLabel.Location = new System.Drawing.Point(535, 398);
            this.R2DamageVarLabel.Name = "R2DamageVarLabel";
            this.R2DamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.R2DamageVarLabel.TabIndex = 41;
            this.R2DamageVarLabel.Text = "Damage";
            // 
            // R3DamageVarLabel
            // 
            this.R3DamageVarLabel.AutoSize = true;
            this.R3DamageVarLabel.Location = new System.Drawing.Point(535, 452);
            this.R3DamageVarLabel.Name = "R3DamageVarLabel";
            this.R3DamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.R3DamageVarLabel.TabIndex = 42;
            this.R3DamageVarLabel.Text = "Damage";
            // 
            // TraitDamageVarLabel
            // 
            this.TraitDamageVarLabel.AutoSize = true;
            this.TraitDamageVarLabel.Location = new System.Drawing.Point(535, 498);
            this.TraitDamageVarLabel.Name = "TraitDamageVarLabel";
            this.TraitDamageVarLabel.Size = new System.Drawing.Size(47, 13);
            this.TraitDamageVarLabel.TabIndex = 43;
            this.TraitDamageVarLabel.Text = "Damage";
            // 
            // QHealingVarLabel
            // 
            this.QHealingVarLabel.AutoSize = true;
            this.QHealingVarLabel.Location = new System.Drawing.Point(639, 218);
            this.QHealingVarLabel.Name = "QHealingVarLabel";
            this.QHealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.QHealingVarLabel.TabIndex = 44;
            this.QHealingVarLabel.Text = "Healing";
            // 
            // WHealingVarLabel
            // 
            this.WHealingVarLabel.AutoSize = true;
            this.WHealingVarLabel.Location = new System.Drawing.Point(639, 259);
            this.WHealingVarLabel.Name = "WHealingVarLabel";
            this.WHealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.WHealingVarLabel.TabIndex = 45;
            this.WHealingVarLabel.Text = "Healing";
            // 
            // EHealingVarLabel
            // 
            this.EHealingVarLabel.AutoSize = true;
            this.EHealingVarLabel.Location = new System.Drawing.Point(639, 303);
            this.EHealingVarLabel.Name = "EHealingVarLabel";
            this.EHealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.EHealingVarLabel.TabIndex = 46;
            this.EHealingVarLabel.Text = "Healing";
            // 
            // R1HealingVarLabel
            // 
            this.R1HealingVarLabel.AutoSize = true;
            this.R1HealingVarLabel.Location = new System.Drawing.Point(639, 350);
            this.R1HealingVarLabel.Name = "R1HealingVarLabel";
            this.R1HealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.R1HealingVarLabel.TabIndex = 47;
            this.R1HealingVarLabel.Text = "Healing";
            // 
            // R2HealingVarLabel
            // 
            this.R2HealingVarLabel.AutoSize = true;
            this.R2HealingVarLabel.Location = new System.Drawing.Point(639, 398);
            this.R2HealingVarLabel.Name = "R2HealingVarLabel";
            this.R2HealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.R2HealingVarLabel.TabIndex = 48;
            this.R2HealingVarLabel.Text = "Healing";
            // 
            // R3HealingVarLabel
            // 
            this.R3HealingVarLabel.AutoSize = true;
            this.R3HealingVarLabel.Location = new System.Drawing.Point(639, 452);
            this.R3HealingVarLabel.Name = "R3HealingVarLabel";
            this.R3HealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.R3HealingVarLabel.TabIndex = 49;
            this.R3HealingVarLabel.Text = "Healing";
            // 
            // TraitHealingVarLabel
            // 
            this.TraitHealingVarLabel.AutoSize = true;
            this.TraitHealingVarLabel.Location = new System.Drawing.Point(639, 498);
            this.TraitHealingVarLabel.Name = "TraitHealingVarLabel";
            this.TraitHealingVarLabel.Size = new System.Drawing.Size(43, 13);
            this.TraitHealingVarLabel.TabIndex = 50;
            this.TraitHealingVarLabel.Text = "Healing";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox16.Location = new System.Drawing.Point(613, 498);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(20, 20);
            this.pictureBox16.TabIndex = 36;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox15.Location = new System.Drawing.Point(507, 498);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 20);
            this.pictureBox15.TabIndex = 35;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox14.Location = new System.Drawing.Point(613, 452);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(20, 20);
            this.pictureBox14.TabIndex = 33;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox13.Location = new System.Drawing.Point(507, 452);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 20);
            this.pictureBox13.TabIndex = 32;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox12.Location = new System.Drawing.Point(613, 398);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.TabIndex = 30;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox11.Location = new System.Drawing.Point(507, 398);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox10.Location = new System.Drawing.Point(613, 350);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox9.Location = new System.Drawing.Point(507, 350);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox8.Location = new System.Drawing.Point(613, 303);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox7.Location = new System.Drawing.Point(507, 303);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox6.Location = new System.Drawing.Point(613, 259);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox5.Location = new System.Drawing.Point(507, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotsStatsApplication.Properties.Resources.Healing_Icon;
            this.pictureBox4.Location = new System.Drawing.Point(613, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotsStatsApplication.Properties.Resources.Damage_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(507, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // HeroPicture
            // 
            this.HeroPicture.Location = new System.Drawing.Point(323, 140);
            this.HeroPicture.Name = "HeroPicture";
            this.HeroPicture.Size = new System.Drawing.Size(100, 100);
            this.HeroPicture.TabIndex = 10;
            this.HeroPicture.TabStop = false;
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::HotsStatsApplication.Properties.Resources.temp_logo;
            this.LogoPicture.Location = new System.Drawing.Point(199, 27);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(300, 80);
            this.LogoPicture.TabIndex = 3;
            this.LogoPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 549);
            this.Controls.Add(this.TraitHealingVarLabel);
            this.Controls.Add(this.R3HealingVarLabel);
            this.Controls.Add(this.R2HealingVarLabel);
            this.Controls.Add(this.R1HealingVarLabel);
            this.Controls.Add(this.EHealingVarLabel);
            this.Controls.Add(this.WHealingVarLabel);
            this.Controls.Add(this.QHealingVarLabel);
            this.Controls.Add(this.TraitDamageVarLabel);
            this.Controls.Add(this.R3DamageVarLabel);
            this.Controls.Add(this.R2DamageVarLabel);
            this.Controls.Add(this.R1DamageVarLabel);
            this.Controls.Add(this.EDamageVarLabel);
            this.Controls.Add(this.WDamageVarLabel);
            this.Controls.Add(this.QDamageVarLabel);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.TraitAbilityNameLabel);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.R3AbilityNameLabel);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.R2AbilityNameLabel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.R1AbilityNameLabel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.EAbilityNameLabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.WAbilityNameLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.QAbilityNameLabel);
            this.Controls.Add(this.ManaVarLabel);
            this.Controls.Add(this.ManaLabel);
            this.Controls.Add(this.HealthVarLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.HeroTitleLabel);
            this.Controls.Add(this.HeroPicture);
            this.Controls.Add(this.HeroNameLabel);
            this.Controls.Add(this.SpellPowerComboBox);
            this.Controls.Add(this.SpellPowerModifierLabel);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.HeroSelectLabel);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.HeroComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Heroes of the Storm Stats Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ComboBox HeroComboBox;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.Label HeroSelectLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Label SpellPowerModifierLabel;
        private System.Windows.Forms.ComboBox SpellPowerComboBox;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label HeroTitleLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label HealthVarLabel;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.Label ManaVarLabel;
        private System.Windows.Forms.Label QAbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label WAbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label EAbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label R1AbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label R2AbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label R3AbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label TraitAbilityNameLabel;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label QDamageVarLabel;
        private System.Windows.Forms.Label WDamageVarLabel;
        private System.Windows.Forms.Label EDamageVarLabel;
        private System.Windows.Forms.Label R1DamageVarLabel;
        private System.Windows.Forms.Label R2DamageVarLabel;
        private System.Windows.Forms.Label R3DamageVarLabel;
        private System.Windows.Forms.Label TraitDamageVarLabel;
        private System.Windows.Forms.Label QHealingVarLabel;
        private System.Windows.Forms.Label WHealingVarLabel;
        private System.Windows.Forms.Label EHealingVarLabel;
        private System.Windows.Forms.Label R1HealingVarLabel;
        private System.Windows.Forms.Label R2HealingVarLabel;
        private System.Windows.Forms.Label R3HealingVarLabel;
        private System.Windows.Forms.Label TraitHealingVarLabel;
        public System.Windows.Forms.PictureBox HeroPicture;
    }
}

