// *******************************************************************************
// <copyright file="GeolocationSource.cs" company="Intuit">
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

namespace Intuit.TSheets.Model.Enums
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Supported entry methods for time off request entries.
    /// </summary>
    public enum TimeOffRequestEntryMethod
    {
        /// <summary>
        /// The manual entry method.
        /// </summary>
        /// <remarks>
        /// Manual time off request entries have a date and a duration (in seconds).
        /// </remarks>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// The regular entry method.
        /// </summary>
        /// <remarks>
        /// Regular time off request entries have a start/end time (duration is calculated by TSheets) for determining availability in Schedule.
        /// </remarks>
        [EnumMember(Value = "regular")]
        Regular
    }
}
