
namespace ProgrammingLanguageConceptsA4
{
    partial class Question3
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
            this.pnlQ3 = new System.Windows.Forms.Panel();
            this.pnlA3 = new System.Windows.Forms.Panel();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.pnlQ3.SuspendLayout();
            this.pnlA3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQ3
            // 
            this.pnlQ3.Controls.Add(this.pnlA3);
            this.pnlQ3.Controls.Add(this.lblQ3);
            this.pnlQ3.Location = new System.Drawing.Point(13, 21);
            this.pnlQ3.Name = "pnlQ3";
            this.pnlQ3.Size = new System.Drawing.Size(787, 379);
            this.pnlQ3.TabIndex = 5;
            // 
            // pnlA3
            // 
            this.pnlA3.Controls.Add(this.txtQ3);
            this.pnlA3.Location = new System.Drawing.Point(10, 64);
            this.pnlA3.Name = "pnlA3";
            this.pnlA3.Size = new System.Drawing.Size(489, 136);
            this.pnlA3.TabIndex = 4;
            // 
            // txtQ3
            // 
            this.txtQ3.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ3.ForeColor = System.Drawing.Color.Navy;
            this.txtQ3.Location = new System.Drawing.Point(9, 23);
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(469, 28);
            this.txtQ3.TabIndex = 0;
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3.ForeColor = System.Drawing.Color.Navy;
            this.lblQ3.Location = new System.Drawing.Point(15, 18);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(576, 20);
            this.lblQ3.TabIndex = 3;
            this.lblQ3.Text = "Which year was the first time that Turkey participate in Eurovision?";
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQ3);
            this.Name = "Question3";
            this.Size = new System.Drawing.Size(829, 506);
            this.Load += new System.EventHandler(this.Question3_Load);
            this.pnlQ3.ResumeLayout(false);
            this.pnlQ3.PerformLayout();
            this.pnlA3.ResumeLayout(false);
            this.pnlA3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQ3;
        private System.Windows.Forms.Panel pnlA3;
        private System.Windows.Forms.TextBox txtQ3;
        private System.Windows.Forms.Label lblQ3;
    }
}
