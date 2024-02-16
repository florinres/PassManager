using System;
using System.Windows.Forms;

namespace HourOne
{
    public partial class FereastraParole : Form
    {
        fp fp = new fp();
        public FereastraParole()
        {
            InitializeComponent();
        }

        private void fp_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
