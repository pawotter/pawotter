﻿using Newtonsoft.Json;

namespace Pawotter.Core.Entities
{
    /// <summary>
    /// Error.
    /// https://github.com/tootsuite/documentation/blob/master/Using-the-API/API.md#error
    /// </summary>
    public class Error
    {
        [JsonProperty(PropertyName = "error")]
        public string Description { get; set; }

        public Error(string error)
        {
            Description = error;
        }

        public override string ToString() => string.Format("[Error: Description={0}]", Description);

        public override bool Equals(object obj)
        {
            var o = obj as Error;
            if (o == null) return false;
            return Equals(Description, o.Description);
        }

        public override int GetHashCode() => Object.GetHashCode(Description);
    }
}
