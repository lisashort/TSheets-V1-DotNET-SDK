// *******************************************************************************
// <copyright file="Timesheet.cs" company="Intuit">
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

namespace Intuit.TSheets.Model
{
    using System;
    using System.Collections.Generic;
    using Intuit.TSheets.Client.Serialization.Attributes;
    using Intuit.TSheets.Model.Enums;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Time Off Requests are used to track paid or unpaid time off in TSheets.
    /// Requests are submitted by team members or by admins/managers on their behalf.
    /// Once they are approved, a timesheet is generated for each request entry.
    /// Then the time off timesheets can be exported or summarized in reports as usual.
    /// </summary>
    [DataEntity]
    [JsonObject]
    public class TimeOffRequest: IIdentifiable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequest"/> class.
        /// </summary>
        public TimeOffRequest()
        {
        }

        /// <summary>
        /// Gets the id of the time off request.
        /// </summary>
        [NoSerializeOnCreate]
        [JsonProperty("id")]
        public int Id { get; internal set; }

        /// <summary>
        /// Gets or sets the id for the user that this time off request belongs to.
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="TimeOffRequestNote"/> ids associated with this time off request.
        /// </summary>
        [JsonProperty("time_off_request_notes")]
        public IList<TimeOffRequestNote> TimeOffRequestNotes { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="TimeOffRequestEntry"/> ids associated with this time off request.
        /// </summary>
        [JsonProperty("time_off_request_entries")]
        public IList<TimeOffRequestEntry> TimeOffRequestEntries { get; set; }

        /// <summary>
        /// Gets or sets the status of the time off request.
        /// </summary>
        /// <remarks>
        /// See <see cref="TimeOffRequestStatus"/> for allowable values.
        /// </remarks>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public TimeOffRequestStatus? Status { get; set; }

        /// <summary>
        /// Gets the value indicating whether this time off request entry is active or archived.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("active")]
        public bool? Active { get; internal set; }

        /// <summary>
        /// Gets the date/time when this time off request entry was created.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; internal set; }

        /// <summary>
        /// Gets the date/time when this time off request entry was last modified.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("last_modified")]
        public DateTimeOffset? LastModified { get; internal set; }
    }
}
