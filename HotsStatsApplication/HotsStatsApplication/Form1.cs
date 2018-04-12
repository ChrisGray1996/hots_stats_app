using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace HotsStatsApplication
{
    public partial class Form1 : Form
    {
        



        
        
        
        




        Hero Auriel = new Hero("Auriel", "Archangel of Hope", "Sacred Sweep", "Ray of Heaven", "Detainment Strike", "Crystal Aegis", "Resurrect", "N/A", "Bestow Hope", 1758, 525, 57, 0, 0, 525,
            165, 0, 270, 0, 0, 0, 0, 0, 0, 0, Properties.Resources.Auriel_Mastery_Portrait);

        Hero Dehaka = new Hero("Dehaka", "Primal Pack Leader", "Drag", "Dark Swarm", "Burrow", "Isolation", "Adaptation", "N/A", "Brushtalker", 2532, 500, 160, 0, 47, 0, 0, 0, 200, 0, 0, 2532,
            0, 0, 0, 29, Properties.Resources.Dehaka_Mastery_Portrait);

        Hero Kaelthas = new Hero("Kael'thas", "The Sun King", "Flamestrike", "Living Bomb", "Gravity Lapse", "Pyroblast", "Phoenix", "N/A", "Verdant Spheres", 1520, 500, 320, 0, 200, 0, 0, 0, 810, 0, 78, 0,
            0, 0, 0, 0, Properties.Resources.Kaelthas_Mastery_Portrait);


        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HeroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateScreenInfo();
        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreenInfo();
        }

        private void SpellPowerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreenInfo();
        }


        private void UpdateScreenInfo()
        {
            String text = this.HeroComboBox.Text.ToString();
            this.HeroNameLabel.Text = text;

            double Health;
            double Mana;
            double Q_damage;
            double Q_damage_total;
            double Q_healing; ;
            double Q_healing_total;
            double W_damage;
            double W_damage_total;
            double W_healing;
            double W_healing_total;
            double E_damage;
            double E_damage_total;
            double E_healing;
            double E_healing_total;
            double R1_damage;
            double R1_damage_total;
            double R1_healing;
            double R1_healing_total;
            double R2_damage;
            double R2_damage_total;
            double R2_healing;
            double R2_healing_total;
            double R3_damage;
            double R3_damage_total;
            double R3_healing;
            double R3_healing_total;
            double trait_damage;
            double trait_damage_total;
            double trait_healing;
            double trait_healing_total;
            int hero_level;
            int spell_power_value;
            double spell_power_multiplier;
            Hero hero_name;


            switch (text)
            {
                case "Auriel":
                    {
                        hero_name = Auriel;
                        break;
                    }
                case "Dehaka":
                    {
                        hero_name = Dehaka;
                        break;
                    }
                case "Kael'thas":
                    {
                        hero_name = Kaelthas;
                        break;
                    }
                default:
                    hero_name = Auriel;
                    break;
            }


            try
            {
                hero_level = Int32.Parse(LevelComboBox.Text.ToString());
            }
            catch (FormatException error)
            {
                hero_level = 1;
            }
            try
            {
                spell_power_value = Int32.Parse(SpellPowerComboBox.Text.ToString());
            }
            catch (FormatException error)
            {
               spell_power_value = 0;
            }


            switch(spell_power_value)
            {
                case -50:
                    {
                        spell_power_multiplier = 0.50;
                        break;
                    }
                case -40:
                    {
                        spell_power_multiplier = 0.60;
                        break;
                    }
                case -35:
                    {
                        spell_power_multiplier = 0.65;
                        break;
                    }
                case -25:
                    {
                        spell_power_multiplier = 0.75;
                        break;
                    }
                case -20:
                    {
                        spell_power_multiplier = 0.80;
                        break;
                    }
                case -15:
                    {
                        spell_power_multiplier = 0.85;
                        break;
                    }
                case 0:
                    {
                        spell_power_multiplier = 1.00;
                        break;
                    }
                case 4:
                    {
                        spell_power_multiplier = 1.04;
                        break;
                    }
                case 5:
                    {
                        spell_power_multiplier = 1.05;
                        break;
                    }
                case 10:
                    {
                        spell_power_multiplier = 1.10;
                        break;
                    }
                case 15:
                    {
                        spell_power_multiplier = 1.15;
                        break;
                    }
                case 20:
                    {
                        spell_power_multiplier = 1.20;
                        break;
                    }
                case 25:
                    {
                        spell_power_multiplier = 1.25;
                        break;
                    }
                case 30:
                    {
                        spell_power_multiplier = 1.30;
                        break;
                    }
                case 35:
                    {
                        spell_power_multiplier = 1.35;
                        break;
                    }
                case 40:
                    {
                        spell_power_multiplier = 1.40;
                        break;
                    }
                case 45:
                    {
                        spell_power_multiplier = 1.45;
                        break;
                    }
                case 50:
                    {
                        spell_power_multiplier = 1.50;
                        break;
                    }
                case 55:
                    {
                        spell_power_multiplier = 1.55;
                        break;
                    }
                case 60:
                    {
                        spell_power_multiplier = 1.60;
                        break;
                    }
                case 65:
                    {
                        spell_power_multiplier = 1.65;
                        break;
                    }
                case 70:
                    {
                        spell_power_multiplier = 1.70;
                        break;
                    }
                case 75:
                    {
                        spell_power_multiplier = 1.75;
                        break;
                    }
                case 80:
                    {
                        spell_power_multiplier = 1.80;
                        break;
                    }
                case 85:
                    {
                        spell_power_multiplier = 1.85;
                        break;
                    }
                case 90:
                    {
                        spell_power_multiplier = 1.90;
                        break;
                    }
                case 95:
                    {
                        spell_power_multiplier = 1.95;
                        break;
                    }
                case 100:
                    {
                        spell_power_multiplier = 2.00;
                        break;
                    }
                default:
                        spell_power_multiplier = 1.00;
                        break;
            }
            Health = hero_name.Health;
            Mana = hero_name.Mana;
            Q_damage = hero_name.QDamage;
            Q_healing = hero_name.QHealing;
            W_damage = hero_name.WDamage;
            W_healing = hero_name.WHealing;
            E_damage = hero_name.EDamage;
            E_healing = hero_name.EHealing;
            R1_damage = hero_name.R1Damage;
            R1_healing = hero_name.R1Healing;
            R2_damage = hero_name.R2Damage;
            R2_healing = hero_name.R2Healing;
            R3_damage = hero_name.R3Damage;
            R3_healing = hero_name.R3Healing;
            trait_damage = hero_name.TraitDamage;
            trait_healing = hero_name.TraitHealing;


            for (int i = 0; i < hero_level; i++)
                {
                Health += (Health * 0.04);
                Mana += (Mana * 0.04);
                Q_damage += (Q_damage * 0.04);
                Q_healing += (Q_healing * 0.04);
                W_damage += (W_damage * 0.04);
                W_healing += (W_healing * 0.04);
                E_damage += (E_damage * 0.04);
                E_healing += (E_healing * 0.04);
                R1_damage += (R1_damage * 0.04);
                R1_healing += (R1_healing * 0.04);
                R2_damage += (R2_damage * 0.04);
                R2_healing += (R2_healing * 0.04);
                R3_damage += (R3_damage * 0.04);
                R3_healing += (R3_healing * 0.04);
                trait_damage += (trait_damage * 0.04);
                trait_healing += (trait_healing * 0.04); 
            }
            Health = (int)Math.Round(Health);
            Mana = (int)Math.Round(Mana);
            Q_damage_total = (int)Math.Round(Q_damage * spell_power_multiplier);
            Q_healing_total = (int)Math.Round(Q_healing * spell_power_multiplier);
            W_damage_total = (int)Math.Round(W_damage * spell_power_multiplier);
            W_healing_total = (int)Math.Round(W_healing * spell_power_multiplier);
            E_damage_total = (int)Math.Round(E_damage * spell_power_multiplier);
            E_healing_total = (int)Math.Round(E_healing * spell_power_multiplier);
            R1_damage_total = (int)Math.Round(R1_damage * spell_power_multiplier);
            R1_healing_total = (int)Math.Round(R1_healing * spell_power_multiplier);
            R2_damage_total = (int)Math.Round(R2_damage * spell_power_multiplier);
            R2_healing_total = (int)Math.Round(R2_healing * spell_power_multiplier);
            R3_damage_total = (int)Math.Round(R3_damage * spell_power_multiplier);
            R3_healing_total = (int)Math.Round(R3_healing * spell_power_multiplier);
            trait_damage_total = (int)Math.Round(trait_damage * spell_power_multiplier);
            trait_healing_total = (int)Math.Round(trait_healing * spell_power_multiplier);


            this.HeroPicture.Image = hero_name.HeroImage;
                this.HeroNameLabel.Text = hero_name.HeroName;
                this.HeroTitleLabel.Text = hero_name.HeroTitle;
                this.HealthVarLabel.Text = Health.ToString();
                this.ManaVarLabel.Text = Mana.ToString();
                this.QAbilityNameLabel.Text = hero_name.QAbilityName;
                this.WAbilityNameLabel.Text = hero_name.WAbilityName;
                this.EAbilityNameLabel.Text = hero_name.EAbilityName;
                this.R1AbilityNameLabel.Text = hero_name.R1AbilityName;
                this.R2AbilityNameLabel.Text = hero_name.R2AbilityName;
                this.R3AbilityNameLabel.Text = hero_name.R3AbilityName;
                this.TraitAbilityNameLabel.Text = hero_name.TraitAbilityName;
                this.QDamageVarLabel.Text = Q_damage_total.ToString();
                this.WDamageVarLabel.Text = W_damage_total.ToString();
                this.EDamageVarLabel.Text = E_damage_total.ToString();
                this.R1DamageVarLabel.Text = R1_damage_total.ToString();
                this.R2DamageVarLabel.Text = R2_damage_total.ToString();
                this.R3DamageVarLabel.Text = R3_damage_total.ToString();
                this.TraitDamageVarLabel.Text = trait_damage_total.ToString();
                this.QHealingVarLabel.Text = Q_healing_total.ToString();
                this.WHealingVarLabel.Text = W_healing_total.ToString();
                this.EHealingVarLabel.Text = E_healing_total.ToString();
                this.R1HealingVarLabel.Text = R1_healing_total.ToString();
                this.R2HealingVarLabel.Text = R2_healing_total.ToString();
                this.R3HealingVarLabel.Text = R3_healing_total.ToString();
                this.TraitHealingVarLabel.Text = trait_healing_total.ToString();
            

        }

       
    }
}
