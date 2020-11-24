/*
 * NyoStore
 *
 * This is a NyoStore server. Here you can find  out all the rest api's. 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AddressByKeyDataGeog : IEquatable<AddressByKeyDataGeog>
    { 
        /// <summary>
        /// Gets or Sets Crs
        /// </summary>
        [DataMember(Name="crs")]
        public AddressByKeyDataGeogCrs Crs { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="coordinates")]
        public List<string> Coordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressByKeyDataGeog {\n");
            sb.Append("  Crs: ").Append(Crs).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AddressByKeyDataGeog)obj);
        }

        /// <summary>
        /// Returns true if AddressByKeyDataGeog instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressByKeyDataGeog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressByKeyDataGeog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Crs == other.Crs ||
                    Crs != null &&
                    Crs.Equals(other.Crs)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Coordinates == other.Coordinates ||
                    Coordinates != null &&
                    Coordinates.SequenceEqual(other.Coordinates)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Crs != null)
                    hashCode = hashCode * 59 + Crs.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Coordinates != null)
                    hashCode = hashCode * 59 + Coordinates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AddressByKeyDataGeog left, AddressByKeyDataGeog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AddressByKeyDataGeog left, AddressByKeyDataGeog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
