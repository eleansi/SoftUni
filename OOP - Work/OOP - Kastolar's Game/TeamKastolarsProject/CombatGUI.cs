using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamKastolarsProject
{
    public partial class CombatGUI : Form
    {
        List<CombatPartyMember> playerPartyMembers;
        CombatPartyMember enemyMember;
        int currentPartyMember = 0;
        public bool inCombat;
        //
        public bool playerTurn;
        List<ActiveSkill> activeSkills = new List<ActiveSkill>();
 
        public CombatGUI()
        {
            InitializeComponent();
            playerPartyMembers = new List<CombatPartyMember>();
 
            inCombat = false;
            //
            playerTurn = true;
            enemyAttackTimer.Interval = 1000;
        }
 
       
        public void StartCombat(PlayerParty playerParty, CombatPartyMember enemy)
        {
            enemyMember = enemy;
            playerPartyMembers.Add(playerParty.member1);
            inCombat = true;
 
            PartyPB1.Image = new Bitmap("pala.png");
            EnemyPB1.Image = new Bitmap("LichKing.png");
            LoadSkillsForPlayer();
        }
       
        void OutputFlavourText(string text)
        {
            flavourTextBox.AppendText("\n" + text);
        }
 
        void LoadSkillsForPlayer()
        {
            cmbSkill.Items.Clear();
 
            foreach (Skill s in playerPartyMembers[currentPartyMember].skills)
            {
                cmbSkill.Items.Add(s.name);
            }
        }
 
        void ApplySkillDamage()
        {
            for (int x = 0; x < activeSkills.Count; x++)
            {
                var a = activeSkills[x];
                a.target.health -= a.skill.damagePerTurn;
                a.remainingTurns--;
 
                OutputFlavourText(a.skill.name + " did " + a.skill.damagePerTurn + " damage!");
 
                if (a.remainingTurns == 0)
                    activeSkills.RemoveAt(x);
            }
        }

        private void Btn_Attack_Click(object sender, EventArgs e)
        {
            ApplySkillDamage();
 
            if (inCombat)
            {
                //
                if (playerTurn)
                {
                    LoadSkillsForPlayer();
 
                    if (partyActionAttack.Checked)
                    {
                        //Damage done will vary
                        int damage = playerPartyMembers[currentPartyMember].attackPower;
 
                        OutputFlavourText("You hit " + damage + " damage with your sword!");
 
                        enemyMember.health -= damage;
                    }
 
                    if (partyActionSkill.Checked)
                    {
                        //get skill which matches skill in box
                        foreach (Skill s in playerPartyMembers[currentPartyMember].skills)
                        {
                            if (s.name == cmbSkill.Text)
                            {
                                ActiveSkill a = new ActiveSkill();
                                a.skill = s;
                                a.target = enemyMember;
                                a.remainingTurns = s.duration;
                                activeSkills.Add(a);
 
                                enemyMember.health -= s.initialDamage;
                                OutputFlavourText("Cast " + s.name + " for " + s.initialDamage);
                            }
                        }
                    }
 
                    if (currentPartyMember >= playerPartyMembers.Count)
                    {
                        currentPartyMember++;
                    }
                    else
                    {
                        currentPartyMember = 0;
                        playerTurn = false;
                        enemyAttackTimer.Enabled = true;
                    }
                }
 
                //Exit battle if enemy is dead
                if (enemyMember.health == 0)
                {
                    flavourTextBox.AppendText("\n" + "Enemy defeated!");
                    inCombat = false;
                    
                }
            }
        }

        private void enemyAttackTimer_Tick(object sender, EventArgs e)
        {
            //Target a random player
            Random rand = new Random();
            int x = rand.Next(0, playerPartyMembers.Count);
            //Damage player
            playerPartyMembers[x].health -= enemyMember.attackPower;
            OutputFlavourText("Player was hit for " + enemyMember.attackPower + " damage!");

            //Check if all players are still alive
            inCombat = false;
            foreach (CombatPartyMember c in playerPartyMembers)
            {
                if (c.health >= 0)
                {
                    inCombat = true;
                }
            }

            enemyAttackTimer.Enabled = false;

            if (inCombat == false)
            {
                OutputFlavourText("Player party defeated!");
                //do something
            }
            else
            {
                playerTurn = true;
            }
        }

        private void PartyPB1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
