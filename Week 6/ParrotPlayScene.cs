using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using echo_main.BS_layer.DBFunc;
using echo_main.BS_layer.Func;
using echo_main.res;
using echo_main.user_controls.custom_controls;

namespace echo_main.user_controls.playscene
{
    public partial class ParrotPlayScene : UserControl, IPlayScene
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly ChromiumWebBrowser _brwParrot;
        private readonly ChromiumWebBrowser _brwCheck;
        private readonly ChromiumWebBrowser _brwSound;
        private readonly ChromiumWebBrowser _brwBlueCheck;
        private readonly IEnumerator<(string word, string phonetic)> _curWord;
        private readonly string _keyWord;
        private bool _isShake;
        private readonly CharBoard _charBoard;

        public event EventHandler Finish;

        public ParrotPlayScene(IEnumerable<(string word, string phonetic)> quiz, string keyWord)
        {
            InitializeComponent();

            _curWord = quiz.GetEnumerator();
            _keyWord = keyWord;

            btn_finish.ButtonClick += btn_finish_Click;
            ttb_keyword.TextChanged += TtbKeywordOnTextChanged;

            if (DesignMode) return;
            _brwSound = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/volume_indicator_purple.html");
            _brwSound.Dock = DockStyle.Fill;
            _brwSound.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            pnl_volumeIndicator.Controls.Add(_brwSound);
            _brwSound.Visible = true;
            _brwSound.Tag = new EventHandler(Sound_Click);
            //-----------------
            _brwCheck = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/checked_done_purple.html");
            _brwCheck.Dock = DockStyle.Fill;
            //_brw_check.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            _brwCheck.IsBrowserInitializedChanged += BrwCheckOnIsBrowserInitializedChanged;
            pnl_check.Controls.Add(_brwCheck);
            //--------------------------
            _brwBlueCheck = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/blue_checked_done_purple.html");
            _brwBlueCheck.Dock = DockStyle.Fill;
            _brwBlueCheck.IsBrowserInitializedChanged += BrwCheckOnIsBrowserInitializedChanged;
            pnl_blueCheck.Controls.Add(_brwBlueCheck);
            //--------------------------
            _brwParrot = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/parrot.html");
            _brwParrot.Dock = DockStyle.Fill;
            _brwParrot.IsBrowserInitializedChanged += BrwParrotOnIsBrowserInitializedChanged;
            pnl_parrot.Controls.Add(_brwParrot);
            //--------------------------
            _charBoard = new CharBoard(this)
            {
                IsHide = true,
                Location = Location = new Point(338, 97)
            };
            pnl_mid.Controls.Add(_charBoard);
            _charBoard.BringToFront();
        }

        private async void TtbKeywordOnTextChanged(object sender, EventArgs e)
        {
            if (!string.Equals(ttb_keyword.TextBoxText, _keyWord, StringComparison.OrdinalIgnoreCase)) return;
            if (!_brwBlueCheck.Visible)
            {
                _brwBlueCheck.Visible = true;
            }
            _brwBlueCheck.ExecuteScriptAsync("animation.goToAndPlay(0, true)");
            using (var bsParrot = new BsParrot())
            {
                await bsParrot.Update(Properties.Settings.Default.userId);
            }
            await Task.Delay(2000);
            Finish?.Invoke(sender, e);
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            //Notice that this method is for 2 event handlers. Checking btn_finish state is necessary for EnterKeyDown
            if (!btn_finish.Enabled) return;
            Check(_curWord.Current.phonetic, ttb_answer.TextBoxText);
        }

        public void Sound_Click(object sender, EventArgs e)
        {
            Persistent.Synth.SpeakAsync(lbl_word.Text);
        }

        private void BrwCheckOnIsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ((ChromiumWebBrowser)sender).Visible = false;
            }));
        }

        private void BrwParrotOnIsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                tmr_blink.Start();
            }));
        }

        private void ParrotPlayScene_Resize(object sender, EventArgs e)
        {
            SuspendLayout();

            spl_MidRight.SplitterDistance = (int)(Width * 0.427);
            spl_main.SplitterDistance = spl_MidRight.Width - spl_MidRight.SplitterDistance;

            //Set size
            pnl_parrot.Width = spl_main.SplitterDistance;
            pnl_parrot.Height = spl_main.SplitterDistance;
            pnl_mid.Width = spl_MidRight.SplitterDistance;
            pnl_right.Width = spl_MidRight.Panel2.Width;
            pnl_right.Height = pnl_blueCheck.Location.Y + pnl_blueCheck.Height;

            //Set User Control Position
            pnl_mid.AlignCenter(spl_MidRight.Panel1);
            pnl_right.AlignCenter(spl_MidRight.Panel2);
            pnl_right.Location = new Point(pnl_right.Location.X, pnl_right.Location.Y + 150);
            pnl_mid.Location = new Point(pnl_mid.Location.X, pnl_mid.Location.Y + 30);
            pnl_parrot.AlignCenter(spl_main.Panel1);
            pnl_splitter.AlignCenterV(spl_MidRight.Panel2);

            ResumeLayout();
        }

        private void pnl_mid_Resize(object sender, EventArgs e)
        {
            SuspendLayout();
            //Size
            ttb_answer.Width = pnl_mid.Width - 58;

            //Position
            _charBoard.IsHide = true;
            _charBoard.Location = new Point(pnl_mid.Width - 48, _charBoard.Location.Y);
            lbl_word.AlignCenterH(pnl_mid);
            pnl_buttons.AlignCenterH(pnl_mid);
            pnl_check.AlignCenterH(pnl_mid);
            ResumeLayout();
        }

        private void tmr_blink_Tick(object sender, EventArgs e)
        {
            _brwParrot.ExecuteScriptAsync("animation.goToAndPlay(0, true)");
        }

        public async void Start()
        {
            await Next();
        }

        public void Stop()
        {
            _brwSound.Tag = null;
            lbl_word.Text = "(Đã hết từ)";
        }

        public async void Check(string input, string answer)
        {
            if (input == answer)
            {
                if (!_brwCheck.Visible)
                {
                    _brwCheck.Visible = true;
                }
                _brwCheck.ExecuteScriptAsync("animation.goToAndPlay(0, true)");
                if (await Next()) return;
                btn_finish.Enabled = false;
                await Task.Delay(2000);
                Stop();
            }
            else
            {
                if (_isShake) return;
                _isShake = true;
                await FuncFx.ShakeControl(pnl_mid, 10, 2, 5, _cts.Token);
                _isShake = false;
            }
        }

        public async Task<bool> Next()
        {
            if (!_curWord.MoveNext())
            {
                return false;
            }
            lbl_word.Text = _curWord.Current.word;
            //ttb_answer.TextBoxText = _curWord.Current.phonetic;
            ttb_answer.TextBoxText = string.Empty;
            await Task.Delay(2000);
            _brwCheck.Visible = false;
            return true;
        }

        public void AddTextToAnswer(string text)
        {
            var caretPos = ttb_answer.CaretPosition;
            ttb_answer.TextBoxText = ttb_answer.TextBoxText.Substring(0, caretPos) + text + ttb_answer.TextBoxText.Substring(caretPos);
            ttb_answer.CaretPosition = caretPos + text.Length;
        }

        private void ParrotPlayScene_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void lbl_word_Resize(object sender, EventArgs e)
        {
            lbl_word.AlignCenterH(pnl_mid);
        }

        private void pnl_right_Resize(object sender, EventArgs e)
        {
            //Size
            pnl_blueCheck.Width = pnl_right.Width;
            pnl_blueCheck.Height = pnl_right.Width;
            ttb_keyword.Width = pnl_right.Width - 100;

            //Position
            lbl_rightTitle.AlignCenterH(pnl_right);
            ttb_keyword.AlignCenterH(pnl_right);
        }

        private void ttb_answer_AltKeyDown(object sender, EventArgs e)
        {
            _charBoard.IsHide = false;
        }

        private void ttb_answer_AltKeyUp(object sender, EventArgs e)
        {
            if (!_charBoard.IsHide)
                AddTextToAnswer(_charBoard.Map[_charBoard.SelectedChar.x][_charBoard.SelectedChar.y].Symbol);
            _charBoard.IsHide = true;
        }

        private void ttb_answer_LeftAltKeyDown(object sender, EventArgs e)
        {
            _charBoard.MoveLeft();
        }

        private void ttb_answer_RightAltKeyDown(object sender, EventArgs e)
        {
            _charBoard.MoveRight();
        }

        private void ttb_answer_UpAltKeyDown(object sender, EventArgs e)
        {
            _charBoard.MoveUp();
        }

        private void ttb_answer_DownAltKeyDown(object sender, EventArgs e)
        {
            _charBoard.MoveDown();
        }
    }
}
