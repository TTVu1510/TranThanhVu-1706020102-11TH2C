/*
 * Created by SharpDevelop.
 * User: C1-A03
 * Date: 1/7/2019
 * Time: 11:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace baithicuoiki
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Line = new System.Windows.Forms.ToolStrip();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.tsbTriangle = new System.Windows.Forms.ToolStripButton();
			this.tsbRhombus = new System.Windows.Forms.ToolStripButton();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.Line.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// Line
			// 
			this.Line.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbLine,
									this.tsbTriangle,
									this.tsbRhombus});
			this.Line.Location = new System.Drawing.Point(0, 0);
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(652, 25);
			this.Line.TabIndex = 0;
			this.Line.Text = "Line";
			// 
			// tsbLine
			// 
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(49, 22);
			this.tsbLine.Text = "Line";
			// 
			// tsbTriangle
			// 
			this.tsbTriangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTriangle.Image")));
			this.tsbTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTriangle.Name = "tsbTriangle";
			this.tsbTriangle.Size = new System.Drawing.Size(70, 22);
			this.tsbTriangle.Text = "Triangle";
			// 
			// tsbRhombus
			// 
			this.tsbRhombus.Image = ((System.Drawing.Image)(resources.GetObject("tsbRhombus.Image")));
			this.tsbRhombus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRhombus.Name = "tsbRhombus";
			this.tsbRhombus.Size = new System.Drawing.Size(78, 22);
			this.tsbRhombus.Text = "Rhombus";
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 25);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(652, 270);
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 295);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.Line);
			this.Name = "MainForm";
			this.Text = "baithicuoiki";
			this.Line.ResumeLayout(false);
			this.Line.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.ToolStripButton tsbRhombus;
		private System.Windows.Forms.ToolStripButton tsbTriangle;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip Line;
	}
}
