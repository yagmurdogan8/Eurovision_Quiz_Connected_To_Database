
namespace ProgrammingLanguageConceptsA4
{
    partial class Question2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlQ2 = new System.Windows.Forms.Panel();
            this.pnlA2 = new System.Windows.Forms.Panel();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.pnlQ2.SuspendLayout();
            this.pnlA2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQ2
            // 
            this.pnlQ2.Controls.Add(this.pnlA2);
            this.pnlQ2.Controls.Add(this.lblQ2);
            this.pnlQ2.Location = new System.Drawing.Point(3, 12);
            this.pnlQ2.Name = "pnlQ2";
            this.pnlQ2.Size = new System.Drawing.Size(780, 392);
            this.pnlQ2.TabIndex = 4;
            this.pnlQ2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQ2_Paint);
            // 
            // pnlA2
            // 
            this.pnlA2.Controls.Add(this.rdTrue);
            this.pnlA2.Controls.Add(this.rdFalse);
            this.pnlA2.Location = new System.Drawing.Point(19, 64);
            this.pnlA2.Name = "pnlA2";
            this.pnlA2.Size = new System.Drawing.Size(489, 136);
            this.pnlA2.TabIndex = 4;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrue.ForeColor = System.Drawing.Color.Navy;
            this.rdTrue.Location = new System.Drawing.Point(29, 18);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(63, 21);
            this.rdTrue.TabIndex = 3;
            this.rdTrue.TabStop = true;
            this.rdTrue.Text = "True";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFalse.ForeColor = System.Drawing.Color.Navy;
            this.rdFalse.Location = new System.Drawing.Point(29, 56);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(67, 21);
            this.rdFalse.TabIndex = 0;
            this.rdFalse.TabStop = true;
            this.rdFalse.Text = "False";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.ForeColor = System.Drawing.Color.Navy;
            this.lblQ2.Location = new System.Drawing.Point(15, 18);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(484, 20);
            this.lblQ2.TabIndex = 3;
            this.lblQ2.Text = "Céline Dion represented Switzerland in Eurovision 1988.";
            // 
            // Question2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQ2);
            this.Name = "Question2";
            this.Size = new System.Drawing.Size(791, 415);
            this.pnlQ2.ResumeLayout(false);
            this.pnlQ2.PerformLayout();
            this.pnlA2.ResumeLayout(false);
            this.pnlA2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQ2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Panel pnlA2;
        private System.Windows.Forms.RadioButton rdTrue;
        private System.Windows.Forms.RadioButton rdFalse;
    }
}
