namespace Rectify11Installer.Pages
{
    public partial class EPPage : WizardPage, IRectifyInstalllerEPOptions
    {
        public bool w10 { get => chkW10.Checked; }
        public bool w11 { get => chkW11.Checked; }
        public bool w10TaskB { get => chkW10TaskB.Checked; }
        public bool micaExplorer { get => chkMicaExplorer.Checked; }
        public bool ribbon { get => darkAwareCheckBox1.Checked; }
        public EPPage()
        {
            InitializeComponent();
        }

        private void EPPage_Load(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Build >= 25169)
            {
                chkW10.Enabled = false; // They killed win10 start menu in 25169, if win10 option is selected then EP would die. 
                chkW11.Checked = true;
                label2.Text = "*Win10 start menu is removed in build 25169 and above";
            }
            if (Environment.OSVersion.Version.Build >= 22621 && Environment.OSVersion.Version.Build <= 25000 || Environment.OSVersion.Version.Build >= 25120)
            {
                darkAwareCheckBox1.Hide(); //They partially killed ribbon in 22621 and 25120
            }

        }

        private void chkMicaExplorer_CheckedChanged(object sender, EventArgs e)
        {
            darkAwareCheckBox1.Checked = false;
            darkAwareCheckBox1.Enabled = false;
            if (chkMicaExplorer.Checked == false)
            {
                darkAwareCheckBox1.Enabled = true;
            }
        }

        private void darkAwareCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            chkMicaExplorer.Checked = false;
            chkMicaExplorer.Enabled = false;
            if (darkAwareCheckBox1.Checked == false)
            {
                chkMicaExplorer.Enabled = true;
            }
        }
    }
}
