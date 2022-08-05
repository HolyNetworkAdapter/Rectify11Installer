namespace Rectify11Installer.Pages
{
    public partial class UninstallConfirmPage : WizardPage, IRectifyInstalllerUninstallOptions
    {
        public UninstallConfirmPage()
        {
            InitializeComponent();
        }

        public bool RemoveExplorerPatcher => chkExplorerPatcher.Checked;

        public bool RemoveThemesAndThemeTool => chkRemoveThemes.Checked;

        public bool RestoreWallpapers => chkRestoreWallpaper.Checked;
        public bool deleteASDF => darkAwareCheckBox1.Checked;
        public bool deleteMFE => darkAwareCheckBox2.Checked;
        public bool revertwinver => darkAwareCheckBox3.Checked;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
