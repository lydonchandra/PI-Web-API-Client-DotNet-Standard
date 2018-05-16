// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using NUnit.Framework;
using OSIsoft.AF;
using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System.Collections.Generic;

namespace OSIsoft.PIDevClub.PIWebApiClient.Test
{
    /// <summary>
    ///  Class for testing SecurityIdentityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurityIdentityApiTests : CommonApi
    {
        private ISecurityIdentityApi instance;
        private string webId;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {

            base.CommonInit();
            instance = client.SecurityIdentity;
            base.CreateSampleDatabaseForTests();

            string path = Constants.AF_SECURITY_IDENTITY_PATH;
            string selectedFields = null;
            webId = instance.GetByPath(path, selectedFields).WebId;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            base.DeleteSampleDatabaseForTests();
        }

        /// <summary>
        /// Test an instance of SecurityIdentityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(SecurityIdentityApi), instance, "instance is a SecurityIdentityApi");

        }


        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            string path = Constants.AF_SECURITY_IDENTITY_PATH;
            instance.Delete(webId);
            StandardPISystem.Refresh();
            AFSecurityIdentity mySecurityIdentity = AFObject.FindObject(path) as AFSecurityIdentity;

            Assert.IsNull(mySecurityIdentity);
            DeleteSampleDatabaseForTests();
            CreateSampleDatabaseForTests();

        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            string selectedFields = null;
            var response = instance.Get(webId, selectedFields);
            Assert.IsInstanceOf<PISecurityIdentity>(response, "response is PISecurityIdentity");
        }

        /// <summary>
        /// Test GetByPath
        /// </summary>
        [Test]
        public void GetByPathTest()
        {
            string path = Constants.AF_SECURITY_IDENTITY_PATH;
            string selectedFields = null;
            var response = instance.GetByPath(path, selectedFields);
            Assert.IsInstanceOf<PISecurityIdentity>(response, "response is PISecurityIdentity");
        }

        /// <summary>
        /// Test GetSecurity
        /// </summary>
        [Test]
        public void GetSecurityTest()
        {
            List<string> userIdentity = new List<string>() { @"marc\marc.adm", @"marc\marc.user" };
            bool? forceRefresh = null;
            string selectedFields = null;
            var response = instance.GetSecurity(webId, userIdentity, forceRefresh, selectedFields);
            Assert.IsInstanceOf<PIItemsSecurityRights>(response, "response is PIItemsSecurityRights");
        }

        /// <summary>
        /// Test GetSecurityEntries
        /// </summary>
        [Test]
        public void GetSecurityEntriesTest()
        {
            string nameFilter = null;
            string selectedFields = null;
            var response = instance.GetSecurityEntries(webId, nameFilter, selectedFields);
            Assert.IsInstanceOf<PIItemsSecurityEntry>(response, "response is PIItemsSecurityEntry");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetSecurityEntryByName
        /// </summary>
        [Test]
        public void GetSecurityEntryByNameTest()
        {
            string name = "Administrators";
            string selectedFields = null;
            var response = instance.GetSecurityEntryByName(webId: webId, name: name, selectedFields: selectedFields);
            Assert.IsInstanceOf<PISecurityEntry>(response, "response is PISecurityEntry");
            Assert.IsTrue(response.Name == name);
        }

        /// <summary>
        /// Test GetSecurityMappings
        /// </summary>
        [Test]
        public void GetSecurityMappingsTest()
        {
            string selectedFields = null;
            var response = instance.GetSecurityMappings(webId, selectedFields);
            Assert.IsInstanceOf<PIItemsSecurityMapping>(response, "response is PIItemsSecurityMapping");
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            string path = Constants.AF_SECURITY_IDENTITY_PATH;
            PISecurityIdentity securityIdentity = instance.Get(webId, null);
            securityIdentity.WebId = null;
            securityIdentity.Id = null;
            securityIdentity.Links = null;
            securityIdentity.Path = null;
            securityIdentity.Description = "This is the new security identity swagger description";

            instance.Update(webId, securityIdentity);


            StandardPISystem.Refresh();
            AFSecurityIdentity mySecurityIdentity = AFObject.FindObject(path) as AFSecurityIdentity;
            if (mySecurityIdentity != null)
            {
                Assert.IsTrue(mySecurityIdentity.Description == securityIdentity.Description);
            }

        }

    }

}
