using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using echo_main.BS_layer.Func;
using echo_main.res;

namespace echo_main.forms.fx
{
    public partial class England : Form
    {
        public England()
        {
            InitializeComponent();
        }

        private async void England_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            Info.dct_data = await FuncDict.get_dict(Info.current_dir + @"\dictdata\2790517_Anh-Viet\Anh-Viet.dict");
            Info.lst_music = await FuncCommon.get_music_files();
            Persistent.FrmMenu.Show();
            await opa_to_zero();
            Hide();
        }

        private async Task opa_to_zero()
        {
            while (Opacity > 0)
            {
                Opacity-=0.01;
                await Task.Delay(1);
            }
        }
    }
}
