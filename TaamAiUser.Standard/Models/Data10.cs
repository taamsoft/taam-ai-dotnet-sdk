// <copyright file="Data10.cs" company="APIMatic">
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
    /// Data10.
    /// </summary>
    public class Data10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        public Data10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="subName">sub_name.</param>
        /// <param name="chatCode">chat_code.</param>
        /// <param name="logo">logo.</param>
        /// <param name="status">status.</param>
        /// <param name="prompt">prompt.</param>
        /// <param name="description">description.</param>
        /// <param name="category">category.</param>
        /// <param name="type">type.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data10(
            int id,
            string name,
            string subName,
            string chatCode,
            string logo,
            int status,
            string prompt,
            string description,
            string category,
            string type,
            string createdAt,
            string updatedAt,
            string deletedAt = null)
        {
            this.Id = id;
            this.Name = name;
            this.SubName = subName;
            this.ChatCode = chatCode;
            this.Logo = logo;
            this.Status = status;
            this.Prompt = prompt;
            this.Description = description;
            this.Category = category;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SubName.
        /// </summary>
        [JsonProperty("sub_name")]
        public string SubName { get; set; }

        /// <summary>
        /// Gets or sets ChatCode.
        /// </summary>
        [JsonProperty("chat_code")]
        public string ChatCode { get; set; }

        /// <summary>
        /// Gets or sets Logo.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets Prompt.
        /// </summary>
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Include)]
        public string DeletedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data10 other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SubName == null && other.SubName == null) || (this.SubName?.Equals(other.SubName) == true)) &&
                ((this.ChatCode == null && other.ChatCode == null) || (this.ChatCode?.Equals(other.ChatCode) == true)) &&
                ((this.Logo == null && other.Logo == null) || (this.Logo?.Equals(other.Logo) == true)) &&
                this.Status.Equals(other.Status) &&
                ((this.Prompt == null && other.Prompt == null) || (this.Prompt?.Equals(other.Prompt) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.SubName = {(this.SubName == null ? "null" : this.SubName)}");
            toStringOutput.Add($"this.ChatCode = {(this.ChatCode == null ? "null" : this.ChatCode)}");
            toStringOutput.Add($"this.Logo = {(this.Logo == null ? "null" : this.Logo)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Prompt = {(this.Prompt == null ? "null" : this.Prompt)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}