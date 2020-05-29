// *******************************************************************************
// <copyright file="DataService_TimeOffRequestsTests.cs" company="Intuit">
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

namespace Intuit.TSheets.Tests.Unit.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Intuit.TSheets.Client.Core;
    using Intuit.TSheets.Model;
    using Intuit.TSheets.Model.Filters;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DataService_TimeOffRequestsTests : DataServiceTestBase
    {
        private static readonly TimeOffRequestFilter DummyFilter = new TimeOffRequestFilter
        {
            Ids = new[] { 1, 2 }
        };

        private static readonly TimeOffRequest DummyEntity = new TimeOffRequest();
        private static readonly List<TimeOffRequest> DummyEntities = new List<TimeOffRequest> { DummyEntity };

        #region Create Method Tests

        [TestMethod, TestCategory("Unit")]
        public void CreateTimeOffRequests_TestWithoutOptions()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.CreateTimeOffRequests(DummyEntities));
        }

        [TestMethod, TestCategory("Unit")]
        public void CreateTimeOffRequests_TestWithOptions()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.CreateTimeOffRequests(DummyEntities));
        }

        [TestMethod, TestCategory("Unit")]
        public void CreateTimeOffRequest_TestWithoutOptions()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.CreateTimeOffRequest(DummyEntity));
        }

        [TestMethod, TestCategory("Unit")]
        public void CreateTimeOffRequest_TestWithOptions()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.CreateTimeOffRequest(DummyEntity));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task CreateTimeOffRequests_TestWithoutOptionsAsync()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.CreateTimeOffRequestsAsync(DummyEntities).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task CreateTimeOffRequests_TestWithOptionsAsync()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.CreateTimeOffRequestsAsync(DummyEntities).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task CreateTimeOffRequest_TestWithoutOptionsAsync()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.CreateTimeOffRequestAsync(DummyEntity).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task CreateTimeOffRequest_TestWithOptionsAsync()
        {
            ExpectCreate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.CreateTimeOffRequestAsync(DummyEntity).ConfigureAwait(false));
        }

        #endregion

        #region Get Method Tests

        [TestMethod, TestCategory("Unit")]
        public void GetTimeOffRequests_TestWithFilterAndWithoutOptions()
        {
            ExpectGet<TimeOffRequest>(EndpointName.TimeOffRequests, Params.Filter);

            VerifyResult(
                ApiService.GetTimeOffRequests(DummyFilter));
        }

        [TestMethod, TestCategory("Unit")]
        public void GetTimeOffRequests_TestWithFilterAndWithOptions()
        {
            ExpectGet<TimeOffRequest>(EndpointName.TimeOffRequests, Params.Filter | Params.RequestOptions);

            VerifyResult(
                ApiService.GetTimeOffRequests(DummyFilter, DummyRequestOptions));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task GetTimeOffRequests_TestWithFilterAndWithoutOptionsAsync()
        {
            ExpectGet<TimeOffRequest>(EndpointName.TimeOffRequests, Params.Filter);

            VerifyResult(
                await ApiService.GetTimeOffRequestsAsync(DummyFilter).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task GetTimeOffRequests_TestWithFilterAndWithOptionsAsync()
        {
            ExpectGet<TimeOffRequest>(EndpointName.TimeOffRequests, Params.Filter | Params.RequestOptions);

            VerifyResult(
                await ApiService.GetTimeOffRequestsAsync(DummyFilter, DummyRequestOptions).ConfigureAwait(false));
        }

        #endregion

        #region Update Method Tests

        [TestMethod, TestCategory("Unit")]
        public void UpdateTimeOffRequests_TestWithoutOptions()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.UpdateTimeOffRequests(DummyEntities));
        }

        [TestMethod, TestCategory("Unit")]
        public void UpdateTimeOffRequests_TestWithOptions()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.UpdateTimeOffRequests(DummyEntities));
        }

        [TestMethod, TestCategory("Unit")]
        public void UpdateTimeOffRequest_TestWithoutOptions()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.UpdateTimeOffRequest(DummyEntity));
        }

        [TestMethod, TestCategory("Unit")]
        public void UpdateTimeOffRequest_TestWithOptions()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                ApiService.UpdateTimeOffRequest(DummyEntity));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task UpdateTimeOffRequests_TestWithoutOptionsAsync()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.UpdateTimeOffRequestsAsync(DummyEntities).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task UpdateTimeOffRequests_TestWithOptionsAsync()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.UpdateTimeOffRequestsAsync(DummyEntities).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task UpdateTimeOffRequest_TestWithoutOptionsAsync()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.UpdateTimeOffRequestAsync(DummyEntity).ConfigureAwait(false));
        }

        [TestMethod, TestCategory("Unit")]
        public async Task UpdateTimeOffRequest_TestWithOptionsAsync()
        {
            ExpectUpdate<TimeOffRequest>(EndpointName.TimeOffRequests);

            VerifyResult(
                await ApiService.UpdateTimeOffRequestAsync(DummyEntity).ConfigureAwait(false));
        }

        #endregion
    }
}
