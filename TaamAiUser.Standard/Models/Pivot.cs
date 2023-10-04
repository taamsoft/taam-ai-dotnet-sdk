// <copyright file="Pivot.cs" company="APIMatic">
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
    /// Pivot.
    /// </summary>
    public class Pivot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pivot"/> class.
        /// </summary>
        public Pivot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pivot"/> class.
        /// </summary>
        /// <param name="modelId">model_id.</param>
        /// <param name="roleId">role_id.</param>
        /// <param name="modelType">model_type.</param>
        public Pivot(
            int modelId,
            int roleId,
            string modelType)
        {
            this.ModelId = modelId;
            this.RoleId = roleId;
            this.ModelType = modelType;
        }

        /// <summary>
        /// Gets or sets ModelId.
        /// </summary>
        [JsonProperty("model_id")]
        public int ModelId { get; set; }

        /// <summary>
        /// Gets or sets RoleId.
        /// </summary>
        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets ModelType.
        /// </summary>
        [JsonProperty("model_type")]
        public string ModelType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Pivot : ({string.Join(", ", toStringOutput)})";
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
            return obj is Pivot other &&                this.ModelId.Equals(other.ModelId) &&
                this.RoleId.Equals(other.RoleId) &&
                ((this.ModelType == null && other.ModelType == null) || (this.ModelType?.Equals(other.ModelType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ModelId = {this.ModelId}");
            toStringOutput.Add($"this.RoleId = {this.RoleId}");
            toStringOutput.Add($"this.ModelType = {(this.ModelType == null ? "null" : this.ModelType)}");
        }
    }
}