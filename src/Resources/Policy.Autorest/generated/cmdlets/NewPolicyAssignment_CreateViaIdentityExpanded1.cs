// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Cmdlets
{
    using static Sample.API.Runtime.Extensions;
    using System;

    /// <summary>
    /// This operation creates or updates the policy assignment with the given ID. Policy assignments made on a scope apply to
    /// all resources contained in that scope. For example, when you assign a policy to a resource group that policy applies to
    /// all resources in the group. Policy assignment IDs have this format: '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
    /// Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription
    /// (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
    /// or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] CreateById=>PUT:"/{policyAssignmentId}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"PolicyAssignment_CreateViaIdentityExpanded1", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Sample.API.Models.IPolicyAssignment))]
    [global::Sample.API.Description(@"This operation creates or updates the policy assignment with the given ID. Policy assignments made on a scope apply to all resources contained in that scope. For example, when you assign a policy to a resource group that policy applies to all resources in the group. Policy assignment IDs have this format: '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'.")]
    [global::Sample.API.Generated]
    public partial class NewPolicyAssignment_CreateViaIdentityExpanded1 : global::System.Management.Automation.PSCmdlet,
        Sample.API.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>The policy assignment.</summary>
        private Sample.API.Models.IPolicyAssignment _parametersBody = new Sample.API.Models.PolicyAssignment();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Sample.API.PolicyClient Client => Sample.API.Module.Instance.ClientAPI;

        /// <summary>This message will be part of response in case of policy violation.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This message will be part of response in case of policy violation.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This message will be part of response in case of policy violation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string Description { get => _parametersBody.Description ?? null; set => _parametersBody.Description = value; }

        /// <summary>The display name of the policy assignment.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The display name of the policy assignment.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the policy assignment.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        public string DisplayName { get => _parametersBody.DisplayName ?? null; set => _parametersBody.DisplayName = value; }

        /// <summary>
        /// The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.",
        SerializedName = @"enforcementMode",
        PossibleTypes = new [] { typeof(Sample.API.Support.EnforcementMode) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Sample.API.Support.EnforcementMode))]
        public Sample.API.Support.EnforcementMode EnforcementMode { get => _parametersBody.EnforcementMode ?? ((Sample.API.Support.EnforcementMode)""); set => _parametersBody.EnforcementMode = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public Sample.API.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public Sample.API.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The identity type. This is the only required field when adding a system or user assigned identity to a resource.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type. This is the only required field when adding a system or user assigned identity to a resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Sample.API.Support.ResourceIdentityType) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Sample.API.Support.ResourceIdentityType))]
        public Sample.API.Support.ResourceIdentityType IdentityType { get => _parametersBody.IdentityType ?? ((Sample.API.Support.ResourceIdentityType)""); set => _parametersBody.IdentityType = value; }

        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [global::Sample.API.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Sample.API.Models.IIdentityUserAssignedIdentities) })]
        public Sample.API.Models.IIdentityUserAssignedIdentities IdentityUserAssignedIdentities { get => _parametersBody.IdentityUserAssignedIdentities ?? null /* object */; set => _parametersBody.IdentityUserAssignedIdentities = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Sample.API.Models.IPolicyIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public Sample.API.Models.IPolicyIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// The location of the policy assignment. Only required when utilizing managed identity.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The location of the policy assignment. Only required when utilizing managed identity.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the policy assignment. Only required when utilizing managed identity.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _parametersBody.Location ?? null; set => _parametersBody.Location = value; }

        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Sample.API.Models.IAny) })]
        public Sample.API.Models.IAny Metadata { get => _parametersBody.Metadata ?? null /* object */; set => _parametersBody.Metadata = value; }

        /// <summary>
        /// <see cref="Sample.API.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Sample.API.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Sample.API.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Sample.API.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>The messages that describe why a resource is non-compliant with the policy.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The messages that describe why a resource is non-compliant with the policy.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The messages that describe why a resource is non-compliant with the policy.",
        SerializedName = @"nonComplianceMessages",
        PossibleTypes = new [] { typeof(Sample.API.Models.INonComplianceMessage) })]
        public Sample.API.Models.INonComplianceMessage[] NonComplianceMessages { get => _parametersBody.NonComplianceMessages ?? null /* arrayOf */; set => _parametersBody.NonComplianceMessages = value; }

        /// <summary>The policy's excluded scopes.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy's excluded scopes.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy's excluded scopes.",
        SerializedName = @"notScopes",
        PossibleTypes = new [] { typeof(string) })]
        public string[] NotScopes { get => _parametersBody.NotScopes ?? null /* arrayOf */; set => _parametersBody.NotScopes = value; }

        /// <summary>The policy property value override.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy property value override.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy property value override.",
        SerializedName = @"overrides",
        PossibleTypes = new [] { typeof(Sample.API.Models.IOverride) })]
        public Sample.API.Models.IOverride[] Overrides { get => _parametersBody.Overrides ?? null /* arrayOf */; set => _parametersBody.Overrides = value; }

        /// <summary>
        /// The parameter values for the assigned policy rule. The keys are the parameter names.
        /// </summary>
        [global::Sample.API.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The parameter values for the assigned policy rule. The keys are the parameter names.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameter values for the assigned policy rule. The keys are the parameter names.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Sample.API.Models.IParameterValues) })]
        public Sample.API.Models.IParameterValues Parameters { get => _parametersBody.Parameters ?? null /* object */; set => _parametersBody.Parameters = value; }

        /// <summary>
        /// The instance of the <see cref="Sample.API.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Sample.API.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The ID of the policy definition or policy set definition being assigned.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ID of the policy definition or policy set definition being assigned.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the policy definition or policy set definition being assigned.",
        SerializedName = @"policyDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        public string PolicyDefinitionId { get => _parametersBody.PolicyDefinitionId ?? null; set => _parametersBody.PolicyDefinitionId = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource selector list to filter policies by resource properties.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource selector list to filter policies by resource properties.",
        SerializedName = @"resourceSelectors",
        PossibleTypes = new [] { typeof(Sample.API.Models.IResourceSelector) })]
        public Sample.API.Models.IResourceSelector[] ResourceSelectors { get => _parametersBody.ResourceSelectors ?? null /* arrayOf */; set => _parametersBody.ResourceSelectors = value; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicyAssignment">Sample.API.Models.IPolicyAssignment</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicyAssignment> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.ICloudError">Sample.API.Models.ICloudError</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.ICloudError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Sample.API.Runtime.AttachDebugger.Break();
            }
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Sample.API.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Sample.API.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Sample.API.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Sample.API.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Sample.API.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Sample.API.Runtime.IEventListener)this).Signal(i,t,()=> Sample.API.Runtime.EventDataConverter.ConvertFrom( m() ) as Sample.API.Runtime.EventData ), InvocationInformation, this.ParameterSetName, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewPolicyAssignment_CreateViaIdentityExpanded1" /> cmdlet class.
        /// </summary>
        public NewPolicyAssignment_CreateViaIdentityExpanded1()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'PolicyAssignmentsCreateById' operation"))
                {
                    using( var asyncCommandRuntime = new Sample.API.Runtime.PowerShell.AsyncCommandRuntime(this, ((Sample.API.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Sample.API.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletGetPipeline); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Sample.API.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Sample.API.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Sample.API.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletBeforeAPICall); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.PolicyAssignmentId)
                    {
                        ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.PolicyAssignmentId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.PolicyAssignmentsCreateById(InputObject.PolicyAssignmentId ?? null, _parametersBody, onCreated, onDefault, this, Pipeline);
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletAfterAPICall); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Sample.API.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=_parametersBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Sample.API.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 201 (Created).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicyAssignment">Sample.API.Models.IPolicyAssignment</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicyAssignment> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnCreated(responseMessage, response, ref _returnNow);
                // if overrideOnCreated has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onCreated - response for 201 / application/json
                // (await response) // should be Sample.API.Models.IPolicyAssignment
                WriteObject((await response));
            }
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.ICloudError">Sample.API.Models.ICloudError</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.ICloudError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Sample.API.Runtime.RestException<Sample.API.Models.ICloudError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }
    }
}