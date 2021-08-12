
namespace GoogleChromePopupMaker
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.pgShortcutCreator = new System.Windows.Forms.TabPage();
			this.pgQuickPopup = new System.Windows.Forms.TabPage();
			this.lblShortcutWebsite = new System.Windows.Forms.Label();
			this.txtShortcutWebsite = new System.Windows.Forms.TextBox();
			this.txtShortcutFileName = new System.Windows.Forms.TextBox();
			this.lblShortcutFileName = new System.Windows.Forms.Label();
			this.btnCreateShortcut = new System.Windows.Forms.Button();
			this.btnDisplayPopup = new System.Windows.Forms.Button();
			this.txtPopupLink = new System.Windows.Forms.TextBox();
			this.lblPopupLink = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.pgShortcutCreator.SuspendLayout();
			this.pgQuickPopup.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.pgShortcutCreator);
			this.tabControl1.Controls.Add(this.pgQuickPopup);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(390, 249);
			this.tabControl1.TabIndex = 0;
			// 
			// pgShortcutCreator
			// 
			this.pgShortcutCreator.Controls.Add(this.btnCreateShortcut);
			this.pgShortcutCreator.Controls.Add(this.txtShortcutFileName);
			this.pgShortcutCreator.Controls.Add(this.lblShortcutFileName);
			this.pgShortcutCreator.Controls.Add(this.txtShortcutWebsite);
			this.pgShortcutCreator.Controls.Add(this.lblShortcutWebsite);
			this.pgShortcutCreator.Location = new System.Drawing.Point(4, 26);
			this.pgShortcutCreator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pgShortcutCreator.Name = "pgShortcutCreator";
			this.pgShortcutCreator.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pgShortcutCreator.Size = new System.Drawing.Size(382, 219);
			this.pgShortcutCreator.TabIndex = 0;
			this.pgShortcutCreator.Text = "Shortcut Creator";
			this.pgShortcutCreator.UseVisualStyleBackColor = true;
			// 
			// pgQuickPopup
			// 
			this.pgQuickPopup.Controls.Add(this.btnDisplayPopup);
			this.pgQuickPopup.Controls.Add(this.txtPopupLink);
			this.pgQuickPopup.Controls.Add(this.lblPopupLink);
			this.pgQuickPopup.Location = new System.Drawing.Point(4, 26);
			this.pgQuickPopup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pgQuickPopup.Name = "pgQuickPopup";
			this.pgQuickPopup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pgQuickPopup.Size = new System.Drawing.Size(382, 219);
			this.pgQuickPopup.TabIndex = 1;
			this.pgQuickPopup.Text = "Quick Popup";
			this.pgQuickPopup.UseVisualStyleBackColor = true;
			// 
			// lblShortcutWebsite
			// 
			this.lblShortcutWebsite.AutoSize = true;
			this.lblShortcutWebsite.Location = new System.Drawing.Point(10, 56);
			this.lblShortcutWebsite.Name = "lblShortcutWebsite";
			this.lblShortcutWebsite.Size = new System.Drawing.Size(60, 19);
			this.lblShortcutWebsite.TabIndex = 0;
			this.lblShortcutWebsite.Text = "Website:";
			// 
			// txtShortcutWebsite
			// 
			this.txtShortcutWebsite.Location = new System.Drawing.Point(88, 53);
			this.txtShortcutWebsite.Name = "txtShortcutWebsite";
			this.txtShortcutWebsite.Size = new System.Drawing.Size(286, 25);
			this.txtShortcutWebsite.TabIndex = 1;
			// 
			// txtShortcutFileName
			// 
			this.txtShortcutFileName.Location = new System.Drawing.Point(88, 84);
			this.txtShortcutFileName.Name = "txtShortcutFileName";
			this.txtShortcutFileName.Size = new System.Drawing.Size(286, 25);
			this.txtShortcutFileName.TabIndex = 3;
			// 
			// lblShortcutFileName
			// 
			this.lblShortcutFileName.AutoSize = true;
			this.lblShortcutFileName.Location = new System.Drawing.Point(10, 87);
			this.lblShortcutFileName.Name = "lblShortcutFileName";
			this.lblShortcutFileName.Size = new System.Drawing.Size(72, 19);
			this.lblShortcutFileName.TabIndex = 2;
			this.lblShortcutFileName.Text = "File Name:";
			// 
			// btnCreateShortcut
			// 
			this.btnCreateShortcut.Location = new System.Drawing.Point(127, 127);
			this.btnCreateShortcut.Name = "btnCreateShortcut";
			this.btnCreateShortcut.Size = new System.Drawing.Size(136, 37);
			this.btnCreateShortcut.TabIndex = 4;
			this.btnCreateShortcut.Text = "Create Shortcut";
			this.btnCreateShortcut.UseVisualStyleBackColor = true;
			this.btnCreateShortcut.Click += new System.EventHandler(this.CreateShortcut_MSClick);
			// 
			// btnDisplayPopup
			// 
			this.btnDisplayPopup.Location = new System.Drawing.Point(126, 121);
			this.btnDisplayPopup.Name = "btnDisplayPopup";
			this.btnDisplayPopup.Size = new System.Drawing.Size(136, 37);
			this.btnDisplayPopup.TabIndex = 7;
			this.btnDisplayPopup.Text = "Display Popup";
			this.btnDisplayPopup.UseVisualStyleBackColor = true;
			this.btnDisplayPopup.Click += new System.EventHandler(this.DisplayPopup_MSClick);
			// 
			// txtPopupLink
			// 
			this.txtPopupLink.Location = new System.Drawing.Point(87, 71);
			this.txtPopupLink.Name = "txtPopupLink";
			this.txtPopupLink.Size = new System.Drawing.Size(286, 25);
			this.txtPopupLink.TabIndex = 6;
			// 
			// lblPopupLink
			// 
			this.lblPopupLink.AutoSize = true;
			this.lblPopupLink.Location = new System.Drawing.Point(9, 75);
			this.lblPopupLink.Name = "lblPopupLink";
			this.lblPopupLink.Size = new System.Drawing.Size(60, 19);
			this.lblPopupLink.TabIndex = 5;
			this.lblPopupLink.Text = "Website:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(390, 249);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Chrome Popup Maker";
			this.tabControl1.ResumeLayout(false);
			this.pgShortcutCreator.ResumeLayout(false);
			this.pgShortcutCreator.PerformLayout();
			this.pgQuickPopup.ResumeLayout(false);
			this.pgQuickPopup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage pgShortcutCreator;
		private System.Windows.Forms.TabPage pgQuickPopup;
		private System.Windows.Forms.TextBox txtShortcutWebsite;
		private System.Windows.Forms.Label lblShortcutWebsite;
		private System.Windows.Forms.TextBox txtShortcutFileName;
		private System.Windows.Forms.Label lblShortcutFileName;
		private System.Windows.Forms.Button btnCreateShortcut;
		private System.Windows.Forms.Button btnDisplayPopup;
		private System.Windows.Forms.TextBox txtPopupLink;
		private System.Windows.Forms.Label lblPopupLink;
	}
}

