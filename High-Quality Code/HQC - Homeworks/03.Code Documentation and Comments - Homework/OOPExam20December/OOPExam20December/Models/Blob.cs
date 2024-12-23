namespace OOPExam20December.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public class Blob : IBlob
    {
        #region Constants

        //private const int MinimalHealth = 0;
        private const int MinimalDamage = 0;

        #endregion


        #region Fields

        private string name;
        private int health;
        private int damage;
        private string behavior;
        private string attack;

        #endregion


        #region Constructor

        public Blob(string name, int health, int damage, string behavior, string attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;
        }


        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid blob name!\nName cannot be bull.");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            private set { this.health = value; }
        }

        public int Damage 
        {
            get { return this.damage; }
            private set
            {
                if (value <= MinimalDamage)
                {
                    throw new ArgumentOutOfRangeException("damage", "Damage cannot be negative");
                }
                this.damage = value;
            }
        }

        public string Behavior
        {
            get { return this.behavior; }
            private set { this.behavior = value; }
        }

        public string Attack
        {
            get { return this.attack; }
            private set { this.attack = value; }
        }

        #endregion

        /// <summary>
        /// Behavior of a Blob.
        /// </summary>
        public void AggresiveBehaviorImplementation()
        {
            int aggresiveDamage = this.Damage * 2;

        }

        /// <summary>
        /// Behavior of a Blob.
        /// </summary>
        public void InflatedBehaviorImplementation()
        {
            int inflatedHealth = this.Health + 50;
        }

        /// <summary>
        /// Attack that a single Blob can produce.
        /// </summary>
        /// <param name="enemyName"></param>
        public void PutridFartAttackImplementation(string enemyName)
        {
            //TODO: Implement Attack
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attack that a single Blob can produce.
        /// </summary>
        /// <param name="enemyName"></param>
        public void BlobplodeAttackImplementation(string enemyName)
        {
            throw new NotImplementedException();
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("{0}: {1} HP, {2} Damage{3}", this.Name,this.Health, 
                this.Damage, Environment.NewLine);

            var sbToString = sb.ToString();
            return sbToString;
        }
    }
}
