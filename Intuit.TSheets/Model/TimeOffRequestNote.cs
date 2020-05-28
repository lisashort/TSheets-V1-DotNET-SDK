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
    using Newtonsoft.Json;

    /// <summary>
    /// Descriptive notes to accompany Time Off Requests.
    /// </summary>
    [DataEntity]
    [JsonObject]
    public class TimeOffRequestNote : IIdentifiable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestNote"/> class.
        /// </summary>
        public TimeOffRequestNote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestNote"/> class, with
        /// minimal required parameters.
        /// </summary>
        /// <param name="timeOffRequestId">Id of the time off request note.</param>
        /// <param name="note">The time off request note the user wrote.</param>
        public TimeOffRequestNote(int timeOffRequestId, string note)
        {
            TimeOffRequestId = timeOffRequestId;
            Note = note;
        }

        /// <summary>
        /// Gets the id of the time off request note.
        /// </summary>
        [NoSerializeOnCreate]
        [JsonProperty("id")]
        public int Id { get; internal set; }

        /// <summary>
        /// Gets or sets the id for the time off request that this note belongs to.
        /// </summary>
        [JsonProperty("time_off_request_id")]
        public int? TimeOffRequestId { get; set; }

        /// <summary>
        /// Gets the id for the user that created this time off request note.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("user_id")]
        public int? UserId { get; internal set; }

        /// <summary>
        /// Gets or sets the time off request note the user wrote.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets the value indicating whether this time off request note is active or archived.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("active")]
        public bool? Active { get; internal set; }

        /// <summary>
        /// Gets the date/time when this time off request note was created.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; internal set; }

        /// <summary>
        /// Gets the date/time when this time off request note was last modified.
        /// </summary>
        [NoSerializeOnWrite]
        [JsonProperty("last_modified")]
        public DateTimeOffset? LastModified { get; internal set; }
    }
}
