// <copyright file="PromptTemplateLikeOrRemoveFromLike.cs" company="APIMatic">
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
    /// PromptTemplateLikeOrRemoveFromLike.
    /// </summary>
    public class PromptTemplateLikeOrRemoveFromLike
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplateLikeOrRemoveFromLike"/> class.
        /// </summary>
        public PromptTemplateLikeOrRemoveFromLike()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplateLikeOrRemoveFromLike"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="count">count.</param>
        public PromptTemplateLikeOrRemoveFromLike(
            string status,
            string message,
            int count)
        {
            this.Status = status;
            this.Message = message;
            this.Count = count;
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

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PromptTemplateLikeOrRemoveFromLike : ({string.Join(", ", toStringOutput)})";
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
            return obj is PromptTemplateLikeOrRemoveFromLike other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.Count.Equals(other.Count);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Count = {this.Count}");
        }
    }
}