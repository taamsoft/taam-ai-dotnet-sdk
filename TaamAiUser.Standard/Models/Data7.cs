// <copyright file="Data7.cs" company="APIMatic">
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
    /// Data7.
    /// </summary>
    public class Data7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data7"/> class.
        /// </summary>
        public Data7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data7"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="url">url.</param>
        /// <param name="transcript">transcript.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="title">title.</param>
        /// <param name="workbook">workbook.</param>
        /// <param name="task">task.</param>
        /// <param name="words">words.</param>
        /// <param name="format">format.</param>
        /// <param name="audioType">audio_type.</param>
        /// <param name="storage">storage.</param>
        /// <param name="length">length.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="size">size.</param>
        /// <param name="fileName">file_name.</param>
        /// <param name="tempName">temp_name.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="description">description.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data7(
            int id,
            int userId,
            string url,
            string transcript,
            int workbookId,
            int workbookFolderId,
            string title,
            string workbook,
            string task,
            int words,
            string format,
            string audioType,
            string storage,
            string length,
            string planType,
            string size,
            string fileName,
            string tempName,
            string expiresAt,
            string createdAt,
            string updatedAt,
            string description = null,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Url = url;
            this.Transcript = transcript;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.Title = title;
            this.Workbook = workbook;
            this.Task = task;
            this.Words = words;
            this.Format = format;
            this.AudioType = audioType;
            this.Description = description;
            this.Storage = storage;
            this.Length = length;
            this.PlanType = planType;
            this.Size = size;
            this.FileName = fileName;
            this.TempName = tempName;
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
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Transcript.
        /// </summary>
        [JsonProperty("transcript")]
        public string Transcript { get; set; }

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
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Workbook.
        /// </summary>
        [JsonProperty("workbook")]
        public string Workbook { get; set; }

        /// <summary>
        /// Gets or sets Task.
        /// </summary>
        [JsonProperty("task")]
        public string Task { get; set; }

        /// <summary>
        /// Gets or sets Words.
        /// </summary>
        [JsonProperty("words")]
        public int Words { get; set; }

        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets AudioType.
        /// </summary>
        [JsonProperty("audio_type")]
        public string AudioType { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Storage.
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Length.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets TempName.
        /// </summary>
        [JsonProperty("temp_name")]
        public string TempName { get; set; }

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

            return $"Data7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data7 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Transcript == null && other.Transcript == null) || (this.Transcript?.Equals(other.Transcript) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Workbook == null && other.Workbook == null) || (this.Workbook?.Equals(other.Workbook) == true)) &&
                ((this.Task == null && other.Task == null) || (this.Task?.Equals(other.Task) == true)) &&
                this.Words.Equals(other.Words) &&
                ((this.Format == null && other.Format == null) || (this.Format?.Equals(other.Format) == true)) &&
                ((this.AudioType == null && other.AudioType == null) || (this.AudioType?.Equals(other.AudioType) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.Length == null && other.Length == null) || (this.Length?.Equals(other.Length) == true)) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.TempName == null && other.TempName == null) || (this.TempName?.Equals(other.TempName) == true)) &&
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
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Transcript = {(this.Transcript == null ? "null" : this.Transcript)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Workbook = {(this.Workbook == null ? "null" : this.Workbook)}");
            toStringOutput.Add($"this.Task = {(this.Task == null ? "null" : this.Task)}");
            toStringOutput.Add($"this.Words = {this.Words}");
            toStringOutput.Add($"this.Format = {(this.Format == null ? "null" : this.Format)}");
            toStringOutput.Add($"this.AudioType = {(this.AudioType == null ? "null" : this.AudioType)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage)}");
            toStringOutput.Add($"this.Length = {(this.Length == null ? "null" : this.Length)}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size)}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.TempName = {(this.TempName == null ? "null" : this.TempName)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}