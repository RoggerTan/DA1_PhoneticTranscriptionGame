using echo_main.user_controls.custom_controls;

namespace echo_main.user_controls.playscene
{
    partial class TimePlayScene
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
            this.components = new System.ComponentModel.Container();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_count = new System.Windows.Forms.Label();
            this.pnl_timer = new System.Windows.Forms.Panel();
            this.lbl_addition = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.pnl_middle = new System.Windows.Forms.Panel();
            this.lbl_word = new System.Windows.Forms.Label();
            this.ttb_answer = new echo_main.user_controls.custom_controls.UnderlineTextbox();
            this.btn_finish = new echo_main.user_controls.custom_controls.RoundButton();
            this.pnl_volumeIndicator = new System.Windows.Forms.Panel();
            this.pnl_check = new System.Windows.Forms.Panel();
            this.tmr_timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_main.SuspendLayout();
            this.pnl_timer.SuspendLayout();
            this.pnl_middle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.lbl_count);
            this.pnl_main.Controls.Add(this.pnl_timer);
            this.pnl_main.Controls.Add(this.pnl_middle);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1042, 613);
            this.pnl_main.TabIndex = 1;
            this.pnl_main.Resize += new System.EventHandler(this.pnl_main_Resize);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this.lbl_count.Location = new System.Drawing.Point(494, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(54, 65);
            this.lbl_count.TabIndex = 11;
            this.lbl_count.Text = "0";
            // 
            // pnl_timer
            // 
            this.pnl_timer.Controls.Add(this.lbl_addition);
            this.pnl_timer.Controls.Add(this.lbl_timer);
            this.pnl_timer.Location = new System.Drawing.Point(751, 222);
            this.pnl_timer.Name = "pnl_timer";
            this.pnl_timer.Size = new System.Drawing.Size(291, 388);
            this.pnl_timer.TabIndex = 11;
            // 
            // lbl_addition
            // 
            this.lbl_addition.AutoSize = true;
            this.lbl_addition.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.lbl_addition.Location = new System.Drawing.Point(203, 245);
            this.lbl_addition.Name = "lbl_addition";
            this.lbl_addition.Size = new System.Drawing.Size(59, 45);
            this.lbl_addition.TabIndex = 10;
            this.lbl_addition.Text = "+5";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this.lbl_timer.Location = new System.Drawing.Point(7, 260);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(284, 128);
            this.lbl_timer.TabIndex = 9;
            this.lbl_timer.Text = "2 : 15";
            // 
            // pnl_middle
            // 
            this.pnl_middle.Controls.Add(this.lbl_word);
            this.pnl_middle.Controls.Add(this.ttb_answer);
            this.pnl_middle.Controls.Add(this.btn_finish);
            this.pnl_middle.Controls.Add(this.pnl_volumeIndicator);
            this.pnl_middle.Controls.Add(this.pnl_check);
            this.pnl_middle.Location = new System.Drawing.Point(344, 113);
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
            this.ttb_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.ttb_answer.CaretPosition = 0;
            this.ttb_answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_answer.IsPassword = false;
            this.ttb_answer.Location = new System.Drawing.Point(15, 97);
            this.ttb_answer.Name = "ttb_answer";
            this.ttb_answer.Size = new System.Drawing.Size(299, 38);
            this.ttb_answer.TabIndex = 7;
            this.ttb_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttb_answer.TextBoxText = "";
            this.ttb_answer.TextColor = System.Drawing.Color.White;
            this.ttb_answer.UnderlineColor = System.Drawing.Color.White;
            this.ttb_answer.EnterKeyDown += new System.EventHandler(this.btn_finish_Click);
            this.ttb_answer.LeftAltKeyDown += new System.EventHandler(this.ttb_answer_LeftAltKeyDown);
            this.ttb_answer.RightAltKeyDown += new System.EventHandler(this.ttb_answer_RightAltKeyDown);
            this.ttb_answer.UpAltKeyDown += new System.EventHandler(this.ttb_answer_UpAltKeyDown);
            this.ttb_answer.DownAltKeyDown += new System.EventHandler(this.ttb_answer_DownAltKeyDown);
            this.ttb_answer.AltKeyDown += new System.EventHandler(this.ttb_answer_AltKeyDown);
            this.ttb_answer.AltKeyUp += new System.EventHandler(this.ttb_answer_AltKeyUp);
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.btn_finish.ButtonText = "Xong!";
            this.btn_finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
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
            // tmr_timer
            // 
            this.tmr_timer.Enabled = true;
            this.tmr_timer.Interval = 1000;
            this.tmr_timer.Tick += new System.EventHandler(this.tmr_timer_Tick);
            // 
            // TimePlayScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.pnl_main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimePlayScene";
            this.Size = new System.Drawing.Size(1042, 613);
            this.Load += new System.EventHandler(this.TimePlayScene_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_timer.ResumeLayout(false);
            this.pnl_timer.PerformLayout();
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
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Panel pnl_timer;
        private System.Windows.Forms.Label lbl_addition;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Timer tmr_timer;
    }
}
