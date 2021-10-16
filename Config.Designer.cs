
namespace Previsualisation_PEA
{
    partial class Config
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.ajoutMensuelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.montantInitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rendementAnnuelMoyenCheckBox = new System.Windows.Forms.CheckBox();
            this.anneeTrackBar = new System.Windows.Forms.TrackBar();
            this.anneeLabel = new System.Windows.Forms.Label();
            this.premiereAnneeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rendementTrackBar = new System.Windows.Forms.TrackBar();
            this.rendementLabel = new System.Windows.Forms.Label();
            this.montantTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutMensuelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantInitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendementTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ajoutMensuelNumericUpDown
            // 
            this.ajoutMensuelNumericUpDown.Location = new System.Drawing.Point(369, 432);
            this.ajoutMensuelNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ajoutMensuelNumericUpDown.Name = "ajoutMensuelNumericUpDown";
            this.ajoutMensuelNumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.ajoutMensuelNumericUpDown.TabIndex = 12;
            this.ajoutMensuelNumericUpDown.ValueChanged += new System.EventHandler(this.ajoutMensuelNumericUpDown_ValueChanged);
            // 
            // montantInitNumericUpDown
            // 
            this.montantInitNumericUpDown.Location = new System.Drawing.Point(87, 432);
            this.montantInitNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.montantInitNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.montantInitNumericUpDown.Name = "montantInitNumericUpDown";
            this.montantInitNumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.montantInitNumericUpDown.TabIndex = 11;
            this.montantInitNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.montantInitNumericUpDown.ValueChanged += new System.EventHandler(this.montantInitNumericUpDown_ValueChanged);
            // 
            // calculButton
            // 
            this.calculButton.Location = new System.Drawing.Point(69, 509);
            this.calculButton.Name = "calculButton";
            this.calculButton.Size = new System.Drawing.Size(407, 28);
            this.calculButton.TabIndex = 10;
            this.calculButton.Text = "Calcul";
            this.calculButton.UseVisualStyleBackColor = true;
            this.calculButton.Click += new System.EventHandler(this.calculButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ajout mensuel :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Montant initial :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rendementAnnuelMoyenCheckBox
            // 
            this.rendementAnnuelMoyenCheckBox.AutoSize = true;
            this.rendementAnnuelMoyenCheckBox.Location = new System.Drawing.Point(6, 399);
            this.rendementAnnuelMoyenCheckBox.Name = "rendementAnnuelMoyenCheckBox";
            this.rendementAnnuelMoyenCheckBox.Size = new System.Drawing.Size(434, 17);
            this.rendementAnnuelMoyenCheckBox.TabIndex = 13;
            this.rendementAnnuelMoyenCheckBox.Text = "Cocher = rendement annuel moyen 8% / Pas cocher = rendement aléatoire de 6 à 10%";
            this.rendementAnnuelMoyenCheckBox.UseVisualStyleBackColor = true;
            // 
            // anneeTrackBar
            // 
            this.anneeTrackBar.Location = new System.Drawing.Point(6, 324);
            this.anneeTrackBar.Maximum = 100;
            this.anneeTrackBar.Minimum = 5;
            this.anneeTrackBar.Name = "anneeTrackBar";
            this.anneeTrackBar.Size = new System.Drawing.Size(525, 45);
            this.anneeTrackBar.TabIndex = 14;
            this.anneeTrackBar.Value = 5;
            this.anneeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // anneeLabel
            // 
            this.anneeLabel.AutoSize = true;
            this.anneeLabel.Location = new System.Drawing.Point(16, 308);
            this.anneeLabel.Name = "anneeLabel";
            this.anneeLabel.Size = new System.Drawing.Size(113, 13);
            this.anneeLabel.TabIndex = 15;
            this.anneeLabel.Text = "Durée du PEA : 5 ans.";
            // 
            // premiereAnneeCheckBox
            // 
            this.premiereAnneeCheckBox.AutoSize = true;
            this.premiereAnneeCheckBox.Location = new System.Drawing.Point(6, 375);
            this.premiereAnneeCheckBox.Name = "premiereAnneeCheckBox";
            this.premiereAnneeCheckBox.Size = new System.Drawing.Size(464, 17);
            this.premiereAnneeCheckBox.TabIndex = 16;
            this.premiereAnneeCheckBox.Text = "Ouverture du PEA la première semaine de janvier (rendement de la première année c" +
    "omplète)";
            this.premiereAnneeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "A lire :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 96);
            this.label4.TabIndex = 18;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // rendementTrackBar
            // 
            this.rendementTrackBar.Location = new System.Drawing.Point(6, 260);
            this.rendementTrackBar.Maximum = 25;
            this.rendementTrackBar.Name = "rendementTrackBar";
            this.rendementTrackBar.Size = new System.Drawing.Size(525, 45);
            this.rendementTrackBar.TabIndex = 19;
            this.rendementTrackBar.Scroll += new System.EventHandler(this.rendementTrackBar_Scroll);
            // 
            // rendementLabel
            // 
            this.rendementLabel.AutoSize = true;
            this.rendementLabel.Location = new System.Drawing.Point(16, 244);
            this.rendementLabel.Name = "rendementLabel";
            this.rendementLabel.Size = new System.Drawing.Size(173, 13);
            this.rendementLabel.TabIndex = 20;
            this.rendementLabel.Text = "Rendement annuel en % : Aléatoire";
            // 
            // montantTotalLabel
            // 
            this.montantTotalLabel.AutoSize = true;
            this.montantTotalLabel.Location = new System.Drawing.Point(168, 475);
            this.montantTotalLabel.Name = "montantTotalLabel";
            this.montantTotalLabel.Size = new System.Drawing.Size(95, 13);
            this.montantTotalLabel.TabIndex = 21;
            this.montantTotalLabel.Text = "montantTotalLabel";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.montantTotalLabel);
            this.Controls.Add(this.rendementLabel);
            this.Controls.Add(this.rendementTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.premiereAnneeCheckBox);
            this.Controls.Add(this.anneeLabel);
            this.Controls.Add(this.anneeTrackBar);
            this.Controls.Add(this.rendementAnnuelMoyenCheckBox);
            this.Controls.Add(this.ajoutMensuelNumericUpDown);
            this.Controls.Add(this.montantInitNumericUpDown);
            this.Controls.Add(this.calculButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Size = new System.Drawing.Size(545, 550);
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajoutMensuelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantInitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendementTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ajoutMensuelNumericUpDown;
        private System.Windows.Forms.NumericUpDown montantInitNumericUpDown;
        private System.Windows.Forms.Button calculButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rendementAnnuelMoyenCheckBox;
        private System.Windows.Forms.TrackBar anneeTrackBar;
        private System.Windows.Forms.Label anneeLabel;
        private System.Windows.Forms.CheckBox premiereAnneeCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar rendementTrackBar;
        private System.Windows.Forms.Label rendementLabel;
        private System.Windows.Forms.Label montantTotalLabel;
    }
}
