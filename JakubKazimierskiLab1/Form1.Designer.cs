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
            this.components = new System.ComponentModel.Container();
            this.LabelWithName = new System.Windows.Forms.Label();
            this.TableofTimer = new System.Windows.Forms.TableLayoutPanel();
            this.HoursTable = new System.Windows.Forms.Label();
            this.MinutesTable = new System.Windows.Forms.Label();
            this.SecondsTable = new System.Windows.Forms.Label();
            this.HunSecondsTable = new System.Windows.Forms.Label();
            this.TableOfButons = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TableOfColors = new System.Windows.Forms.TableLayoutPanel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TableofTimer.SuspendLayout();
            this.TableOfButons.SuspendLayout();
            this.TableOfColors.SuspendLayout();
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
            // TableofTimer
            // 
            this.TableofTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableofTimer.ColumnCount = 4;
            this.TableofTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableofTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableofTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableofTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableofTimer.Controls.Add(this.HunSecondsTable, 3, 0);
            this.TableofTimer.Controls.Add(this.SecondsTable, 2, 0);
            this.TableofTimer.Controls.Add(this.MinutesTable, 1, 0);
            this.TableofTimer.Controls.Add(this.HoursTable, 0, 0);
            this.TableofTimer.Location = new System.Drawing.Point(21, 72);
            this.TableofTimer.Name = "TableofTimer";
            this.TableofTimer.RowCount = 1;
            this.TableofTimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableofTimer.Size = new System.Drawing.Size(365, 100);
            this.TableofTimer.TabIndex = 1;
            // 
            // HoursTable
            // 
            this.HoursTable.AutoSize = true;
            this.HoursTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HoursTable.Location = new System.Drawing.Point(3, 0);
            this.HoursTable.Name = "HoursTable";
            this.HoursTable.Size = new System.Drawing.Size(85, 100);
            this.HoursTable.TabIndex = 0;
            this.HoursTable.Text = "00";
            // 
            // MinutesTable
            // 
            this.MinutesTable.AutoSize = true;
            this.MinutesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinutesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinutesTable.Location = new System.Drawing.Point(94, 0);
            this.MinutesTable.Name = "MinutesTable";
            this.MinutesTable.Size = new System.Drawing.Size(85, 100);
            this.MinutesTable.TabIndex = 1;
            this.MinutesTable.Text = "00";
            // 
            // SecondsTable
            // 
            this.SecondsTable.AutoSize = true;
            this.SecondsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondsTable.Location = new System.Drawing.Point(185, 0);
            this.SecondsTable.Name = "SecondsTable";
            this.SecondsTable.Size = new System.Drawing.Size(85, 100);
            this.SecondsTable.TabIndex = 2;
            this.SecondsTable.Text = "00";
            // 
            // HunSecondsTable
            // 
            this.HunSecondsTable.AutoSize = true;
            this.HunSecondsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HunSecondsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HunSecondsTable.Location = new System.Drawing.Point(276, 0);
            this.HunSecondsTable.Name = "HunSecondsTable";
            this.HunSecondsTable.Size = new System.Drawing.Size(86, 100);
            this.HunSecondsTable.TabIndex = 3;
            this.HunSecondsTable.Text = "00";
            // 
            // TableOfButons
            // 
            this.TableOfButons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableOfButons.ColumnCount = 3;
            this.TableOfButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableOfButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableOfButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.TableOfButons.Controls.Add(this.StopButton, 2, 0);
            this.TableOfButons.Controls.Add(this.PauseButton, 1, 0);
            this.TableOfButons.Controls.Add(this.StartButton, 0, 0);
            this.TableOfButons.Location = new System.Drawing.Point(21, 178);
            this.TableOfButons.Name = "TableOfButons";
            this.TableOfButons.RowCount = 1;
            this.TableOfButons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableOfButons.Size = new System.Drawing.Size(362, 100);
            this.TableOfButons.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 94);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Location = new System.Drawing.Point(123, 3);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(114, 94);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Location = new System.Drawing.Point(243, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(116, 94);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TableOfColors
            // 
            this.TableOfColors.ColumnCount = 1;
            this.TableOfColors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableOfColors.Controls.Add(this.ColorButton, 0, 0);
            this.TableOfColors.Location = new System.Drawing.Point(21, 284);
            this.TableOfColors.Name = "TableOfColors";
            this.TableOfColors.RowCount = 1;
            this.TableOfColors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableOfColors.Size = new System.Drawing.Size(359, 100);
            this.TableOfColors.TabIndex = 3;
            // 
            // ColorButton
            // 
            this.ColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorButton.Location = new System.Drawing.Point(3, 3);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(353, 94);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Change Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.TableOfColors);
            this.Controls.Add(this.TableOfButons);
            this.Controls.Add(this.TableofTimer);
            this.Controls.Add(this.LabelWithName);
            this.MaximumSize = new System.Drawing.Size(414, 468);
            this.MinimumSize = new System.Drawing.Size(414, 468);
            this.Name = "Form1";
            this.Text = "Simple Timer";
            this.TableofTimer.ResumeLayout(false);
            this.TableofTimer.PerformLayout();
            this.TableOfButons.ResumeLayout(false);
            this.TableOfColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWithName;
        private System.Windows.Forms.TableLayoutPanel TableofTimer;
        private System.Windows.Forms.Label HunSecondsTable;
        private System.Windows.Forms.Label SecondsTable;
        private System.Windows.Forms.Label MinutesTable;
        private System.Windows.Forms.Label HoursTable;
        private System.Windows.Forms.TableLayoutPanel TableOfButons;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TableLayoutPanel TableOfColors;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Timer timer1;
    }
}

