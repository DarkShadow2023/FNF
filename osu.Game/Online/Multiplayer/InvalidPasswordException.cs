﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.SignalR;

namespace osu.Game.Online.Multiplayer
{
    [Serializable]
    public class InvalidPasswordException : HubException
    {
        public InvalidPasswordException()
        {
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
