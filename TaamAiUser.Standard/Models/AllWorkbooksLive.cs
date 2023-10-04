// <copyright file="AllWorkbooksLive.cs" company="APIMatic">
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
    /// AllWorkbooksLive.
    /// </summary>
    public class AllWorkbooksLive
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllWorkbooksLive"/> class.
        /// </summary>
        public AllWorkbooksLive()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllWorkbooksLive"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="status">status.</param>
        /// <param name="mesaage">mesaage.</param>
        /// <param name="data">data.</param>
        public AllWorkbooksLive(
            int code,
            string status,
            string mesaage,
            List<Models.Datum1> data)
        {
            this.Code = code;
            this.Status = status;
            this.Mesaage = mesaage;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Mesaage.
        /// </summary>
        [JsonProperty("mesaage")]
        public string Mesaage { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.Datum1> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllWorkbooksLive : ({string.Join(", ", toStringOutput)})";
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
            return obj is AllWorkbooksLive other &&                this.Code.Equals(other.Code) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Mesaage == null && other.Mesaage == null) || (this.Mesaage?.Equals(other.Mesaage) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {this.Code}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Mesaage = {(this.Mesaage == null ? "null" : this.Mesaage)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}