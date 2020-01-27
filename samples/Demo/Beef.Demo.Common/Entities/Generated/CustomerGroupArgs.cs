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
    /// Represents the <see cref="CustomerGroup"/> arguments entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CustomerGroupArgs : EntityBase
    {
        #region PropertyNames
      
        /// <summary>
        /// Represents the <see cref="Company"/> property name.
        /// </summary>
        public const string Property_Company = nameof(Company);

        /// <summary>
        /// Represents the <see cref="Description"/> property name.
        /// </summary>
        public const string Property_Description = nameof(Description);

        #endregion

        #region Privates

        private string _companySid;
        private string _companyText;
        private string _description;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Company"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Company")]
        public string CompanySid
        {
            get { return _companySid; }
            set { SetValue(ref _companySid, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_Company); }
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
            set { SetValue<string>(ref _companySid, value, false, false, Property_Company); }
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

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="CustomerGroupArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CustomerGroupArgs"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<CustomerGroupArgs>(from);
            CopyFrom((CustomerGroupArgs)fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="CustomerGroupArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CustomerGroupArgs"/> to copy from.</param>
        public void CopyFrom(CustomerGroupArgs from)
        {
            CopyFrom((EntityBase)from);
            CompanySid = from.CompanySid;
            Description = from.Description;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="CustomerGroupArgs"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="CustomerGroupArgs"/>.</returns>
        public override object Clone()
        {
            var clone = new CustomerGroupArgs();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="CustomerGroupArgs"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            CompanySid = Cleaner.Clean(CompanySid);
            Description = Cleaner.Clean(Description, StringTrim.End, StringTransform.EmptyToNull);

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
                return Cleaner.IsInitial(CompanySid)
                    && Cleaner.IsInitial(Description);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(CustomerGroupArgs from);

        #endregion
    } 
}
