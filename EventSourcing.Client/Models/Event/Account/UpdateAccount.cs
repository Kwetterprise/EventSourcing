﻿using System;

namespace Kwetterprise.EventSourcing.Client.Models.Event.Account
{
    public sealed class UpdateAccount : EventBase
    {
        public UpdateAccount()
        {
            
        }

        public UpdateAccount(Guid id, string newUsername, string newEmailAddress, string newHashedPassword, byte[]? newProfilePicture, string newBio)
        {
            Id = id;
            NewUsername = newUsername;
            NewEmailAddress = newEmailAddress;
            NewHashedPassword = newHashedPassword;
            NewProfilePicture = newProfilePicture;
            NewBio = newBio;
        }

        public Guid Id { get; set; }

        public string NewUsername { get; set; } = null!;

        public string NewEmailAddress { get; set; } = null!;

        public string NewHashedPassword { get; set; } = null!;

        public byte[]? NewProfilePicture { get; set; } = null!;

        public string NewBio { get; set; } = null!;
    }
}