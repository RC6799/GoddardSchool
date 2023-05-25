/*
 * Goddard.FMS.SchoolTestimonials
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

using FranchiseePortal.TestimonialsWebApiClient.Client;
using FranchiseePortal.TestimonialsWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.TestimonialsWebApiClient.Model;

namespace FranchiseePortal.TestimonialsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing TestimonialsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TestimonialsApiTests : IDisposable
    {
        private TestimonialsApi instance;

        public TestimonialsApiTests()
        {
            instance = new TestimonialsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TestimonialsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TestimonialsApi
            //Assert.IsType<TestimonialsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1AddtestimonialsPost
        /// </summary>
        [Fact]
        public void ApiV1AddtestimonialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestimonialDto testimonialDto = null;
            //var response = instance.ApiV1AddtestimonialsPost(testimonialDto);
            //Assert.IsType<Testimonial>(response);
        }

        /// <summary>
        /// Test ApiV1TestimonialsGet
        /// </summary>
        [Fact]
        public void ApiV1TestimonialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fmsSchoolId = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.ApiV1TestimonialsGet(fmsSchoolId, page, pageSize);
            //Assert.IsType<TestimonialPagedResponse>(response);
        }

        /// <summary>
        /// Test ApiV1UnpublishedTestimonialsGet
        /// </summary>
        [Fact]
        public void ApiV1UnpublishedTestimonialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fmsSchoolId = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.ApiV1UnpublishedTestimonialsGet(fmsSchoolId, page, pageSize);
            //Assert.IsType<GetUnpublishedTestimonialResultPagedResponse>(response);
        }
    }
}