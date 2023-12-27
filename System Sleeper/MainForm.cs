/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 5/11/2008
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace System_Sleeper
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
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.SetSuspendState(PowerState.Suspend, true, false);
		}

		void Button2Click(object sender, EventArgs e)
		{			
			Application.SetSuspendState(PowerState.Hibernate, true, false);
		}
	}
}
