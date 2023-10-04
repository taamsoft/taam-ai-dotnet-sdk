// <copyright file="Data6.cs" company="APIMatic">
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
    /// Data6.
    /// </summary>
    public class Data6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        public Data6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="language">language.</param>
        /// <param name="languageFlag">language_flag.</param>
        /// <param name="voice">voice.</param>
        /// <param name="voiceId">voice_id.</param>
        /// <param name="gender">gender.</param>
        /// <param name="text">text.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="textRaw">text_raw.</param>
        /// <param name="fileName">file_name.</param>
        /// <param name="resultUrl">result_url.</param>
        /// <param name="resultExt">result_ext.</param>
        /// <param name="storage">storage.</param>
        /// <param name="title">title.</param>
        /// <param name="vendor">vendor.</param>
        /// <param name="vendorId">vendor_id.</param>
        /// <param name="characters">characters.</param>
        /// <param name="voiceType">voice_type.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="audioType">audio_type.</param>
        /// <param name="mode">mode.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="project">project.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data6(
            int id,
            int userId,
            string language,
            string languageFlag,
            string voice,
            string voiceId,
            string gender,
            string text,
            int workbookId,
            int workbookFolderId,
            string textRaw,
            string fileName,
            string resultUrl,
            string resultExt,
            string storage,
            string title,
            string vendor,
            string vendorId,
            int characters,
            string voiceType,
            string planType,
            string audioType,
            string mode,
            string createdAt,
            string updatedAt,
            string project = null,
            string expiresAt = null,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Language = language;
            this.LanguageFlag = languageFlag;
            this.Voice = voice;
            this.VoiceId = voiceId;
            this.Gender = gender;
            this.Text = text;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.TextRaw = textRaw;
            this.FileName = fileName;
            this.ResultUrl = resultUrl;
            this.ResultExt = resultExt;
            this.Storage = storage;
            this.Title = title;
            this.Vendor = vendor;
            this.VendorId = vendorId;
            this.Characters = characters;
            this.VoiceType = voiceType;
            this.PlanType = planType;
            this.AudioType = audioType;
            this.Mode = mode;
            this.Project = project;
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
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets LanguageFlag.
        /// </summary>
        [JsonProperty("language_flag")]
        public string LanguageFlag { get; set; }

        /// <summary>
        /// Gets or sets Voice.
        /// </summary>
        [JsonProperty("voice")]
        public string Voice { get; set; }

        /// <summary>
        /// Gets or sets VoiceId.
        /// </summary>
        [JsonProperty("voice_id")]
        public string VoiceId { get; set; }

        /// <summary>
        /// Gets or sets Gender.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

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
        /// Gets or sets TextRaw.
        /// </summary>
        [JsonProperty("text_raw")]
        public string TextRaw { get; set; }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets ResultUrl.
        /// </summary>
        [JsonProperty("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// Gets or sets ResultExt.
        /// </summary>
        [JsonProperty("result_ext")]
        public string ResultExt { get; set; }

        /// <summary>
        /// Gets or sets Storage.
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets VendorId.
        /// </summary>
        [JsonProperty("vendor_id")]
        public string VendorId { get; set; }

        /// <summary>
        /// Gets or sets Characters.
        /// </summary>
        [JsonProperty("characters")]
        public int Characters { get; set; }

        /// <summary>
        /// Gets or sets VoiceType.
        /// </summary>
        [JsonProperty("voice_type")]
        public string VoiceType { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets AudioType.
        /// </summary>
        [JsonProperty("audio_type")]
        public string AudioType { get; set; }

        /// <summary>
        /// Gets or sets Mode.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets Project.
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Include)]
        public string Project { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Include)]
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

            return $"Data6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data6 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.LanguageFlag == null && other.LanguageFlag == null) || (this.LanguageFlag?.Equals(other.LanguageFlag) == true)) &&
                ((this.Voice == null && other.Voice == null) || (this.Voice?.Equals(other.Voice) == true)) &&
                ((this.VoiceId == null && other.VoiceId == null) || (this.VoiceId?.Equals(other.VoiceId) == true)) &&
                ((this.Gender == null && other.Gender == null) || (this.Gender?.Equals(other.Gender) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                ((this.TextRaw == null && other.TextRaw == null) || (this.TextRaw?.Equals(other.TextRaw) == true)) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.ResultUrl == null && other.ResultUrl == null) || (this.ResultUrl?.Equals(other.ResultUrl) == true)) &&
                ((this.ResultExt == null && other.ResultExt == null) || (this.ResultExt?.Equals(other.ResultExt) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.VendorId == null && other.VendorId == null) || (this.VendorId?.Equals(other.VendorId) == true)) &&
                this.Characters.Equals(other.Characters) &&
                ((this.VoiceType == null && other.VoiceType == null) || (this.VoiceType?.Equals(other.VoiceType) == true)) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
                ((this.AudioType == null && other.AudioType == null) || (this.AudioType?.Equals(other.AudioType) == true)) &&
                ((this.Mode == null && other.Mode == null) || (this.Mode?.Equals(other.Mode) == true)) &&
                ((this.Project == null && other.Project == null) || (this.Project?.Equals(other.Project) == true)) &&
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
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language)}");
            toStringOutput.Add($"this.LanguageFlag = {(this.LanguageFlag == null ? "null" : this.LanguageFlag)}");
            toStringOutput.Add($"this.Voice = {(this.Voice == null ? "null" : this.Voice)}");
            toStringOutput.Add($"this.VoiceId = {(this.VoiceId == null ? "null" : this.VoiceId)}");
            toStringOutput.Add($"this.Gender = {(this.Gender == null ? "null" : this.Gender)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.TextRaw = {(this.TextRaw == null ? "null" : this.TextRaw)}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.ResultUrl = {(this.ResultUrl == null ? "null" : this.ResultUrl)}");
            toStringOutput.Add($"this.ResultExt = {(this.ResultExt == null ? "null" : this.ResultExt)}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : this.Vendor)}");
            toStringOutput.Add($"this.VendorId = {(this.VendorId == null ? "null" : this.VendorId)}");
            toStringOutput.Add($"this.Characters = {this.Characters}");
            toStringOutput.Add($"this.VoiceType = {(this.VoiceType == null ? "null" : this.VoiceType)}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.AudioType = {(this.AudioType == null ? "null" : this.AudioType)}");
            toStringOutput.Add($"this.Mode = {(this.Mode == null ? "null" : this.Mode)}");
            toStringOutput.Add($"this.Project = {(this.Project == null ? "null" : this.Project)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}