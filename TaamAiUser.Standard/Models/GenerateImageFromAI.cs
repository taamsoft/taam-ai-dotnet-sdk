// <copyright file="GenerateImageFromAI.cs" company="APIMatic">
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
    /// GenerateImageFromAI.
    /// </summary>
    public class GenerateImageFromAI
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageFromAI"/> class.
        /// </summary>
        public GenerateImageFromAI()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageFromAI"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="old">old.</param>
        /// <param name="current">current.</param>
        /// <param name="data">data.</param>
        public GenerateImageFromAI(
            string status,
            string old,
            int current,
            Models.Data17 data)
        {
            this.Status = status;
            this.Old = old;
            this.Current = current;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

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

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data17 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GenerateImageFromAI : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateImageFromAI other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Old == null && other.Old == null) || (this.Old?.Equals(other.Old) == true)) &&
                this.Current.Equals(other.Current) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Old = {(this.Old == null ? "null" : this.Old)}");
            toStringOutput.Add($"this.Current = {this.Current}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}