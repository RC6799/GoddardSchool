/*
 * Goddard.FMS.SchoolEvents
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace FranchiseePortal.SchoolEventsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventsApi
            //Assert.IsType<EventsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1AddEventsPost
        /// </summary>
        [Fact]
        public void ApiV1AddEventsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostEvents postEvents = null;
            //var response = instance.ApiV1AddEventsPost(postEvents);
            //Assert.IsType<PostEvents>(response);
        }

        /// <summary>
        /// Test ApiV1EventsGet
        /// </summary>
        [Fact]
        public void ApiV1EventsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fmsSchoolId = null;
            //string startDate = null;
            //string endDate = null;
            //var response = instance.ApiV1EventsGet(fmsSchoolId, startDate, endDate);
            //Assert.IsType<List<Events>>(response);
        }
    }
}