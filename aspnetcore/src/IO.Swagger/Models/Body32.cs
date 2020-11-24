/*
 * NyoStore
 *
 * This is a NyoStore server. Here you can find  out all the rest api's. 
 *
 * OpenAPI spec version: 2.1
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
    public partial class Body32 : IEquatable<Body32>
    { 
        /// <summary>
        /// Address id&#x27;s to get branch
        /// </summary>
        /// <value>Address id&#x27;s to get branch</value>
        [DataMember(Name="address_ids")]
        public List<Object> AddressIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body32 {\n");
            sb.Append("  AddressIds: ").Append(AddressIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Body32)obj);
        }

        /// <summary>
        /// Returns true if Body32 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body32 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body32 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AddressIds == other.AddressIds ||
                    AddressIds != null &&
                    AddressIds.SequenceEqual(other.AddressIds)
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
                    if (AddressIds != null)
                    hashCode = hashCode * 59 + AddressIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Body32 left, Body32 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Body32 left, Body32 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
