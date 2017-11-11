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

namespace echo_main.user_controls.playscene
{
    public partial class TrainingPlayScene : UserControl, IPlayScene
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly IEnumerator<(string word, string phonetic)> _curWord;
        private readonly ChromiumWebBrowser _brwCheck;
        private readonly ChromiumWebBrowser _brwSound;

        private bool _isShake;

        public event EventHandler Finish;

        [Category("Appearance"), Description("Set PlayScene back-color")]
        public Color CustomBackColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        public int WordCount { get; private set; }

        public TrainingPlayScene(IEnumerable<(string word, string phonetic)> quiz)
        {
            InitializeComponent();

            _curWord = quiz.GetEnumerator();
            btn_finish.ButtonClick += btn_finish_Click;
            ttb_answer.EnterKeyDown += btn_finish_Click;

            if (DesignMode) return;
            _brwSound = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/volume_indicator_darkblue.html");
            _brwSound.Dock = DockStyle.Fill;
            _brwSound.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            pnl_volumeIndicator.Controls.Add(_brwSound);
            _brwSound.Visible = true;
            _brwSound.Tag = new EventHandler(Sound_Click);
            //-----------------
            _brwCheck = FuncInitialize.brw_initialize(Info.CurrentDir + "/animate/checked_done_darkblue.html");
            _brwCheck.Dock = DockStyle.Fill;
            //_brw_check.IsBrowserInitializedChanged += Persistent.ini_mouseclick_replay;
            _brwCheck.IsBrowserInitializedChanged += BrwCheckOnIsBrowserInitializedChanged;
            pnl_check.Controls.Add(_brwCheck);
            //--------------------------
        }

        private void TrainingPlayScene_Load(object sender, EventArgs e)
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
            Check(_curWord.Current.phonetic, ttb_answer.TextBoxText);
        }

        public async void Start()
        {
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
                await FuncFx.ShakeControl(pnl_middle, 10, 2, 5, _cts.Token);
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
            pnl_middle.Location = new Point((Width - pnl_middle.Width) / 2, (Height - pnl_middle.Height) / 2);
        }

        private void lbl_word_Resize(object sender, EventArgs e)
        {
            lbl_word.AlignCenterH(pnl_middle);
        }
    }
}
