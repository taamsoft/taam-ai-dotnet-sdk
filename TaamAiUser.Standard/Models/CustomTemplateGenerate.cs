// <copyright file="CustomTemplateGenerate.cs" company="APIMatic">
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
    /// CustomTemplateGenerate.
    /// </summary>
    public class CustomTemplateGenerate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTemplateGenerate"/> class.
        /// </summary>
        public CustomTemplateGenerate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTemplateGenerate"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="maxResults">max_results.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="maxWords">max_words.</param>
        /// <param name="id">id.</param>
        public CustomTemplateGenerate(
            string status,
            string maxResults,
            string temperature,
            int maxWords,
            int id)
        {
            this.Status = status;
            this.MaxResults = maxResults;
            this.Temperature = temperature;
            this.MaxWords = maxWords;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets MaxResults.
        /// </summary>
        [JsonProperty("max_results")]
        public string MaxResults { get; set; }

        /// <summary>
        /// Gets or sets Temperature.
        /// </summary>
        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or sets MaxWords.
        /// </summary>
        [JsonProperty("max_words")]
        public int MaxWords { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomTemplateGenerate : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomTemplateGenerate other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MaxResults == null && other.MaxResults == null) || (this.MaxResults?.Equals(other.MaxResults) == true)) &&
                ((this.Temperature == null && other.Temperature == null) || (this.Temperature?.Equals(other.Temperature) == true)) &&
                this.MaxWords.Equals(other.MaxWords) &&
                this.Id.Equals(other.Id);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.MaxResults = {(this.MaxResults == null ? "null" : this.MaxResults)}");
            toStringOutput.Add($"this.Temperature = {(this.Temperature == null ? "null" : this.Temperature)}");
            toStringOutput.Add($"this.MaxWords = {this.MaxWords}");
            toStringOutput.Add($"this.Id = {this.Id}");
        }
    }
}