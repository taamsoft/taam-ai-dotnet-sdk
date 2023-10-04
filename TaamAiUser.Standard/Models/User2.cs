// <copyright file="User2.cs" company="APIMatic">
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
    /// User2.
    /// </summary>
    public class User2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User2"/> class.
        /// </summary>
        public User2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User2"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="country">country.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="id">id.</param>
        /// <param name="emailVerifiedAt">email_verified_at.</param>
        /// <param name="status">status.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="availableWordsPrepaid">available_words_prepaid.</param>
        /// <param name="availableImagesPrepaid">available_images_prepaid.</param>
        /// <param name="availableCharsPrepaid">available_chars_prepaid.</param>
        /// <param name="availableMinutesPrepaid">available_minutes_prepaid.</param>
        /// <param name="defaultVoiceoverLanguage">default_voiceover_language.</param>
        /// <param name="defaultVoiceoverVoice">default_voiceover_voice.</param>
        /// <param name="jobRole">job_role.</param>
        /// <param name="referralId">referral_id.</param>
        /// <param name="referredBy">referred_by.</param>
        /// <param name="workbook">workbook.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="planId">plan_id.</param>
        /// <param name="totalWords">total_words.</param>
        /// <param name="totalImages">total_images.</param>
        /// <param name="totalChars">total_chars.</param>
        /// <param name="totalMinutes">total_minutes.</param>
        /// <param name="availableWords">available_words.</param>
        /// <param name="availableImages">available_images.</param>
        /// <param name="availableChars">available_chars.</param>
        /// <param name="availableMinutes">available_minutes.</param>
        /// <param name="roles">roles.</param>
        public User2(
            string name,
            string email,
            string country,
            string updatedAt,
            string createdAt,
            int id,
            string emailVerifiedAt,
            string status,
            string mGroup,
            string availableWordsPrepaid,
            string availableImagesPrepaid,
            string availableCharsPrepaid,
            string availableMinutesPrepaid,
            string defaultVoiceoverLanguage,
            string defaultVoiceoverVoice,
            string jobRole,
            string referralId,
            string referredBy,
            string workbook,
            int workbookId,
            int workbookFolderId,
            int planId,
            int totalWords,
            int totalImages,
            int totalChars,
            int totalMinutes,
            int availableWords,
            int availableImages,
            int availableChars,
            int availableMinutes,
            List<Models.Role> roles)
        {
            this.Name = name;
            this.Email = email;
            this.Country = country;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.EmailVerifiedAt = emailVerifiedAt;
            this.Status = status;
            this.MGroup = mGroup;
            this.AvailableWordsPrepaid = availableWordsPrepaid;
            this.AvailableImagesPrepaid = availableImagesPrepaid;
            this.AvailableCharsPrepaid = availableCharsPrepaid;
            this.AvailableMinutesPrepaid = availableMinutesPrepaid;
            this.DefaultVoiceoverLanguage = defaultVoiceoverLanguage;
            this.DefaultVoiceoverVoice = defaultVoiceoverVoice;
            this.JobRole = jobRole;
            this.ReferralId = referralId;
            this.ReferredBy = referredBy;
            this.Workbook = workbook;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.PlanId = planId;
            this.TotalWords = totalWords;
            this.TotalImages = totalImages;
            this.TotalChars = totalChars;
            this.TotalMinutes = totalMinutes;
            this.AvailableWords = availableWords;
            this.AvailableImages = availableImages;
            this.AvailableChars = availableChars;
            this.AvailableMinutes = availableMinutes;
            this.Roles = roles;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

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
        /// Gets or sets EmailVerifiedAt.
        /// </summary>
        [JsonProperty("email_verified_at")]
        public string EmailVerifiedAt { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group")]
        public string MGroup { get; set; }

        /// <summary>
        /// Gets or sets AvailableWordsPrepaid.
        /// </summary>
        [JsonProperty("available_words_prepaid")]
        public string AvailableWordsPrepaid { get; set; }

        /// <summary>
        /// Gets or sets AvailableImagesPrepaid.
        /// </summary>
        [JsonProperty("available_images_prepaid")]
        public string AvailableImagesPrepaid { get; set; }

        /// <summary>
        /// Gets or sets AvailableCharsPrepaid.
        /// </summary>
        [JsonProperty("available_chars_prepaid")]
        public string AvailableCharsPrepaid { get; set; }

        /// <summary>
        /// Gets or sets AvailableMinutesPrepaid.
        /// </summary>
        [JsonProperty("available_minutes_prepaid")]
        public string AvailableMinutesPrepaid { get; set; }

        /// <summary>
        /// Gets or sets DefaultVoiceoverLanguage.
        /// </summary>
        [JsonProperty("default_voiceover_language")]
        public string DefaultVoiceoverLanguage { get; set; }

        /// <summary>
        /// Gets or sets DefaultVoiceoverVoice.
        /// </summary>
        [JsonProperty("default_voiceover_voice")]
        public string DefaultVoiceoverVoice { get; set; }

        /// <summary>
        /// Gets or sets JobRole.
        /// </summary>
        [JsonProperty("job_role")]
        public string JobRole { get; set; }

        /// <summary>
        /// Gets or sets ReferralId.
        /// </summary>
        [JsonProperty("referral_id")]
        public string ReferralId { get; set; }

        /// <summary>
        /// Gets or sets ReferredBy.
        /// </summary>
        [JsonProperty("referred_by")]
        public string ReferredBy { get; set; }

        /// <summary>
        /// Gets or sets Workbook.
        /// </summary>
        [JsonProperty("workbook")]
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
        /// Gets or sets PlanId.
        /// </summary>
        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Gets or sets TotalWords.
        /// </summary>
        [JsonProperty("total_words")]
        public int TotalWords { get; set; }

        /// <summary>
        /// Gets or sets TotalImages.
        /// </summary>
        [JsonProperty("total_images")]
        public int TotalImages { get; set; }

        /// <summary>
        /// Gets or sets TotalChars.
        /// </summary>
        [JsonProperty("total_chars")]
        public int TotalChars { get; set; }

        /// <summary>
        /// Gets or sets TotalMinutes.
        /// </summary>
        [JsonProperty("total_minutes")]
        public int TotalMinutes { get; set; }

        /// <summary>
        /// Gets or sets AvailableWords.
        /// </summary>
        [JsonProperty("available_words")]
        public int AvailableWords { get; set; }

        /// <summary>
        /// Gets or sets AvailableImages.
        /// </summary>
        [JsonProperty("available_images")]
        public int AvailableImages { get; set; }

        /// <summary>
        /// Gets or sets AvailableChars.
        /// </summary>
        [JsonProperty("available_chars")]
        public int AvailableChars { get; set; }

        /// <summary>
        /// Gets or sets AvailableMinutes.
        /// </summary>
        [JsonProperty("available_minutes")]
        public int AvailableMinutes { get; set; }

        /// <summary>
        /// Gets or sets Roles.
        /// </summary>
        [JsonProperty("roles")]
        public List<Models.Role> Roles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"User2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is User2 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.EmailVerifiedAt == null && other.EmailVerifiedAt == null) || (this.EmailVerifiedAt?.Equals(other.EmailVerifiedAt) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.AvailableWordsPrepaid == null && other.AvailableWordsPrepaid == null) || (this.AvailableWordsPrepaid?.Equals(other.AvailableWordsPrepaid) == true)) &&
                ((this.AvailableImagesPrepaid == null && other.AvailableImagesPrepaid == null) || (this.AvailableImagesPrepaid?.Equals(other.AvailableImagesPrepaid) == true)) &&
                ((this.AvailableCharsPrepaid == null && other.AvailableCharsPrepaid == null) || (this.AvailableCharsPrepaid?.Equals(other.AvailableCharsPrepaid) == true)) &&
                ((this.AvailableMinutesPrepaid == null && other.AvailableMinutesPrepaid == null) || (this.AvailableMinutesPrepaid?.Equals(other.AvailableMinutesPrepaid) == true)) &&
                ((this.DefaultVoiceoverLanguage == null && other.DefaultVoiceoverLanguage == null) || (this.DefaultVoiceoverLanguage?.Equals(other.DefaultVoiceoverLanguage) == true)) &&
                ((this.DefaultVoiceoverVoice == null && other.DefaultVoiceoverVoice == null) || (this.DefaultVoiceoverVoice?.Equals(other.DefaultVoiceoverVoice) == true)) &&
                ((this.JobRole == null && other.JobRole == null) || (this.JobRole?.Equals(other.JobRole) == true)) &&
                ((this.ReferralId == null && other.ReferralId == null) || (this.ReferralId?.Equals(other.ReferralId) == true)) &&
                ((this.ReferredBy == null && other.ReferredBy == null) || (this.ReferredBy?.Equals(other.ReferredBy) == true)) &&
                ((this.Workbook == null && other.Workbook == null) || (this.Workbook?.Equals(other.Workbook) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                this.PlanId.Equals(other.PlanId) &&
                this.TotalWords.Equals(other.TotalWords) &&
                this.TotalImages.Equals(other.TotalImages) &&
                this.TotalChars.Equals(other.TotalChars) &&
                this.TotalMinutes.Equals(other.TotalMinutes) &&
                this.AvailableWords.Equals(other.AvailableWords) &&
                this.AvailableImages.Equals(other.AvailableImages) &&
                this.AvailableChars.Equals(other.AvailableChars) &&
                this.AvailableMinutes.Equals(other.AvailableMinutes) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.EmailVerifiedAt = {(this.EmailVerifiedAt == null ? "null" : this.EmailVerifiedAt)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup)}");
            toStringOutput.Add($"this.AvailableWordsPrepaid = {(this.AvailableWordsPrepaid == null ? "null" : this.AvailableWordsPrepaid)}");
            toStringOutput.Add($"this.AvailableImagesPrepaid = {(this.AvailableImagesPrepaid == null ? "null" : this.AvailableImagesPrepaid)}");
            toStringOutput.Add($"this.AvailableCharsPrepaid = {(this.AvailableCharsPrepaid == null ? "null" : this.AvailableCharsPrepaid)}");
            toStringOutput.Add($"this.AvailableMinutesPrepaid = {(this.AvailableMinutesPrepaid == null ? "null" : this.AvailableMinutesPrepaid)}");
            toStringOutput.Add($"this.DefaultVoiceoverLanguage = {(this.DefaultVoiceoverLanguage == null ? "null" : this.DefaultVoiceoverLanguage)}");
            toStringOutput.Add($"this.DefaultVoiceoverVoice = {(this.DefaultVoiceoverVoice == null ? "null" : this.DefaultVoiceoverVoice)}");
            toStringOutput.Add($"this.JobRole = {(this.JobRole == null ? "null" : this.JobRole)}");
            toStringOutput.Add($"this.ReferralId = {(this.ReferralId == null ? "null" : this.ReferralId)}");
            toStringOutput.Add($"this.ReferredBy = {(this.ReferredBy == null ? "null" : this.ReferredBy)}");
            toStringOutput.Add($"this.Workbook = {(this.Workbook == null ? "null" : this.Workbook)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.PlanId = {this.PlanId}");
            toStringOutput.Add($"this.TotalWords = {this.TotalWords}");
            toStringOutput.Add($"this.TotalImages = {this.TotalImages}");
            toStringOutput.Add($"this.TotalChars = {this.TotalChars}");
            toStringOutput.Add($"this.TotalMinutes = {this.TotalMinutes}");
            toStringOutput.Add($"this.AvailableWords = {this.AvailableWords}");
            toStringOutput.Add($"this.AvailableImages = {this.AvailableImages}");
            toStringOutput.Add($"this.AvailableChars = {this.AvailableChars}");
            toStringOutput.Add($"this.AvailableMinutes = {this.AvailableMinutes}");
            toStringOutput.Add($"this.Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
        }
    }
}