// <copyright file="Data12.cs" company="APIMatic">
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
    /// Data12.
    /// </summary>
    public class Data12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data12"/> class.
        /// </summary>
        public Data12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data12"/> class.
        /// </summary>
        /// <param name="userId">user_id.</param>
        /// <param name="status">status.</param>
        /// <param name="professional">professional.</param>
        /// <param name="templateCode">template_code.</param>
        /// <param name="name">name.</param>
        /// <param name="icon">icon.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="slug">slug.</param>
        /// <param name="prompt">prompt.</param>
        /// <param name="tone">tone.</param>
        /// <param name="fields">fields.</param>
        /// <param name="package">package.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        public Data12(
            string userId,
            bool status,
            bool professional,
            string templateCode,
            string name,
            string icon,
            string mGroup,
            string slug,
            string prompt,
            bool tone,
            List<Models.Field> fields,
            string package,
            string updatedAt,
            string createdAt,
            int id,
            string description = null)
        {
            this.UserId = userId;
            this.Description = description;
            this.Status = status;
            this.Professional = professional;
            this.TemplateCode = templateCode;
            this.Name = name;
            this.Icon = icon;
            this.MGroup = mGroup;
            this.Slug = slug;
            this.Prompt = prompt;
            this.Tone = tone;
            this.Fields = fields;
            this.Package = package;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets Professional.
        /// </summary>
        [JsonProperty("professional")]
        public bool Professional { get; set; }

        /// <summary>
        /// Gets or sets TemplateCode.
        /// </summary>
        [JsonProperty("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group")]
        public string MGroup { get; set; }

        /// <summary>
        /// Gets or sets Slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets Prompt.
        /// </summary>
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// Gets or sets Tone.
        /// </summary>
        [JsonProperty("tone")]
        public bool Tone { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields")]
        public List<Models.Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets Package.
        /// </summary>
        [JsonProperty("package")]
        public string Package { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

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

            return $"Data12 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data12 other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Status.Equals(other.Status) &&
                this.Professional.Equals(other.Professional) &&
                ((this.TemplateCode == null && other.TemplateCode == null) || (this.TemplateCode?.Equals(other.TemplateCode) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Icon == null && other.Icon == null) || (this.Icon?.Equals(other.Icon) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Slug == null && other.Slug == null) || (this.Slug?.Equals(other.Slug) == true)) &&
                ((this.Prompt == null && other.Prompt == null) || (this.Prompt?.Equals(other.Prompt) == true)) &&
                this.Tone.Equals(other.Tone) &&
                ((this.Fields == null && other.Fields == null) || (this.Fields?.Equals(other.Fields) == true)) &&
                ((this.Package == null && other.Package == null) || (this.Package?.Equals(other.Package) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                this.Id.Equals(other.Id);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Professional = {this.Professional}");
            toStringOutput.Add($"this.TemplateCode = {(this.TemplateCode == null ? "null" : this.TemplateCode)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Icon = {(this.Icon == null ? "null" : this.Icon)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup)}");
            toStringOutput.Add($"this.Slug = {(this.Slug == null ? "null" : this.Slug)}");
            toStringOutput.Add($"this.Prompt = {(this.Prompt == null ? "null" : this.Prompt)}");
            toStringOutput.Add($"this.Tone = {this.Tone}");
            toStringOutput.Add($"this.Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");
            toStringOutput.Add($"this.Package = {(this.Package == null ? "null" : this.Package)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.Id = {this.Id}");
        }
    }
}