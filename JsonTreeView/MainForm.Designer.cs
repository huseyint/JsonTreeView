namespace JsonTreeView
{
	partial class MainForm
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
			this.JsonTreeView = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// JsonTreeView
			// 
			this.JsonTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.JsonTreeView.Location = new System.Drawing.Point(0, 0);
			this.JsonTreeView.Name = "JsonTreeView";
			this.JsonTreeView.Size = new System.Drawing.Size(484, 461);
			this.JsonTreeView.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.JsonTreeView);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JSON TreeView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView JsonTreeView;
	}
}

