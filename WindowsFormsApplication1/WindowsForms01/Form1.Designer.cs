namespace WindowsForms01
{
    partial class m_test
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
            this.components = new System.ComponentModel.Container();
            this.m_testButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_statusLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // m_testButton
            // 
            this.m_testButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.m_testButton.Font = new System.Drawing.Font("SketchFlow Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_testButton.Location = new System.Drawing.Point(187, 29);
            this.m_testButton.Name = "m_testButton";
            this.m_testButton.Size = new System.Drawing.Size(166, 63);
            this.m_testButton.TabIndex = 0;
            this.m_testButton.Text = "COUCOU ";
            this.m_testButton.UseVisualStyleBackColor = false;
            this.m_testButton.Click += new System.EventHandler(this.m_testButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Museo Sans For Dell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.m_TestButton2);
            // 
            // m_statusLabel
            // 
            this.m_statusLabel.Location = new System.Drawing.Point(284, 533);
            this.m_statusLabel.Name = "m_statusLabel";
            this.m_statusLabel.Size = new System.Drawing.Size(114, 13);
            this.m_statusLabel.TabIndex = 2;
            this.m_statusLabel.Text = "\"aucun bouton cliqué\"";
            this.m_statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(243, 309);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(475, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // m_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(732, 555);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.m_statusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_testButton);
            this.Name = "m_test";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_test_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_testButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label m_statusLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}

