using System;
using System.Windows.Forms;
using echo_main.user_controls.congrat;
using echo_main.user_controls.playscene;

namespace echo_main.forms.playScene
{
    public partial class TimeRunning : Form
    {
        private readonly TimePlayScene _playScene;

        //Get from database
        private readonly int _record;

        public TimeRunning(int record)
        {
            InitializeComponent();

            _record = record;

            _playScene = new TimePlayScene(new[] { ("dragon", "dragon"), ("hello", "hello"), ("run", "run")}, new TimeSpan(0, 0, 20)) { Dock = DockStyle.Fill };
            _playScene.Finish += PlaySceneOnFinish;
        }

        private void PlaySceneOnFinish(object sender, EventArgs eventArgs)
        {
            if (_playScene.WordCount > _record)
            {
                var congrat = new TimingCongrat(_playScene.WordCount) {Dock = DockStyle.Fill};
                Controls.Add(congrat);
                congrat.BringToFront();
            }
            else
            {
                var lost = new TimingLost { Dock = DockStyle.Fill };
                Controls.Add(lost);
                lost.BringToFront();
            }
            Controls.Remove(_playScene);
            _playScene.Dispose();
        }

        private void Training_Load(object sender, EventArgs e)
        {
            Controls.Add(_playScene);
        }
    }
}
