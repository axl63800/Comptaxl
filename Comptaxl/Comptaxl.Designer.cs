namespace Comptaxl
{
    partial class Comptaxl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editionDesTypesDeRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendezVousToolStripMenuItem,
            this.listeDesClientsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fichierToolStripMenuItem.Text = "Fichier..";
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients..";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionDesTypesDeRendezvousToolStripMenuItem,
            this.configurationUtilisateurToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.optionsToolStripMenuItem.Text = "Options..";
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.rendezVousToolStripMenuItem.Text = "Rendez vous..";
            this.rendezVousToolStripMenuItem.Click += new System.EventHandler(this.rendezVousToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // editionDesTypesDeRendezvousToolStripMenuItem
            // 
            this.editionDesTypesDeRendezvousToolStripMenuItem.Name = "editionDesTypesDeRendezvousToolStripMenuItem";
            this.editionDesTypesDeRendezvousToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.editionDesTypesDeRendezvousToolStripMenuItem.Text = "Edition des types de rendez-vous..";
            this.editionDesTypesDeRendezvousToolStripMenuItem.Click += new System.EventHandler(this.editionDesTypesDeRendezvousToolStripMenuItem_Click);
            // 
            // configurationUtilisateurToolStripMenuItem
            // 
            this.configurationUtilisateurToolStripMenuItem.Name = "configurationUtilisateurToolStripMenuItem";
            this.configurationUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.configurationUtilisateurToolStripMenuItem.Text = "Configuration utilisateur..";
            this.configurationUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.configurationUtilisateurToolStripMenuItem_Click);
            // 
            // Comptaxl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 498);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Comptaxl";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comptaxl_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editionDesTypesDeRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationUtilisateurToolStripMenuItem;
    }
}

