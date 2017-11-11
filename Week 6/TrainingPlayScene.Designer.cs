using echo_main.user_controls.custom_controls;

namespace echo_main.user_controls.playscene
{
    partial class TrainingPlayScene
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_middle = new System.Windows.Forms.Panel();
            this.lbl_word = new System.Windows.Forms.Label();
            this.ttb_answer = new UnderlineTextbox();
            this.btn_finish = new RoundButton();
            this.pnl_volumeIndicator = new System.Windows.Forms.Panel();
            this.pnl_check = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.pnl_middle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_middle);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1042, 489);
            this.pnl_main.TabIndex = 1;
            this.pnl_main.Resize += new System.EventHandler(this.pnl_main_Resize);
            // 
            // pnl_middle
            // 
            this.pnl_middle.Controls.Add(this.lbl_word);
            this.pnl_middle.Controls.Add(this.ttb_answer);
            this.pnl_middle.Controls.Add(this.btn_finish);
            this.pnl_middle.Controls.Add(this.pnl_volumeIndicator);
            this.pnl_middle.Controls.Add(this.pnl_check);
            this.pnl_middle.Location = new System.Drawing.Point(344, 3);
            this.pnl_middle.Name = "pnl_middle";
            this.pnl_middle.Size = new System.Drawing.Size(371, 497);
            this.pnl_middle.TabIndex = 4;
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.ForeColor = System.Drawing.Color.White;
            this.lbl_word.Location = new System.Drawing.Point(96, 0);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(172, 65);
            this.lbl_word.TabIndex = 8;
            this.lbl_word.Text = "{Word}";
            this.lbl_word.Resize += new System.EventHandler(this.lbl_word_Resize);
            // 
            // ttb_answer
            // 
            this.ttb_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.ttb_answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_answer.Location = new System.Drawing.Point(15, 97);
            this.ttb_answer.Name = "ttb_answer";
            this.ttb_answer.Size = new System.Drawing.Size(339, 38);
            this.ttb_answer.TabIndex = 7;
            this.ttb_answer.TextBoxText = "";
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.btn_finish.ButtonText = "Xong!";
            this.btn_finish.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.btn_finish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.Location = new System.Drawing.Point(193, 158);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(161, 56);
            this.btn_finish.TabIndex = 6;
            // 
            // pnl_volumeIndicator
            // 
            this.pnl_volumeIndicator.Location = new System.Drawing.Point(15, 143);
            this.pnl_volumeIndicator.Name = "pnl_volumeIndicator";
            this.pnl_volumeIndicator.Size = new System.Drawing.Size(146, 86);
            this.pnl_volumeIndicator.TabIndex = 5;
            // 
            // pnl_check
            // 
            this.pnl_check.Location = new System.Drawing.Point(73, 255);
            this.pnl_check.Name = "pnl_check";
            this.pnl_check.Size = new System.Drawing.Size(219, 219);
            this.pnl_check.TabIndex = 4;
            // 
            // TrainingPlayScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.pnl_main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TrainingPlayScene";
            this.Size = new System.Drawing.Size(1042, 489);
            this.Load += new System.EventHandler(this.TrainingPlayScene_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_middle.ResumeLayout(false);
            this.pnl_middle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_middle;
        private UnderlineTextbox ttb_answer;
        private RoundButton btn_finish;
        private System.Windows.Forms.Panel pnl_volumeIndicator;
        private System.Windows.Forms.Panel pnl_check;
        private System.Windows.Forms.Label lbl_word;
    }
}
