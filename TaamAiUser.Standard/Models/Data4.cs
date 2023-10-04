// <copyright file="Data4.cs" company="APIMatic">
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
    using TaamAiUser.Standard.Models.Containers;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// Data4.
    /// </summary>
    public class Data4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        public Data4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="language">language.</param>
        /// <param name="templateName">template_name.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="icon">icon.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="draft">draft.</param>
        /// <param name="languageName">language_name.</param>
        /// <param name="languageFlag">language_flag.</param>
        /// <param name="tokens">tokens.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="title">title.</param>
        /// <param name="inputText">input_text.</param>
        /// <param name="resultText">result_text.</param>
        /// <param name="model">model.</param>
        /// <param name="templateCode">template_code.</param>
        /// <param name="workbook">workbook.</param>
        /// <param name="tags">tags.</param>
        /// <param name="words">words.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data4(
            int id,
            int userId,
            string language,
            string templateName,
            int workbookId,
            int workbookFolderId,
            string icon,
            string mGroup,
            int draft,
            string languageName,
            string languageFlag,
            int tokens,
            string planType,
            string createdAt,
            string updatedAt,
            string title = null,
            string inputText = null,
            string resultText = null,
            string model = null,
            string templateCode = null,
            string workbook = null,
            string tags = null,
            Data4Words words = null,
            string deletedAt = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.Title = title;
            this.InputText = inputText;
            this.ResultText = resultText;
            this.Model = model;
            this.Language = language;
            this.TemplateCode = templateCode;
            this.TemplateName = templateName;
            this.Workbook = workbook;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.Icon = icon;
            this.MGroup = mGroup;
            this.Tags = tags;
            this.Draft = draft;
            this.LanguageName = languageName;
            this.LanguageFlag = languageFlag;
            this.Tokens = tokens;
            this.Words = words;
            this.PlanType = planType;
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
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Include)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets InputText.
        /// </summary>
        [JsonProperty("input_text", NullValueHandling = NullValueHandling.Include)]
        public string InputText { get; set; }

        /// <summary>
        /// Gets or sets ResultText.
        /// </summary>
        [JsonProperty("result_text", NullValueHandling = NullValueHandling.Include)]
        public string ResultText { get; set; }

        /// <summary>
        /// Gets or sets Model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Include)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets TemplateCode.
        /// </summary>
        [JsonProperty("template_code", NullValueHandling = NullValueHandling.Include)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// Gets or sets TemplateName.
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets Workbook.
        /// </summary>
        [JsonProperty("workbook", NullValueHandling = NullValueHandling.Include)]
        public string Workbook { get; set; }

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
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Include)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets Draft.
        /// </summary>
        [JsonProperty("draft")]
        public int Draft { get; set; }

        /// <summary>
        /// Gets or sets LanguageName.
        /// </summary>
        [JsonProperty("language_name")]
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets LanguageFlag.
        /// </summary>
        [JsonProperty("language_flag")]
        public string LanguageFlag { get; set; }

        /// <summary>
        /// Gets or sets Tokens.
        /// </summary>
        [JsonProperty("tokens")]
        public int Tokens { get; set; }

        /// <summary>
        /// Gets or sets Words.
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Include)]
        public Data4Words Words { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

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

            return $"Data4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data4 other &&                this.Id.Equals(other.Id) &&
                this.UserId.Equals(other.UserId) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.InputText == null && other.InputText == null) || (this.InputText?.Equals(other.InputText) == true)) &&
                ((this.ResultText == null && other.ResultText == null) || (this.ResultText?.Equals(other.ResultText) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.TemplateCode == null && other.TemplateCode == null) || (this.TemplateCode?.Equals(other.TemplateCode) == true)) &&
                ((this.TemplateName == null && other.TemplateName == null) || (this.TemplateName?.Equals(other.TemplateName) == true)) &&
                ((this.Workbook == null && other.Workbook == null) || (this.Workbook?.Equals(other.Workbook) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                ((this.Icon == null && other.Icon == null) || (this.Icon?.Equals(other.Icon) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                this.Draft.Equals(other.Draft) &&
                ((this.LanguageName == null && other.LanguageName == null) || (this.LanguageName?.Equals(other.LanguageName) == true)) &&
                ((this.LanguageFlag == null && other.LanguageFlag == null) || (this.LanguageFlag?.Equals(other.LanguageFlag) == true)) &&
                this.Tokens.Equals(other.Tokens) &&
                ((this.Words == null && other.Words == null) || (this.Words?.Equals(other.Words) == true)) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
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
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.InputText = {(this.InputText == null ? "null" : this.InputText)}");
            toStringOutput.Add($"this.ResultText = {(this.ResultText == null ? "null" : this.ResultText)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language)}");
            toStringOutput.Add($"this.TemplateCode = {(this.TemplateCode == null ? "null" : this.TemplateCode)}");
            toStringOutput.Add($"this.TemplateName = {(this.TemplateName == null ? "null" : this.TemplateName)}");
            toStringOutput.Add($"this.Workbook = {(this.Workbook == null ? "null" : this.Workbook)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.Icon = {(this.Icon == null ? "null" : this.Icon)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags)}");
            toStringOutput.Add($"this.Draft = {this.Draft}");
            toStringOutput.Add($"this.LanguageName = {(this.LanguageName == null ? "null" : this.LanguageName)}");
            toStringOutput.Add($"this.LanguageFlag = {(this.LanguageFlag == null ? "null" : this.LanguageFlag)}");
            toStringOutput.Add($"this.Tokens = {this.Tokens}");
            toStringOutput.Add($"Words = {(this.Words == null ? "null" : this.Words.ToString())}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
        }
    }
}