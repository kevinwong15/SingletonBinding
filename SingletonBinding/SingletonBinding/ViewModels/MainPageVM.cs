using SingletonBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SingletonBinding.ViewModels
{
    public class MainPageVM
    {
        public ObservableCollection<ChatListItem> Playlists { get; private set; } = new ObservableCollection<ChatListItem>();

        public MainPageVM()
        {
            Playlists.Add(new ChatListItem { Name = "This is the typical way" });
        }
    }
}
