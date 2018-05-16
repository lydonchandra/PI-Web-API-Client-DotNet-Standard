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
using OSIsoft.AF.Asset;
using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System;
using System.Collections.Generic;

namespace OSIsoft.PIDevClub.PIWebApiClient.Test
{
    /// <summary>
    ///  Class for testing AttributeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AttributeApiTests : CommonApi
    {
        private IAttributeApi instance;
        private string webId;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {


            base.CommonInit();
            instance = client.Attribute;
            base.CreateSampleDatabaseForTests();

            string path = Constants.AF_ATTRIBUTE_PATH;
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
        /// Test an instance of AttributeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(AttributeApi), instance, "instance is a AttributeApi");
        }


        /// <summary>
        /// Test CreateAttribute
        /// </summary>
        [Test]
        public void CreateAttributeTest()
        {
            PIAttribute attribute = new PIAttribute()
            {
                Name = "Water",
                Description = "2008 Water Use",
                Type = "Int32",
                TypeQualifier = "",
                DataReferencePlugIn = "Table Lookup",
                ConfigString = "SELECT [Water Use] FROM [Energy Use 2008] WHERE [Asset ID] = '%Element%'",
                IsConfigurationItem = false,
                IsHidden = false,
                IsManualDataEntry = false,
                TraitName = "LimitLoLo"
            };

            instance.CreateAttribute(webId, attribute);

            AFAttribute myAttribute = AFObject.FindObject(Constants.AF_ATTRIBUTE_PATH) as AFAttribute;
            myAttribute.Database.Refresh();
            Assert.IsNotNull(myAttribute.Attributes[attribute.Name]);


        }

        /// <summary>
        /// Test CreateConfig
        /// </summary>
        [Test]
        public void CreateConfigTest()
        {
            string path2 = Constants.AF_ATTRIBUTE_PATH.Replace(Constants.AF_ATTRIBUTE_NAME, "Temperature");
            string webId2 = instance.GetByPath(path2).WebId;
            instance.CreateConfig(webId2);

        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            instance.Delete(webId);
            AFDatabase db = StandardPISystem.Databases[Constants.AF_DATABASE_NAME];
            db.Refresh();
            AFAttribute attribute = AFObject.FindObject(Constants.AF_ATTRIBUTE_PATH) as AFAttribute;
            Assert.IsNull(attribute);
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
            Assert.IsInstanceOf<PIAttribute>(response, "response is PIAttribute");
            Assert.IsTrue(response.Name == Constants.AF_ATTRIBUTE_NAME);
        }

        /// <summary>
        /// Test GetAttributes
        /// </summary>
        [Test]
        public void GetAttributesTest()
        {
            string nameFilter = null;
            string categoryName = null;
            string templateName = null;
            string valueType = null;
            bool? searchFullHierarchy = null;
            string sortField = null;
            string sortOrder = null;
            int? startIndex = null;
            bool? showExcluded = null;
            bool? showHidden = null;
            int? maxCount = null;
            string selectedFields = null;
            var response = instance.GetAttributes(webId,
                nameFilter: nameFilter,
                categoryName: categoryName,
                templateName: templateName,
                valueType: valueType,
                searchFullHierarchy: searchFullHierarchy,
                sortField: sortField,
                sortOrder: sortOrder,
                startIndex: startIndex,
                showExcluded: showExcluded,
                showHidden: showHidden,
                maxCount: maxCount,
                selectedFields: selectedFields);
            Assert.IsInstanceOf<PIItemsAttribute>(response, "response is PIItemsAttribute");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetByPath
        /// </summary>
        [Test]
        public void GetByPathTest()
        {

            string path = Constants.AF_ATTRIBUTE_PATH;
            string selectedFields = null;
            var response = instance.GetByPath(path, selectedFields);
            Assert.IsInstanceOf<PIAttribute>(response, "response is PIAttribute");
            Assert.IsTrue(response.Name == Constants.AF_ATTRIBUTE_NAME);
        }

        /// <summary>
        /// Test GetCategories
        /// </summary>
        [Test]
        public void GetCategoriesTest()
        {
            string selectedFields = null;
            var response = instance.GetCategories(webId, selectedFields);
            Assert.IsInstanceOf<PIItemsAttributeCategory>(response, "response is PIItemsCategory");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetMultiple
        /// </summary>
        [Test]
        public void GetMultipleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string path2 = Constants.AF_ATTRIBUTE_PATH.Replace(Constants.AF_ATTRIBUTE_NAME, "Temperature");
            string webId2 = instance.GetByPath(path2).WebId;
            List<string> webIdList = new List<string>() { webId, webId2 };
            List<string> path = null;
            string includeMode = "All";
            bool? asParallel = false;
            string selectedFields = null;
            var response = instance.GetMultiple(asParallel, includeMode, path, selectedFields, webIdList);
            Assert.IsInstanceOf<PIItemsItemAttribute>(response, "response is PIItemsItemAttribute");
        }

        /// <summary>
        /// Test GetValue
        /// </summary>
        [Test]
        public void GetValueTest()
        {

            string selectedFields = null;
            var response = instance.GetValue(webId, selectedFields);
            Assert.IsInstanceOf<PITimedValue>(response, "response is PITimedValue");
        }

        /// <summary>
        /// Test SetValue
        /// </summary>
        [Test]
        public void SetValueTest()
        {
            DateTime time = DateTime.Today;
            PITimedValue value = new PITimedValue("t", null, true, false, false, 153);
            value.Substituted = null;
            instance.SetValue(webId, value);

            string path = Constants.AF_ATTRIBUTE_PATH;
            AFDatabase db = StandardPISystem.Databases[Constants.AF_DATABASE_NAME];
            db.Refresh();
            AFAttribute myAttribute = AFObject.FindObject(path) as AFAttribute;
            float v1 = myAttribute.GetValue().ValueAsSingle();
            float v2 = Convert.ToSingle(value.Value);
            Assert.IsTrue(v1 == v2);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            string path = Constants.AF_ATTRIBUTE_PATH;
            PIAttribute attribute = instance.GetByPath(path);
            attribute.WebId = null;
            attribute.Id = null;
            attribute.Path = null;
            attribute.Step = null;
            attribute.HasChildren = null;
            attribute.Links = null;
            attribute.Description = "New description for Swagger attribute";
            instance.Update(webId, attribute);
            StandardPISystem.Refresh();
            AFAttribute myAttribute = AFObject.FindObject(path) as AFAttribute;
            myAttribute.Database.Refresh();
            if (myAttribute != null)
            {
                Assert.IsTrue(myAttribute.Description == myAttribute.Description);
            }
        }

    }

}
