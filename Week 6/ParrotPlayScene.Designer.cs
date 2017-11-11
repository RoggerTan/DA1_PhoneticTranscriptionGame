namespace echo_main.user_controls.playscene
{
    partial class ParrotPlayScene
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
            this.spl_main = new System.Windows.Forms.SplitContainer();
            this.pnl_parrot = new System.Windows.Forms.Panel();
            this.spl_MidRight = new System.Windows.Forms.SplitContainer();
            this.pnl_mid = new System.Windows.Forms.Panel();
            this.lbl_word = new System.Windows.Forms.Label();
            this.ttb_answer = new echo_main.user_controls.custom_controls.UnderlineTextbox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_finish = new echo_main.user_controls.custom_controls.RoundButton();
            this.pnl_volumeIndicator = new System.Windows.Forms.Panel();
            this.pnl_check = new System.Windows.Forms.Panel();
            this.pnl_splitter = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_blueCheck = new System.Windows.Forms.Panel();
            this.lbl_rightTitle = new System.Windows.Forms.Label();
            this.ttb_keyword = new echo_main.user_controls.custom_controls.UnderlineTextbox();
            this.tmr_blink = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spl_main)).BeginInit();
            this.spl_main.Panel1.SuspendLayout();
            this.spl_main.Panel2.SuspendLayout();
            this.spl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_MidRight)).BeginInit();
            this.spl_MidRight.Panel1.SuspendLayout();
            this.spl_MidRight.Panel2.SuspendLayout();
            this.spl_MidRight.SuspendLayout();
            this.pnl_mid.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // spl_main
            // 
            this.spl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_main.IsSplitterFixed = true;
            this.spl_main.Location = new System.Drawing.Point(0, 0);
            this.spl_main.Name = "spl_main";
            // 
            // spl_main.Panel1
            // 
            this.spl_main.Panel1.Controls.Add(this.pnl_parrot);
            // 
            // spl_main.Panel2
            // 
            this.spl_main.Panel2.Controls.Add(this.spl_MidRight);
            this.spl_main.Size = new System.Drawing.Size(1042, 613);
            this.spl_main.SplitterDistance = 334;
            this.spl_main.SplitterWidth = 1;
            this.spl_main.TabIndex = 0;
            // 
            // pnl_parrot
            // 
            this.pnl_parrot.Location = new System.Drawing.Point(3, 100);
            this.pnl_parrot.Name = "pnl_parrot";
            this.pnl_parrot.Size = new System.Drawing.Size(326, 329);
            this.pnl_parrot.TabIndex = 0;
            // 
            // spl_MidRight
            // 
            this.spl_MidRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_MidRight.IsSplitterFixed = true;
            this.spl_MidRight.Location = new System.Drawing.Point(0, 0);
            this.spl_MidRight.Name = "spl_MidRight";
            // 
            // spl_MidRight.Panel1
            // 
            this.spl_MidRight.Panel1.Controls.Add(this.pnl_mid);
            // 
            // spl_MidRight.Panel2
            // 
            this.spl_MidRight.Panel2.Controls.Add(this.pnl_splitter);
            this.spl_MidRight.Panel2.Controls.Add(this.pnl_right);
            this.spl_MidRight.Size = new System.Drawing.Size(707, 613);
            this.spl_MidRight.SplitterDistance = 403;
            this.spl_MidRight.SplitterWidth = 1;
            this.spl_MidRight.TabIndex = 0;
            // 
            // pnl_mid
            // 
            this.pnl_mid.Controls.Add(this.lbl_word);
            this.pnl_mid.Controls.Add(this.ttb_answer);
            this.pnl_mid.Controls.Add(this.pnl_buttons);
            this.pnl_mid.Controls.Add(this.pnl_check);
            this.pnl_mid.Location = new System.Drawing.Point(13, 3);
            this.pnl_mid.Name = "pnl_mid";
            this.pnl_mid.Size = new System.Drawing.Size(386, 491);
            this.pnl_mid.TabIndex = 0;
            this.pnl_mid.Resize += new System.EventHandler(this.pnl_mid_Resize);
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.ForeColor = System.Drawing.Color.White;
            this.lbl_word.Location = new System.Drawing.Point(104, 0);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(172, 65);
            this.lbl_word.TabIndex = 18;
            this.lbl_word.Text = "{Word}";
            this.lbl_word.Resize += new System.EventHandler(this.lbl_word_Resize);
            // 
            // ttb_answer
            // 
            this.ttb_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.ttb_answer.CaretPosition = 0;
            this.ttb_answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_answer.IsPassword = false;
            this.ttb_answer.Location = new System.Drawing.Point(3, 97);
            this.ttb_answer.Name = "ttb_answer";
            this.ttb_answer.Size = new System.Drawing.Size(328, 38);
            this.ttb_answer.TabIndex = 17;
            this.ttb_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttb_answer.TextBoxText = "";
            this.ttb_answer.TextColor = System.Drawing.Color.White;
            this.ttb_answer.UnderlineColor = System.Drawing.Color.White;
            this.ttb_answer.LeftAltKeyDown += new System.EventHandler(this.ttb_answer_LeftAltKeyDown);
            this.ttb_answer.RightAltKeyDown += new System.EventHandler(this.ttb_answer_RightAltKeyDown);
            this.ttb_answer.UpAltKeyDown += new System.EventHandler(this.ttb_answer_UpAltKeyDown);
            this.ttb_answer.DownAltKeyDown += new System.EventHandler(this.ttb_answer_DownAltKeyDown);
            this.ttb_answer.AltKeyDown += new System.EventHandler(this.ttb_answer_AltKeyDown);
            this.ttb_answer.AltKeyUp += new System.EventHandler(this.ttb_answer_AltKeyUp);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_finish);
            this.pnl_buttons.Controls.Add(this.pnl_volumeIndicator);
            this.pnl_buttons.Location = new System.Drawing.Point(15, 141);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(348, 100);
            this.pnl_buttons.TabIndex = 19;
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btn_finish.ButtonText = "Xong!";
            this.btn_finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btn_finish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.Location = new System.Drawing.Point(175, 13);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(161, 56);
            this.btn_finish.TabIndex = 16;
            // 
            // pnl_volumeIndicator
            // 
            this.pnl_volumeIndicator.Location = new System.Drawing.Point(13, 0);
            this.pnl_volumeIndicator.Name = "pnl_volumeIndicator";
            this.pnl_volumeIndicator.Size = new System.Drawing.Size(146, 86);
            this.pnl_volumeIndicator.TabIndex = 15;
            // 
            // pnl_check
            // 
            this.pnl_check.Location = new System.Drawing.Point(81, 247);
            this.pnl_check.Name = "pnl_check";
            this.pnl_check.Size = new System.Drawing.Size(219, 219);
            this.pnl_check.TabIndex = 14;
            // 
            // pnl_splitter
            // 
            this.pnl_splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.pnl_splitter.Location = new System.Drawing.Point(3, 64);
            this.pnl_splitter.Name = "pnl_splitter";
            this.pnl_splitter.Size = new System.Drawing.Size(5, 430);
            this.pnl_splitter.TabIndex = 1;
            // 
            // pnl_right
            // 
            this.pnl_right.Controls.Add(this.pnl_blueCheck);
            this.pnl_right.Controls.Add(this.lbl_rightTitle);
            this.pnl_right.Controls.Add(this.ttb_keyword);
            this.pnl_right.Location = new System.Drawing.Point(17, 212);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(276, 386);
            this.pnl_right.TabIndex = 0;
            this.pnl_right.Resize += new System.EventHandler(this.pnl_right_Resize);
            // 
            // pnl_blueCheck
            // 
            this.pnl_blueCheck.Location = new System.Drawing.Point(0, 129);
            this.pnl_blueCheck.Name = "pnl_blueCheck";
            this.pnl_blueCheck.Size = new System.Drawing.Size(276, 276);
            this.pnl_blueCheck.TabIndex = 15;
            // 
            // lbl_rightTitle
            // 
            this.lbl_rightTitle.AutoSize = true;
            this.lbl_rightTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_rightTitle.Location = new System.Drawing.Point(83, 4);
            this.lbl_rightTitle.Name = "lbl_rightTitle";
            this.lbl_rightTitle.Size = new System.Drawing.Size(116, 40);
            this.lbl_rightTitle.TabIndex = 17;
            this.lbl_rightTitle.Text = "Mật mã";
            // 
            // ttb_keyword
            // 
            this.ttb_keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.ttb_keyword.CaretPosition = 0;
            this.ttb_keyword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_keyword.IsPassword = false;
            this.ttb_keyword.Location = new System.Drawing.Point(3, 85);
            this.ttb_keyword.Name = "ttb_keyword";
            this.ttb_keyword.Size = new System.Drawing.Size(270, 38);
            this.ttb_keyword.TabIndex = 16;
            this.ttb_keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttb_keyword.TextBoxText = "";
            this.ttb_keyword.TextColor = System.Drawing.Color.White;
            this.ttb_keyword.UnderlineColor = System.Drawing.Color.White;
            // 
            // tmr_blink
            // 
            this.tmr_blink.Enabled = true;
            this.tmr_blink.Interval = 5000;
            this.tmr_blink.Tick += new System.EventHandler(this.tmr_blink_Tick);
            // 
            // ParrotPlayScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.spl_main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ParrotPlayScene";
            this.Size = new System.Drawing.Size(1042, 613);
            this.Load += new System.EventHandler(this.ParrotPlayScene_Load);
            this.Resize += new System.EventHandler(this.ParrotPlayScene_Resize);
            this.spl_main.Panel1.ResumeLayout(false);
            this.spl_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_main)).EndInit();
            this.spl_main.ResumeLayout(false);
            this.spl_MidRight.Panel1.ResumeLayout(false);
            this.spl_MidRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_MidRight)).EndInit();
            this.spl_MidRight.ResumeLayout(false);
            this.pnl_mid.ResumeLayout(false);
            this.pnl_mid.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_right.ResumeLayout(false);
            this.pnl_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl_main;
        private System.Windows.Forms.Panel pnl_parrot;
        private System.Windows.Forms.SplitContainer spl_MidRight;
        private System.Windows.Forms.Panel pnl_mid;
        private System.Windows.Forms.Label lbl_word;
        private custom_controls.UnderlineTextbox ttb_answer;
        private custom_controls.RoundButton btn_finish;
        private System.Windows.Forms.Panel pnl_volumeIndicator;
        private System.Windows.Forms.Panel pnl_check;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Label lbl_rightTitle;
        private custom_controls.UnderlineTextbox ttb_keyword;
        private System.Windows.Forms.Panel pnl_splitter;
        private System.Windows.Forms.Timer tmr_blink;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel pnl_blueCheck;
    }
}
