using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superheltene
{
    internal class Superhero
    {
        private string secretName;
        /// <summary>
        /// The secret identity of the superhero.
        /// </summary>
        public string SecretName
        {
            get { return secretName; }
            private set { secretName = value; }
        }

        private string[] powers;
        /// <summary>
        /// A list of powers known to the super hero.
        /// </summary>
        public string[] Powers
        {
            get { return powers; }
            private set { powers = value; }
        }

        /// <summary>
        /// The heros costume.
        /// </summary>
        private Costume costume;
        public Costume Costume
        {
            get { return costume; }
            private set
            {
                costume = value;
            }
        }

        // "En ensom kamp mod kriminalitet (selvom forlagene har slået nogle af superheltene sammen i konstellationer, som f.eks. Justice League"
        // I've interpreted this as a string denoting which team a super hero might be affiliated with, which, in the case of a lone crimefighter
        // would simply be his own name.
        private string team;
        /// <summary>
        /// The team that a superhero is affiliated with.
        /// </summary>
        public string Team
        {
            get { return team; }
            private set
            {
                team = value;
            }
        }

        private string moralCode;
        /// <summary>
        /// A string describing the superhero's moral code.
        /// </summary>
        public string MoralCode
        {
            get { return moralCode; }
            private set
            {
                moralCode = value;
            }
        }

        private Villain[] enemies;
        /// <summary>
        /// A list of enemies this superhero is known to have.
        /// </summary>
        public Villain[] Enemies
        {
            get { return enemies; }
            private set { enemies = value; }
        }

        private string privateProblems;
        /// <summary>
        /// A description of the private problems a hero faces outside
        /// of his superhero work.
        /// </summary>
        public string PrivateProblems
        {
            get { return privateProblems; }
            private set { privateProblems = value; }
        }

        /// <summary>
        /// Constructor for hero that doesn't already have a named team, i.e. a lone crimefighter.
        /// </summary>
        public Superhero(string secretName, string[] powers, Costume costume, string moralCode, Villain[] enemies, string privateProblems)
        {
            SecretName = secretName;
            Powers = powers;
            Costume = costume;
            Team = team;
            MoralCode = moralCode;
            Enemies = enemies;
            PrivateProblems = privateProblems;
            Team = SecretName; // Hero is only affiliated with himself.
        }

        /// <summary>
        /// Constructor for superhero that is already a part of a known team.
        /// </summary>
        public Superhero(string secretName, string[] powers, Costume costume, string team, string moralCode, Villain[] enemies, string privateProblems)
        {
            SecretName = secretName;
            Powers = powers;
            Costume = costume;
            Team = team;
            MoralCode = moralCode;
            Enemies = enemies;
            PrivateProblems = privateProblems;
        }

        /// <summary>
        /// The hero introduces himself using his secret identity.
        /// </summary>
        /// <returns>A string with the introduction.</returns>
        public string MakeIntro()
        {
            return SecretName + " is here to save the day!";
        }

        /// <summary>
        /// Attempt to use a power.
        /// </summary>
        public string UsePower(string power)
        {
            // Check if hero knows this power
            if (Powers.Contains(power))
            {
                // if he does, use it.
                return SecretName + " used " + power;
            }

            // Power doesn't exist on this hero.
            return SecretName + " doesn't know " + power;
        }

        /// <returns>A description of the heros current costume.</returns>
        public string DescribeCostume()
        {
            return SecretName + "'s costume is:\n" + Costume.Description;
        }

        /// <summary>
        /// Change the heros currently affiliated team.
        /// </summary>
        public void ChangeTeam(string newTeam)
        {
            Team = newTeam;
        }
    }
}
