using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Shared.Models;

namespace SimpleChat.ViewModels
{
    public interface ISettingsViewModel
    {
        public long UserId { get; set; }
        public bool Notifications { get; set; }
        public bool DarkTheme { get; set; }

        public Task Save();
        public Task GetProfile();
    }
}
