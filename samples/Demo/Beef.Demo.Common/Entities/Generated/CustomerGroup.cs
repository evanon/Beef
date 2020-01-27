/*
 * This file is automatically generated; any changes will be lost. 
 */

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
    /// Represents the Customer group entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CustomerGroup : EntityBase
    {
        #region PropertyNames
      
        /// <summary>
        /// Represents the <see cref="Id"/> property name.
        /// </summary>
        public const string Property_Id = nameof(Id);

        /// <summary>
        /// Represents the <see cref="Company"/> property name.
        /// </summary>
        public const string Property_Company = nameof(Company);

        /// <summary>
        /// Represents the <see cref="Description"/> property name.
        /// </summary>
        public const string Property_Description = nameof(Description);

        /// <summary>
        /// Represents the <see cref="IsSalesTaxIncludedInPrice"/> property name.
        /// </summary>
        public const string Property_IsSalesTaxIncludedInPrice = nameof(IsSalesTaxIncludedInPrice);

        /// <summary>
        /// Represents the <see cref="TaxGroup"/> property name.
        /// </summary>
        public const string Property_TaxGroup = nameof(TaxGroup);

        #endregion

        #region Privates

        private string _id;
        private string _companySid;
        private string _companyText;
        private string _description;
        private bool _isSalesTaxIncludedInPrice;
        private string _taxGroup;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="CustomerGroup"/> identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Identifier")]
        public string Id
        {
            get { return _id; }
            set { SetValue(ref _id, value, true, StringTrim.End, StringTransform.EmptyToNull, Property_Id); }
        }

        /// <summary>
        /// Gets or sets the <see cref="Company"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Company")]
        public string CompanySid
        {
            get { return _companySid; }
            set { SetValue(ref _companySid, value, true, StringTrim.End, StringTransform.EmptyToNull, Property_Company); }
        }

        /// <summary>
        /// Gets the corresponding <see cref="Company"/> text (read-only where selected).
        /// </summary>
        [JsonProperty("companyText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyText { get => _companyText ?? GetRefDataText(() => Company); set => _companyText = value; }

        /// <summary>
        /// Gets or sets the Company (see <see cref="RefDataNamespace.Company"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Company")]
        public RefDataNamespace.Company Company
        {
            get { return _companySid; }
            set { SetValue<string>(ref _companySid, value, true, false, Property_Company); }
        }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Description")]
        public string Description
        {
            get { return _description; }
            set { SetValue(ref _description, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_Description); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether Is Sales Tax Included In Price.
        /// </summary>
        [JsonProperty("isSalesTaxIncludedInPrice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Is Sales Tax Included In Price")]
        public bool IsSalesTaxIncludedInPrice
        {
            get { return _isSalesTaxIncludedInPrice; }
            set { SetValue<bool>(ref _isSalesTaxIncludedInPrice, value, false, false, Property_IsSalesTaxIncludedInPrice); }
        }

        /// <summary>
        /// Gets or sets the Tax Group.
        /// </summary>
        [JsonProperty("taxGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Tax Group")]
        public string TaxGroup
        {
            get { return _taxGroup; }
            set { SetValue(ref _taxGroup, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_TaxGroup); }
        }

        #endregion

        #region UniqueKey
      
        /// <summary>
        /// Indicates whether the <see cref="CustomerGroup"/> has a <see cref="UniqueKey"/> value.
        /// </summary>
        public override bool HasUniqueKey
        {
            get { return true; }
        }
        
        /// <summary>
        /// Gets the list of property names that represent the unique key.
        /// </summary>
        public override string[] UniqueKeyProperties => new string[] { Property_Id, Property_Company };
        
        /// <summary>
        /// Creates the <see cref="UniqueKey"/>.
        /// </summary>
        /// <returns>The <see cref="Beef.Entities.UniqueKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        /// <param name="company">The <see cref="Company"/>.</param>
        public static UniqueKey CreateUniqueKey(string id, RefDataNamespace.Company company)
        {
            return new UniqueKey(id, (string)company);
        }
          
        /// <summary>
        /// Gets the <see cref="UniqueKey"/>.
        /// </summary>
        /// <remarks>
        /// The <b>UniqueKey</b> key consists of the following property(s): <see cref="Id"/>, <see cref="Company"/>.
        /// </remarks>
        public override UniqueKey UniqueKey
        {
            get { return new UniqueKey(Id, CompanySid); }
        }

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="CustomerGroup"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CustomerGroup"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<CustomerGroup>(from);
            CopyFrom((CustomerGroup)fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="CustomerGroup"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CustomerGroup"/> to copy from.</param>
        public void CopyFrom(CustomerGroup from)
        {
            CopyFrom((EntityBase)from);
            Id = from.Id;
            CompanySid = from.CompanySid;
            Description = from.Description;
            IsSalesTaxIncludedInPrice = from.IsSalesTaxIncludedInPrice;
            TaxGroup = from.TaxGroup;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="CustomerGroup"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="CustomerGroup"/>.</returns>
        public override object Clone()
        {
            var clone = new CustomerGroup();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="CustomerGroup"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Description = Cleaner.Clean(Description, StringTrim.End, StringTransform.EmptyToNull);
            IsSalesTaxIncludedInPrice = Cleaner.Clean(IsSalesTaxIncludedInPrice);
            TaxGroup = Cleaner.Clean(TaxGroup, StringTrim.End, StringTransform.EmptyToNull);

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
                return Cleaner.IsInitial(Description)
                    && Cleaner.IsInitial(IsSalesTaxIncludedInPrice)
                    && Cleaner.IsInitial(TaxGroup);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(CustomerGroup from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="CustomerGroup"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class CustomerGroupCollection : EntityBaseCollection<CustomerGroup>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGroupCollection"/> class.
        /// </summary>
        public CustomerGroupCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGroupCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="CustomerGroup"/> entities.</param>
        public CustomerGroupCollection(IEnumerable<CustomerGroup> entities)
        {
            AddRange(entities);
        }

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="CustomerGroupCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="CustomerGroupCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new CustomerGroupCollection();
            foreach (CustomerGroup item in this)
            {
                clone.Add((CustomerGroup)item.Clone());
            }
                
            return clone;
        }
        
        #endregion

        #region Operator

        /// <summary>
        /// An implicit cast from a <see cref="CustomerGroupCollectionResult"/> to a <see cref="CustomerGroupCollection"/>.
        /// </summary>
        /// <param name="result">The <see cref="CustomerGroupCollectionResult"/>.</param>
        /// <returns>The corresponding <see cref="CustomerGroupCollection"/>.</returns>
        public static implicit operator CustomerGroupCollection(CustomerGroupCollectionResult result)
        {
            return result?.Result;
        }

        #endregion
    }

    /// <summary>
    /// Represents a <see cref="CustomerGroup"/> collection result.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public class CustomerGroupCollectionResult : EntityCollectionResult<CustomerGroupCollection, CustomerGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGroupCollectionResult"/> class.
        /// </summary>
        public CustomerGroupCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGroupCollectionResult"/> class with default <see cref="PagingArgs"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public CustomerGroupCollectionResult(PagingArgs paging) : base(paging) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGroupCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public CustomerGroupCollectionResult(IEnumerable<CustomerGroup> collection, PagingArgs paging = null) : base(paging)
        {
            Result.AddRange(collection);
        }
        
        /// <summary>
        /// Creates a deep copy of the <see cref="CustomerGroupCollectionResult"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="CustomerGroupCollectionResult"/>.</returns>
        public override object Clone()
        {
            var clone = new CustomerGroupCollectionResult();
            clone.CopyFrom(this);
            return clone;
        }
    }
}
