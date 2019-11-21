namespace JakubKazimierskiLab1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelWithName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWithName
            // 
            this.LabelWithName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWithName.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.LabelWithName.Location = new System.Drawing.Point(12, 9);
            this.LabelWithName.Name = "LabelWithName";
            this.LabelWithName.Size = new System.Drawing.Size(374, 60);
            this.LabelWithName.TabIndex = 0;
            this.LabelWithName.Text = "Jakub Kazimierski";
            this.LabelWithName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.LabelWithName);
            this.MinimumSize = new System.Drawing.Size(414, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWithName;
    }
}

