namespace BlogService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlogServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.blogServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // BlogServiceProcessInstaller
            // 
            this.BlogServiceProcessInstaller.Password = null;
            this.BlogServiceProcessInstaller.Username = null;
            // 
            // blogServiceInstaller
            // 
            this.blogServiceInstaller.ServiceName = "BlogService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.BlogServiceProcessInstaller,
            this.blogServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller BlogServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller blogServiceInstaller;
    }
}