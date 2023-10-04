// <copyright file="Data17.cs" company="APIMatic">
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
    /// Data17.
    /// </summary>
    public class Data17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        public Data17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        /// <param name="userId">user_id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="image">image.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="storage">storage.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="imageName">image_name.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="id">id.</param>
        /// <param name="imageUrl">image_url.</param>
        public Data17(
            int userId,
            string name,
            string description,
            string resolution,
            string image,
            string planType,
            string storage,
            string expiresAt,
            string imageName,
            string workbookId,
            string workbookFolderId,
            string updatedAt,
            string createdAt,
            int id,
            string imageUrl)
        {
            this.UserId = userId;
            this.Name = name;
            this.Description = description;
            this.Resolution = resolution;
            this.Image = image;
            this.PlanType = planType;
            this.Storage = storage;
            this.ExpiresAt = expiresAt;
            this.ImageName = imageName;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.ImageUrl = imageUrl;
        }

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
        /// Gets or sets Resolution.
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets Storage.
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets ImageName.
        /// </summary>
        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets WorkbookId.
        /// </summary>
        [JsonProperty("workbook_id")]
        public string WorkbookId { get; set; }

        /// <summary>
        /// Gets or sets WorkbookFolderId.
        /// </summary>
        [JsonProperty("workbook_folder_id")]
        public string WorkbookFolderId { get; set; }

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

        /// <summary>
        /// Gets or sets ImageUrl.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data17 other &&                this.UserId.Equals(other.UserId) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Resolution == null && other.Resolution == null) || (this.Resolution?.Equals(other.Resolution) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.ImageName == null && other.ImageName == null) || (this.ImageName?.Equals(other.ImageName) == true)) &&
                ((this.WorkbookId == null && other.WorkbookId == null) || (this.WorkbookId?.Equals(other.WorkbookId) == true)) &&
                ((this.WorkbookFolderId == null && other.WorkbookFolderId == null) || (this.WorkbookFolderId?.Equals(other.WorkbookFolderId) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.ImageUrl == null && other.ImageUrl == null) || (this.ImageUrl?.Equals(other.ImageUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Resolution = {(this.Resolution == null ? "null" : this.Resolution)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.ImageName = {(this.ImageName == null ? "null" : this.ImageName)}");
            toStringOutput.Add($"this.WorkbookId = {(this.WorkbookId == null ? "null" : this.WorkbookId)}");
            toStringOutput.Add($"this.WorkbookFolderId = {(this.WorkbookFolderId == null ? "null" : this.WorkbookFolderId)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.ImageUrl = {(this.ImageUrl == null ? "null" : this.ImageUrl)}");
        }
    }
}