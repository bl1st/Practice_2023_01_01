using EasyCaptcha.Wpf;
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
using System.Windows.Shapes;

namespace PcComponents.Views
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        public CaptchaWindow()
        {
            InitializeComponent();
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 7);
        }

        public void OnButtonRecreate_Click(object sender, EventArgs e)
        {
			MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 7);
            TextBlockCaptcha.Text = "";
            TextBlockCaptcha.Focus();
		}

		private void OnKeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
                string userCaptcha = TextBlockCaptcha.Text;
                if (userCaptcha != MyCaptcha.CaptchaText)
                {
                    TextBlockCaptcha.Text = "";
					MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 7);
				}
                else
                {
                    this.Close();
                }
			}
		}
	}
}
