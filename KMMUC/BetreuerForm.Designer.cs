namespace KMMUC
{
    partial class BetreuerForm
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
            this.dataGridViewÄrzte = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchwestern = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÄrzte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchwestern)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewÄrzte
            // 
            this.dataGridViewÄrzte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÄrzte.Location = new System.Drawing.Point(15, 37);
            this.dataGridViewÄrzte.Name = "dataGridViewÄrzte";
            this.dataGridViewÄrzte.RowTemplate.Height = 28;
            this.dataGridViewÄrzte.Size = new System.Drawing.Size(1081, 315);
            this.dataGridViewÄrzte.TabIndex = 0;
            this.dataGridViewÄrzte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewÄrzte_MouseDoubleClick);
            // 
            // dataGridViewSchwestern
            // 
            this.dataGridViewSchwestern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchwestern.Location = new System.Drawing.Point(15, 391);
            this.dataGridViewSchwestern.Name = "dataGridViewSchwestern";
            this.dataGridViewSchwestern.RowTemplate.Height = 28;
            this.dataGridViewSchwestern.Size = new System.Drawing.Size(1081, 364);
            this.dataGridViewSchwestern.TabIndex = 1;
            this.dataGridViewSchwestern.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSchwestern_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ärzte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Schwestern";
            // 
            // BetreuerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSchwestern);
            this.Controls.Add(this.dataGridViewÄrzte);
            this.Name = "BetreuerForm";
            this.Text = "BetreuerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÄrzte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchwestern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewÄrzte;
        private System.Windows.Forms.DataGridView dataGridViewSchwestern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}