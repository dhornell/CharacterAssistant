namespace Dnd_4e_Character_Assistant
{
    partial class CharacterView
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.levelNud = new System.Windows.Forms.NumericUpDown();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chaNud = new System.Windows.Forms.NumericUpDown();
            this.wisNud = new System.Windows.Forms.NumericUpDown();
            this.intNud = new System.Windows.Forms.NumericUpDown();
            this.conNud = new System.Windows.Forms.NumericUpDown();
            this.dexNud = new System.Windows.Forms.NumericUpDown();
            this.strNud = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.willLbl = new System.Windows.Forms.Label();
            this.fortLbl = new System.Windows.Forms.Label();
            this.refLbl = new System.Windows.Forms.Label();
            this.acLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strNud)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.levelNud);
            this.groupBox1.Controls.Add(this.raceBox);
            this.groupBox1.Controls.Add(this.classBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // levelNud
            // 
            this.levelNud.Location = new System.Drawing.Point(49, 68);
            this.levelNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelNud.Name = "levelNud";
            this.levelNud.Size = new System.Drawing.Size(54, 20);
            this.levelNud.TabIndex = 7;
            this.levelNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // raceBox
            // 
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Location = new System.Drawing.Point(48, 13);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(126, 21);
            this.raceBox.TabIndex = 4;
            this.raceBox.SelectedValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(48, 40);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(126, 21);
            this.classBox.TabIndex = 3;
            this.classBox.SelectedValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chaNud);
            this.groupBox2.Controls.Add(this.wisNud);
            this.groupBox2.Controls.Add(this.intNud);
            this.groupBox2.Controls.Add(this.conNud);
            this.groupBox2.Controls.Add(this.dexNud);
            this.groupBox2.Controls.Add(this.strNud);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attributes";
            // 
            // chaNud
            // 
            this.chaNud.Location = new System.Drawing.Point(81, 144);
            this.chaNud.Name = "chaNud";
            this.chaNud.Size = new System.Drawing.Size(54, 20);
            this.chaNud.TabIndex = 11;
            this.chaNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // wisNud
            // 
            this.wisNud.Location = new System.Drawing.Point(81, 118);
            this.wisNud.Name = "wisNud";
            this.wisNud.Size = new System.Drawing.Size(54, 20);
            this.wisNud.TabIndex = 10;
            this.wisNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // intNud
            // 
            this.intNud.Location = new System.Drawing.Point(81, 92);
            this.intNud.Name = "intNud";
            this.intNud.Size = new System.Drawing.Size(54, 20);
            this.intNud.TabIndex = 9;
            this.intNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // conNud
            // 
            this.conNud.Location = new System.Drawing.Point(81, 66);
            this.conNud.Name = "conNud";
            this.conNud.Size = new System.Drawing.Size(54, 20);
            this.conNud.TabIndex = 8;
            this.conNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // dexNud
            // 
            this.dexNud.Location = new System.Drawing.Point(81, 40);
            this.dexNud.Name = "dexNud";
            this.dexNud.Size = new System.Drawing.Size(54, 20);
            this.dexNud.TabIndex = 7;
            this.dexNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // strNud
            // 
            this.strNud.Location = new System.Drawing.Point(81, 14);
            this.strNud.Name = "strNud";
            this.strNud.Size = new System.Drawing.Size(54, 20);
            this.strNud.TabIndex = 6;
            this.strNud.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Charisma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Wisdom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Intelligence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Constitution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dexterity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Strength:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.willLbl);
            this.groupBox3.Controls.Add(this.fortLbl);
            this.groupBox3.Controls.Add(this.refLbl);
            this.groupBox3.Controls.Add(this.acLbl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Defenses";
            // 
            // willLbl
            // 
            this.willLbl.AutoSize = true;
            this.willLbl.Location = new System.Drawing.Point(63, 61);
            this.willLbl.Name = "willLbl";
            this.willLbl.Size = new System.Drawing.Size(28, 13);
            this.willLbl.TabIndex = 7;
            this.willLbl.Text = "###";
            // 
            // fortLbl
            // 
            this.fortLbl.AutoSize = true;
            this.fortLbl.Location = new System.Drawing.Point(63, 48);
            this.fortLbl.Name = "fortLbl";
            this.fortLbl.Size = new System.Drawing.Size(28, 13);
            this.fortLbl.TabIndex = 6;
            this.fortLbl.Text = "###";
            // 
            // refLbl
            // 
            this.refLbl.AutoSize = true;
            this.refLbl.Location = new System.Drawing.Point(63, 35);
            this.refLbl.Name = "refLbl";
            this.refLbl.Size = new System.Drawing.Size(28, 13);
            this.refLbl.TabIndex = 5;
            this.refLbl.Text = "###";
            // 
            // acLbl
            // 
            this.acLbl.AutoSize = true;
            this.acLbl.Location = new System.Drawing.Point(63, 22);
            this.acLbl.Name = "acLbl";
            this.acLbl.Size = new System.Drawing.Size(28, 13);
            this.acLbl.TabIndex = 4;
            this.acLbl.Text = "###";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Armor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Fortitude:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Reflex:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Will:";
            // 
            // CharacterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 274);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CharacterView";
            this.Text = "Character Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strNud)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown chaNud;
        private System.Windows.Forms.NumericUpDown wisNud;
        private System.Windows.Forms.NumericUpDown intNud;
        private System.Windows.Forms.NumericUpDown conNud;
        private System.Windows.Forms.NumericUpDown dexNud;
        private System.Windows.Forms.NumericUpDown strNud;
        private System.Windows.Forms.NumericUpDown levelNud;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label willLbl;
        private System.Windows.Forms.Label fortLbl;
        private System.Windows.Forms.Label refLbl;
        private System.Windows.Forms.Label acLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}

