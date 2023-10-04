// <copyright file="Data9.cs" company="APIMatic">
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
    /// Data9.
    /// </summary>
    public class Data9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data9"/> class.
        /// </summary>
        public Data9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data9"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="model">model.</param>
        /// <param name="title">title.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="code">code.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data9(
            int id,
            int userId,
            string model,
            string title,
            string instructions,
            string code,
            int workbookId,
            int workbookFolderId,
            string createdAt,
            string updatedAt,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Model = model;
            this.Title = title;
            this.Instructions = instructions;
            this.Code = code;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
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
        /// Gets or sets Model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Instructions.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

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

            return $"Data9 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data9 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
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
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}