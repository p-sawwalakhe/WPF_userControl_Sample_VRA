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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			usercontrol1.txtNumberTextChanged += new TextChangedEventHandler(txtNumber_TextChanged);
			usercontrol2.txtNumberTextChanged += new TextChangedEventHandler(txtNumber1_TextChanged);
			usercontrol3.txtNumberTextChanged += new TextChangedEventHandler(txtNumber2_TextChanged);
		}

		private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			MessageBox.Show(usercontrol1.SelectedNumber);
		}

		private void txtNumber1_TextChanged(object sender, TextChangedEventArgs e)
		{
			MessageBox.Show(usercontrol2.SelectedNumber);
		}

		private void txtNumber2_TextChanged(object sender, TextChangedEventArgs e)
		{
			MessageBox.Show(usercontrol3.SelectedNumber);
		}
	}
}
