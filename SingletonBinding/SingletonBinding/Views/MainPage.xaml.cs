using SingletonBinding.Models;
using SingletonBinding.Singletons;
using SingletonBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SingletonBinding.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            App.ChatList.Add(new ChatListItem { Name = "Kevin123456" });
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            NewChatList.Current.List.Add(new ChatListItem { Name = "Kevin123456" });
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            ((MainPageVM)this.BindingContext).Playlists.Add(new ChatListItem { Name = "Kevin123456" });
        }
    }
}
