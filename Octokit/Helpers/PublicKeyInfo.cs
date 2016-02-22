﻿using System;

namespace Octokit
{
    /// <summary>
    /// Represents the data and name parsed from a PublicKey.
    /// </summary>
    public class PublicKeyInfo
    {
        public PublicKeyInfo(string data, string name)
        {
            Ensure.ArgumentNotNull(data, "data");
            Ensure.ArgumentNotNull(name, "name");

            Data = data;
            Name = name;
        }

        public string Data { get; private set; }
        public string Name { get; private set; }
    }
}