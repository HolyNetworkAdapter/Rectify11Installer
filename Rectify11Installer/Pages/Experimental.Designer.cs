﻿
namespace Rectify11Installer.Pages
{
	partial class Experimental
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
			this.label1 = new Controls.DarkAwareLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-3, 0);
			this.label1.Name = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Size = new System.Drawing.Size(341, 250);
			this.label1.TabIndex = 0;
			this.label1.Text = "The following installer is for testing purposes only. \nIt currently only contains icons and texture changes, no visual style, wallpaper, theme changes, nor additional software yet. Rectify11 3.0, the complete experience, will be released in the near future. \n\nRemember to report bugs you find in this installer to the Discord Server. \nWith this in mind, welcome to the Rectify11 3.0 Release Preview 2 installer, press Next to continue. ";
			//
			// ExperimentalPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label1);
			this.Name = "ExperimentalPage";
			this.WizardHeader = "Incomplete Software";
			this.SideImage = global::Rectify11Installer.Properties.Resources.incomplete;
			this.ResumeLayout(false);
		}

		private Controls.DarkAwareLabel label1;

		#endregion
	}
}