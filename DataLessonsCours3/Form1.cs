using DataLessonsCours3.Properties;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLessonsCours3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void mainPage_Click(object sender, EventArgs e)
		{
			int pointX = mainPage.Location.X;
			int pointY = mainPage.Location.Y;
			navSeparator.Location = new Point(pointX, pointY);
		}

		private void addExam_Click(object sender, EventArgs e)
		{
			/*GunaGradientPanel grPanel = new GunaGradientPanel();
			grPanel.BackColor = System.Drawing.Color.Transparent;
			grPanel.Controls.Add(this.gunaGradient2Panel5);
			grPanel.Controls.Add(this.label12);
		    grPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			grPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			grPanel.Margin = new System.Windows.Forms.Padding(15);
			grPanel.Name = "gunaGradient2Panel4";
			grPanel.Size = new System.Drawing.Size(438, 246);
			examLayoutPanel.Controls.Add(grPanel);*/

			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			GunaGradient2Panel gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
			GunaGradient2Panel gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
			PictureBox pictureBox7 = new System.Windows.Forms.PictureBox();
			Label label7 = new System.Windows.Forms.Label();
			PictureBox pictureBox8 = new System.Windows.Forms.PictureBox();
			Label label8 = new System.Windows.Forms.Label();
			PictureBox pictureBox9 = new System.Windows.Forms.PictureBox();
			Label label9 = new System.Windows.Forms.Label();
			PictureBox pictureBox10 = new System.Windows.Forms.PictureBox();
			Label label10 = new System.Windows.Forms.Label();
			PictureBox pictureBox11 = new System.Windows.Forms.PictureBox();
			Label label11 = new System.Windows.Forms.Label();
			Label label12 = new System.Windows.Forms.Label();
			gunaGradient2Panel4.SuspendLayout();
			gunaGradient2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();

			gunaGradient2Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
			gunaGradient2Panel4.Controls.Add(this.gunaGradient2Panel5);
			gunaGradient2Panel4.Controls.Add(this.label12);
			gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			gunaGradient2Panel4.Margin = new System.Windows.Forms.Padding(15);
			gunaGradient2Panel4.Name = "gunaGradient2Panel4";
			gunaGradient2Panel4.Radius = 10;
			gunaGradient2Panel4.Size = new System.Drawing.Size(438, 246);




			


			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(143, 4);
			this.label12.Margin = new System.Windows.Forms.Padding(11);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(170, 29);
			this.label12.TabIndex = 5;
			this.label12.Text = "Понедельник";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
examLayoutPanel.Controls.Add(gunaGradient2Panel4);

			/*gunaGradient2Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
			gunaGradient2Panel4.Controls.Add(this.gunaGradient2Panel5);
			gunaGradient2Panel4.Controls.Add(this.label12);
			gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			gunaGradient2Panel4.Margin = new System.Windows.Forms.Padding(15);
			gunaGradient2Panel4.Name = "gunaGradient2Panel4";
			//this.gunaGradient2Panel4.Radius = 10;
			gunaGradient2Panel4.Size = new System.Drawing.Size(438, 246);*/
			// 
			// gunaGradient2Panel4
			// 
			//this.gunaGradient2Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			/*this.gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel4.Controls.Add(this.gunaGradient2Panel5);
			this.gunaGradient2Panel4.Controls.Add(this.label12);
			this.gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			this.gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			this.gunaGradient2Panel4.Margin = new System.Windows.Forms.Padding(15);
			this.gunaGradient2Panel4.Name = "gunaGradient2Panel4";
			//this.gunaGradient2Panel4.Radius = 10;
			this.gunaGradient2Panel4.Size = new System.Drawing.Size(438, 246);
			// 
			// gunaGradient2Panel5
			// 
			this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox7);
			this.gunaGradient2Panel5.Controls.Add(this.label7);
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox8);
			this.gunaGradient2Panel5.Controls.Add(this.label8);
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox9);
			this.gunaGradient2Panel5.Controls.Add(this.label9);
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox10);
			this.gunaGradient2Panel5.Controls.Add(this.label10);
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox11);
			this.gunaGradient2Panel5.Controls.Add(this.label11);
			this.gunaGradient2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.Location = new System.Drawing.Point(0, 34);
			this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
			this.gunaGradient2Panel5.Radius = 10;
			this.gunaGradient2Panel5.Size = new System.Drawing.Size(438, 212);
			this.gunaGradient2Panel5.TabIndex = 1;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(391, 165);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 32);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox7.TabIndex = 9;
			this.pictureBox7.TabStop = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(10, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(367, 27);
			this.label7.TabIndex = 8;
			this.label7.Text = "1 УиАБД 343аГТ Богданорвская Д.Е";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(391, 126);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(32, 32);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox8.TabIndex = 7;
			this.pictureBox8.TabStop = false;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(10, 130);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(367, 27);
			this.label8.TabIndex = 6;
			this.label8.Text = "1 УиАБД 343аГТ Богданорвская Д.Е";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(391, 86);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(32, 32);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox9.TabIndex = 5;
			this.pictureBox9.TabStop = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(10, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(367, 27);
			this.label9.TabIndex = 4;
			this.label9.Text = "1 УиАБД 343аГТ Богданорвская Д.Е";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(391, 47);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 32);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox10.TabIndex = 3;
			this.pictureBox10.TabStop = false;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(10, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(367, 27);
			this.label10.TabIndex = 2;
			this.label10.Text = "1 УиАБД 343аГТ Богданорвская Д.Е";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(391, 7);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(32, 32);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox11.TabIndex = 1;
			this.pictureBox11.TabStop = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(10, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(367, 27);
			this.label11.TabIndex = 0;
			this.label11.Text = "1 УиАБД 343аГТ Богданорвская Д.Е";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(143, 4);
			this.label12.Margin = new System.Windows.Forms.Padding(11);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(170, 29);
			this.label12.TabIndex = 5;
			this.label12.Text = "Понедельник";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// examLayoutPanel
			// 
			examLayoutPanel.Controls.Add(this.gunaGradient2Panel4);*/


		}



	}
}
