// <copyright file="User.cs" company="APIMatic">
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
    /// User.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="jobRole">job_role.</param>
        /// <param name="email">email.</param>
        /// <param name="emailVerifiedAt">email_verified_at.</param>
        /// <param name="status">status.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="workbook">workbook.</param>
        /// <param name="workbookId">workbook_id.</param>
        /// <param name="workbookFolderId">workbook_folder_id.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="planId">plan_id.</param>
        /// <param name="country">country.</param>
        /// <param name="availableWords">available_words.</param>
        /// <param name="availableWordsPrepaid">available_words_prepaid.</param>
        /// <param name="totalWords">total_words.</param>
        /// <param name="availableImages">available_images.</param>
        /// <param name="availableImagesPrepaid">available_images_prepaid.</param>
        /// <param name="totalImages">total_images.</param>
        /// <param name="balance">balance.</param>
        /// <param name="totalChars">total_chars.</param>
        /// <param name="availableChars">available_chars.</param>
        /// <param name="availableCharsPrepaid">available_chars_prepaid.</param>
        /// <param name="totalMinutes">total_minutes.</param>
        /// <param name="availableMinutes">available_minutes.</param>
        /// <param name="availableMinutesPrepaid">available_minutes_prepaid.</param>
        /// <param name="memberRole">member_role.</param>
        /// <param name="parentId">parent_id.</param>
        /// <param name="google2faEnabled">google2fa_enabled.</param>
        /// <param name="referralId">referral_id.</param>
        /// <param name="referredBy">referred_by.</param>
        /// <param name="defaultVoiceoverLanguage">default_voiceover_language.</param>
        /// <param name="defaultTempLanguage">default_temp_language.</param>
        /// <param name="defaultVoiceoverVoice">default_voiceover_voice.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="subdomain">subdomain.</param>
        /// <param name="planType">plan_type.</param>
        /// <param name="company">company.</param>
        /// <param name="website">website.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="address">address.</param>
        /// <param name="city">city.</param>
        /// <param name="postalCode">postal_code.</param>
        /// <param name="profilePhotoPath">profile_photo_path.</param>
        /// <param name="oauthId">oauth_id.</param>
        /// <param name="oauthType">oauth_type.</param>
        /// <param name="lastSeen">last_seen.</param>
        /// <param name="ckbox">ckbox.</param>
        /// <param name="google2faSecret">google2fa_secret.</param>
        /// <param name="referralPaymentMethod">referral_payment_method.</param>
        /// <param name="referralPaypal">referral_paypal.</param>
        /// <param name="referralBankRequisites">referral_bank_requisites.</param>
        /// <param name="defaultTone">default_tone.</param>
        /// <param name="subdomainToken">subdomain_token.</param>
        public User(
            int id,
            string name,
            string jobRole,
            string email,
            string emailVerifiedAt,
            string status,
            string mGroup,
            string workbook,
            int workbookId,
            int workbookFolderId,
            int productId,
            int planId,
            string country,
            int availableWords,
            int availableWordsPrepaid,
            int totalWords,
            int availableImages,
            int availableImagesPrepaid,
            int totalImages,
            int balance,
            int totalChars,
            int availableChars,
            int availableCharsPrepaid,
            string totalMinutes,
            string availableMinutes,
            string availableMinutesPrepaid,
            int memberRole,
            int parentId,
            int google2faEnabled,
            string referralId,
            string referredBy,
            string defaultVoiceoverLanguage,
            int defaultTempLanguage,
            string defaultVoiceoverVoice,
            string createdAt,
            string updatedAt,
            string subdomain = null,
            string planType = null,
            string company = null,
            string website = null,
            string phoneNumber = null,
            string address = null,
            string city = null,
            string postalCode = null,
            string profilePhotoPath = null,
            string oauthId = null,
            string oauthType = null,
            string lastSeen = null,
            string ckbox = null,
            string google2faSecret = null,
            string referralPaymentMethod = null,
            string referralPaypal = null,
            string referralBankRequisites = null,
            string defaultTone = null,
            string subdomainToken = null)
        {
            this.Id = id;
            this.Name = name;
            this.JobRole = jobRole;
            this.Email = email;
            this.Subdomain = subdomain;
            this.EmailVerifiedAt = emailVerifiedAt;
            this.Status = status;
            this.MGroup = mGroup;
            this.Workbook = workbook;
            this.WorkbookId = workbookId;
            this.WorkbookFolderId = workbookFolderId;
            this.ProductId = productId;
            this.PlanId = planId;
            this.PlanType = planType;
            this.Company = company;
            this.Website = website;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
            this.AvailableWords = availableWords;
            this.AvailableWordsPrepaid = availableWordsPrepaid;
            this.TotalWords = totalWords;
            this.AvailableImages = availableImages;
            this.AvailableImagesPrepaid = availableImagesPrepaid;
            this.TotalImages = totalImages;
            this.Balance = balance;
            this.TotalChars = totalChars;
            this.AvailableChars = availableChars;
            this.AvailableCharsPrepaid = availableCharsPrepaid;
            this.TotalMinutes = totalMinutes;
            this.AvailableMinutes = availableMinutes;
            this.AvailableMinutesPrepaid = availableMinutesPrepaid;
            this.ProfilePhotoPath = profilePhotoPath;
            this.OauthId = oauthId;
            this.OauthType = oauthType;
            this.LastSeen = lastSeen;
            this.MemberRole = memberRole;
            this.ParentId = parentId;
            this.Ckbox = ckbox;
            this.Google2faSecret = google2faSecret;
            this.Google2faEnabled = google2faEnabled;
            this.ReferralId = referralId;
            this.ReferredBy = referredBy;
            this.ReferralPaymentMethod = referralPaymentMethod;
            this.ReferralPaypal = referralPaypal;
            this.ReferralBankRequisites = referralBankRequisites;
            this.DefaultVoiceoverLanguage = defaultVoiceoverLanguage;
            this.DefaultTempLanguage = defaultTempLanguage;
            this.DefaultVoiceoverVoice = defaultVoiceoverVoice;
            this.DefaultTone = defaultTone;
            this.SubdomainToken = subdomainToken;
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
        /// Gets or sets JobRole.
        /// </summary>
        [JsonProperty("job_role")]
        public string JobRole { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Subdomain.
        /// </summary>
        [JsonProperty("subdomain", NullValueHandling = NullValueHandling.Include)]
        public string Subdomain { get; set; }

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
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets PlanId.
        /// </summary>
        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Gets or sets PlanType.
        /// </summary>
        [JsonProperty("plan_type", NullValueHandling = NullValueHandling.Include)]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets Company.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Include)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets Website.
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Include)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets PhoneNumber.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Include)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Include)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Include)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets PostalCode.
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Include)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets AvailableWords.
        /// </summary>
        [JsonProperty("available_words")]
        public int AvailableWords { get; set; }

        /// <summary>
        /// Gets or sets AvailableWordsPrepaid.
        /// </summary>
        [JsonProperty("available_words_prepaid")]
        public int AvailableWordsPrepaid { get; set; }

        /// <summary>
        /// Gets or sets TotalWords.
        /// </summary>
        [JsonProperty("total_words")]
        public int TotalWords { get; set; }

        /// <summary>
        /// Gets or sets AvailableImages.
        /// </summary>
        [JsonProperty("available_images")]
        public int AvailableImages { get; set; }

        /// <summary>
        /// Gets or sets AvailableImagesPrepaid.
        /// </summary>
        [JsonProperty("available_images_prepaid")]
        public int AvailableImagesPrepaid { get; set; }

        /// <summary>
        /// Gets or sets TotalImages.
        /// </summary>
        [JsonProperty("total_images")]
        public int TotalImages { get; set; }

        /// <summary>
        /// Gets or sets Balance.
        /// </summary>
        [JsonProperty("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// Gets or sets TotalChars.
        /// </summary>
        [JsonProperty("total_chars")]
        public int TotalChars { get; set; }

        /// <summary>
        /// Gets or sets AvailableChars.
        /// </summary>
        [JsonProperty("available_chars")]
        public int AvailableChars { get; set; }

        /// <summary>
        /// Gets or sets AvailableCharsPrepaid.
        /// </summary>
        [JsonProperty("available_chars_prepaid")]
        public int AvailableCharsPrepaid { get; set; }

        /// <summary>
        /// Gets or sets TotalMinutes.
        /// </summary>
        [JsonProperty("total_minutes")]
        public string TotalMinutes { get; set; }

        /// <summary>
        /// Gets or sets AvailableMinutes.
        /// </summary>
        [JsonProperty("available_minutes")]
        public string AvailableMinutes { get; set; }

        /// <summary>
        /// Gets or sets AvailableMinutesPrepaid.
        /// </summary>
        [JsonProperty("available_minutes_prepaid")]
        public string AvailableMinutesPrepaid { get; set; }

        /// <summary>
        /// Gets or sets ProfilePhotoPath.
        /// </summary>
        [JsonProperty("profile_photo_path", NullValueHandling = NullValueHandling.Include)]
        public string ProfilePhotoPath { get; set; }

        /// <summary>
        /// Gets or sets OauthId.
        /// </summary>
        [JsonProperty("oauth_id", NullValueHandling = NullValueHandling.Include)]
        public string OauthId { get; set; }

        /// <summary>
        /// Gets or sets OauthType.
        /// </summary>
        [JsonProperty("oauth_type", NullValueHandling = NullValueHandling.Include)]
        public string OauthType { get; set; }

        /// <summary>
        /// Gets or sets LastSeen.
        /// </summary>
        [JsonProperty("last_seen", NullValueHandling = NullValueHandling.Include)]
        public string LastSeen { get; set; }

        /// <summary>
        /// Gets or sets MemberRole.
        /// </summary>
        [JsonProperty("member_role")]
        public int MemberRole { get; set; }

        /// <summary>
        /// Gets or sets ParentId.
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets Ckbox.
        /// </summary>
        [JsonProperty("ckbox", NullValueHandling = NullValueHandling.Include)]
        public string Ckbox { get; set; }

        /// <summary>
        /// Gets or sets Google2faSecret.
        /// </summary>
        [JsonProperty("google2fa_secret", NullValueHandling = NullValueHandling.Include)]
        public string Google2faSecret { get; set; }

        /// <summary>
        /// Gets or sets Google2faEnabled.
        /// </summary>
        [JsonProperty("google2fa_enabled")]
        public int Google2faEnabled { get; set; }

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
        /// Gets or sets ReferralPaymentMethod.
        /// </summary>
        [JsonProperty("referral_payment_method", NullValueHandling = NullValueHandling.Include)]
        public string ReferralPaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets ReferralPaypal.
        /// </summary>
        [JsonProperty("referral_paypal", NullValueHandling = NullValueHandling.Include)]
        public string ReferralPaypal { get; set; }

        /// <summary>
        /// Gets or sets ReferralBankRequisites.
        /// </summary>
        [JsonProperty("referral_bank_requisites", NullValueHandling = NullValueHandling.Include)]
        public string ReferralBankRequisites { get; set; }

        /// <summary>
        /// Gets or sets DefaultVoiceoverLanguage.
        /// </summary>
        [JsonProperty("default_voiceover_language")]
        public string DefaultVoiceoverLanguage { get; set; }

        /// <summary>
        /// Gets or sets DefaultTempLanguage.
        /// </summary>
        [JsonProperty("default_temp_language")]
        public int DefaultTempLanguage { get; set; }

        /// <summary>
        /// Gets or sets DefaultVoiceoverVoice.
        /// </summary>
        [JsonProperty("default_voiceover_voice")]
        public string DefaultVoiceoverVoice { get; set; }

        /// <summary>
        /// Gets or sets DefaultTone.
        /// </summary>
        [JsonProperty("default_tone", NullValueHandling = NullValueHandling.Include)]
        public string DefaultTone { get; set; }

        /// <summary>
        /// Gets or sets SubdomainToken.
        /// </summary>
        [JsonProperty("subdomain_token", NullValueHandling = NullValueHandling.Include)]
        public string SubdomainToken { get; set; }

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

            return $"User : ({string.Join(", ", toStringOutput)})";
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
            return obj is User other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.JobRole == null && other.JobRole == null) || (this.JobRole?.Equals(other.JobRole) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Subdomain == null && other.Subdomain == null) || (this.Subdomain?.Equals(other.Subdomain) == true)) &&
                ((this.EmailVerifiedAt == null && other.EmailVerifiedAt == null) || (this.EmailVerifiedAt?.Equals(other.EmailVerifiedAt) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Workbook == null && other.Workbook == null) || (this.Workbook?.Equals(other.Workbook) == true)) &&
                this.WorkbookId.Equals(other.WorkbookId) &&
                this.WorkbookFolderId.Equals(other.WorkbookFolderId) &&
                this.ProductId.Equals(other.ProductId) &&
                this.PlanId.Equals(other.PlanId) &&
                ((this.PlanType == null && other.PlanType == null) || (this.PlanType?.Equals(other.PlanType) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                this.AvailableWords.Equals(other.AvailableWords) &&
                this.AvailableWordsPrepaid.Equals(other.AvailableWordsPrepaid) &&
                this.TotalWords.Equals(other.TotalWords) &&
                this.AvailableImages.Equals(other.AvailableImages) &&
                this.AvailableImagesPrepaid.Equals(other.AvailableImagesPrepaid) &&
                this.TotalImages.Equals(other.TotalImages) &&
                this.Balance.Equals(other.Balance) &&
                this.TotalChars.Equals(other.TotalChars) &&
                this.AvailableChars.Equals(other.AvailableChars) &&
                this.AvailableCharsPrepaid.Equals(other.AvailableCharsPrepaid) &&
                ((this.TotalMinutes == null && other.TotalMinutes == null) || (this.TotalMinutes?.Equals(other.TotalMinutes) == true)) &&
                ((this.AvailableMinutes == null && other.AvailableMinutes == null) || (this.AvailableMinutes?.Equals(other.AvailableMinutes) == true)) &&
                ((this.AvailableMinutesPrepaid == null && other.AvailableMinutesPrepaid == null) || (this.AvailableMinutesPrepaid?.Equals(other.AvailableMinutesPrepaid) == true)) &&
                ((this.ProfilePhotoPath == null && other.ProfilePhotoPath == null) || (this.ProfilePhotoPath?.Equals(other.ProfilePhotoPath) == true)) &&
                ((this.OauthId == null && other.OauthId == null) || (this.OauthId?.Equals(other.OauthId) == true)) &&
                ((this.OauthType == null && other.OauthType == null) || (this.OauthType?.Equals(other.OauthType) == true)) &&
                ((this.LastSeen == null && other.LastSeen == null) || (this.LastSeen?.Equals(other.LastSeen) == true)) &&
                this.MemberRole.Equals(other.MemberRole) &&
                this.ParentId.Equals(other.ParentId) &&
                ((this.Ckbox == null && other.Ckbox == null) || (this.Ckbox?.Equals(other.Ckbox) == true)) &&
                ((this.Google2faSecret == null && other.Google2faSecret == null) || (this.Google2faSecret?.Equals(other.Google2faSecret) == true)) &&
                this.Google2faEnabled.Equals(other.Google2faEnabled) &&
                ((this.ReferralId == null && other.ReferralId == null) || (this.ReferralId?.Equals(other.ReferralId) == true)) &&
                ((this.ReferredBy == null && other.ReferredBy == null) || (this.ReferredBy?.Equals(other.ReferredBy) == true)) &&
                ((this.ReferralPaymentMethod == null && other.ReferralPaymentMethod == null) || (this.ReferralPaymentMethod?.Equals(other.ReferralPaymentMethod) == true)) &&
                ((this.ReferralPaypal == null && other.ReferralPaypal == null) || (this.ReferralPaypal?.Equals(other.ReferralPaypal) == true)) &&
                ((this.ReferralBankRequisites == null && other.ReferralBankRequisites == null) || (this.ReferralBankRequisites?.Equals(other.ReferralBankRequisites) == true)) &&
                ((this.DefaultVoiceoverLanguage == null && other.DefaultVoiceoverLanguage == null) || (this.DefaultVoiceoverLanguage?.Equals(other.DefaultVoiceoverLanguage) == true)) &&
                this.DefaultTempLanguage.Equals(other.DefaultTempLanguage) &&
                ((this.DefaultVoiceoverVoice == null && other.DefaultVoiceoverVoice == null) || (this.DefaultVoiceoverVoice?.Equals(other.DefaultVoiceoverVoice) == true)) &&
                ((this.DefaultTone == null && other.DefaultTone == null) || (this.DefaultTone?.Equals(other.DefaultTone) == true)) &&
                ((this.SubdomainToken == null && other.SubdomainToken == null) || (this.SubdomainToken?.Equals(other.SubdomainToken) == true)) &&
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
            toStringOutput.Add($"this.JobRole = {(this.JobRole == null ? "null" : this.JobRole)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Subdomain = {(this.Subdomain == null ? "null" : this.Subdomain)}");
            toStringOutput.Add($"this.EmailVerifiedAt = {(this.EmailVerifiedAt == null ? "null" : this.EmailVerifiedAt)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup)}");
            toStringOutput.Add($"this.Workbook = {(this.Workbook == null ? "null" : this.Workbook)}");
            toStringOutput.Add($"this.WorkbookId = {this.WorkbookId}");
            toStringOutput.Add($"this.WorkbookFolderId = {this.WorkbookFolderId}");
            toStringOutput.Add($"this.ProductId = {this.ProductId}");
            toStringOutput.Add($"this.PlanId = {this.PlanId}");
            toStringOutput.Add($"this.PlanType = {(this.PlanType == null ? "null" : this.PlanType)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.Website = {(this.Website == null ? "null" : this.Website)}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.AvailableWords = {this.AvailableWords}");
            toStringOutput.Add($"this.AvailableWordsPrepaid = {this.AvailableWordsPrepaid}");
            toStringOutput.Add($"this.TotalWords = {this.TotalWords}");
            toStringOutput.Add($"this.AvailableImages = {this.AvailableImages}");
            toStringOutput.Add($"this.AvailableImagesPrepaid = {this.AvailableImagesPrepaid}");
            toStringOutput.Add($"this.TotalImages = {this.TotalImages}");
            toStringOutput.Add($"this.Balance = {this.Balance}");
            toStringOutput.Add($"this.TotalChars = {this.TotalChars}");
            toStringOutput.Add($"this.AvailableChars = {this.AvailableChars}");
            toStringOutput.Add($"this.AvailableCharsPrepaid = {this.AvailableCharsPrepaid}");
            toStringOutput.Add($"this.TotalMinutes = {(this.TotalMinutes == null ? "null" : this.TotalMinutes)}");
            toStringOutput.Add($"this.AvailableMinutes = {(this.AvailableMinutes == null ? "null" : this.AvailableMinutes)}");
            toStringOutput.Add($"this.AvailableMinutesPrepaid = {(this.AvailableMinutesPrepaid == null ? "null" : this.AvailableMinutesPrepaid)}");
            toStringOutput.Add($"this.ProfilePhotoPath = {(this.ProfilePhotoPath == null ? "null" : this.ProfilePhotoPath)}");
            toStringOutput.Add($"this.OauthId = {(this.OauthId == null ? "null" : this.OauthId)}");
            toStringOutput.Add($"this.OauthType = {(this.OauthType == null ? "null" : this.OauthType)}");
            toStringOutput.Add($"this.LastSeen = {(this.LastSeen == null ? "null" : this.LastSeen)}");
            toStringOutput.Add($"this.MemberRole = {this.MemberRole}");
            toStringOutput.Add($"this.ParentId = {this.ParentId}");
            toStringOutput.Add($"this.Ckbox = {(this.Ckbox == null ? "null" : this.Ckbox)}");
            toStringOutput.Add($"this.Google2faSecret = {(this.Google2faSecret == null ? "null" : this.Google2faSecret)}");
            toStringOutput.Add($"this.Google2faEnabled = {this.Google2faEnabled}");
            toStringOutput.Add($"this.ReferralId = {(this.ReferralId == null ? "null" : this.ReferralId)}");
            toStringOutput.Add($"this.ReferredBy = {(this.ReferredBy == null ? "null" : this.ReferredBy)}");
            toStringOutput.Add($"this.ReferralPaymentMethod = {(this.ReferralPaymentMethod == null ? "null" : this.ReferralPaymentMethod)}");
            toStringOutput.Add($"this.ReferralPaypal = {(this.ReferralPaypal == null ? "null" : this.ReferralPaypal)}");
            toStringOutput.Add($"this.ReferralBankRequisites = {(this.ReferralBankRequisites == null ? "null" : this.ReferralBankRequisites)}");
            toStringOutput.Add($"this.DefaultVoiceoverLanguage = {(this.DefaultVoiceoverLanguage == null ? "null" : this.DefaultVoiceoverLanguage)}");
            toStringOutput.Add($"this.DefaultTempLanguage = {this.DefaultTempLanguage}");
            toStringOutput.Add($"this.DefaultVoiceoverVoice = {(this.DefaultVoiceoverVoice == null ? "null" : this.DefaultVoiceoverVoice)}");
            toStringOutput.Add($"this.DefaultTone = {(this.DefaultTone == null ? "null" : this.DefaultTone)}");
            toStringOutput.Add($"this.SubdomainToken = {(this.SubdomainToken == null ? "null" : this.SubdomainToken)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
        }
    }
}