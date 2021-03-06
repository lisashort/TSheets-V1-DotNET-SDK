﻿// *******************************************************************************
// <copyright file="IWritableContext.cs" company="Intuit">
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

namespace Intuit.TSheets.Client.RequestFlow.Contexts
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for pipeline context classes which write data to the API (i.e. create/update)
    /// </summary>
    /// <typeparam name="T">The type of data entity.</typeparam>
    internal interface IWritableContext<T> : ISerializedRequest
    {
        /// <summary>
        /// Gets or sets the set of data entity items to be created or updated.
        /// </summary>
        IEnumerable<T> Items { get; set; }
    }
}
