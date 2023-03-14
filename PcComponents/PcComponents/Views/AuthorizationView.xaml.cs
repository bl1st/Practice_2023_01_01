using PcComponents.Models.Entities;
using PcComponents.Views;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PcComponents
{ 
	public partial class MainWindow : Window
	{
		int attempts = 0;
		public MainWindow()
		{
			Bitmap img = Properties.Resources.noproduct;
			ImageConverter converter = new ImageConverter();
			Helper.NoImage = (byte[])converter.ConvertTo(img, typeof(byte[]))!;

			InitializeComponent();
			Bitmap logo = Properties.Resources.logo;
			var handle = logo.GetHbitmap();
			ImageSource isc = Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			imgIcon.Source = isc;
			Helper.context = new PcComponentsDbWpfContext();
			textBlockUserName.Text = "19dn@outlook.com";
			passwordBoxUserPassword.Password = "RSbvHv";

		}

		private void btnLogIn_Click(object sender, RoutedEventArgs e)
		{
			string login = textBlockUserName.Text;
			string pass = passwordBoxUserPassword.Password;

			if (attempts > 1)
			{
				CaptchaWindow cv = new CaptchaWindow();
				this.Hide();
				cv.ShowDialog();
				this.Show();
			}


			User? usr = Helper.context.Users.Include(u => u.Role).Where(u => u.Login == login && u.Password == pass).FirstOrDefault();
			if (usr == null)
			{
				tbFail.Text = "Неправильный логин или пароль!";
				attempts++;
				return;
			}

			tbFail.Text = "";
			MessageBox.Show($"Добро пожаловать, {usr.Firstname} {usr.Patronymic}\n Роль: {usr.Role.RoleName}", "Приветствие");
			Helper.UserName = $"{usr.Surename} {usr.Firstname} {usr.Patronymic}";
			
			Helper.UserRole = usr.Role.RoleName;
			MainView mv = new MainView();
			this.Hide();
			mv.ShowDialog();
			this.Show();


		}

		private void btnGuest_Click(object sender, RoutedEventArgs e)
		{
			Helper.UserRole = "Гость";
			Helper.UserName = "";
			MainView mv = new MainView();
			this.Hide();
			mv.ShowDialog();
			this.Show();
		}
	}
}
