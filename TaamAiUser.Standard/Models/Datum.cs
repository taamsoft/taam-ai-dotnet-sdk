// <copyright file="Datum.cs" company="APIMatic">
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
    /// Datum.
    /// </summary>
    public class Datum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Datum"/> class.
        /// </summary>
        public Datum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Datum"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="icon">icon.</param>
        /// <param name="popular">popular.</param>
        /// <param name="description">description.</param>
        /// <param name="templateCode">template_code.</param>
        /// <param name="status">status.</param>
        /// <param name="professional">professional.</param>
        /// <param name="mNew">new.</param>
        /// <param name="type">type.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="slug">slug.</param>
        /// <param name="package">package.</param>
        /// <param name="fields">fields.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="image">image.</param>
        public Datum(
            int id,
            string name,
            string icon,
            int popular,
            string description,
            string templateCode,
            int status,
            int professional,
            int mNew,
            string type,
            string mGroup,
            string slug,
            string package,
            string fields,
            string createdAt,
            string updatedAt,
            string image = null)
        {
            this.Id = id;
            this.Name = name;
            this.Icon = icon;
            this.Image = image;
            this.Popular = popular;
            this.Description = description;
            this.TemplateCode = templateCode;
            this.Status = status;
            this.Professional = professional;
            this.MNew = mNew;
            this.Type = type;
            this.MGroup = mGroup;
            this.Slug = slug;
            this.Package = package;
            this.Fields = fields;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
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
        /// Gets or sets Icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Include)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets Popular.
        /// </summary>
        [JsonProperty("popular")]
        public int Popular { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets TemplateCode.
        /// </summary>
        [JsonProperty("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets Professional.
        /// </summary>
        [JsonProperty("professional")]
        public int Professional { get; set; }

        /// <summary>
        /// Gets or sets MNew.
        /// </summary>
        [JsonProperty("new")]
        public int MNew { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

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
        /// Gets or sets Package.
        /// </summary>
        [JsonProperty("package")]
        public string Package { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Datum : ({string.Join(", ", toStringOutput)})";
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
            return obj is Datum other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Icon == null && other.Icon == null) || (this.Icon?.Equals(other.Icon) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                this.Popular.Equals(other.Popular) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.TemplateCode == null && other.TemplateCode == null) || (this.TemplateCode?.Equals(other.TemplateCode) == true)) &&
                this.Status.Equals(other.Status) &&
                this.Professional.Equals(other.Professional) &&
                this.MNew.Equals(other.MNew) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Slug == null && other.Slug == null) || (this.Slug?.Equals(other.Slug) == true)) &&
                ((this.Package == null && other.Package == null) || (this.Package?.Equals(other.Package) == true)) &&
                ((this.Fields == null && other.Fields == null) || (this.Fields?.Equals(other.Fields) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Icon = {(this.Icon == null ? "null" : this.Icon)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.Popular = {this.Popular}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.TemplateCode = {(this.TemplateCode == null ? "null" : this.TemplateCode)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Professional = {this.Professional}");
            toStringOutput.Add($"this.MNew = {this.MNew}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup)}");
            toStringOutput.Add($"this.Slug = {(this.Slug == null ? "null" : this.Slug)}");
            toStringOutput.Add($"this.Package = {(this.Package == null ? "null" : this.Package)}");
            toStringOutput.Add($"this.Fields = {(this.Fields == null ? "null" : this.Fields)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
        }
    }
}