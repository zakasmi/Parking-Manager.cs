namespace GestParc
{
    partial class Form1
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
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_debut = new System.Windows.Forms.Button();
            this.BTN_precedent = new System.Windows.Forms.Button();
            this.BTN_suivant = new System.Windows.Forms.Button();
            this.BTN_fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_immatricule = new System.Windows.Forms.ComboBox();
            this.CB_IdConducteur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_IdHC = new System.Windows.Forms.TextBox();
            this.DTP_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Modifier.Location = new System.Drawing.Point(175, 289);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(99, 23);
            this.BTN_Modifier.TabIndex = 0;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Supprimer.Location = new System.Drawing.Point(341, 289);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(99, 23);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Ajouter.Location = new System.Drawing.Point(507, 289);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(99, 23);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_debut
            // 
            this.BTN_debut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_debut.Location = new System.Drawing.Point(27, 289);
            this.BTN_debut.Name = "BTN_debut";
            this.BTN_debut.Size = new System.Drawing.Size(37, 23);
            this.BTN_debut.TabIndex = 0;
            this.BTN_debut.Text = "<<";
            this.BTN_debut.UseVisualStyleBackColor = true;
            this.BTN_debut.Click += new System.EventHandler(this.BTN_debut_Click);
            // 
            // BTN_precedent
            // 
            this.BTN_precedent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_precedent.Location = new System.Drawing.Point(78, 289);
            this.BTN_precedent.Name = "BTN_precedent";
            this.BTN_precedent.Size = new System.Drawing.Size(37, 23);
            this.BTN_precedent.TabIndex = 0;
            this.BTN_precedent.Text = "<";
            this.BTN_precedent.UseVisualStyleBackColor = true;
            this.BTN_precedent.Click += new System.EventHandler(this.BTN_precedent_Click);
            // 
            // BTN_suivant
            // 
            this.BTN_suivant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_suivant.Location = new System.Drawing.Point(655, 289);
            this.BTN_suivant.Name = "BTN_suivant";
            this.BTN_suivant.Size = new System.Drawing.Size(37, 23);
            this.BTN_suivant.TabIndex = 0;
            this.BTN_suivant.Text = ">";
            this.BTN_suivant.UseVisualStyleBackColor = true;
            this.BTN_suivant.Click += new System.EventHandler(this.BTN_suivant_Click);
            // 
            // BTN_fin
            // 
            this.BTN_fin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_fin.Location = new System.Drawing.Point(708, 289);
            this.BTN_fin.Name = "BTN_fin";
            this.BTN_fin.Size = new System.Drawing.Size(37, 23);
            this.BTN_fin.TabIndex = 0;
            this.BTN_fin.Text = ">>";
            this.BTN_fin.UseVisualStyleBackColor = true;
            this.BTN_fin.Click += new System.EventHandler(this.BTN_fin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panne >>";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Immatricule :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Conducteur :";
            // 
            // CB_immatricule
            // 
            this.CB_immatricule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_immatricule.FormattingEnabled = true;
            this.CB_immatricule.Location = new System.Drawing.Point(150, 68);
            this.CB_immatricule.Name = "CB_immatricule";
            this.CB_immatricule.Size = new System.Drawing.Size(138, 21);
            this.CB_immatricule.TabIndex = 3;
            // 
            // CB_IdConducteur
            // 
            this.CB_IdConducteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_IdConducteur.FormattingEnabled = true;
            this.CB_IdConducteur.Location = new System.Drawing.Point(150, 124);
            this.CB_IdConducteur.Name = "CB_IdConducteur";
            this.CB_IdConducteur.Size = new System.Drawing.Size(144, 21);
            this.CB_IdConducteur.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Historique de Conducteur";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de Fin";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de Debut";
            // 
            // TB_IdHC
            // 
            this.TB_IdHC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_IdHC.Location = new System.Drawing.Point(554, 67);
            this.TB_IdHC.Name = "TB_IdHC";
            this.TB_IdHC.Size = new System.Drawing.Size(138, 20);
            this.TB_IdHC.TabIndex = 5;
            // 
            // DTP_DateDebut
            // 
            this.DTP_DateDebut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP_DateDebut.Location = new System.Drawing.Point(554, 129);
            this.DTP_DateDebut.Name = "DTP_DateDebut";
            this.DTP_DateDebut.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateDebut.TabIndex = 6;
            // 
            // DTP_DateFin
            // 
            this.DTP_DateFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP_DateFin.Location = new System.Drawing.Point(554, 191);
            this.DTP_DateFin.Name = "DTP_DateFin";
            this.DTP_DateFin.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateFin.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 339);
            this.Controls.Add(this.DTP_DateFin);
            this.Controls.Add(this.DTP_DateDebut);
            this.Controls.Add(this.TB_IdHC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_IdConducteur);
            this.Controls.Add(this.CB_immatricule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_fin);
            this.Controls.Add(this.BTN_precedent);
            this.Controls.Add(this.BTN_suivant);
            this.Controls.Add(this.BTN_debut);
            this.Controls.Add(this.BTN_Modifier);
            this.Name = "Form1";
            this.Text = "Gesttion Parc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_debut;
        private System.Windows.Forms.Button BTN_precedent;
        private System.Windows.Forms.Button BTN_suivant;
        private System.Windows.Forms.Button BTN_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_immatricule;
        private System.Windows.Forms.ComboBox CB_IdConducteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_IdHC;
        private System.Windows.Forms.DateTimePicker DTP_DateDebut;
        private System.Windows.Forms.DateTimePicker DTP_DateFin;
    }
}

