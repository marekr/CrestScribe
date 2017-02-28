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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetUniverseSystemsSystemIdOk :  IEquatable<GetUniverseSystemsSystemIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseSystemsSystemIdOk" /> class.
        /// </summary>
        /// <param name="SolarSystemName">the full name of the system.</param>
        public GetUniverseSystemsSystemIdOk(string SolarSystemName = default(string))
        {
            this.SolarSystemName = SolarSystemName;
        }
        
        /// <summary>
        /// the full name of the system
        /// </summary>
        /// <value>the full name of the system</value>
        [DataMember(Name="solar_system_name", EmitDefaultValue=false)]
        public string SolarSystemName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseSystemsSystemIdOk {\n");
            sb.Append("  SolarSystemName: ").Append(SolarSystemName).Append("\n");
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
            return this.Equals(obj as GetUniverseSystemsSystemIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseSystemsSystemIdOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetUniverseSystemsSystemIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseSystemsSystemIdOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SolarSystemName == other.SolarSystemName ||
                    this.SolarSystemName != null &&
                    this.SolarSystemName.Equals(other.SolarSystemName)
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
                if (this.SolarSystemName != null)
                    hash = hash * 59 + this.SolarSystemName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}