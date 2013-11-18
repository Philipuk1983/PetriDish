namespace PetriDishWin
{
    partial class PetriDishForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.petriDishImage = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.statsHeaderLabel = new System.Windows.Forms.Label();
            this.MicrobeID = new System.Windows.Forms.Label();
            this.MicrobeCount = new System.Windows.Forms.Label();
            this.microbeIdLabel = new System.Windows.Forms.Label();
            this.microbeCountLabel = new System.Windows.Forms.Label();
            this.mutateStrengthLabel = new System.Windows.Forms.Label();
            this.MutateStrength = new System.Windows.Forms.Label();
            this.MutateResistance = new System.Windows.Forms.Label();
            this.SpreadChance = new System.Windows.Forms.Label();
            this.ConsumeStrength = new System.Windows.Forms.Label();
            this.mutateResistanceLabel = new System.Windows.Forms.Label();
            this.spreadChanceLabel = new System.Windows.Forms.Label();
            this.consumeStrengthLabel = new System.Windows.Forms.Label();
            this.ConsumeResistance = new System.Windows.Forms.Label();
            this.consumeResistanceLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.mutationFactor = new System.Windows.Forms.Label();
            this.evolutionFactor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petriDishImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // petriDishImage
            // 
            this.petriDishImage.Location = new System.Drawing.Point(12, 9);
            this.petriDishImage.Name = "petriDishImage";
            this.petriDishImage.Size = new System.Drawing.Size(315, 309);
            this.petriDishImage.TabIndex = 0;
            this.petriDishImage.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(429, 302);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statsHeaderLabel
            // 
            this.statsHeaderLabel.AutoSize = true;
            this.statsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsHeaderLabel.Location = new System.Drawing.Point(411, 9);
            this.statsHeaderLabel.Name = "statsHeaderLabel";
            this.statsHeaderLabel.Size = new System.Drawing.Size(77, 20);
            this.statsHeaderLabel.TabIndex = 2;
            this.statsHeaderLabel.Text = "Top Dog";
            this.statsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicrobeID
            // 
            this.MicrobeID.AutoSize = true;
            this.MicrobeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MicrobeID.Location = new System.Drawing.Point(462, 39);
            this.MicrobeID.Name = "MicrobeID";
            this.MicrobeID.Size = new System.Drawing.Size(29, 20);
            this.MicrobeID.TabIndex = 1;
            this.MicrobeID.Text = "na";
            this.MicrobeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicrobeCount
            // 
            this.MicrobeCount.AutoSize = true;
            this.MicrobeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MicrobeCount.Location = new System.Drawing.Point(462, 59);
            this.MicrobeCount.Name = "MicrobeCount";
            this.MicrobeCount.Size = new System.Drawing.Size(29, 20);
            this.MicrobeCount.TabIndex = 0;
            this.MicrobeCount.Text = "na";
            this.MicrobeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // microbeIdLabel
            // 
            this.microbeIdLabel.AutoSize = true;
            this.microbeIdLabel.Location = new System.Drawing.Point(346, 39);
            this.microbeIdLabel.Name = "microbeIdLabel";
            this.microbeIdLabel.Size = new System.Drawing.Size(59, 13);
            this.microbeIdLabel.TabIndex = 3;
            this.microbeIdLabel.Text = "Microbe ID";
            this.microbeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // microbeCountLabel
            // 
            this.microbeCountLabel.AutoSize = true;
            this.microbeCountLabel.Location = new System.Drawing.Point(346, 59);
            this.microbeCountLabel.Name = "microbeCountLabel";
            this.microbeCountLabel.Size = new System.Drawing.Size(76, 13);
            this.microbeCountLabel.TabIndex = 4;
            this.microbeCountLabel.Text = "Microbe Count";
            this.microbeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mutateStrengthLabel
            // 
            this.mutateStrengthLabel.AutoSize = true;
            this.mutateStrengthLabel.Location = new System.Drawing.Point(346, 78);
            this.mutateStrengthLabel.Name = "mutateStrengthLabel";
            this.mutateStrengthLabel.Size = new System.Drawing.Size(83, 13);
            this.mutateStrengthLabel.TabIndex = 5;
            this.mutateStrengthLabel.Text = "Mutate Strength";
            this.mutateStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MutateStrength
            // 
            this.MutateStrength.AutoSize = true;
            this.MutateStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutateStrength.Location = new System.Drawing.Point(462, 78);
            this.MutateStrength.Name = "MutateStrength";
            this.MutateStrength.Size = new System.Drawing.Size(29, 20);
            this.MutateStrength.TabIndex = 6;
            this.MutateStrength.Text = "na";
            this.MutateStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MutateResistance
            // 
            this.MutateResistance.AutoSize = true;
            this.MutateResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutateResistance.Location = new System.Drawing.Point(462, 98);
            this.MutateResistance.Name = "MutateResistance";
            this.MutateResistance.Size = new System.Drawing.Size(29, 20);
            this.MutateResistance.TabIndex = 7;
            this.MutateResistance.Text = "na";
            this.MutateResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpreadChance
            // 
            this.SpreadChance.AutoSize = true;
            this.SpreadChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpreadChance.Location = new System.Drawing.Point(462, 118);
            this.SpreadChance.Name = "SpreadChance";
            this.SpreadChance.Size = new System.Drawing.Size(29, 20);
            this.SpreadChance.TabIndex = 8;
            this.SpreadChance.Text = "na";
            this.SpreadChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsumeStrength
            // 
            this.ConsumeStrength.AutoSize = true;
            this.ConsumeStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsumeStrength.Location = new System.Drawing.Point(462, 138);
            this.ConsumeStrength.Name = "ConsumeStrength";
            this.ConsumeStrength.Size = new System.Drawing.Size(29, 20);
            this.ConsumeStrength.TabIndex = 9;
            this.ConsumeStrength.Text = "na";
            this.ConsumeStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mutateResistanceLabel
            // 
            this.mutateResistanceLabel.AutoSize = true;
            this.mutateResistanceLabel.Location = new System.Drawing.Point(346, 98);
            this.mutateResistanceLabel.Name = "mutateResistanceLabel";
            this.mutateResistanceLabel.Size = new System.Drawing.Size(96, 13);
            this.mutateResistanceLabel.TabIndex = 10;
            this.mutateResistanceLabel.Text = "Mutate Resistance";
            this.mutateResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spreadChanceLabel
            // 
            this.spreadChanceLabel.AutoSize = true;
            this.spreadChanceLabel.Location = new System.Drawing.Point(346, 118);
            this.spreadChanceLabel.Name = "spreadChanceLabel";
            this.spreadChanceLabel.Size = new System.Drawing.Size(81, 13);
            this.spreadChanceLabel.TabIndex = 11;
            this.spreadChanceLabel.Text = "Spread Chance";
            this.spreadChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumeStrengthLabel
            // 
            this.consumeStrengthLabel.AutoSize = true;
            this.consumeStrengthLabel.Location = new System.Drawing.Point(346, 138);
            this.consumeStrengthLabel.Name = "consumeStrengthLabel";
            this.consumeStrengthLabel.Size = new System.Drawing.Size(94, 13);
            this.consumeStrengthLabel.TabIndex = 12;
            this.consumeStrengthLabel.Text = "Consume Strength";
            this.consumeStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsumeResistance
            // 
            this.ConsumeResistance.AutoSize = true;
            this.ConsumeResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsumeResistance.Location = new System.Drawing.Point(462, 158);
            this.ConsumeResistance.Name = "ConsumeResistance";
            this.ConsumeResistance.Size = new System.Drawing.Size(29, 20);
            this.ConsumeResistance.TabIndex = 13;
            this.ConsumeResistance.Text = "na";
            this.ConsumeResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumeResistanceLabel
            // 
            this.consumeResistanceLabel.AutoSize = true;
            this.consumeResistanceLabel.Location = new System.Drawing.Point(346, 158);
            this.consumeResistanceLabel.Name = "consumeResistanceLabel";
            this.consumeResistanceLabel.Size = new System.Drawing.Size(107, 13);
            this.consumeResistanceLabel.TabIndex = 14;
            this.consumeResistanceLabel.Text = "Consume Resistance";
            this.consumeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(447, 200);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(139, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Maximum = 20;
            this.trackBar1.Value = 1;
            this.trackBar1.TickFrequency = 20;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(447, 251);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(139, 45);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Maximum = 20;
            this.trackBar2.Value = 1;
            this.trackBar2.TickFrequency = 20;
            // 
            // mutationFactor
            // 
            this.mutationFactor.AutoSize = true;
            this.mutationFactor.Location = new System.Drawing.Point(349, 200);
            this.mutationFactor.Name = "mutationFactor";
            this.mutationFactor.Size = new System.Drawing.Size(81, 13);
            this.mutationFactor.TabIndex = 17;
            this.mutationFactor.Text = "Mutation Factor";
            // 
            // evolutionFactor
            // 
            this.evolutionFactor.AutoSize = true;
            this.evolutionFactor.Location = new System.Drawing.Point(349, 251);
            this.evolutionFactor.Name = "evolutionFactor";
            this.evolutionFactor.Size = new System.Drawing.Size(84, 13);
            this.evolutionFactor.TabIndex = 18;
            this.evolutionFactor.Text = "Evolution Factor";
            // 
            // PetriDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 345);
            this.Controls.Add(this.evolutionFactor);
            this.Controls.Add(this.mutationFactor);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.consumeResistanceLabel);
            this.Controls.Add(this.ConsumeResistance);
            this.Controls.Add(this.consumeStrengthLabel);
            this.Controls.Add(this.spreadChanceLabel);
            this.Controls.Add(this.mutateResistanceLabel);
            this.Controls.Add(this.ConsumeStrength);
            this.Controls.Add(this.SpreadChance);
            this.Controls.Add(this.MutateResistance);
            this.Controls.Add(this.MutateStrength);
            this.Controls.Add(this.mutateStrengthLabel);
            this.Controls.Add(this.microbeCountLabel);
            this.Controls.Add(this.microbeIdLabel);
            this.Controls.Add(this.MicrobeCount);
            this.Controls.Add(this.MicrobeID);
            this.Controls.Add(this.statsHeaderLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.petriDishImage);
            this.Name = "PetriDishForm";
            this.Text = "PetriDishWin";
            ((System.ComponentModel.ISupportInitialize)(this.petriDishImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox petriDishImage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statsHeaderLabel;
        private System.Windows.Forms.Label MicrobeID;
        private System.Windows.Forms.Label MicrobeCount;
        private System.Windows.Forms.Label microbeIdLabel;
        private System.Windows.Forms.Label microbeCountLabel;
        private System.Windows.Forms.Label mutateStrengthLabel;
        private System.Windows.Forms.Label MutateStrength;
        private System.Windows.Forms.Label MutateResistance;
        private System.Windows.Forms.Label SpreadChance;
        private System.Windows.Forms.Label ConsumeStrength;
        private System.Windows.Forms.Label mutateResistanceLabel;
        private System.Windows.Forms.Label spreadChanceLabel;
        private System.Windows.Forms.Label consumeStrengthLabel;
        private System.Windows.Forms.Label ConsumeResistance;
        private System.Windows.Forms.Label consumeResistanceLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label mutationFactor;
        private System.Windows.Forms.Label evolutionFactor;
    }
}