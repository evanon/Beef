/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef.Business;
using Beef.Mapper;
using Beef.Mapper.Converters;
using Beef.Data.Database;
using Beef.Data.EntityFrameworkCore;
using Beef.Data.Cosmos;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> database access.
    /// </summary>
    public partial class ReferenceDataData : IReferenceDataData
    {
        private readonly IDatabase _db;
        private readonly IEfDb _ef;
        private readonly ICosmosDb _cosmos;

        /// <summary>
        /// Parameterless constructor is explictly not supported.
        /// </summary>
        private ReferenceDataData() => throw new NotSupportedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataData"/> class.
        /// </summary>
        /// <param name="db">The <see cref="IDatabase"/>.</param>
        /// <param name="ef">The <see cref="IEfDb"/>.</param>
        /// <param name="cosmos">The <see cref="ICosmosDb"/>.</param>
        public ReferenceDataData(IDatabase db, IEfDb ef, ICosmosDb cosmos) { _db = db ?? throw new ArgumentNullException(nameof(db)); _ef = ef ?? throw new ArgumentNullException(nameof(ef)); _cosmos = cosmos ?? throw new ArgumentNullException(nameof(cosmos)); ReferenceDataDataCtor(); }

        /// <summary>
        /// Enables additional functionality to be added to the constructor.
        /// </summary>
        partial void ReferenceDataDataCtor();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.Country"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.CountryCollection"/>.</returns>
        public async Task<RefDataNamespace.CountryCollection> CountryGetAllAsync()
        {
            var __coll = new RefDataNamespace.CountryCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => 
            {
                await _db.GetRefDataAsync<RefDataNamespace.CountryCollection, RefDataNamespace.Country>(__coll, "[Ref].[spCountryGetAll]", "CountryId");
            }, BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);

            return __coll;
        }

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.USState"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.USStateCollection"/>.</returns>
        public async Task<RefDataNamespace.USStateCollection> USStateGetAllAsync()
        {
            var __coll = new RefDataNamespace.USStateCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => 
            {
                await _db.GetRefDataAsync<RefDataNamespace.USStateCollection, RefDataNamespace.USState>(__coll, "[Ref].[spUSStateGetAll]", "USStateId");
            }, BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);

            return __coll;
        }

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.Gender"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.GenderCollection"/>.</returns>
        public async Task<RefDataNamespace.GenderCollection> GenderGetAllAsync()
        {
            var __coll = new RefDataNamespace.GenderCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => 
            {
                await _db.GetRefDataAsync<RefDataNamespace.GenderCollection, RefDataNamespace.Gender>(__coll, "[Ref].[spGenderGetAll]", "GenderId", additionalProperties: (dr, item, fields) =>
                {
                    item.AlternateName = dr.GetValue<string>("AlternateName");
                    item.TripCode = dr.GetValue<string>("TripCode");
                });
            }, BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);

            return __coll;
        }

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.EyeColor"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.EyeColorCollection"/>.</returns>
        public async Task<RefDataNamespace.EyeColorCollection> EyeColorGetAllAsync()
        {
            var __coll = new RefDataNamespace.EyeColorCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => { _ef.Query(EyeColorMapper.CreateArgs()).SelectQuery(__coll); await Task.CompletedTask.ConfigureAwait(false); }, BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);
            return __coll;
        }

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.PowerSource"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.PowerSourceCollection"/>.</returns>
        public async Task<RefDataNamespace.PowerSourceCollection> PowerSourceGetAllAsync()
        {
            var __coll = new RefDataNamespace.PowerSourceCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => { _cosmos.ValueQuery(PowerSourceMapper.CreateArgs("RefData")).SelectQuery(__coll); await Task.CompletedTask.ConfigureAwait(false); }, BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);
            return __coll;
        }

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.Company"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.CompanyCollection"/>.</returns>
        public async Task<RefDataNamespace.CompanyCollection> CompanyGetAllAsync()
        {
            var __coll = new RefDataNamespace.CompanyCollection();
            await DataInvoker.Default.InvokeAsync(this, async () => await CompanyGetAll_OnImplementation(__coll).ConfigureAwait(false), BusinessInvokerArgs.RequiresNewAndTransactionSuppress).ConfigureAwait(false);
            return __coll;
        }

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.EyeColor"/> entity and Entity Framework <see cref="EfModel.EyeColor"/> property mapping.
        /// </summary>
        public static EfDbMapper<RefDataNamespace.EyeColor, EfModel.EyeColor> EyeColorMapper => EfDbMapper.CreateAuto<RefDataNamespace.EyeColor, EfModel.EyeColor>()
            .HasProperty(s => s.Id, d => d.EyeColorId)
            .AddStandardProperties();

        /// <summary>
        /// Provides the <see cref="RefDataNamespace.PowerSource"/> entity and Cosmos <see cref="RefDataNamespace.PowerSource"/> property mapping.
        /// </summary>
        public static CosmosDbMapper<RefDataNamespace.PowerSource, RefDataNamespace.PowerSource> PowerSourceMapper => CosmosDbMapper.CreateAuto<RefDataNamespace.PowerSource, RefDataNamespace.PowerSource>()
            .AddStandardProperties()
            .HasProperty(s => s.AdditionalInfo, d => d.AdditionalInfo, p => p.SetOperationTypes(OperationTypes.Any));
    }
}

#pragma warning restore IDE0005
#nullable restore