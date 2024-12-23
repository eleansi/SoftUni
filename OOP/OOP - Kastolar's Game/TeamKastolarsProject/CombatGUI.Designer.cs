namespace TeamKastolarsProject
{
    partial class CombatGUI
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
            this.components = new System.ComponentModel.Container();
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.enemyAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.partyActionAttack = new System.Windows.Forms.RadioButton();
            this.partyActionSkill = new System.Windows.Forms.RadioButton();
            this.flavourTextBox = new System.Windows.Forms.RichTextBox();
            this.Btn_defend = new System.Windows.Forms.RadioButton();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.PartyPB1 = new System.Windows.Forms.PictureBox();
            this.EnemyPB1 = new System.Windows.Forms.PictureBox();
            this.lbl_versus = new System.Windows.Forms.Label();
            this.PartyPB2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Attack.Location = new System.Drawing.Point(129, 347);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(571, 52);
            this.Btn_Attack.TabIndex = 0;
            this.Btn_Attack.Text = "Attack";
            this.Btn_Attack.UseVisualStyleBackColor = true;
            this.Btn_Attack.Click += new System.EventHandler(this.Btn_Attack_Click);
            // 
            // enemyAttackTimer
            // 
            this.enemyAttackTimer.Tick += new System.EventHandler(this.enemyAttackTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abilities";
            // 
            // partyActionAttack
            // 
            this.partyActionAttack.AutoSize = true;
            this.partyActionAttack.Location = new System.Drawing.Point(12, 266);
            this.partyActionAttack.Name = "partyActionAttack";
            this.partyActionAttack.Size = new System.Drawing.Size(56, 17);
            this.partyActionAttack.TabIndex = 3;
            this.partyActionAttack.TabStop = true;
            this.partyActionAttack.Text = "Attack";
            this.partyActionAttack.UseVisualStyleBackColor = true;
            // 
            // partyActionSkill
            // 
            this.partyActionSkill.AutoSize = true;
            this.partyActionSkill.Location = new System.Drawing.Point(12, 312);
            this.partyActionSkill.Name = "partyActionSkill";
            this.partyActionSkill.Size = new System.Drawing.Size(44, 17);
            this.partyActionSkill.TabIndex = 4;
            this.partyActionSkill.TabStop = true;
            this.partyActionSkill.Text = "Skill";
            this.partyActionSkill.UseVisualStyleBackColor = true;
            // 
            // flavourTextBox
            // 
            this.flavourTextBox.Location = new System.Drawing.Point(129, 249);
            this.flavourTextBox.Name = "flavourTextBox";
            this.flavourTextBox.Size = new System.Drawing.Size(571, 80);
            this.flavourTextBox.TabIndex = 5;
            this.flavourTextBox.Text = "";
            // 
            // Btn_defend
            // 
            this.Btn_defend.AutoSize = true;
            this.Btn_defend.Location = new System.Drawing.Point(12, 289);
            this.Btn_defend.Name = "Btn_defend";
            this.Btn_defend.Size = new System.Drawing.Size(60, 17);
            this.Btn_defend.TabIndex = 6;
            this.Btn_defend.TabStop = true;
            this.Btn_defend.Text = "Defend";
            this.Btn_defend.UseVisualStyleBackColor = true;
            // 
            // cmbSkill
            // 
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(2, 335);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(107, 21);
            this.cmbSkill.TabIndex = 7;
            // 
            // PartyPB1
            // 
            this.PartyPB1.Location = new System.Drawing.Point(177, 53);
            this.PartyPB1.Name = "PartyPB1";
            this.PartyPB1.Size = new System.Drawing.Size(150, 150);
            this.PartyPB1.TabIndex = 8;
            this.PartyPB1.TabStop = false;
            this.PartyPB1.Click += new System.EventHandler(this.PartyPB1_Click);
            // 
            // EnemyPB1
            // 
            this.EnemyPB1.Location = new System.Drawing.Point(513, 53);
            this.EnemyPB1.Name = "EnemyPB1";
            this.EnemyPB1.Size = new System.Drawing.Size(150, 150);
            this.EnemyPB1.TabIndex = 9;
            this.EnemyPB1.TabStop = false;
            // 
            // lbl_versus
            // 
            this.lbl_versus.AutoSize = true;
            this.lbl_versus.Font = new System.Drawing.Font("Motorwerk", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versus.Location = new System.Drawing.Point(395, 110);
            this.lbl_versus.Name = "lbl_versus";
            this.lbl_versus.Size = new System.Drawing.Size(39, 22);
            this.lbl_versus.TabIndex = 10;
            this.lbl_versus.Text = "VS\r\n";
            // 
            // PartyPB2
            // 
            this.PartyPB2.Location = new System.Drawing.Point(13, 53);
            this.PartyPB2.Name = "PartyPB2";
            this.PartyPB2.Size = new System.Drawing.Size(158, 150);
            this.PartyPB2.TabIndex = 11;
            this.PartyPB2.TabStop = false;
            // 
            // CombatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 411);
            this.Controls.Add(this.PartyPB2);
            this.Controls.Add(this.lbl_versus);
            this.Controls.Add(this.EnemyPB1);
            this.Controls.Add(this.PartyPB1);
            this.Controls.Add(this.cmbSkill);
            this.Controls.Add(this.Btn_defend);
            this.Controls.Add(this.flavourTextBox);
            this.Controls.Add(this.partyActionSkill);
            this.Controls.Add(this.partyActionAttack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Attack);
            this.Name = "CombatGUI";
            this.Text = "CombatGUI";
            //this.Load += new System.EventHandler(this.CombatGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartyPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Attack;
        private System.Windows.Forms.Timer enemyAttackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton partyActionAttack;
        private System.Windows.Forms.RadioButton partyActionSkill;
        private System.Windows.Forms.RichTextBox flavourTextBox;
        private System.Windows.Forms.RadioButton Btn_defend;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.PictureBox PartyPB1;
        private System.Windows.Forms.PictureBox EnemyPB1;
        private System.Windows.Forms.Label lbl_versus;
        private System.Windows.Forms.PictureBox PartyPB2;
    }
}