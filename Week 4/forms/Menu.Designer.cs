using echo_main.user_controls.custom_controls;

namespace echo_main.forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.ptb_word = new System.Windows.Forms.PictureBox();
            this.lbl_headphone = new System.Windows.Forms.Label();
            this.ptb_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.ttb_def = new System.Windows.Forms.TextBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_word = new System.Windows.Forms.Label();
            this.pnl_message_arrow = new System.Windows.Forms.Panel();
            this.lbl_phonetic = new System.Windows.Forms.Label();
            this.ptb_triangle2 = new System.Windows.Forms.PictureBox();
            this.pnl_dict = new System.Windows.Forms.Panel();
            this.vertical_button2 = new echo_main.user_controls.custom_controls.VerticalButton();
            this.vertical_button1 = new echo_main.user_controls.custom_controls.VerticalButton();
            this.menu_light2 = new echo_main.user_controls.custom_controls.MenuLight();
            this.menu_light1 = new echo_main.user_controls.custom_controls.MenuLight();
            this.menu_dark1 = new echo_main.user_controls.custom_controls.MenuDark();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_triangle2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Image = global::echo_main.Properties.Resources.logo_with_pen;
            this.ptb_logo.Location = new System.Drawing.Point(33, 12);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(496, 187);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            this.ptb_logo.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ptb_word
            // 
            this.ptb_word.BackColor = System.Drawing.Color.Transparent;
            this.ptb_word.Image = global::echo_main.Properties.Resources.new_word;
            this.ptb_word.Location = new System.Drawing.Point(12, 218);
            this.ptb_word.Name = "ptb_word";
            this.ptb_word.Size = new System.Drawing.Size(532, 203);
            this.ptb_word.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_word.TabIndex = 1;
            this.ptb_word.TabStop = false;
            this.ptb_word.Click += new System.EventHandler(this.Menu_Click);
            // 
            // lbl_headphone
            // 
            this.lbl_headphone.AutoSize = true;
            this.lbl_headphone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_headphone.ForeColor = System.Drawing.Color.White;
            this.lbl_headphone.Location = new System.Drawing.Point(605, 479);
            this.lbl_headphone.Name = "lbl_headphone";
            this.lbl_headphone.Size = new System.Drawing.Size(252, 21);
            this.lbl_headphone.TabIndex = 7;
            this.lbl_headphone.Text = "Trải nghiệm tốt hơn khi có tai nghe";
            // 
            // ptb_avatar
            // 
            this.ptb_avatar.BackColor = System.Drawing.Color.Transparent;
            this.ptb_avatar.Image = global::echo_main.Properties.Resources.avatar_default;
            this.ptb_avatar.Location = new System.Drawing.Point(737, 5);
            this.ptb_avatar.Name = "ptb_avatar";
            this.ptb_avatar.Size = new System.Drawing.Size(124, 124);
            this.ptb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avatar.TabIndex = 8;
            this.ptb_avatar.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(717, 132);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(144, 32);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "Đăng nhập?";
            // 
            // ttb_def
            // 
            this.ttb_def.BackColor = System.Drawing.Color.White;
            this.ttb_def.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttb_def.Enabled = false;
            this.ttb_def.ForeColor = System.Drawing.Color.Black;
            this.ttb_def.Location = new System.Drawing.Point(33, 303);
            this.ttb_def.Multiline = true;
            this.ttb_def.Name = "ttb_def";
            this.ttb_def.Size = new System.Drawing.Size(496, 102);
            this.ttb_def.TabIndex = 10;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.White;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this.lbl_header.Location = new System.Drawing.Point(27, 232);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(197, 32);
            this.lbl_header.TabIndex = 11;
            this.lbl_header.Text = "Từ mới mỗi ngày";
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.BackColor = System.Drawing.Color.White;
            this.lbl_word.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.ForeColor = System.Drawing.Color.Black;
            this.lbl_word.Location = new System.Drawing.Point(27, 265);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(82, 32);
            this.lbl_word.TabIndex = 12;
            this.lbl_word.Text = "{word}";
            // 
            // pnl_message_arrow
            // 
            this.pnl_message_arrow.BackColor = System.Drawing.Color.White;
            this.pnl_message_arrow.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_message_arrow.Location = new System.Drawing.Point(474, 352);
            this.pnl_message_arrow.Name = "pnl_message_arrow";
            this.pnl_message_arrow.Size = new System.Drawing.Size(44, 44);
            this.pnl_message_arrow.TabIndex = 13;
            // 
            // lbl_phonetic
            // 
            this.lbl_phonetic.AutoSize = true;
            this.lbl_phonetic.BackColor = System.Drawing.Color.White;
            this.lbl_phonetic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phonetic.ForeColor = System.Drawing.Color.Black;
            this.lbl_phonetic.Location = new System.Drawing.Point(115, 265);
            this.lbl_phonetic.Name = "lbl_phonetic";
            this.lbl_phonetic.Size = new System.Drawing.Size(123, 32);
            this.lbl_phonetic.TabIndex = 14;
            this.lbl_phonetic.Text = "{phonetic}";
            // 
            // ptb_triangle2
            // 
            this.ptb_triangle2.BackColor = System.Drawing.Color.Transparent;
            this.ptb_triangle2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_triangle2.Image")));
            this.ptb_triangle2.Location = new System.Drawing.Point(12, 0);
            this.ptb_triangle2.Name = "ptb_triangle2";
            this.ptb_triangle2.Size = new System.Drawing.Size(42, 42);
            this.ptb_triangle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_triangle2.TabIndex = 16;
            this.ptb_triangle2.TabStop = false;
            // 
            // pnl_dict
            // 
            this.pnl_dict.BackColor = System.Drawing.Color.White;
            this.pnl_dict.Location = new System.Drawing.Point(867, 0);
            this.pnl_dict.Name = "pnl_dict";
            this.pnl_dict.Size = new System.Drawing.Size(362, 511);
            this.pnl_dict.TabIndex = 17;
            // 
            // vertical_button2
            // 
            this.vertical_button2.BackColor = System.Drawing.Color.Transparent;
            this.vertical_button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vertical_button2.Location = new System.Drawing.Point(107, 447);
            this.vertical_button2.Margin = new System.Windows.Forms.Padding(6);
            this.vertical_button2.Name = "vertical_button2";
            this.vertical_button2.Size = new System.Drawing.Size(89, 219);
            this.vertical_button2.TabIndex = 6;
            this.vertical_button2.Title = "S";
            // 
            // vertical_button1
            // 
            this.vertical_button1.BackColor = System.Drawing.Color.Transparent;
            this.vertical_button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vertical_button1.Location = new System.Drawing.Point(12, 447);
            this.vertical_button1.Margin = new System.Windows.Forms.Padding(6);
            this.vertical_button1.Name = "vertical_button1";
            this.vertical_button1.Size = new System.Drawing.Size(89, 219);
            this.vertical_button1.TabIndex = 5;
            this.vertical_button1.Title = "A";
            // 
            // menu_light2
            // 
            this.menu_light2.BackColor = System.Drawing.Color.Transparent;
            this.menu_light2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_light2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_light2.Location = new System.Drawing.Point(649, 352);
            this.menu_light2.Margin = new System.Windows.Forms.Padding(6);
            this.menu_light2.Name = "menu_light2";
            this.menu_light2.Size = new System.Drawing.Size(289, 53);
            this.menu_light2.TabIndex = 4;
            this.menu_light2.Title = "Trợ giúp";
            this.menu_light2.XAlias = 58;
            // 
            // menu_light1
            // 
            this.menu_light1.BackColor = System.Drawing.Color.Transparent;
            this.menu_light1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_light1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_light1.Location = new System.Drawing.Point(603, 292);
            this.menu_light1.Margin = new System.Windows.Forms.Padding(6);
            this.menu_light1.Name = "menu_light1";
            this.menu_light1.Size = new System.Drawing.Size(313, 53);
            this.menu_light1.TabIndex = 3;
            this.menu_light1.Title = "Từ điển Anh-Việt";
            this.menu_light1.XAlias = 26;
            this.menu_light1.ButtonClick += new System.EventHandler(this.menu_light1_ButtonClick);
            // 
            // menu_dark1
            // 
            this.menu_dark1.BackColor = System.Drawing.Color.Transparent;
            this.menu_dark1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_dark1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_dark1.Location = new System.Drawing.Point(562, 234);
            this.menu_dark1.Margin = new System.Windows.Forms.Padding(6);
            this.menu_dark1.Name = "menu_dark1";
            this.menu_dark1.Size = new System.Drawing.Size(354, 53);
            this.menu_dark1.TabIndex = 2;
            this.menu_dark1.Title = "Bắt đầu chơi";
            this.menu_dark1.XAlias = 85;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::echo_main.Properties.Resources.england_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 509);
            this.Controls.Add(this.pnl_dict);
            this.Controls.Add(this.lbl_phonetic);
            this.Controls.Add(this.pnl_message_arrow);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.ttb_def);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.ptb_avatar);
            this.Controls.Add(this.lbl_headphone);
            this.Controls.Add(this.vertical_button2);
            this.Controls.Add(this.vertical_button1);
            this.Controls.Add(this.menu_light2);
            this.Controls.Add(this.menu_light1);
            this.Controls.Add(this.menu_dark1);
            this.Controls.Add(this.ptb_word);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.ptb_triangle2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(807, 453);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Click += new System.EventHandler(this.Menu_Click);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_triangle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.PictureBox ptb_word;
        private MenuDark menu_dark1;
        private MenuLight menu_light1;
        private MenuLight menu_light2;
        private VerticalButton vertical_button1;
        private VerticalButton vertical_button2;
        private System.Windows.Forms.Label lbl_headphone;
        private System.Windows.Forms.PictureBox ptb_avatar;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox ttb_def;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Panel pnl_message_arrow;
        private System.Windows.Forms.Label lbl_phonetic;
        private System.Windows.Forms.PictureBox ptb_triangle2;
        private System.Windows.Forms.Panel pnl_dict;
    }
}

