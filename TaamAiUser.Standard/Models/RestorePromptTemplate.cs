// <copyright file="RestorePromptTemplate.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace TaamAiUser.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using TaamAiUser.Standard;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// RestorePromptTemplate.
    /// </summary>
    public class RestorePromptTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePromptTemplate"/> class.
        /// </summary>
        public RestorePromptTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePromptTemplate"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        public RestorePromptTemplate(
            string status,
            string message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RestorePromptTemplate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is RestorePromptTemplate other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}