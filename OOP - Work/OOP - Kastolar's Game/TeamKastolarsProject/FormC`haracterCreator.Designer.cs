using System.Windows.Forms;

namespace TeamKastolarsProject
{
    partial class FormC_haracterCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormC_haracterCreator));
            this.Lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rdb_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Cbo_CharacterClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharacterClass = new System.Windows.Forms.Label();
            this.Btn_SaveCharacter = new System.Windows.Forms.Button();
            this.Gbox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            this.Lbl_CharacterName.AutoSize = true;
            this.Lbl_CharacterName.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CharacterName.Font = new System.Drawing.Font("Motorwerk", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharacterName.ForeColor = System.Drawing.Color.DarkGray;
            this.Lbl_CharacterName.Location = new System.Drawing.Point(12, 9);
            this.Lbl_CharacterName.Name = "Lbl_CharacterName";
            this.Lbl_CharacterName.Size = new System.Drawing.Size(177, 16);
            this.Lbl_CharacterName.TabIndex = 0;
            this.Lbl_CharacterName.Text = "Character Name";
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(195, 8);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(133, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Gender.Controls.Add(this.Rdb_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Gbox_Gender.Font = new System.Drawing.Font("Motorwerk", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbox_Gender.ForeColor = System.Drawing.Color.DarkGray;
            this.Gbox_Gender.Location = new System.Drawing.Point(12, 41);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(316, 96);
            this.Gbox_Gender.TabIndex = 2;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Choose gender";
            // 
            // Rdb_GenderFemale
            // 
            this.Rdb_GenderFemale.AutoSize = true;
            this.Rdb_GenderFemale.Font = new System.Drawing.Font("Motorwerk", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_GenderFemale.Location = new System.Drawing.Point(7, 61);
            this.Rdb_GenderFemale.Name = "Rdb_GenderFemale";
            this.Rdb_GenderFemale.Size = new System.Drawing.Size(99, 20);
            this.Rdb_GenderFemale.TabIndex = 1;
            this.Rdb_GenderFemale.TabStop = true;
            this.Rdb_GenderFemale.Text = "Female";
            this.Rdb_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Font = new System.Drawing.Font("Motorwerk", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdo_GenderMale.Location = new System.Drawing.Point(6, 25);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(78, 20);
            this.Rdo_GenderMale.TabIndex = 0;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharacterClass
            // 
            this.Cbo_CharacterClass.BackColor = System.Drawing.Color.White;
            this.Cbo_CharacterClass.Font = new System.Drawing.Font("Motorwerk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_CharacterClass.ForeColor = System.Drawing.Color.Maroon;
            this.Cbo_CharacterClass.FormattingEnabled = true;
            this.Cbo_CharacterClass.Items.AddRange(new object[] {
            "Mage",
            "Paladin",
            "Rogue",
            "Druid",
            "Warrior"});
            this.Cbo_CharacterClass.Location = new System.Drawing.Point(109, 194);
            this.Cbo_CharacterClass.Name = "Cbo_CharacterClass";
            this.Cbo_CharacterClass.Size = new System.Drawing.Size(121, 16);
            this.Cbo_CharacterClass.TabIndex = 3;
            this.Cbo_CharacterClass.SelectedIndexChanged += new System.EventHandler(this.Cbo_CharacterClass_SelectedIndexChanged);
            // 
            // Lbl_CharacterClass
            // 
            this.Lbl_CharacterClass.AutoSize = true;
            this.Lbl_CharacterClass.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CharacterClass.Font = new System.Drawing.Font("Motorwerk", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharacterClass.ForeColor = System.Drawing.Color.DarkGray;
            this.Lbl_CharacterClass.Location = new System.Drawing.Point(67, 160);
            this.Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            this.Lbl_CharacterClass.Size = new System.Drawing.Size(202, 16);
            this.Lbl_CharacterClass.TabIndex = 4;
            this.Lbl_CharacterClass.Text = "Choose your Class";
            // 
            // Btn_SaveCharacter
            // 
            this.Btn_SaveCharacter.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SaveCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SaveCharacter.BackgroundImage")));
            this.Btn_SaveCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SaveCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_SaveCharacter.Font = new System.Drawing.Font("Motorwerk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveCharacter.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_SaveCharacter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SaveCharacter.Location = new System.Drawing.Point(109, 233);
            this.Btn_SaveCharacter.Name = "Btn_SaveCharacter";
            this.Btn_SaveCharacter.Size = new System.Drawing.Size(121, 45);
            this.Btn_SaveCharacter.TabIndex = 5;
            this.Btn_SaveCharacter.Text = "Save Character";
            this.Btn_SaveCharacter.UseVisualStyleBackColor = false;
            this.Btn_SaveCharacter.Click += new System.EventHandler(this.Btn_SaveCharacter_Click);
            // 
            // FormC_haracterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(340, 290);
            this.Controls.Add(this.Btn_SaveCharacter);
            this.Controls.Add(this.Lbl_CharacterClass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_CharacterName);
            this.Controls.Add(this.Cbo_CharacterClass);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormC_haracterCreator";
            this.Text = "Create Your Character";
            this.Load += new System.EventHandler(this.FormC_haracterCreator_Load);
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.ComboBox Cbo_CharacterClass;
        private System.Windows.Forms.Label Lbl_CharacterClass;
        private System.Windows.Forms.RadioButton Rdb_GenderFemale;
        private System.Windows.Forms.Button Btn_SaveCharacter;
    }
}