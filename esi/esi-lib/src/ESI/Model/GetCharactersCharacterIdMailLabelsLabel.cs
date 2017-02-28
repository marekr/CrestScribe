/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ESI.Model
{
    /// <summary>
    /// label object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdMailLabelsLabel :  IEquatable<GetCharactersCharacterIdMailLabelsLabel>, IValidatableObject
    {
        /// <summary>
        /// color string
        /// </summary>
        /// <value>color string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            
            /// <summary>
            /// Enum Ffffff for "#ffffff"
            /// </summary>
            [EnumMember(Value = "#ffffff")]
            Ffffff,
            
            /// <summary>
            /// Enum Ffff01 for "#ffff01"
            /// </summary>
            [EnumMember(Value = "#ffff01")]
            Ffff01,
            
            /// <summary>
            /// Enum Ff6600 for "#ff6600"
            /// </summary>
            [EnumMember(Value = "#ff6600")]
            Ff6600,
            
            /// <summary>
            /// Enum Fe0000 for "#fe0000"
            /// </summary>
            [EnumMember(Value = "#fe0000")]
            Fe0000,
            
            /// <summary>
            /// Enum _9a0000 for "#9a0000"
            /// </summary>
            [EnumMember(Value = "#9a0000")]
            _9a0000,
            
            /// <summary>
            /// Enum _660066 for "#660066"
            /// </summary>
            [EnumMember(Value = "#660066")]
            _660066,
            
            /// <summary>
            /// Enum _0000fe for "#0000fe"
            /// </summary>
            [EnumMember(Value = "#0000fe")]
            _0000fe,
            
            /// <summary>
            /// Enum _0099ff for "#0099ff"
            /// </summary>
            [EnumMember(Value = "#0099ff")]
            _0099ff,
            
            /// <summary>
            /// Enum _01ffff for "#01ffff"
            /// </summary>
            [EnumMember(Value = "#01ffff")]
            _01ffff,
            
            /// <summary>
            /// Enum _00ff33 for "#00ff33"
            /// </summary>
            [EnumMember(Value = "#00ff33")]
            _00ff33,
            
            /// <summary>
            /// Enum _349800 for "#349800"
            /// </summary>
            [EnumMember(Value = "#349800")]
            _349800,
            
            /// <summary>
            /// Enum _006634 for "#006634"
            /// </summary>
            [EnumMember(Value = "#006634")]
            _006634,
            
            /// <summary>
            /// Enum _666666 for "#666666"
            /// </summary>
            [EnumMember(Value = "#666666")]
            _666666,
            
            /// <summary>
            /// Enum _999999 for "#999999"
            /// </summary>
            [EnumMember(Value = "#999999")]
            _999999,
            
            /// <summary>
            /// Enum E6e6e6 for "#e6e6e6"
            /// </summary>
            [EnumMember(Value = "#e6e6e6")]
            E6e6e6,
            
            /// <summary>
            /// Enum Ffffcd for "#ffffcd"
            /// </summary>
            [EnumMember(Value = "#ffffcd")]
            Ffffcd,
            
            /// <summary>
            /// Enum _99ffff for "#99ffff"
            /// </summary>
            [EnumMember(Value = "#99ffff")]
            _99ffff,
            
            /// <summary>
            /// Enum Ccff9a for "#ccff9a"
            /// </summary>
            [EnumMember(Value = "#ccff9a")]
            Ccff9a
        }

        /// <summary>
        /// color string
        /// </summary>
        /// <value>color string</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMailLabelsLabel" /> class.
        /// </summary>
        /// <param name="Color">color string (default to ColorEnum.Ffffff).</param>
        /// <param name="LabelId">label_id integer.</param>
        /// <param name="Name">name string.</param>
        /// <param name="UnreadCount">unread_count integer.</param>
        public GetCharactersCharacterIdMailLabelsLabel(ColorEnum? Color = ColorEnum.Ffffff, int? LabelId = default(int?), string Name = default(string), int? UnreadCount = default(int?))
        {
            // use default value if no "Color" provided
            if (Color == null)
            {
                this.Color = ColorEnum.Ffffff;
            }
            else
            {
                this.Color = Color;
            }
            this.LabelId = LabelId;
            this.Name = Name;
            this.UnreadCount = UnreadCount;
        }
        
        /// <summary>
        /// label_id integer
        /// </summary>
        /// <value>label_id integer</value>
        [DataMember(Name="label_id", EmitDefaultValue=false)]
        public int? LabelId { get; set; }
        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// unread_count integer
        /// </summary>
        /// <value>unread_count integer</value>
        [DataMember(Name="unread_count", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMailLabelsLabel {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetCharactersCharacterIdMailLabelsLabel);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMailLabelsLabel instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdMailLabelsLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMailLabelsLabel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.LabelId == other.LabelId ||
                    this.LabelId != null &&
                    this.LabelId.Equals(other.LabelId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.UnreadCount == other.UnreadCount ||
                    this.UnreadCount != null &&
                    this.UnreadCount.Equals(other.UnreadCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.LabelId != null)
                    hash = hash * 59 + this.LabelId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.UnreadCount != null)
                    hash = hash * 59 + this.UnreadCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // LabelId (int?) minimum
            if(this.LabelId < (int?)0)
            {
                yield return new ValidationResult("Invalid value for LabelId, must be a value greater than or equal to 0.", new [] { "LabelId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
            }

            // UnreadCount (int?) minimum
            if(this.UnreadCount < (int?)0)
            {
                yield return new ValidationResult("Invalid value for UnreadCount, must be a value greater than or equal to 0.", new [] { "UnreadCount" });
            }

            yield break;
        }
    }

}