// <copyright file="Data11.cs" company="APIMatic">
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
    /// Data11.
    /// </summary>
    public class Data11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data11"/> class.
        /// </summary>
        public Data11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data11"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="mAlias">alias.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="lang">lang.</param>
        /// <param name="content">content.</param>
        /// <param name="response">response.</param>
        /// <param name="userId">user_id.</param>
        /// <param name="paid">paid.</param>
        /// <param name="ai">ai.</param>
        /// <param name="aiDone">ai_done.</param>
        /// <param name="aiUsedTokens">ai_used_tokens.</param>
        /// <param name="active">active.</param>
        /// <param name="price">price.</param>
        /// <param name="md">md.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public Data11(
            int id,
            string createdAt,
            string updatedAt,
            string mAlias,
            string name,
            string type,
            string lang,
            string content,
            string response,
            int userId,
            int paid,
            int ai,
            int aiDone,
            int aiUsedTokens,
            int active,
            int price,
            string md,
            string deletedAt = null)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.MAlias = mAlias;
            this.Name = name;
            this.Type = type;
            this.Lang = lang;
            this.Content = content;
            this.Response = response;
            this.UserId = userId;
            this.Paid = paid;
            this.Ai = ai;
            this.AiDone = aiDone;
            this.AiUsedTokens = aiUsedTokens;
            this.Active = active;
            this.Price = price;
            this.Md = md;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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

        /// <summary>
        /// Gets or sets MAlias.
        /// </summary>
        [JsonProperty("alias")]
        public string MAlias { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Lang.
        /// </summary>
        [JsonProperty("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets Response.
        /// </summary>
        [JsonProperty("response")]
        public string Response { get; set; }

        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets Paid.
        /// </summary>
        [JsonProperty("paid")]
        public int Paid { get; set; }

        /// <summary>
        /// Gets or sets Ai.
        /// </summary>
        [JsonProperty("ai")]
        public int Ai { get; set; }

        /// <summary>
        /// Gets or sets AiDone.
        /// </summary>
        [JsonProperty("ai_done")]
        public int AiDone { get; set; }

        /// <summary>
        /// Gets or sets AiUsedTokens.
        /// </summary>
        [JsonProperty("ai_used_tokens")]
        public int AiUsedTokens { get; set; }

        /// <summary>
        /// Gets or sets Active.
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets Md.
        /// </summary>
        [JsonProperty("md")]
        public string Md { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data11 other &&                this.Id.Equals(other.Id) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.MAlias == null && other.MAlias == null) || (this.MAlias?.Equals(other.MAlias) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Lang == null && other.Lang == null) || (this.Lang?.Equals(other.Lang) == true)) &&
                ((this.Content == null && other.Content == null) || (this.Content?.Equals(other.Content) == true)) &&
                ((this.Response == null && other.Response == null) || (this.Response?.Equals(other.Response) == true)) &&
                this.UserId.Equals(other.UserId) &&
                this.Paid.Equals(other.Paid) &&
                this.Ai.Equals(other.Ai) &&
                this.AiDone.Equals(other.AiDone) &&
                this.AiUsedTokens.Equals(other.AiUsedTokens) &&
                this.Active.Equals(other.Active) &&
                this.Price.Equals(other.Price) &&
                ((this.Md == null && other.Md == null) || (this.Md?.Equals(other.Md) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt)}");
            toStringOutput.Add($"this.MAlias = {(this.MAlias == null ? "null" : this.MAlias)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Lang = {(this.Lang == null ? "null" : this.Lang)}");
            toStringOutput.Add($"this.Content = {(this.Content == null ? "null" : this.Content)}");
            toStringOutput.Add($"this.Response = {(this.Response == null ? "null" : this.Response)}");
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.Paid = {this.Paid}");
            toStringOutput.Add($"this.Ai = {this.Ai}");
            toStringOutput.Add($"this.AiDone = {this.AiDone}");
            toStringOutput.Add($"this.AiUsedTokens = {this.AiUsedTokens}");
            toStringOutput.Add($"this.Active = {this.Active}");
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.Md = {(this.Md == null ? "null" : this.Md)}");
        }
    }
}