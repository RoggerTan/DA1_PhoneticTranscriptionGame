using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using echo_main.user_controls.Intro;
using echo_main.user_controls.playscene;

namespace echo_main.forms.playScene
{
    public partial class Parrot : Form
    {
        private readonly ParrotIntro _parrotIntro;
        private CountDown _countDown;

        public Parrot()
        {
            InitializeComponent();
            
            _parrotIntro = new ParrotIntro{Dock = DockStyle.Fill};

            _parrotIntro.OnClick += ParrotIntroOnOnClick;
        }

        private void ParrotIntroOnOnClick(object sender, EventArgs eventArgs)
        {
            Invoke(new Action(() =>
            {
                pnl_main.Controls.Remove(_parrotIntro);

                _countDown = new CountDown{Dock = DockStyle.Fill};
                _countDown.Finish += CountDownOnFinish;
                pnl_main.Controls.Add(_countDown);
            }));
        }

        private void CountDownOnFinish(object sender, EventArgs eventArgs)
        {
            Invoke(new Action(() =>
            {
                pnl_main.Controls.Remove(_countDown);
                pnl_main.Controls.Add(new ParrotPlayScene(new[]{("school", "school"), ("student", "student")}, "education") { Dock = DockStyle.Fill });
            }));
        }

        private void Parrot_Load(object sender, EventArgs e)
        {
            pnl_main.Controls.Add(_parrotIntro);
        }
    }
}
