/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ESI.Client;
using ESI.Api;
using ESI.Model;

namespace ESI.Test
{
    /// <summary>
    ///  Class for testing SovereigntyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SovereigntyApiTests
    {
        private SovereigntyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SovereigntyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SovereigntyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SovereigntyApi
            //Assert.IsInstanceOfType(typeof(SovereigntyApi), instance, "instance is a SovereigntyApi");
        }

        
        /// <summary>
        /// Test GetSovereigntyCampaigns
        /// </summary>
        [Test]
        public void GetSovereigntyCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datasource = null;
            //var response = instance.GetSovereigntyCampaigns(datasource);
            //Assert.IsInstanceOf<List<GetSovereigntyCampaigns200Ok>> (response, "response is List<GetSovereigntyCampaigns200Ok>");
        }
        
        /// <summary>
        /// Test GetSovereigntyStructures
        /// </summary>
        [Test]
        public void GetSovereigntyStructuresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datasource = null;
            //var response = instance.GetSovereigntyStructures(datasource);
            //Assert.IsInstanceOf<List<GetSovereigntyStructures200Ok>> (response, "response is List<GetSovereigntyStructures200Ok>");
        }
        
    }

}