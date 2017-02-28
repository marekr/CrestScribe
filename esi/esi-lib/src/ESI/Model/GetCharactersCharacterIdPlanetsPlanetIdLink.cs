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
    /// link object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdPlanetsPlanetIdLink :  IEquatable<GetCharactersCharacterIdPlanetsPlanetIdLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdPlanetsPlanetIdLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdLink" /> class.
        /// </summary>
        /// <param name="DestinationPinId">destination_pin_id integer (required).</param>
        /// <param name="LinkLevel">link_level integer (required).</param>
        /// <param name="SourcePinId">source_pin_id integer (required).</param>
        public GetCharactersCharacterIdPlanetsPlanetIdLink(long? DestinationPinId = default(long?), int? LinkLevel = default(int?), long? SourcePinId = default(long?))
        {
            // to ensure "DestinationPinId" is required (not null)
            if (DestinationPinId == null)
            {
                throw new InvalidDataException("DestinationPinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.DestinationPinId = DestinationPinId;
            }
            // to ensure "LinkLevel" is required (not null)
            if (LinkLevel == null)
            {
                throw new InvalidDataException("LinkLevel is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.LinkLevel = LinkLevel;
            }
            // to ensure "SourcePinId" is required (not null)
            if (SourcePinId == null)
            {
                throw new InvalidDataException("SourcePinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.SourcePinId = SourcePinId;
            }
        }
        
        /// <summary>
        /// destination_pin_id integer
        /// </summary>
        /// <value>destination_pin_id integer</value>
        [DataMember(Name="destination_pin_id", EmitDefaultValue=false)]
        public long? DestinationPinId { get; set; }
        /// <summary>
        /// link_level integer
        /// </summary>
        /// <value>link_level integer</value>
        [DataMember(Name="link_level", EmitDefaultValue=false)]
        public int? LinkLevel { get; set; }
        /// <summary>
        /// source_pin_id integer
        /// </summary>
        /// <value>source_pin_id integer</value>
        [DataMember(Name="source_pin_id", EmitDefaultValue=false)]
        public long? SourcePinId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdLink {\n");
            sb.Append("  DestinationPinId: ").Append(DestinationPinId).Append("\n");
            sb.Append("  LinkLevel: ").Append(LinkLevel).Append("\n");
            sb.Append("  SourcePinId: ").Append(SourcePinId).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdPlanetsPlanetIdLink);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanetsPlanetIdLink instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdPlanetsPlanetIdLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanetsPlanetIdLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DestinationPinId == other.DestinationPinId ||
                    this.DestinationPinId != null &&
                    this.DestinationPinId.Equals(other.DestinationPinId)
                ) && 
                (
                    this.LinkLevel == other.LinkLevel ||
                    this.LinkLevel != null &&
                    this.LinkLevel.Equals(other.LinkLevel)
                ) && 
                (
                    this.SourcePinId == other.SourcePinId ||
                    this.SourcePinId != null &&
                    this.SourcePinId.Equals(other.SourcePinId)
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
                if (this.DestinationPinId != null)
                    hash = hash * 59 + this.DestinationPinId.GetHashCode();
                if (this.LinkLevel != null)
                    hash = hash * 59 + this.LinkLevel.GetHashCode();
                if (this.SourcePinId != null)
                    hash = hash * 59 + this.SourcePinId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // LinkLevel (int?) maximum
            if(this.LinkLevel > (int?)10)
            {
                yield return new ValidationResult("Invalid value for LinkLevel, must be a value less than or equal to 10.", new [] { "LinkLevel" });
            }

            // LinkLevel (int?) minimum
            if(this.LinkLevel < (int?)0)
            {
                yield return new ValidationResult("Invalid value for LinkLevel, must be a value greater than or equal to 0.", new [] { "LinkLevel" });
            }

            yield break;
        }
    }

}