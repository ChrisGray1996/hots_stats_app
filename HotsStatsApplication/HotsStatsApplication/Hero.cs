using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HotsStatsApplication
{
    class Hero
    {
        public string HeroName, HeroTitle, QAbilityName, WAbilityName, EAbilityName, R1AbilityName, R2AbilityName, R3AbilityName, TraitAbilityName;
            
        public int Health, Mana, QDamage, QHealing, WDamage, WHealing, EDamage, EHealing, R1Damage, R1Healing, R2Damage, R2Healing, R3Damage, R3Healing, TraitDamage, TraitHealing;

        public Image HeroImage;

        public Hero(string heroName, string heroTitle, string qAbilityName, string wAbilityName, string eAbilityName, string r1AbilityName, string r2AbilityName,
            string r3AbilityName, string traitAbilityName, int health, int mana, int qDamage, int qHealing, int wDamage, int wHealing, int eDamage, int eHealing,
            int r1Damage, int r1Healing, int r2Damage, int r2Healing, int r3Damage, int r3Healing, int traitDamage, int traitHealing, Image heroImage)
        {
            HeroName = heroName;
            HeroTitle = heroTitle;
            QAbilityName = qAbilityName;
            WAbilityName = wAbilityName;
            EAbilityName = eAbilityName;
            R1AbilityName = r1AbilityName;
            R2AbilityName = r2AbilityName;
            R3AbilityName = r3AbilityName;
            TraitAbilityName = traitAbilityName;
            Health = health;
            Mana = mana;
            QDamage = qDamage;
            QHealing = qHealing;
            WDamage = wDamage;
            WHealing = wHealing;
            EDamage = eDamage;
            EHealing = eHealing;
            R1Damage = r1Damage;
            R1Healing = r1Healing;
            R2Damage = r2Damage;
            R2Healing = r2Healing;
            R3Damage = r3Damage;
            R3Healing = r3Healing;
            TraitDamage = traitDamage;
            TraitHealing = traitHealing;
            HeroImage = heroImage;

            
        }


        
    }
}
