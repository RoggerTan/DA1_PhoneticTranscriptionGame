using System;
using System.Windows.Forms;
using echo_main.user_controls.congrat;
using echo_main.user_controls.playscene;

namespace echo_main.forms.playScene
{
    public partial class Training : Form
    {
        private readonly TrainingPlayScene _playScene;
        private TrainingCongrat _congrat;
        public Training()
        {
            InitializeComponent();
            _playScene = new TrainingPlayScene(new[] { ("dragon", "dragon"), ("hello", "hello") }) { Dock = DockStyle.Fill };
            _playScene.Finish += PlaySceneOnFinish;
        }

        private void PlaySceneOnFinish(object sender, EventArgs eventArgs)
        {
            Controls.Remove(_playScene);
            _playScene.Dispose();
            _congrat = new TrainingCongrat{Dock = DockStyle.Fill};
            Controls.Add(_congrat);
            _congrat.BringToFront();
        }

        private void Training_Load(object sender, EventArgs e)
        {
            Controls.Add(_playScene);
        }
    }
}
