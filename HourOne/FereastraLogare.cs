using System;
using System.Windows.Forms;


namespace HourOne
{
    public partial class fp : Form
    {
        string numeUtilizator = Environment.UserName; //windows name
        FereastraParole fereastraParole;
        public fp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeUtilizator.ToUpper();
            fp_bunVenit.Text += numeUtilizator;
        }

        private void fp_logare_Click(object sender, EventArgs e)
        {
            string user = fp_utilizator.Text;
            string pass = fp_parola.Text;
            Logare logare = new Logare();
            if(logare.login(user, pass))
            {
                fereastraParole = new FereastraParole();
                if(fereastraParole.Created == false)
                {

                }
            }
        }
        private void fp_recuperare_Click(object sender, EventArgs e)
        {

        }
    }
}
