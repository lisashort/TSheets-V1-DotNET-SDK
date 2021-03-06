﻿// *******************************************************************************
// <copyright file="EffectiveSettingsFilter.cs" company="Intuit">
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

namespace Intuit.TSheets.Model.Filters
{
    using System;
    using Intuit.TSheets.Client.Serialization.Converters;
    using Newtonsoft.Json;

    /// <summary>
    /// Filter for narrowing down the results of a call to retrieve <see cref="EffectiveSettings"/> values.
    /// </summary>
    [JsonObject]
    public class EffectiveSettingsFilter : EntityFilter
    {
        /// <summary>
        /// Gets or sets the User id for whom you'd like to retrieve effective settings.
        /// If none is specified, the currently logged in user's id will be used.
        /// Only effective settings that apply to this UserId will be returned.
        /// </summary>
        /// <remarks>
        /// An admin will see more settings than a regular user will.
        /// </remarks>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the filter for returning only those settings modified before this date/time.
        /// </summary>
        [JsonConverter(typeof(DateTimeFormatConverter))]
        [JsonProperty("modified_before")]
        public DateTimeOffset? ModifiedBefore { get; set; }

        /// <summary>
        /// Gets or sets the filter for returning only those settings modified after this date/time.
        /// </summary>
        [JsonConverter(typeof(DateTimeFormatConverter))]
        [JsonProperty("modified_since")]
        public DateTimeOffset? ModifiedSince { get; set; }
    }
}
