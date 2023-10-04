// <copyright file="Field.cs" company="APIMatic">
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
    /// Field.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        public Field()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="input">input.</param>
        /// <param name="code">code.</param>
        public Field(
            string name,
            string placeholder,
            string input,
            string code)
        {
            this.Name = name;
            this.Placeholder = placeholder;
            this.Input = input;
            this.Code = code;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Placeholder.
        /// </summary>
        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or sets Input.
        /// </summary>
        [JsonProperty("input")]
        public string Input { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Field : ({string.Join(", ", toStringOutput)})";
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
            return obj is Field other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Placeholder == null && other.Placeholder == null) || (this.Placeholder?.Equals(other.Placeholder) == true)) &&
                ((this.Input == null && other.Input == null) || (this.Input?.Equals(other.Input) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Placeholder = {(this.Placeholder == null ? "null" : this.Placeholder)}");
            toStringOutput.Add($"this.Input = {(this.Input == null ? "null" : this.Input)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
        }
    }
}