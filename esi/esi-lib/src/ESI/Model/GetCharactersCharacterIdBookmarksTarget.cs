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
    /// target object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdBookmarksTarget :  IEquatable<GetCharactersCharacterIdBookmarksTarget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarksTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdBookmarksTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarksTarget" /> class.
        /// </summary>
        /// <param name="Coordinates">Coordinates.</param>
        /// <param name="Item">Item.</param>
        /// <param name="LocationId">location_id integer (required).</param>
        public GetCharactersCharacterIdBookmarksTarget(GetCharactersCharacterIdBookmarksCoordinates Coordinates = default(GetCharactersCharacterIdBookmarksCoordinates), GetCharactersCharacterIdBookmarksItem Item = default(GetCharactersCharacterIdBookmarksItem), long? LocationId = default(long?))
        {
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for GetCharactersCharacterIdBookmarksTarget and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            this.Coordinates = Coordinates;
            this.Item = Item;
        }
        
        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="coordinates", EmitDefaultValue=false)]
        public GetCharactersCharacterIdBookmarksCoordinates Coordinates { get; set; }
        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public GetCharactersCharacterIdBookmarksItem Item { get; set; }
        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdBookmarksTarget {\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdBookmarksTarget);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdBookmarksTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdBookmarksTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdBookmarksTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Coordinates == other.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.Equals(other.Coordinates)
                ) && 
                (
                    this.Item == other.Item ||
                    this.Item != null &&
                    this.Item.Equals(other.Item)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
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
                if (this.Coordinates != null)
                    hash = hash * 59 + this.Coordinates.GetHashCode();
                if (this.Item != null)
                    hash = hash * 59 + this.Item.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}