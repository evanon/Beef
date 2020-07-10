/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005, IDE0044 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Demo.Business.Data;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the Contact data repository services.
    /// </summary>
    public partial class ContactDataSvc : IContactDataSvc
    {
        private readonly IContactData _data;

        /// <summary>
        /// Parameterless constructor is explictly not supported.
        /// </summary>
        private ContactDataSvc() => throw new NotSupportedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IContactData"/>.</param>
        public ContactDataSvc(IContactData data) { _data = data ?? throw new ArgumentNullException(nameof(data)); ContactDataSvcCtor(); }

        /// <summary>
        /// Enables additional functionality to be added to the constructor.
        /// </summary>
        partial void ContactDataSvcCtor();

        /// <summary>
        /// Gets the <see cref="Contact"/> collection object that matches the selection criteria.
        /// </summary>
        /// <returns>A <see cref="ContactCollectionResult"/>.</returns>
        public Task<ContactCollectionResult> GetAllAsync()
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ContactDataSvc), async () => 
            {
                var __result = await _data.GetAllAsync().ConfigureAwait(false);
                return __result;
            });
        }

        /// <summary>
        /// Gets the <see cref="Contact"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        /// <returns>The selected <see cref="Contact"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Contact?> GetAsync(Guid id)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ContactDataSvc), async () => 
            {
                var __key = new UniqueKey(id);
                if (ExecutionContext.Current.TryGetCacheValue(__key, out Contact __val))
                    return __val;

                var __result = await _data.GetAsync(id).ConfigureAwait(false);
                ExecutionContext.Current.CacheSet(__key, __result!);
                return __result;
            });
        }

        /// <summary>
        /// Creates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <returns>A refreshed <see cref="Contact"/> object.</returns>
        public Task<Contact> CreateAsync(Contact value)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ContactDataSvc), async () => 
            {
                var __result = await _data.CreateAsync(Check.NotNull(value, nameof(value))).ConfigureAwait(false);
                await Beef.Events.Event.PublishValueEventAsync(__result, $"Demo.Contact.{__result.Id}", "Create").ConfigureAwait(false);
                ExecutionContext.Current.CacheSet(__result.UniqueKey, __result);
                return __result;
            });
        }

        /// <summary>
        /// Updates the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Contact"/> object.</param>
        /// <returns>A refreshed <see cref="Contact"/> object.</returns>
        public Task<Contact> UpdateAsync(Contact value)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ContactDataSvc), async () => 
            {
                var __result = await _data.UpdateAsync(Check.NotNull(value, nameof(value))).ConfigureAwait(false);
                await Beef.Events.Event.PublishValueEventAsync(__result, $"Demo.Contact.{__result.Id}", "Update").ConfigureAwait(false);
                ExecutionContext.Current.CacheSet(__result.UniqueKey, __result);
                return __result;
            });
        }

        /// <summary>
        /// Deletes the <see cref="Contact"/> object.
        /// </summary>
        /// <param name="id">The <see cref="Contact"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ContactDataSvc), async () => 
            {
                await _data.DeleteAsync(id).ConfigureAwait(false);
                await Beef.Events.Event.PublishEventAsync($"Demo.Contact.{id}", "Delete", id).ConfigureAwait(false);
                ExecutionContext.Current.CacheRemove<Contact>(new UniqueKey(id));
            });
        }
    }
}

#pragma warning restore IDE0005, IDE0044
#nullable restore