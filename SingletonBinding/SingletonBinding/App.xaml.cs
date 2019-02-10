using SingletonBinding.Models;
using SingletonBinding.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SingletonBinding
{
    public partial class App : Application
    {
        public static ObservableCollection<ChatListItem> ChatList { get; set; } = new ObservableCollection<ChatListItem>();

        public App()
        {
            InitializeComponent();
            ChatList.Add(new ChatListItem() { Name = "Kevin1" });

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
