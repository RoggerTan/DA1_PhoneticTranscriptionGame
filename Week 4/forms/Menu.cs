using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using echo_main.BS_layer.Func;
using echo_main.res;
using echo_main.user_controls.custom_controls;

namespace echo_main.forms
{
    public partial class Menu : Form
    {
        private int _oldWidth;
        private int _oldHeight;
        private (string word, string phonetic, string meaning) _rndWord;
        private readonly Font _bigFont;
        private readonly Font _biggerFont;
        private readonly Font _smallFont;
        private MusicBar _musicBar;
        private PictureBox[] _arrTriangle;
        private DictSidebar _dictSidebar;
        private bool _isDictHide = true;

        public Menu()
        {
            InitializeComponent();

            _oldWidth = Width;
            _oldHeight = Height;
            _bigFont = new Font(ttb_def.Font.FontFamily, 20);
            _biggerFont = new Font(ttb_def.Font.FontFamily, 30);
            _smallFont = new Font(ttb_def.Font.FontFamily, 12);
            var tmp = FuncInitialize.brw_initialize(Info.current_dir + "/animate/message_arrow.html");

            tmp.Dock = DockStyle.Fill;
            tmp.Tag = new EventHandler(Arrow_Click);
            tmp.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            pnl_message_arrow.Controls.Add(tmp);
            tmp.Visible = true;
        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                _rndWord = FuncDict.get_random_word().Result;
                lbl_word.Text = _rndWord.word;
                lbl_phonetic.Text = _rndWord.phonetic;
                ttb_def.Text = _rndWord.meaning;
                lbl_phonetic.Location = new Point(lbl_word.Location.X + lbl_word.Width, lbl_word.Location.Y);
            }));
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Persistent.FrmEngland.Close();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized || _oldWidth != 0 && _oldWidth == Width && _oldHeight == Height) return;
            var changeWidth = Width - _oldWidth;
            var changeHeight = Height - _oldHeight;
            var halfChangeWidth = changeWidth / 2;
            var halfChangeHeight = changeHeight / 2;
            _oldWidth = Width;
            _oldHeight = Height;
            SuspendLayout();
            //Logo
            //ptb_logo.Width += change_width;
            //ptb_logo.Height += change_height;

            //picturebox
            ptb_word.Width += changeWidth;
            ptb_word.Height += changeHeight;
            ptb_avatar.Width += halfChangeHeight / 2;
            ptb_avatar.Height += halfChangeHeight / 2;
            ptb_avatar.Location = new Point(Width - ptb_avatar.Width - 21, ptb_avatar.Location.Y);
            ptb_logo.Location = new Point(ptb_logo.Location.X + halfChangeWidth, ptb_logo.Location.Y);

            //buttons
            menu_dark1.Location = new Point(menu_dark1.Location.X + changeWidth, menu_dark1.Location.Y + halfChangeHeight);
            menu_light1.Location = new Point(menu_light1.Location.X + changeWidth, menu_light1.Location.Y + halfChangeHeight);
            menu_light2.Location = new Point(menu_light2.Location.X + changeWidth, menu_light2.Location.Y + halfChangeHeight);
            vertical_button1.Location = new Point(vertical_button1.Location.X, vertical_button1.Location.Y + changeHeight);
            vertical_button2.Location = new Point(vertical_button2.Location.X, vertical_button2.Location.Y + changeHeight);

            //label
            lbl_headphone.Location = new Point(lbl_headphone.Location.X + changeWidth, lbl_headphone.Location.Y + changeHeight);
            lbl_login.Location = new Point(lbl_login.Location.X + changeWidth, ptb_avatar.Height + ptb_avatar.Location.Y + 3);
            lbl_header.Location = new Point(lbl_header.Location.X + halfChangeWidth / 6, lbl_header.Location.Y);
            var ttb_def_width = ptb_word.Width - 36 - halfChangeWidth;
            var ttb_def_height = ptb_word.Height - 101 - halfChangeHeight;
            if (WindowState == FormWindowState.Maximized)
            {
                ttb_def.Width = ttb_def_width;
                ttb_def.Height = ttb_def_height;
                ttb_def.Font = _bigFont;
                lbl_header.Font = _biggerFont;
                pnl_message_arrow.Location = new Point(ptb_word.Location.X + ptb_word.Width - 85, ptb_word.Location.Y + ptb_word.Height - 69);
            }
            else
            {
                ttb_def.Width = ptb_word.Width - 36;
                ttb_def.Height = ptb_word.Height - 101;
                ttb_def.Font = _smallFont;
                lbl_header.Font = _bigFont;
                pnl_message_arrow.Location = new Point(ptb_word.Location.X + ptb_word.Width - 70, ptb_word.Location.Y + ptb_word.Height - 69);
            }
            lbl_word.Location = new Point(lbl_header.Location.X, lbl_header.Height + lbl_header.Location.Y);
            lbl_phonetic.Location = new Point(lbl_word.Location.X + lbl_word.Width, lbl_word.Location.Y);
            ttb_def.Location = new Point(lbl_header.Location.X, lbl_word.Height + lbl_word.Location.Y - 2);
            if (_musicBar != null)
            {
                _musicBar.Location = !_musicBar.IsHide ? 
                    new Point(Width - _musicBar.Width, Height - _musicBar.Height - 80) : 
                    new Point(Width - _musicBar.RightLimit, Height - _musicBar.Height - 80);
            }

            pnl_dict.Height = Height - 29;
            pnl_dict.Location = _isDictHide ? 
                new Point(Width, 0) : 
                new Point(Width - pnl_dict.Width, 0);
            ResumeLayout();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            IniTriangle();
            _rndWord = await FuncDict.get_random_word();
            lbl_word.Text = _rndWord.word;
            lbl_phonetic.Text = _rndWord.phonetic;
            ttb_def.Text = _rndWord.meaning;
            lbl_phonetic.Location = new Point(lbl_word.Location.X + lbl_word.Width, lbl_word.Location.Y);
            _musicBar = new MusicBar(this);
            Controls.Add(_musicBar);
            _musicBar.BringToFront();
            _musicBar.Start(FuncCommon.GetRandomMusic(ref _musicBar.CurTrack));
            Fx_background();
        }

        public async void Fx_background()
        {
            while (true)
            {
                for (var i = 0; i < _arrTriangle.Length; i++)
                {
                    if (_arrTriangle[i].Location.X > Width || _arrTriangle[i].Location.Y > Height)
                    {
                        _arrTriangle[i].Location = new Point(_arrTriangle[i].Location.X - _arrTriangle[i].Location.Y - 20, -20);
                    }
                    else
                    {
                        _arrTriangle[i].Location =
                            new Point(_arrTriangle[i].Location.X + 1, _arrTriangle[i].Location.Y + 1);
                    }
                }
                await Task.Delay(20);
            }
        }

        public void IniTriangle()
        {
            var lstTriangle = new List<PictureBox>(20) { ptb_triangle2 };
            var curPoint = ptb_triangle2.Location;
            for (var i = 0; i < 15; i++)
            {
                var tmp = ptb_triangle2.Clone();
                Controls.Add(tmp);
                tmp.SendToBack();
                tmp.Visible = true;
                curPoint = new Point(curPoint.X + 250, curPoint.Y);
                if (curPoint.X >= Width)
                {
                    curPoint = new Point(ptb_triangle2.Location.X, curPoint.Y + 250);
                }
                tmp.Location = curPoint;
                lstTriangle.Add(tmp);
            }
            _arrTriangle = lstTriangle.ToArray();
        }

        private void menu_light1_ButtonClick(object sender, EventArgs e)
        {
            if (_dictSidebar == null)
            {
                _dictSidebar = new DictSidebar{Dock = DockStyle.Fill};
            }
            pnl_dict.Controls.Add(_dictSidebar);
            pnl_dict.Location = new Point(Width - pnl_dict.Width, 0);
            _isDictHide = false;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (_isDictHide) return;
            _isDictHide = false;
            pnl_dict.Location = new Point(Width, 0);
        }
    }
}
