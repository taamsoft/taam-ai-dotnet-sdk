// <copyright file="GenerateCode.cs" company="APIMatic">
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
    /// GenerateCode.
    /// </summary>
    public class GenerateCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCode"/> class.
        /// </summary>
        public GenerateCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCode"/> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="status">status.</param>
        /// <param name="id">id.</param>
        /// <param name="old">old.</param>
        /// <param name="current">current.</param>
        public GenerateCode(
            string text,
            string status,
            int id,
            string old,
            int current)
        {
            this.Text = text;
            this.Status = status;
            this.Id = id;
            this.Old = old;
            this.Current = current;
        }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Old.
        /// </summary>
        [JsonProperty("old")]
        public string Old { get; set; }

        /// <summary>
        /// Gets or sets Current.
        /// </summary>
        [JsonProperty("current")]
        public int Current { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GenerateCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateCode other &&                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.Old == null && other.Old == null) || (this.Old?.Equals(other.Old) == true)) &&
                this.Current.Equals(other.Current);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Old = {(this.Old == null ? "null" : this.Old)}");
            toStringOutput.Add($"this.Current = {this.Current}");
        }
    }
}