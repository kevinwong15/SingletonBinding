using SingletonBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SingletonBinding.Singletons
{
    public class NewChatList : INotifyPropertyChanged
    {

        // Singleton
        private static NewChatList current;
        public static NewChatList Current
        {
            get
            {
                // DoubleLock
                if (current == null)
                {
                    lock (m_lock)
                    {
                        if (current == null)
                        {
                            current = new NewChatList();
                        }
                    }
                }
                return current;
            }
        }

        private static object m_lock = new object();
        public ObservableCollection<ChatListItem> List { get; set; } = new ObservableCollection<ChatListItem> { new ChatListItem { Name = "Kevin4" } };

        private string fullName = "This is to test Label";
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}