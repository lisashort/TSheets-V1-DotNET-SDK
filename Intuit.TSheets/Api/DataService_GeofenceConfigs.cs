﻿// *******************************************************************************
// <copyright file="DataService_GeofenceConfigs.cs" company="Intuit">
// Copyright (c) 2019 Intuit
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
// *******************************************************************************

namespace Intuit.TSheets.Api
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Intuit.TSheets.Client.Core;
    using Intuit.TSheets.Client.RequestFlow.Contexts;
    using Intuit.TSheets.Client.Utilities;
    using Intuit.TSheets.Model;
    using Intuit.TSheets.Model.Filters;

    /// <summary>
    /// Top-level service class for interacting with all TSheets API operations.
    /// </summary>
    /// <remarks>
    /// This file contains operations specific to the GeofenceConfigs endpoint.
    /// </remarks>  
    public partial class DataService
    {
        #region Get Methods

        /// <summary>
        /// Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public (IList<GeofenceConfig>, ResultsMeta) GetGeofenceConfigs()
        {
            return AsyncUtil.RunSync(() => GetGeofenceConfigsAsync());
        }

        /// <summary>
        /// Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public (IList<GeofenceConfig>, ResultsMeta) GetGeofenceConfigs(
            RequestOptions options)
        {
            return AsyncUtil.RunSync(() => GetGeofenceConfigsAsync(options));
        }

        /// <summary>
        /// Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public (IList<GeofenceConfig>, ResultsMeta) GetGeofenceConfigs(
            GeofenceConfigFilter filter)
        {
            return AsyncUtil.RunSync(() => GetGeofenceConfigsAsync(filter));
        }

        /// <summary>
        /// Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public (IList<GeofenceConfig>, ResultsMeta) GetGeofenceConfigs(
            GeofenceConfigFilter filter,
            RequestOptions options)
        {
            return AsyncUtil.RunSync(() => GetGeofenceConfigsAsync(filter, options));
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync()
        {
            return await GetGeofenceConfigsAsync(null, null, default).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations, with support for cancellation.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            CancellationToken cancellationToken)
        {
            return await GetGeofenceConfigsAsync(null, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            RequestOptions options)
        {
            return await GetGeofenceConfigsAsync(null, options, default).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations, with support for cancellation.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            RequestOptions options,
            CancellationToken cancellationToken)
        {
            return await GetGeofenceConfigsAsync(null, options, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            GeofenceConfigFilter filter)
        {
            return await GetGeofenceConfigsAsync(filter, null, default).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations, with support for cancellation.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            GeofenceConfigFilter filter,
            CancellationToken cancellationToken)
        {
            return await GetGeofenceConfigsAsync(filter, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            GeofenceConfigFilter filter,
            RequestOptions options)
        {
            return await GetGeofenceConfigsAsync(filter, options, default).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously Retrieve Geofence Configurations, with support for cancellation.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all geofence configurations, with
        /// optional filters to narrow down the results.
        /// </remarks>
        /// <param name="filter">
        /// An instance of the <see cref="GeofenceConfigFilter"/> class, for narrowing down the results.
        /// </param>
        /// <param name="options">
        /// An instance of the <see cref="RequestOptions"/> class, for customizing method processing.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>
        /// An enumerable set of <see cref="GeofenceConfig"/> objects, along with an output
        /// instance of the <see cref="ResultsMeta"/> class containing additional data.
        /// </returns> 
        public async Task<(IList<GeofenceConfig>, ResultsMeta)> GetGeofenceConfigsAsync(
            GeofenceConfigFilter filter,
            RequestOptions options,
            CancellationToken cancellationToken)
        {
            var context = new GetContext<GeofenceConfig>(EndpointName.GeofenceConfigs, filter, options);

            await ExecuteOperationAsync(context, cancellationToken).ConfigureAwait(false);

            return (context.Results.Items, context.ResultsMeta);
        }

        #endregion
    }
}
