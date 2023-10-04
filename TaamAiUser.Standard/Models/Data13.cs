// <copyright file="Data13.cs" company="APIMatic">
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
    /// Data13.
    /// </summary>
    public class Data13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data13"/> class.
        /// </summary>
        public Data13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data13"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="bulletPoints">bullet_points.</param>
        /// <param name="targetAudience">target_audience.</param>
        /// <param name="featureImage">feature_image.</param>
        /// <param name="tags">tags.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data13(
            int id,
            int userId,
            string name,
            string description,
            string bulletPoints,
            string targetAudience,
            string featureImage = null,
            string tags = null,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Name = name;
            this.Description = description;
            this.FeatureImage = featureImage;
            this.BulletPoints = bulletPoints;
            this.TargetAudience = targetAudience;
            this.Tags = tags;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets FeatureImage.
        /// </summary>
        [JsonProperty("feature_image", NullValueHandling = NullValueHandling.Include)]
        public string FeatureImage { get; set; }

        /// <summary>
        /// Gets or sets BulletPoints.
        /// </summary>
        [JsonProperty("bullet_points")]
        public string BulletPoints { get; set; }

        /// <summary>
        /// Gets or sets TargetAudience.
        /// </summary>
        [JsonProperty("target_audience")]
        public string TargetAudience { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Include)]
        public string Tags { get; set; }

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

            return $"Data13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data13 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.FeatureImage == null && other.FeatureImage == null) || (this.FeatureImage?.Equals(other.FeatureImage) == true)) &&
                ((this.BulletPoints == null && other.BulletPoints == null) || (this.BulletPoints?.Equals(other.BulletPoints) == true)) &&
                ((this.TargetAudience == null && other.TargetAudience == null) || (this.TargetAudience?.Equals(other.TargetAudience) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.FeatureImage = {(this.FeatureImage == null ? "null" : this.FeatureImage)}");
            toStringOutput.Add($"this.BulletPoints = {(this.BulletPoints == null ? "null" : this.BulletPoints)}");
            toStringOutput.Add($"this.TargetAudience = {(this.TargetAudience == null ? "null" : this.TargetAudience)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}