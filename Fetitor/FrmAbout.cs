﻿// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Fetitor
{
	/// <summary>
	/// Form with information about the program.
	/// </summary>
	public partial class FrmAbout : Form
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		public FrmAbout()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Closes form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Opens the clicked image's link in its Tag.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkImage_Click(object sender, EventArgs e)
		{
			var tag = ((sender as Control)?.Tag as string);
			if (tag != null)
				Process.Start(tag);
		}
	}
}
