﻿using Newtonsoft.Json;

namespace Pawotter.Core.Entities
{
    public class Token
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Initializes for JSON.NET
        /// </summary>
        internal Token() { }

        public Token(string accessToken, string tokenType, string scope, string createdAt)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            Scope = scope;
            CreatedAt = createdAt;
        }

        public override string ToString() => string.Format("[Token: AccessToken={0}, TokenType={1}, Scope={2}, CreatedAt={3}]", AccessToken, TokenType, Scope, CreatedAt);

        public override bool Equals(object obj)
        {
            var o = obj as Token;
            if (o == null) return false;
            return Equals(AccessToken, o.AccessToken) &&
                Equals(TokenType, o.TokenType) &&
                Equals(Scope, o.Scope) &&
                Equals(CreatedAt, o.CreatedAt);
        }

        public override int GetHashCode() => Object.GetHashCode(AccessToken, TokenType, Scope, CreatedAt);
    }
}
