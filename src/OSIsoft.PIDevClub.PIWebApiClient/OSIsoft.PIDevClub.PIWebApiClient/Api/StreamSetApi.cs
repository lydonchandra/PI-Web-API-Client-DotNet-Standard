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
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API StreamSet controller.
	/// </summary>
	public interface IStreamSetApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetChannel(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetChannelWithHttpInfo(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetEnd(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetEndWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetInterpolated(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetInterpolatedWithHttpInfo(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetInterpolatedAtTimes(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetInterpolatedAtTimesWithHttpInfo(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetPlot(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetPlotWithHttpInfo(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetRecorded(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetRecordedWithHttpInfo(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsItemsSubstatus</returns>
		PIItemsItemsSubstatus UpdateValues(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsItemsSubstatus></returns>
		ApiResponse<PIItemsItemsSubstatus> UpdateValuesWithHttpInfo(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetRecordedAtTime(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetRecordedAtTimeWithHttpInfo(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetRecordedAtTimes(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetRecordedAtTimesWithHttpInfo(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamSummaries</returns>
		PIItemsStreamSummaries GetSummaries(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamSummaries></returns>
		ApiResponse<PIItemsStreamSummaries> GetSummariesWithHttpInfo(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetValues(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetValuesWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		PIItemsSubstatus UpdateValue(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		ApiResponse<PIItemsSubstatus> UpdateValueWithHttpInfo(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetChannelAdHoc(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null);

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetChannelAdHocWithHttpInfo(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null);

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetEndAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetEndAdHocWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetInterpolatedAdHoc(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetInterpolatedAdHocWithHttpInfo(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetInterpolatedAtTimesAdHoc(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetInterpolatedAtTimesAdHocWithHttpInfo(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetPlotAdHoc(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetPlotAdHocWithHttpInfo(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetRecordedAdHoc(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetRecordedAdHocWithHttpInfo(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsItemsSubstatus</returns>
		PIItemsItemsSubstatus UpdateValuesAdHoc(List<PIStreamValues> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsItemsSubstatus></returns>
		ApiResponse<PIItemsItemsSubstatus> UpdateValuesAdHocWithHttpInfo(List<PIStreamValues> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetRecordedAtTimeAdHoc(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetRecordedAtTimeAdHocWithHttpInfo(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetRecordedAtTimesAdHoc(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetRecordedAtTimesAdHocWithHttpInfo(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamSummaries</returns>
		PIItemsStreamSummaries GetSummariesAdHoc(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamSummaries></returns>
		ApiResponse<PIItemsStreamSummaries> GetSummariesAdHocWithHttpInfo(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		PIItemsStreamValue GetValuesAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		ApiResponse<PIItemsStreamValue> GetValuesAdHocWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null);

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		PIItemsSubstatus UpdateValueAdHoc(List<PIStreamValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		ApiResponse<PIItemsSubstatus> UpdateValueAdHocWithHttpInfo(List<PIStreamValue> values, string bufferOption = null, string updateOption = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetChannelAsync(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetChannelAsyncWithHttpInfo(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetEndAsync(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetEndAsyncWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAsync(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAsyncWithHttpInfo(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAtTimesAsync(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAtTimesAsyncWithHttpInfo(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetPlotAsync(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetPlotAsyncWithHttpInfo(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAsync(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAsyncWithHttpInfo(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemsSubstatus></returns>
		System.Threading.Tasks.Task<PIItemsItemsSubstatus> UpdateValuesAsync(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>> UpdateValuesAsyncWithHttpInfo(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimeAsync(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimeAsyncWithHttpInfo(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimesAsync(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimesAsyncWithHttpInfo(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamSummaries></returns>
		System.Threading.Tasks.Task<PIItemsStreamSummaries> GetSummariesAsync(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>> GetSummariesAsyncWithHttpInfo(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetValuesAsync(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetValuesAsyncWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValueAsync(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValueAsyncWithHttpInfo(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetChannelAdHocAsync(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetChannelAdHocAsyncWithHttpInfo(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetEndAdHocAsync(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetEndAdHocAsyncWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAdHocAsync(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAdHocAsyncWithHttpInfo(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAtTimesAdHocAsync(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAtTimesAdHocAsyncWithHttpInfo(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetPlotAdHocAsync(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetPlotAdHocAsyncWithHttpInfo(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAdHocAsync(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAdHocAsyncWithHttpInfo(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemsSubstatus></returns>
		System.Threading.Tasks.Task<PIItemsItemsSubstatus> UpdateValuesAdHocAsync(List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>> UpdateValuesAdHocAsyncWithHttpInfo(List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetRecordedAtTimeAdHocAsync(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetRecordedAtTimeAdHocAsyncWithHttpInfo(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimesAdHocAsync(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimesAdHocAsyncWithHttpInfo(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamSummaries></returns>
		System.Threading.Tasks.Task<PIItemsStreamSummaries> GetSummariesAdHocAsync(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>> GetSummariesAdHocAsyncWithHttpInfo(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		System.Threading.Tasks.Task<PIItemsStreamValue> GetValuesAdHocAsync(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetValuesAdHocAsyncWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValueAdHocAsync(List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValueAdHocAsyncWithHttpInfo(List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class StreamSetApi : IStreamSetApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public StreamSetApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetChannel(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetChannelWithHttpInfo(webId, categoryName, heartbeatRate, includeInitialValues, nameFilter, searchFullHierarchy, showExcluded, showHidden, templateName, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetChannelWithHttpInfo(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (heartbeatRate!= null) localVarQueryParams.Add("heartbeatRate", heartbeatRate, false);
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", includeInitialValues, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetEnd(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetEndWithHttpInfo(webId, categoryName, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, templateName, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetEndWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetInterpolated(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetInterpolatedWithHttpInfo(webId, categoryName, endTime, filterExpression, includeFilteredValues, interval, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, syncTime, syncTimeBoundaryType, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetInterpolatedWithHttpInfo(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (interval!= null) localVarQueryParams.Add("interval", interval, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (syncTime!= null) localVarQueryParams.Add("syncTime", syncTime, false);
			if (syncTimeBoundaryType!= null) localVarQueryParams.Add("syncTimeBoundaryType", syncTimeBoundaryType, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetInterpolatedAtTimes(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetInterpolatedAtTimesWithHttpInfo(webId, time, categoryName, filterExpression, includeFilteredValues, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortOrder, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetInterpolatedAtTimesWithHttpInfo(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetPlot(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetPlotWithHttpInfo(webId, categoryName, endTime, intervals, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetPlotWithHttpInfo(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (intervals!= null) localVarQueryParams.Add("intervals", intervals, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetRecorded(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetRecordedWithHttpInfo(webId, boundaryType, categoryName, endTime, filterExpression, includeFilteredValues, maxCount, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetRecordedWithHttpInfo(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", boundaryType, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsItemsSubstatus</returns>
		public PIItemsItemsSubstatus UpdateValues(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsItemsSubstatus> localVarResponse = UpdateValuesWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsItemsSubstatus></returns>
		public ApiResponse<PIItemsItemsSubstatus> UpdateValuesWithHttpInfo(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetRecordedAtTime(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetRecordedAtTimeWithHttpInfo(webId, time, categoryName, nameFilter, retrievalMode, searchFullHierarchy, selectedFields, showExcluded, showHidden, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetRecordedAtTimeWithHttpInfo(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetRecordedAtTimes(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetRecordedAtTimesWithHttpInfo(webId, time, categoryName, nameFilter, retrievalMode, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortOrder, templateName, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetRecordedAtTimesWithHttpInfo(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamSummaries</returns>
		public PIItemsStreamSummaries GetSummaries(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamSummaries> localVarResponse = GetSummariesWithHttpInfo(webId, calculationBasis, categoryName, endTime, filterExpression, nameFilter, sampleInterval, sampleType, searchFullHierarchy, selectedFields, showExcluded, showHidden, startTime, summaryDuration, summaryType, templateName, timeType, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamSummaries></returns>
		public ApiResponse<PIItemsStreamSummaries> GetSummariesWithHttpInfo(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummariesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamSummaries>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetValues(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetValuesWithHttpInfo(webId, categoryName, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, templateName, time, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetValuesWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValuesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		public PIItemsSubstatus UpdateValue(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = UpdateValueWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		public ApiResponse<PIItemsSubstatus> UpdateValueWithHttpInfo(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetChannelAdHoc(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetChannelAdHocWithHttpInfo(webId, heartbeatRate, includeInitialValues, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetChannelAdHocWithHttpInfo(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (heartbeatRate!= null) localVarQueryParams.Add("heartbeatRate", heartbeatRate, false);
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", includeInitialValues, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetEndAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetEndAdHocWithHttpInfo(webId, selectedFields, sortField, sortOrder, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetEndAdHocWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetInterpolatedAdHoc(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetInterpolatedAdHocWithHttpInfo(webId, endTime, filterExpression, includeFilteredValues, interval, selectedFields, sortField, sortOrder, startTime, syncTime, syncTimeBoundaryType, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetInterpolatedAdHocWithHttpInfo(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (interval!= null) localVarQueryParams.Add("interval", interval, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (syncTime!= null) localVarQueryParams.Add("syncTime", syncTime, false);
			if (syncTimeBoundaryType!= null) localVarQueryParams.Add("syncTimeBoundaryType", syncTimeBoundaryType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetInterpolatedAtTimesAdHoc(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetInterpolatedAtTimesAdHocWithHttpInfo(time, webId, filterExpression, includeFilteredValues, selectedFields, sortOrder, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetInterpolatedAtTimesAdHocWithHttpInfo(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetPlotAdHoc(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetPlotAdHocWithHttpInfo(webId, endTime, intervals, selectedFields, sortField, sortOrder, startTime, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetPlotAdHocWithHttpInfo(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (intervals!= null) localVarQueryParams.Add("intervals", intervals, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetRecordedAdHoc(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetRecordedAdHocWithHttpInfo(webId, boundaryType, endTime, filterExpression, includeFilteredValues, maxCount, selectedFields, sortField, sortOrder, startTime, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetRecordedAdHocWithHttpInfo(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", boundaryType, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsItemsSubstatus</returns>
		public PIItemsItemsSubstatus UpdateValuesAdHoc(List<PIStreamValues> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsItemsSubstatus> localVarResponse = UpdateValuesAdHocWithHttpInfo(values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsItemsSubstatus></returns>
		public ApiResponse<PIItemsItemsSubstatus> UpdateValuesAdHocWithHttpInfo(List<PIStreamValues> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetRecordedAtTimeAdHoc(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetRecordedAtTimeAdHocWithHttpInfo(time, webId, retrievalMode, selectedFields, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetRecordedAtTimeAdHocWithHttpInfo(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetRecordedAtTimesAdHoc(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetRecordedAtTimesAdHocWithHttpInfo(time, webId, retrievalMode, selectedFields, sortOrder, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetRecordedAtTimesAdHocWithHttpInfo(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamSummaries</returns>
		public PIItemsStreamSummaries GetSummariesAdHoc(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamSummaries> localVarResponse = GetSummariesAdHocWithHttpInfo(webId, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamSummaries></returns>
		public ApiResponse<PIItemsStreamSummaries> GetSummariesAdHocWithHttpInfo(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummariesAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamSummaries>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsStreamValue</returns>
		public PIItemsStreamValue GetValuesAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null)
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = GetValuesAdHocWithHttpInfo(webId, selectedFields, sortField, sortOrder, time, timeZone, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsStreamValue></returns>
		public ApiResponse<PIItemsStreamValue> GetValuesAdHocWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValuesAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		public PIItemsSubstatus UpdateValueAdHoc(List<PIStreamValue> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = UpdateValueAdHocWithHttpInfo(values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		public ApiResponse<PIItemsSubstatus> UpdateValueAdHocWithHttpInfo(List<PIStreamValue> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueAdHocWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetChannelAsync(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetChannelAsyncWithHttpInfo(webId, categoryName, heartbeatRate, includeInitialValues, nameFilter, searchFullHierarchy, showExcluded, showHidden, templateName, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetChannelAsyncWithHttpInfo(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (heartbeatRate!= null) localVarQueryParams.Add("heartbeatRate", heartbeatRate, false);
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", includeInitialValues, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetEndAsync(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetEndAsyncWithHttpInfo(webId, categoryName, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, templateName, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns End of stream values of the attributes for an Element, Event Frame or Attribute
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetEndAsyncWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAsync(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetInterpolatedAsyncWithHttpInfo(webId, categoryName, endTime, filterExpression, includeFilteredValues, interval, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, syncTime, syncTimeBoundaryType, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAsyncWithHttpInfo(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (interval!= null) localVarQueryParams.Add("interval", interval, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (syncTime!= null) localVarQueryParams.Add("syncTime", syncTime, false);
			if (syncTimeBoundaryType!= null) localVarQueryParams.Add("syncTimeBoundaryType", syncTimeBoundaryType, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAtTimesAsync(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetInterpolatedAtTimesAsyncWithHttpInfo(webId, time, categoryName, filterExpression, includeFilteredValues, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortOrder, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAtTimesAsyncWithHttpInfo(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetPlotAsync(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetPlotAsyncWithHttpInfo(webId, categoryName, endTime, intervals, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetPlotAsyncWithHttpInfo(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (intervals!= null) localVarQueryParams.Add("intervals", intervals, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAsync(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetRecordedAsyncWithHttpInfo(webId, boundaryType, categoryName, endTime, filterExpression, includeFilteredValues, maxCount, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startTime, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAsyncWithHttpInfo(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", boundaryType, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemsSubstatus></returns>
		public async System.Threading.Tasks.Task<PIItemsItemsSubstatus> UpdateValuesAsync(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsItemsSubstatus> localVarResponse = await UpdateValuesAsyncWithHttpInfo(webId, values, bufferOption, updateOption, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>> UpdateValuesAsyncWithHttpInfo(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimeAsync(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetRecordedAtTimeAsyncWithHttpInfo(webId, time, categoryName, nameFilter, retrievalMode, searchFullHierarchy, selectedFields, showExcluded, showHidden, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the attributes for an element, event frame, or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimeAsyncWithHttpInfo(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimesAsync(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetRecordedAtTimesAsyncWithHttpInfo(webId, time, categoryName, nameFilter, retrievalMode, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortOrder, templateName, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of attributes for an element, event frame or attribute at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimesAsyncWithHttpInfo(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamSummaries></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamSummaries> GetSummariesAsync(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamSummaries> localVarResponse = await GetSummariesAsyncWithHttpInfo(webId, calculationBasis, categoryName, endTime, filterExpression, nameFilter, sampleInterval, sampleType, searchFullHierarchy, selectedFields, showExcluded, showHidden, startTime, summaryDuration, summaryType, templateName, timeType, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns summary values of the attributes for an element, event frame or attribute.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>> GetSummariesAsyncWithHttpInfo(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummariesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamSummaries>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetValuesAsync(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetValuesAsyncWithHttpInfo(webId, categoryName, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, templateName, time, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.</param>
		/// <param name="categoryName">Specify that included attributes must have this category. The default is no category filter.</param>
		/// <param name="nameFilter">The name query string used for filtering attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="templateName">Specify that included attributes must be members of this template. The default is no template filter.</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetValuesAsyncWithHttpInfo(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", showExcluded, false);
			if (showHidden!= null) localVarQueryParams.Add("showHidden", showHidden, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValuesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		public async System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValueAsync(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = await UpdateValueAsyncWithHttpInfo(webId, values, bufferOption, updateOption, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValueAsyncWithHttpInfo(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetChannelAdHocAsync(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetChannelAdHocAsyncWithHttpInfo(webId, heartbeatRate, includeInitialValues, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="heartbeatRate">Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetChannelAdHocAsyncWithHttpInfo(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (heartbeatRate!= null) localVarQueryParams.Add("heartbeatRate", heartbeatRate, false);
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", includeInitialValues, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetEndAdHocAsync(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetEndAdHocAsyncWithHttpInfo(webId, selectedFields, sortField, sortOrder, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns End Of Stream values for attributes of the specified streams
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetEndAdHocAsyncWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAdHocAsync(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetInterpolatedAdHocAsyncWithHttpInfo(webId, endTime, filterExpression, includeFilteredValues, interval, selectedFields, sortField, sortOrder, startTime, syncTime, syncTimeBoundaryType, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="syncTime">An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.</param>
		/// <param name="syncTimeBoundaryType">An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAdHocAsyncWithHttpInfo(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (interval!= null) localVarQueryParams.Add("interval", interval, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (syncTime!= null) localVarQueryParams.Add("syncTime", syncTime, false);
			if (syncTimeBoundaryType!= null) localVarQueryParams.Add("syncTimeBoundaryType", syncTimeBoundaryType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetInterpolatedAtTimesAdHocAsync(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetInterpolatedAtTimesAdHocAsyncWithHttpInfo(time, webId, filterExpression, includeFilteredValues, selectedFields, sortOrder, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns interpolated values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetInterpolatedAtTimesAdHocAsyncWithHttpInfo(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetPlotAdHocAsync(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetPlotAdHocAsyncWithHttpInfo(webId, endTime, intervals, selectedFields, sortField, sortOrder, startTime, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state). Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetPlotAdHocAsyncWithHttpInfo(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (intervals!= null) localVarQueryParams.Add("intervals", intervals, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAdHocAsync(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetRecordedAdHocAsyncWithHttpInfo(webId, boundaryType, endTime, filterExpression, includeFilteredValues, maxCount, selectedFields, sortField, sortOrder, startTime, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAdHocAsyncWithHttpInfo(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", boundaryType, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", includeFilteredValues, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemsSubstatus></returns>
		public async System.Threading.Tasks.Task<PIItemsItemsSubstatus> UpdateValuesAdHocAsync(List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsItemsSubstatus> localVarResponse = await UpdateValuesAdHocAsyncWithHttpInfo(values, bufferOption, updateOption, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsItemsSubstatus>> UpdateValuesAdHocAsyncWithHttpInfo(List<PIStreamValues> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetRecordedAtTimeAdHocAsync(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetRecordedAtTimeAdHocAsyncWithHttpInfo(time, webId, retrievalMode, selectedFields, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values based on the passed time and retrieval mode.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which the values are desired.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetRecordedAtTimeAdHocAsyncWithHttpInfo(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetRecordedAtTimesAdHocAsync(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetRecordedAtTimesAdHocAsyncWithHttpInfo(time, webId, retrievalMode, selectedFields, sortOrder, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns recorded values of the specified streams at the specified times.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="retrievalMode">An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetRecordedAtTimesAdHocAsyncWithHttpInfo(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", retrievalMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamSummaries></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamSummaries> GetSummariesAdHocAsync(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamSummaries> localVarResponse = await GetSummariesAdHocAsyncWithHttpInfo(webId, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns summary values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d'.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamSummaries>> GetSummariesAdHocAsyncWithHttpInfo(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", filterExpression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummariesAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamSummaries>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValue></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValue> GetValuesAdHocAsync(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsStreamValue> localVarResponse = await GetValuesAdHocAsyncWithHttpInfo(webId, selectedFields, sortField, sortOrder, time, timeZone, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns values of the specified streams.
		/// </summary>
		/// <remarks>
		/// Any time series value in the response that contains an 'Errors' property indicates PI Web API encountered a handled error during the transfer of the response stream.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'</param>
		/// <param name="time">An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValue>> GetValuesAdHocAsyncWithHttpInfo(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarQueryParams.Add("webId", webId, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (time!= null) localVarQueryParams.Add("time", time, false);
			if (timeZone!= null) localVarQueryParams.Add("timeZone", timeZone, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValuesAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValue>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		public async System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValueAdHocAsync(List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = await UpdateValueAdHocAsyncWithHttpInfo(values, bufferOption, updateOption, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a single value for the specified streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValueAdHocAsyncWithHttpInfo(List<PIStreamValue> values, string bufferOption = null, string updateOption = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			localVarPostBody = Configuration.ApiClient.Serialize(values);
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", bufferOption, false);
			if (updateOption!= null) localVarQueryParams.Add("updateOption", updateOption, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueAdHocAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		#endregion
	}
}
