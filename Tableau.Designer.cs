
namespace Previsualisation_PEA
{
    partial class Tableau
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.annee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pourcentageAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profitAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.annee,
            this.pea,
            this.pourcentageAnnee,
            this.profitAnnee,
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 552);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // annee
            // 
            this.annee.Text = "Année";
            this.annee.Width = 61;
            // 
            // pea
            // 
            this.pea.Text = "PEA";
            this.pea.Width = 66;
            // 
            // pourcentageAnnee
            // 
            this.pourcentageAnnee.Text = "% année";
            this.pourcentageAnnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pourcentageAnnee.Width = 64;
            // 
            // profitAnnee
            // 
            this.profitAnnee.Text = "Profit année";
            this.profitAnnee.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ajout mensuel";
            this.columnHeader1.Width = 91;
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "Tableau";
            this.Size = new System.Drawing.Size(587, 558);
            this.Load += new System.EventHandler(this.Tableau_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader annee;
        private System.Windows.Forms.ColumnHeader pea;
        private System.Windows.Forms.ColumnHeader pourcentageAnnee;
        private System.Windows.Forms.ColumnHeader profitAnnee;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
