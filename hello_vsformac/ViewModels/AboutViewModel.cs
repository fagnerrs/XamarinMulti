using System;
using System.Threading.Tasks;
using System.Windows.Input;
using hello_vsformac.Services;
using Xamarin.Forms;

namespace hello_vsformac
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly ILoginService login;

        private string token;

        public string Token
        {
            get { return this.token; }
            set { this.token = value; OnPropertyChanged(nameof(Token)); }
        }

        public AboutViewModel()
        {
            this.login = DependencyService.Get<ILoginService>();

            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            loadToken();
        }

        private void loadToken(){
            Task.Run(async () => {
				this.Token = await this.login.RefreshToken("fagner");
			});
		}

        public ICommand OpenWebCommand { get; }
    }   
}
