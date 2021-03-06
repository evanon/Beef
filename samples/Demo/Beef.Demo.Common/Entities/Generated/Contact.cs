/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options
#pragma warning disable CA2227, CA1819 // Collection/Array properties should be read only; ignored, as acceptable for a DTO.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Contact entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Contact : EntityBase, IGuidIdentifier, IEquatable<Contact>
    {
        #region Privates

        private Guid _id;
        private string? _firstName;
        private string? _lastName;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Contact"/> identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Identifier")]
        public Guid Id
        {
            get => _id;
            set => SetValue(ref _id, value, false, false, nameof(Id)); 
        }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="First Name")]
        public string? FirstName
        {
            get => _firstName;
            set => SetValue(ref _firstName, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(FirstName)); 
        }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Last Name")]
        public string? LastName
        {
            get => _lastName;
            set => SetValue(ref _lastName, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(LastName)); 
        }

        #endregion

        #region UniqueKey
      
        /// <summary>
        /// Indicates whether the <see cref="Contact"/> has a <see cref="UniqueKey"/> value.
        /// </summary>
        public override bool HasUniqueKey => true;
        
        /// <summary>
        /// Gets the list of property names that represent the unique key.
        /// </summary>
        public override string[] UniqueKeyProperties => new string[] { nameof(Id) };
        
        /// <summary>
        /// Creates the <see cref="UniqueKey"/>.
        /// </summary>
        /// <returns>The <see cref="Beef.Entities.UniqueKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        public static UniqueKey CreateUniqueKey(Guid id) => new UniqueKey(id);
          
        /// <summary>
        /// Gets the <see cref="UniqueKey"/>.
        /// </summary>
        /// <remarks>
        /// The <b>UniqueKey</b> key consists of the following property(s): <see cref="Id"/>.
        /// </remarks>
        public override UniqueKey UniqueKey => new UniqueKey(Id);

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is Contact val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Contact"/> is equal to the current <see cref="Contact"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(Contact? obj)
        {
            if (obj == null)
                return false;
            else if (ReferenceEquals(obj, this))
                return true;

            return base.Equals((object)obj)
                && Equals(Id, obj.Id)
                && Equals(FirstName, obj.FirstName)
                && Equals(LastName, obj.LastName);
        }

        /// <summary>
        /// Compares two <see cref="Contact"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="Contact"/> A.</param>
        /// <param name="b"><see cref="Contact"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (Contact? a, Contact? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="Contact"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="Contact"/> A.</param>
        /// <param name="b"><see cref="Contact"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (Contact? a, Contact? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="Contact"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="Contact"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Id);
            hash.Add(FirstName);
            hash.Add(LastName);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="Contact"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Contact"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<Contact>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="Contact"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Contact"/> to copy from.</param>
        public void CopyFrom(Contact from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Id = from.Id;
            FirstName = from.FirstName;
            LastName = from.LastName;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="Contact"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="Contact"/>.</returns>
        public override object Clone()
        {
            var clone = new Contact();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="Contact"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Id = Cleaner.Clean(Id);
            FirstName = Cleaner.Clean(FirstName, StringTrim.UseDefault, StringTransform.UseDefault);
            LastName = Cleaner.Clean(LastName, StringTrim.UseDefault, StringTransform.UseDefault);

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(Id)
                    && Cleaner.IsInitial(FirstName)
                    && Cleaner.IsInitial(LastName);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(Contact from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="Contact"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class ContactCollection : EntityBaseCollection<Contact>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCollection"/> class.
        /// </summary>
        public ContactCollection(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="Contact"/> entities.</param>
        public ContactCollection(IEnumerable<Contact> entities) => AddRange(entities);

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="ContactCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="ContactCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new ContactCollection();
            foreach (Contact item in this)
            {
                clone.Add((Contact)item.Clone());
            }
                
            return clone;
        }
        
        #endregion

        #region Operator

        /// <summary>
        /// An implicit cast from a <see cref="ContactCollectionResult"/> to a <see cref="ContactCollection"/>.
        /// </summary>
        /// <param name="result">The <see cref="ContactCollectionResult"/>.</param>
        /// <returns>The corresponding <see cref="ContactCollection"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Improves useability")]
        public static implicit operator ContactCollection(ContactCollectionResult result) => result?.Result!;

        #endregion
    }

    /// <summary>
    /// Represents a <see cref="Contact"/> collection result.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public class ContactCollectionResult : EntityCollectionResult<ContactCollection, Contact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCollectionResult"/> class.
        /// </summary>
        public ContactCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCollectionResult"/> class with default <see cref="PagingArgs"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public ContactCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public ContactCollectionResult(IEnumerable<Contact> collection, PagingArgs? paging = null) : base(paging) => Result.AddRange(collection);
        
        /// <summary>
        /// Creates a deep copy of the <see cref="ContactCollectionResult"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="ContactCollectionResult"/>.</returns>
        public override object Clone()
        {
            var clone = new ContactCollectionResult();
            clone.CopyFrom(this);
            return clone;
        }
    }
}

#pragma warning restore CA2227, CA1819
#pragma warning restore IDE0005
#nullable restore