// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PIAnalysisRuleLinks
	/// </summary>
	[DataContract]

	public class PIAnalysisRuleLinks
	{
		public PIAnalysisRuleLinks(string Self = null, string AnalysisRules = null, string Analysis = null, string AnalysisTemplate = null, string Parent = null, string PlugIn = null)
		{
			this.Self = Self;
			this.AnalysisRules = AnalysisRules;
			this.Analysis = Analysis;
			this.AnalysisTemplate = AnalysisTemplate;
			this.Parent = Parent;
			this.PlugIn = PlugIn;
		}

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "AnalysisRules", EmitDefaultValue = false)]
		public string AnalysisRules { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "Analysis", EmitDefaultValue = false)]
		public string Analysis { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "AnalysisTemplate", EmitDefaultValue = false)]
		public string AnalysisTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisRuleLinks
		/// </summary>
		[DataMember(Name = "PlugIn", EmitDefaultValue = false)]
		public string PlugIn { get; set; }

	}
}
