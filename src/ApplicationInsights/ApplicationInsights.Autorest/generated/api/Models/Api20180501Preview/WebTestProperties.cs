// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Metadata describing a web test for an Azure resource.</summary>
    public partial class WebTestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfiguration _configuration;

        /// <summary>An XML configuration specification for a WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesConfiguration()); set => this._configuration = value; }

        /// <summary>The XML specification of a WebTest to run against an application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string ConfigurationWebTest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfigurationInternal)Configuration).WebTest; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfigurationInternal)Configuration).WebTest = value ?? null; }

        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string ContentValidationContentMatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationContentMatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationContentMatch = value ?? null; }

        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ContentValidationIgnoreCase { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationIgnoreCase; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationIgnoreCase = value ?? default(bool); }

        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ContentValidationPassIfTextFound { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationPassIfTextFound; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidationPassIfTextFound = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>User defined description for this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Is the test actively being monitored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Frequency" /> property.</summary>
        private int? _frequency;

        /// <summary>Interval in seconds between test runs for this WebTest. Default value is 300.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public int? Frequency { get => this._frequency; set => this._frequency = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation[] _location;

        /// <summary>
        /// A list of where to physically run the tests from to give global coverage for accessibility of your application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation[] Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfiguration Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal.Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesConfiguration()); set { {_configuration = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Request</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequest Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal.Request { get => (this._request = this._request ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesRequest()); set { {_request = value;} } }

        /// <summary>Internal Acessors for ValidationRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRules Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal.ValidationRule { get => (this._validationRule = this._validationRule ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesValidationRules()); set { {_validationRule = value;} } }

        /// <summary>Internal Acessors for ValidationRuleContentValidation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesInternal.ValidationRuleContentValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ContentValidation = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Request" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequest _request;

        /// <summary>The collection of request properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequest Request { get => (this._request = this._request ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesRequest()); set => this._request = value; }

        /// <summary>Base64 encoded string body to send with this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string RequestBody { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).RequestBody; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).RequestBody = value ?? null; }

        /// <summary>Follow redirects for this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? RequestFollowRedirect { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).FollowRedirect; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).FollowRedirect = value ?? default(bool); }

        /// <summary>List of headers and their values to add to the WebTest call.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField[] RequestHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).Header; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).Header = value ?? null /* arrayOf */; }

        /// <summary>Http verb to use for this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string RequestHttpVerb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).HttpVerb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).HttpVerb = value ?? null; }

        /// <summary>Parse Dependent request for this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? RequestParseDependentRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).ParseDependentRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).ParseDependentRequest = value ?? default(bool); }

        /// <summary>Url location to test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string RequestUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).RequestUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequestInternal)Request).RequestUrl = value ?? null; }

        /// <summary>Backing field for <see cref="RetryEnabled" /> property.</summary>
        private bool? _retryEnabled;

        /// <summary>Allow for retries should this WebTest fail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? RetryEnabled { get => this._retryEnabled; set => this._retryEnabled = value; }

        /// <summary>Backing field for <see cref="SyntheticMonitorId" /> property.</summary>
        private string _syntheticMonitorId;

        /// <summary>Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string SyntheticMonitorId { get => this._syntheticMonitorId; set => this._syntheticMonitorId = value; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private int? _timeout;

        /// <summary>Seconds until this WebTest will timeout and fail. Default value is 30.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public int? Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Backing field for <see cref="ValidationRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRules _validationRule;

        /// <summary>The collection of validation rule properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRules ValidationRule { get => (this._validationRule = this._validationRule ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesValidationRules()); set => this._validationRule = value; }

        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public int? ValidationRuleExpectedHttpStatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ExpectedHttpStatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).ExpectedHttpStatusCode = value ?? default(int); }

        /// <summary>When set, validation will ignore the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ValidationRuleIgnoreHttpsStatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).IgnoreHttpsStatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).IgnoreHttpsStatusCode = value ?? default(bool); }

        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public int? ValidationRuleSslCertRemainingLifetimeCheck { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).SslCertRemainingLifetimeCheck; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).SslCertRemainingLifetimeCheck = value ?? default(int); }

        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ValidationRuleSslCheck { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).SslCheck; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal)ValidationRule).SslCheck = value ?? default(bool); }

        /// <summary>Backing field for <see cref="WebTestKind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum _webTestKind;

        /// <summary>The kind of web test this is, valid choices are ping, multistep, and standard.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum WebTestKind { get => this._webTestKind; set => this._webTestKind = value; }

        /// <summary>Backing field for <see cref="WebTestName" /> property.</summary>
        private string _webTestName;

        /// <summary>User defined name if this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string WebTestName { get => this._webTestName; set => this._webTestName = value; }

        /// <summary>Creates an new <see cref="WebTestProperties" /> instance.</summary>
        public WebTestProperties()
        {

        }
    }
    /// Metadata describing a web test for an Azure resource.
    public partial interface IWebTestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>The XML specification of a WebTest to run against an application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The XML specification of a WebTest to run against an application.",
        SerializedName = @"WebTest",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationWebTest { get; set; }
        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Content to look for in the return of the WebTest.  Must not be null or empty.",
        SerializedName = @"ContentMatch",
        PossibleTypes = new [] { typeof(string) })]
        string ContentValidationContentMatch { get; set; }
        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When set, this value makes the ContentMatch validation case insensitive.",
        SerializedName = @"IgnoreCase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ContentValidationIgnoreCase { get; set; }
        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, validation will pass if there is a match for the ContentMatch string.  If false, validation will fail if there is a match",
        SerializedName = @"PassIfTextFound",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ContentValidationPassIfTextFound { get; set; }
        /// <summary>User defined description for this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User defined description for this WebTest.",
        SerializedName = @"Description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Is the test actively being monitored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the test actively being monitored.",
        SerializedName = @"Enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>Interval in seconds between test runs for this WebTest. Default value is 300.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Interval in seconds between test runs for this WebTest. Default value is 300.",
        SerializedName = @"Frequency",
        PossibleTypes = new [] { typeof(int) })]
        int? Frequency { get; set; }
        /// <summary>
        /// A list of where to physically run the tests from to give global coverage for accessibility of your application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A list of where to physically run the tests from to give global coverage for accessibility of your application.",
        SerializedName = @"Locations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation[] Location { get; set; }
        /// <summary>
        /// Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Base64 encoded string body to send with this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Base64 encoded string body to send with this web test.",
        SerializedName = @"RequestBody",
        PossibleTypes = new [] { typeof(string) })]
        string RequestBody { get; set; }
        /// <summary>Follow redirects for this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Follow redirects for this web test.",
        SerializedName = @"FollowRedirects",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequestFollowRedirect { get; set; }
        /// <summary>List of headers and their values to add to the WebTest call.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of headers and their values to add to the WebTest call.",
        SerializedName = @"Headers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField[] RequestHeader { get; set; }
        /// <summary>Http verb to use for this web test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Http verb to use for this web test.",
        SerializedName = @"HttpVerb",
        PossibleTypes = new [] { typeof(string) })]
        string RequestHttpVerb { get; set; }
        /// <summary>Parse Dependent request for this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parse Dependent request for this WebTest.",
        SerializedName = @"ParseDependentRequests",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequestParseDependentRequest { get; set; }
        /// <summary>Url location to test.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Url location to test.",
        SerializedName = @"RequestUrl",
        PossibleTypes = new [] { typeof(string) })]
        string RequestUrl { get; set; }
        /// <summary>Allow for retries should this WebTest fail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allow for retries should this WebTest fail.",
        SerializedName = @"RetryEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RetryEnabled { get; set; }
        /// <summary>Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique ID of this WebTest. This is typically the same value as the Name field.",
        SerializedName = @"SyntheticMonitorId",
        PossibleTypes = new [] { typeof(string) })]
        string SyntheticMonitorId { get; set; }
        /// <summary>Seconds until this WebTest will timeout and fail. Default value is 30.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Seconds until this WebTest will timeout and fail. Default value is 30.",
        SerializedName = @"Timeout",
        PossibleTypes = new [] { typeof(int) })]
        int? Timeout { get; set; }
        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validate that the WebTest returns the http status code provided.",
        SerializedName = @"ExpectedHttpStatusCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ValidationRuleExpectedHttpStatusCode { get; set; }
        /// <summary>When set, validation will ignore the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When set, validation will ignore the status code.",
        SerializedName = @"IgnoreHttpsStatusCode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidationRuleIgnoreHttpsStatusCode { get; set; }
        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A number of days to check still remain before the the existing SSL cert expires.  Value must be positive and the SSLCheck must be set to true.",
        SerializedName = @"SSLCertRemainingLifetimeCheck",
        PossibleTypes = new [] { typeof(int) })]
        int? ValidationRuleSslCertRemainingLifetimeCheck { get; set; }
        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Checks to see if the SSL cert is still valid.",
        SerializedName = @"SSLCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidationRuleSslCheck { get; set; }
        /// <summary>The kind of web test this is, valid choices are ping, multistep, and standard.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The kind of web test this is, valid choices are ping, multistep, and standard.",
        SerializedName = @"Kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum WebTestKind { get; set; }
        /// <summary>User defined name if this WebTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"User defined name if this WebTest.",
        SerializedName = @"Name",
        PossibleTypes = new [] { typeof(string) })]
        string WebTestName { get; set; }

    }
    /// Metadata describing a web test for an Azure resource.
    internal partial interface IWebTestPropertiesInternal

    {
        /// <summary>An XML configuration specification for a WebTest.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesConfiguration Configuration { get; set; }
        /// <summary>The XML specification of a WebTest to run against an application.</summary>
        string ConfigurationWebTest { get; set; }
        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        string ContentValidationContentMatch { get; set; }
        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        bool? ContentValidationIgnoreCase { get; set; }
        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        bool? ContentValidationPassIfTextFound { get; set; }
        /// <summary>User defined description for this WebTest.</summary>
        string Description { get; set; }
        /// <summary>Is the test actively being monitored.</summary>
        bool? Enabled { get; set; }
        /// <summary>Interval in seconds between test runs for this WebTest. Default value is 300.</summary>
        int? Frequency { get; set; }
        /// <summary>
        /// A list of where to physically run the tests from to give global coverage for accessibility of your application.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation[] Location { get; set; }
        /// <summary>
        /// Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>The collection of request properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesRequest Request { get; set; }
        /// <summary>Base64 encoded string body to send with this web test.</summary>
        string RequestBody { get; set; }
        /// <summary>Follow redirects for this web test.</summary>
        bool? RequestFollowRedirect { get; set; }
        /// <summary>List of headers and their values to add to the WebTest call.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField[] RequestHeader { get; set; }
        /// <summary>Http verb to use for this web test.</summary>
        string RequestHttpVerb { get; set; }
        /// <summary>Parse Dependent request for this WebTest.</summary>
        bool? RequestParseDependentRequest { get; set; }
        /// <summary>Url location to test.</summary>
        string RequestUrl { get; set; }
        /// <summary>Allow for retries should this WebTest fail.</summary>
        bool? RetryEnabled { get; set; }
        /// <summary>Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
        string SyntheticMonitorId { get; set; }
        /// <summary>Seconds until this WebTest will timeout and fail. Default value is 30.</summary>
        int? Timeout { get; set; }
        /// <summary>The collection of validation rule properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRules ValidationRule { get; set; }
        /// <summary>The collection of content validation properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation ValidationRuleContentValidation { get; set; }
        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        int? ValidationRuleExpectedHttpStatusCode { get; set; }
        /// <summary>When set, validation will ignore the status code.</summary>
        bool? ValidationRuleIgnoreHttpsStatusCode { get; set; }
        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        int? ValidationRuleSslCertRemainingLifetimeCheck { get; set; }
        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        bool? ValidationRuleSslCheck { get; set; }
        /// <summary>The kind of web test this is, valid choices are ping, multistep, and standard.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum WebTestKind { get; set; }
        /// <summary>User defined name if this WebTest.</summary>
        string WebTestName { get; set; }

    }
}