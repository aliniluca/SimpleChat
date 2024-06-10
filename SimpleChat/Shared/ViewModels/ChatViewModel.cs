using System;
using System.Collections.Generic;
using System.Text;
using SimpleChat.Shared.Models;

namespace SimpleChat.Shared.ViewModels
{
    public class ChatViewModel
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string TimeSinceLastMessage { get; set; }
        public string LastMessage { get; set; }

        public ChatViewModel()
        {

        }

        public ChatViewModel(long userId, string firstName, string lastName, string emailAddress)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            LastMessage = "Donec id elit non mi porta gravida at eget metus.";
            TimeSinceLastMessage = "1 day ago";
        }

        public static implicit operator ChatViewModel(User user)
        {
            return new ChatViewModel
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress
            };
        }

        public static implicit operator User(ChatViewModel chatViewModel)
        {
            return new User
            {
                UserId = chatViewModel.UserId,
                FirstName = chatViewModel.FirstName,
                LastName = chatViewModel.LastName,
                EmailAddress = chatViewModel.EmailAddress
            };
        }
    }


}
