namespace Exo2
{
    partial class frmExo2a
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_Modifier = new System.Windows.Forms.CheckBox();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_Affichage_Couleur = new System.Windows.Forms.Label();
            this.rbt_Rouge = new System.Windows.Forms.RadioButton();
            this.rbt_Vert = new System.Windows.Forms.RadioButton();
            this.rbt_Bleu = new System.Windows.Forms.RadioButton();
            this.gbx_Couleur = new System.Windows.Forms.GroupBox();
            this.gbx_Couleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Modifier
            // 
            this.chk_Modifier.AutoSize = true;
            this.chk_Modifier.Location = new System.Drawing.Point(12, 80);
            this.chk_Modifier.Name = "chk_Modifier";
            this.chk_Modifier.Size = new System.Drawing.Size(112, 17);
            this.chk_Modifier.TabIndex = 0;
            this.chk_Modifier.Text = "Modifier la couleur";
            this.chk_Modifier.UseVisualStyleBackColor = true;
            this.chk_Modifier.CheckedChanged += new System.EventHandler(this.chk_Modifier_CheckedChanged);
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.Location = new System.Drawing.Point(9, 27);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(172, 40);
            this.lbl_Titre.TabIndex = 1;
            this.lbl_Titre.Text = "Démonstration des cases à cocher et des boutons d\'options";
            // 
            // lbl_Affichage_Couleur
            // 
            this.lbl_Affichage_Couleur.BackColor = System.Drawing.Color.Red;
            this.lbl_Affichage_Couleur.Location = new System.Drawing.Point(186, 81);
            this.lbl_Affichage_Couleur.Name = "lbl_Affichage_Couleur";
            this.lbl_Affichage_Couleur.Size = new System.Drawing.Size(143, 109);
            this.lbl_Affichage_Couleur.TabIndex = 2;
            this.lbl_Affichage_Couleur.Text = "La couleur choisie";
            // 
            // rbt_Rouge
            // 
            this.rbt_Rouge.AutoSize = true;
            this.rbt_Rouge.Location = new System.Drawing.Point(20, 28);
            this.rbt_Rouge.Name = "rbt_Rouge";
            this.rbt_Rouge.Size = new System.Drawing.Size(57, 17);
            this.rbt_Rouge.TabIndex = 3;
            this.rbt_Rouge.TabStop = true;
            this.rbt_Rouge.Text = "&Rouge";
            this.rbt_Rouge.UseVisualStyleBackColor = true;
            this.rbt_Rouge.CheckedChanged += new System.EventHandler(this.rbt_Rouge_CheckedChanged);
            // 
            // rbt_Vert
            // 
            this.rbt_Vert.AutoSize = true;
            this.rbt_Vert.Location = new System.Drawing.Point(21, 62);
            this.rbt_Vert.Name = "rbt_Vert";
            this.rbt_Vert.Size = new System.Drawing.Size(44, 17);
            this.rbt_Vert.TabIndex = 4;
            this.rbt_Vert.TabStop = true;
            this.rbt_Vert.Text = "&Vert";
            this.rbt_Vert.UseVisualStyleBackColor = true;
            this.rbt_Vert.CheckedChanged += new System.EventHandler(this.rbt_Vert_CheckedChanged);
            // 
            // rbt_Bleu
            // 
            this.rbt_Bleu.AutoSize = true;
            this.rbt_Bleu.Location = new System.Drawing.Point(21, 97);
            this.rbt_Bleu.Name = "rbt_Bleu";
            this.rbt_Bleu.Size = new System.Drawing.Size(46, 17);
            this.rbt_Bleu.TabIndex = 5;
            this.rbt_Bleu.TabStop = true;
            this.rbt_Bleu.Text = "&Bleu";
            this.rbt_Bleu.UseVisualStyleBackColor = true;
            this.rbt_Bleu.CheckedChanged += new System.EventHandler(this.rbt_Bleu_CheckedChanged);
            // 
            // gbx_Couleur
            // 
            this.gbx_Couleur.Controls.Add(this.rbt_Bleu);
            this.gbx_Couleur.Controls.Add(this.rbt_Vert);
            this.gbx_Couleur.Controls.Add(this.rbt_Rouge);
            this.gbx_Couleur.Location = new System.Drawing.Point(190, 210);
            this.gbx_Couleur.Name = "gbx_Couleur";
            this.gbx_Couleur.Size = new System.Drawing.Size(160, 130);
            this.gbx_Couleur.TabIndex = 6;
            this.gbx_Couleur.TabStop = false;
            this.gbx_Couleur.Text = "Couleur";
            this.gbx_Couleur.Visible = false;
            // 
            // frmExo2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.gbx_Couleur);
            this.Controls.Add(this.lbl_Affichage_Couleur);
            this.Controls.Add(this.lbl_Titre);
            this.Controls.Add(this.chk_Modifier);
            this.Name = "frmExo2a";
            this.Text = "Exercice2a : couleurs";
            this.gbx_Couleur.ResumeLayout(false);
            this.gbx_Couleur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Modifier;
        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_Affichage_Couleur;
        private System.Windows.Forms.RadioButton rbt_Rouge;
        private System.Windows.Forms.RadioButton rbt_Vert;
        private System.Windows.Forms.RadioButton rbt_Bleu;
        private System.Windows.Forms.GroupBox gbx_Couleur;
    }
}

