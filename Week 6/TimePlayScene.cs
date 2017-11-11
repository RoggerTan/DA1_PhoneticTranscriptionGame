using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using echo_main.BS_layer.Func;
using echo_main.res;
using System.Threading;
using echo_main.user_controls.custom_controls;

namespace echo_main.user_controls.playscene
{
    public partial class TimePlayScene : UserControl, IPlayScene
    {
        private CancellationTokenSource _ctsFade = new CancellationTokenSource();
        private CancellationTokenSource _ctsMove = new CancellationTokenSource();
        private (string word, string phonetic) _curWord;
        private readonly ChromiumWebBrowser _brwCheck;
        private readonly ChromiumWebBrowser _brwSound;
        private readonly TimeSpan _oneSecond = new TimeSpan(0, 0, 1);
        private readonly TimeSpan _addSecond = new TimeSpan(0, 0, 5);
        private readonly Point _preAddSecondLoc;
        private readonly Point _middleAddSecondLoc;
        private readonly Point _destAddSecondLoc;
        private TimeSpan _curTime;
        private bool _isShake;
        private readonly CharBoard _charBoard;

        public event EventHandler Finish;

        [Category("Appearance"), Description("Set PlayScene back-color")]
        public Color CustomBackColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        public int WordCount
        {
            get => int.Parse(lbl_count.Text);
            set => lbl_count.Text = value.ToString();
        }

        private TimeSpan CurTime
        {
            get => _curTime;
            set
            {
                if (_curTime != TimeSpan.Zero && value > _curTime)
                {
                    lbl_addition.Text = Persistent.AddSecond;
                }
                _curTime = value;
                lbl_timer.Text = value.ToString(@"mm\:ss");
            }
        }

        public TimePlayScene(TimeSpan totalTime)
        {
            InitializeComponent();

            _preAddSecondLoc = lbl_addition.Location;
            _middleAddSecondLoc = new Point(lbl_addition.Location.X, lbl_addition.Location.Y - 20);
            _destAddSecondLoc = new Point(lbl_addition.Location.X, lbl_addition.Location.Y - 40);

            CurTime = totalTime;
            btn_finish.ButtonClick += btn_finish_Click;
            ttb_answer.EnterKeyDown += btn_finish_Click;
            if (Persistent.AddSecond == null)
                Persistent.AddSecond = "+" + _addSecond.ToString("ss").TrimStart('0');

            if (DesignMode) return;
            _brwSound = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/volume_indicator_lightblue.html");
            _brwSound.Dock = DockStyle.Fill;
            _brwSound.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            pnl_volumeIndicator.Controls.Add(_brwSound);
            _brwSound.Visible = true;
            _brwSound.Tag = new EventHandler(Sound_Click);
            //-----------------
            _brwCheck = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/checked_done_lightblue.html");
            _brwCheck.Dock = DockStyle.Fill;
            //_brw_check.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            _brwCheck.IsBrowserInitializedChanged += BrwCheckOnIsBrowserInitializedChanged;
            pnl_check.Controls.Add(_brwCheck);
            //--------------------------
            _charBoard = new CharBoard(this)
            {
                IsHide = true,
                Location = Location = new Point(321, 95)
            };
            pnl_middle.Controls.Add(_charBoard);
            _charBoard.BringToFront();
        }

        private void TimePlayScene_Load(object sender, EventArgs e)
        {
            Start();
        }

        public void Sound_Click(object sender, EventArgs e)
        {
            Persistent.Synth.SpeakAsync(lbl_word.Text);
        }

        //Hide the browser right after initialized
        private void BrwCheckOnIsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                _brwCheck.Visible = false;
            }));
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            //Notice that this method is for 2 event handlers. Checking btn_finish state is necessary for EnterKeyDown
            if (!btn_finish.Enabled) return;
            Check(_curWord.phonetic, ttb_answer.TextBoxText);
        }

        public async void Start()
        {
            tmr_timer.Start();
            await Next();
        }

        public void Stop()
        {
            _brwCheck.Visible = false;
            _brwSound.Visible = false;
            Finish?.Invoke(this, EventArgs.Empty);
        }

        public async void Check(string input, string answer)
        {
            if (input == answer)
            {
                WordCount++;
                AddTime();
                if (!_brwCheck.Visible)
                {
                    _brwCheck.Visible = true;
                }
                _brwCheck.ExecuteScriptAsync("animation.goToAndPlay(0, true)");
                if (await Next()) return;
                btn_finish.Enabled = false;
                tmr_timer.Stop();
                await Task.Delay(2000);
                Stop();
            }
            else
            {
                if (_isShake) return;
                _isShake = true;
                await FuncFx.ShakeControl(pnl_middle, 10, 2, 5, _ctsFade.Token);
                _isShake = false;
            }
        }

        public async Task<bool> Next()
        {
            (string word, string phonetic, string meaning) randomWord;
            do
            {
                randomWord = await FuncDict.get_random_word();
                _curWord = (randomWord.word, randomWord.phonetic);
            } while (randomWord.word == null || string.IsNullOrEmpty(randomWord.phonetic));
            lbl_word.Text = _curWord.word;
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

        private void pnl_main_Resize(object sender, EventArgs e)
        {
            SuspendLayout();
            pnl_middle.Location = new Point((Width - pnl_middle.Width) / 2, (Height - pnl_middle.Height) / 2);
            pnl_timer.Location = new Point(Width - pnl_timer.Width, Height - pnl_timer.Height);
            lbl_count.Location = new Point((Width - lbl_count.Width) / 2, lbl_count.Location.Y);
            _charBoard.IsHide = true;
            _charBoard.Location = new Point(pnl_middle.Width - 48, _charBoard.Location.Y);
            ResumeLayout();
        }

        private void tmr_timer_Tick(object sender, EventArgs e)
        {
            if (CurTime == TimeSpan.Zero)
            {
                Stop();
            }
            else
            {
                CurTime = CurTime - _oneSecond;
            }
        }

        private async void AddTime()
        {
            CurTime += _addSecond;
            _ctsFade.Cancel();
            _ctsMove.Cancel();
            _ctsFade = new CancellationTokenSource();
            _ctsMove = new CancellationTokenSource();
            lbl_addition.ForeColor = lbl_addition.BackColor;
            lbl_addition.Location = _preAddSecondLoc;
            MoveToMid();
            await FuncFx.Fade_in_out_ForeColor(lbl_addition, new byte[] { 0, 69, 87 }, new byte[] { 149, 152, 154 }, _ctsFade.Token);
            MoveToDest();
            await FuncFx.Fade_in_out_ForeColor(lbl_addition, new byte[] { 149, 152, 154 }, new byte[] { 0, 69, 87 }, _ctsFade.Token);

            async void MoveToMid()
            {
                await lbl_addition.MoveControl(_middleAddSecondLoc, 1, _ctsMove.Token);
            }

            async void MoveToDest()
            {
                await lbl_addition.MoveControl(_destAddSecondLoc, 1, _ctsMove.Token);
            }
        }

        private void lbl_word_Resize(object sender, EventArgs e)
        {
            lbl_word.AlignCenterH(pnl_middle);
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
