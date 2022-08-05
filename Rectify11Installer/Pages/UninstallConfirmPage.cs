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
        public bool DeleteASDF => darkAwareCheckBox1.Checked;
        public bool DeleteMFE => darkAwareCheckBox2.Checked;
        public bool Revertwinver => darkAwareCheckBox3.Checked;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UninstallConfirmPage_Load(object sender, EventArgs e)
        {

        }
    }
}
