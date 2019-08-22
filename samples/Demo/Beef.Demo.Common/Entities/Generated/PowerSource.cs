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
    /// Represents the Power Source entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PowerSource : ReferenceDataBaseGuid
    {
        #region Constructor
      
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerSource"/> class.
        /// </summary>
        public PowerSource()
        {
            this.PowerSourceConstructor();
        }
        
        #endregion

        #region Operator

        /// <summary>
        /// An implicit cast from an <b>Id</b> to a <see cref="PowerSource"/>.
        /// </summary>
        /// <param name="id">The <b>Id</b>.</param>
        /// <returns>The corresponding <see cref="PowerSource"/>.</returns>
        public static implicit operator PowerSource(Guid id)
        {
            return ConvertFromId<PowerSource>(id);
        }

        /// <summary>
        /// An implicit cast from a <b>Code</b> to a <see cref="PowerSource"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="PowerSource"/>.</returns>
        public static implicit operator PowerSource(string code)
        {
            return ConvertFromCode<PowerSource>(code);
        }
        
        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="PowerSource"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="PowerSource"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<PowerSource>(from);
            CopyFrom((PowerSource)fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="PowerSource"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="PowerSource"/> to copy from.</param>
        public void CopyFrom(PowerSource from)
        {
            CopyFrom((ReferenceDataBaseGuid)from);

            this.OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="PowerSource"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="PowerSource"/>.</returns>
        public override object Clone()
        {
            var clone = new PowerSource();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="PowerSource"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();

            this.OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                if (!base.IsInitial)
                    return false;

                return true;
            }
        }

        #endregion

        #region PartialMethods
      
        partial void PowerSourceConstructor();

        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(PowerSource from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="PowerSource"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class PowerSourceCollection : ReferenceDataCollectionBase<PowerSource>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerSourceCollection"/> class.
        /// </summary>
        public PowerSourceCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerSourceCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="PowerSource"/> entities.</param>
        public PowerSourceCollection(IEnumerable<PowerSource> entities)
        {
            AddRange(entities);
        }

        #endregion
    }
}
