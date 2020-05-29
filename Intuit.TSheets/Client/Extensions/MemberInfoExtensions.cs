// *******************************************************************************
// <copyright file="DictionaryExtensions.cs" company="Intuit">
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

namespace Intuit.TSheets.Client.Extensions
{
    using System;
    using System.Reflection;

    /// <summary>
    /// For internal use, extension methods for MemberInfo objects.
    /// </summary>
    internal static class MemberInfoExtensions
    {
        /// <summary>
        /// Retrieve a custom attribute of a specified type that is applied to a specified member,
        /// and throws a <see cref="InvalidOperationException"/> if the attribute is not found.
        /// </summary>
        /// <param name="memberInfo">The input dictionary of key/value pairs</param>
        /// <returns>An instance derived from the <see cref="Attribute"/> class.</returns>
        public static T GetCustomAttributeOrThrow<T>(this MemberInfo memberInfo)
            where T: Attribute
        {
            T attribute = memberInfo.GetCustomAttribute<T>();

            if (attribute == null)
            {
                throw new InvalidOperationException(
                    $"Class member '{memberInfo.Name}' is missing the '{typeof(T)}' attribute.");
            }

            return attribute;
        }
    }
}
