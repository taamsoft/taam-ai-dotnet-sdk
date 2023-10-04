// <copyright file="Data8.cs" company="APIMatic">
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
    /// Data8.
    /// </summary>
    public class Data8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        public Data8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="image">image.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="storage">storage.</param>
        /// <param name="imageName">image_name.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data8(
            int id,
            int userId,
            string name,
            string description,
            string image,
            int workbookId,
            int workbookFolderId,
            string storage,
            string imageName,
            string resolution,
            string planType,
            string expiresAt,
            string createdAt,
            string updatedAt,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.Storage = storage;
            this.ImageName = imageName;
            this.Resolution = resolution;
            this.PlanType = planType;
            this.ExpiresAt = expiresAt;
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
        /// Gets or sets Image.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets WorkbookId.
        /// </summary>
        [JsonProperty("workbook_id")]
        public int WorkbookId { get; set; }

        /// <summary>
        /// Gets or sets WorkbookFolderId.
        /// </summary>
        [JsonProperty("workbook_folder_id")]
        public int WorkbookFolderId { get; set; }

        /// <summary>
        /// Gets or sets Storage.
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets ImageName.
        /// </summary>
        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets Resolution.
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

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

            return $"Data8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data8 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.ImageName == null && other.ImageName == null) || (this.ImageName?.Equals(other.ImageName) == true)) &&
                ((this.Resolution == null && other.Resolution == null) || (this.Resolution?.Equals(other.Resolution) == true)) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
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
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage)}");
            toStringOutput.Add($"this.ImageName = {(this.ImageName == null ? "null" : this.ImageName)}");
            toStringOutput.Add($"this.Resolution = {(this.Resolution == null ? "null" : this.Resolution)}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}