// <copyright file="ContentsInWorkBook.cs" company="APIMatic">
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
    /// ContentsInWorkBook.
    /// </summary>
    public class ContentsInWorkBook
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsInWorkBook"/> class.
        /// </summary>
        public ContentsInWorkBook()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsInWorkBook"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="count">count.</param>
        /// <param name="data">data.</param>
        public ContentsInWorkBook(
            string status,
            string message,
            int count,
            List<Models.Data4> data)
        {
            this.Status = status;
            this.Message = message;
            this.Count = count;
            this.Data = data;
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

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.Data4> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContentsInWorkBook : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContentsInWorkBook other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.Count.Equals(other.Count) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}