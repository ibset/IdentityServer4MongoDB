﻿using Project.identityserver.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.identityserver.Domain.Models
{
    public class PersistedGrantStore : Entity
    {
        public PersistedGrantStore(Guid id, bool isActive, string key, string type, string subjectId,string sessionId, string clientId, string description, DateTime creationTime, DateTime? expiration, DateTime? consumedTime, string data)
        {
            Id = id;
            IsActive = isActive;
            Key = key;
            Type = type;
            SubjectId = subjectId;
            SessionId = sessionId;
            ClientId = clientId;
            Description = description;
            CreationTime = creationTime;
            Expiration = expiration;
            ConsumedTime = consumedTime;
            Data = data;
        }

        //
        // Summary:
        //     Gets or protected set s the key.
        //
        // Value:
        //     The key.
        public string Key { get; protected set ; }
        //
        // Summary:
        //     Gets the type.
        //
        // Value:
        //     The type.
        public string Type { get; protected set ; }
        //
        // Summary:
        //     Gets the subject identifier.
        //
        // Value:
        //     The subject identifier.
        public string SubjectId { get; protected set ; }
        //
        // Summary:
        //     Gets the session identifier.
        //
        // Value:
        //     The session identifier.
        public string SessionId { get; protected set ; }
        //
        // Summary:
        //     Gets the client identifier.
        //
        // Value:
        //     The client identifier.
        public string ClientId { get; protected set ; }
        //
        // Summary:
        //     Gets the description the user assigned to the device being authorized.
        //
        // Value:
        //     The description.
        public string Description { get; protected set ; }
        //
        // Summary:
        //     Gets or protected set s the creation time.
        //
        // Value:
        //     The creation time.
        public DateTime CreationTime { get; protected set ; }
        //
        // Summary:
        //     Gets or protected set s the expiration.
        //
        // Value:
        //     The expiration.
        public DateTime? Expiration { get; protected set ; }
        //
        // Summary:
        //     Gets or protected set s the consumed time.
        //
        // Value:
        //     The consumed time.
        public DateTime? ConsumedTime { get; protected set ; }
        //
        // Summary:
        //     Gets or protected set s the data.
        //
        // Value:
        //     The data.
        public string Data { get; protected set ; }
    }
}
