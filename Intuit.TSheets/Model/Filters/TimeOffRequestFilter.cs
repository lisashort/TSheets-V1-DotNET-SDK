﻿// *******************************************************************************
// <copyright file="TimesheetFilter.cs" company="Intuit">
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
    using System.Collections.Generic;
    using Intuit.TSheets.Client.Serialization.Converters;
    using Newtonsoft.Json;
    using NJsonSchema;
    using NJsonSchema.Annotations;

    /// <summary>
    /// Filter for narrowing down the results of a call to retrieve <see cref="TimeOffRequest"/> entities.
    /// </summary>
    [JsonObject]
    public class TimeOffRequestFilter : EntityFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestFilter"/> class.
        /// </summary>
        public TimeOffRequestFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestFilter"/> class,
        /// with minimal required parameters to perform a retrieval operation.
        /// </summary>
        /// <param name="ids">
        /// The time off request ids you'd like to filter on.
        /// </param>
        public TimeOffRequestFilter(IEnumerable<int> ids)
        {
            Ids = ids;
        }

        /// <summary>
        /// Gets or sets the time off request ids you'd like to filter on.
        /// </summary>
        [JsonConverter(typeof(EnumerableToCsvConverter))]
        [JsonSchema(JsonObjectType.String)]
        [JsonProperty("ids")]
        public IEnumerable<int> Ids { get; set; }

        /// <summary>
        /// Gets or sets the user ids you'd like to filter on.
        /// </summary>
        /// <remarks>
        /// Only time off requests linked to one of these user ids will be returned.
        /// Only administrators or group managers may retrieve time off requests for
        /// users other than themselves. Furthermore, administrators or group managers
        /// may only retrieve time off requests for users that belong to their company.
        /// </remarks>
        [JsonConverter(typeof(EnumerableToCsvConverter))]
        [JsonSchema(JsonObjectType.String)]
        [JsonProperty("user_ids")]
        public IEnumerable<int> UserIds { get; set; }
    }
}
