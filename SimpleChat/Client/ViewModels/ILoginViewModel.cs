using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Shared.Models;

namespace SimpleChat.ViewModels
{
    public interface ILoginViewModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public Task LoginUser();
    }
}