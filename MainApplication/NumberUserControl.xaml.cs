using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication
{
	/// <summary>
	/// Interaction logic for NumberUserControl.xaml
	/// </summary>
	public partial class NumberUserControl : UserControl
	{
		public string SelectedNumber
		{
			get { return txtNumber.Text; }
		}

		public event TextChangedEventHandler txtNumberTextChanged;

		public NumberUserControl()
		{
			InitializeComponent();
			txtNumber.TextChanged += new TextChangedEventHandler(txtNumber_TextChanged);
		}

		private void clickMe_Click(object sender, RoutedEventArgs e)
		{
			txtNumber.Text = (Convert.ToInt32(txtNumber.Text ?? "0") + 1).ToString();
			//MessageBox.Show("Clicked !");
		}

		private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (txtNumberTextChanged!=null)
			{
				txtNumberTextChanged(sender, e);
			}
			
		}
	}
}
