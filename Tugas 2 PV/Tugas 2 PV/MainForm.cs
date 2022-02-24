/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/24/2022
 * Time: 10:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_2_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
			textBox1.Clear();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
		void Button3Click(object sender, EventArgs e)
		{
			int r = listBox1.SelectedIndex;
			listBox1.Items.RemoveAt(r);
		}
	}
}
