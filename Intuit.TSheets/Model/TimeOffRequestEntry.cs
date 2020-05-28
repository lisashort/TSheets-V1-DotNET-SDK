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
    using Intuit.TSheets.Client.Serialization.Attributes;
    using Intuit.TSheets.Model.Enums;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Individual time off entries associated with a <see cref="TimeOffRequest"/> object.
    /// </summary>
    [DataEntity]
    [JsonObject]
    public class TimeOffRequestEntry : IIdentifiable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestEntry"/> class.
        /// </summary>
        public TimeOffRequestEntry()
        {
        }

        /// <summary>
        /// Gets the id of the time off request entry.
        /// </summary>
        [NoSerializeOnCreate]
        [JsonProperty("id")]
        public int Id { get; internal set; }

        /// <summary>
        /// Gets or sets the id for the time off request that this entry belongs to.
        /// </summary>
        [JsonProperty("time_off_request_id")]
        public int? TimeOffRequestId { get; set; }

        /// <summary>
        /// Gets or sets the status of the time off request entry.
        /// </summary>
        /// <remarks>
        /// See <see cref="TimeOffRequestStatus"/> for allowable values.
        /// </remarks>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public TimeOffRequestStatus? Status { get; set; }

        /// <summary>
        /// Gets the id of the user that approved or denied the time off request entry.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("approver_user_id")]
        public int? ApproverUserId { get; internal set; }

        /// <summary>
        /// Gets or sets the method of the time off request entry.
        /// </summary>
        /// <remarks>
        /// See <see cref="TimeOffRequestEntryMethod"/> for allowable values.
        /// </remarks>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("entry_method")]
        public TimeOffRequestEntryMethod? EntryMethod { get; set; }

        /// <summary>
        /// Gets or sets the total number of seconds recorded for this time off request entry.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets the timezone of the entry in string format.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("tz_string")]
        public string TzString { get; internal set; }

        /// <summary>
        /// Gets or sets the id for the jobcode that this time off request entry is recorded against.
        /// </summary>
        [JsonProperty("jobcode_id")]
        public int? JobcodeId { get; set; }

        /// <summary>
        /// Gets or sets the id for the user that this time off request entry belongs to.
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets the id of the timesheet associated with this time off request entry when it is approved.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("approved_timesheet_id")]
        public int? ApprovedTimesheetId { get; internal set; }

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
