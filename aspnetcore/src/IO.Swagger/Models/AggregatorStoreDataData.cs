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
    public partial class AggregatorStoreDataData : IEquatable<AggregatorStoreDataData>
    { 
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry")]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets Slogan
        /// </summary>
        [DataMember(Name="slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website")]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets TaxId
        /// </summary>
        [DataMember(Name="tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNumber
        /// </summary>
        [DataMember(Name="registration_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents")]
        public List<string> Documents { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address")]
        public AggregatorStoreDataDataAddress Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatorStoreDataData {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Slogan: ").Append(Slogan).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AggregatorStoreDataData)obj);
        }

        /// <summary>
        /// Returns true if AggregatorStoreDataData instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregatorStoreDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatorStoreDataData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StoreId == other.StoreId ||
                    StoreId != null &&
                    StoreId.Equals(other.StoreId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Industry == other.Industry ||
                    Industry != null &&
                    Industry.Equals(other.Industry)
                ) && 
                (
                    Slogan == other.Slogan ||
                    Slogan != null &&
                    Slogan.Equals(other.Slogan)
                ) && 
                (
                    Logo == other.Logo ||
                    Logo != null &&
                    Logo.Equals(other.Logo)
                ) && 
                (
                    Website == other.Website ||
                    Website != null &&
                    Website.Equals(other.Website)
                ) && 
                (
                    TaxId == other.TaxId ||
                    TaxId != null &&
                    TaxId.Equals(other.TaxId)
                ) && 
                (
                    RegistrationNumber == other.RegistrationNumber ||
                    RegistrationNumber != null &&
                    RegistrationNumber.Equals(other.RegistrationNumber)
                ) && 
                (
                    Documents == other.Documents ||
                    Documents != null &&
                    Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
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
                    if (StoreId != null)
                    hashCode = hashCode * 59 + StoreId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Industry != null)
                    hashCode = hashCode * 59 + Industry.GetHashCode();
                    if (Slogan != null)
                    hashCode = hashCode * 59 + Slogan.GetHashCode();
                    if (Logo != null)
                    hashCode = hashCode * 59 + Logo.GetHashCode();
                    if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                    if (TaxId != null)
                    hashCode = hashCode * 59 + TaxId.GetHashCode();
                    if (RegistrationNumber != null)
                    hashCode = hashCode * 59 + RegistrationNumber.GetHashCode();
                    if (Documents != null)
                    hashCode = hashCode * 59 + Documents.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AggregatorStoreDataData left, AggregatorStoreDataData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AggregatorStoreDataData left, AggregatorStoreDataData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
