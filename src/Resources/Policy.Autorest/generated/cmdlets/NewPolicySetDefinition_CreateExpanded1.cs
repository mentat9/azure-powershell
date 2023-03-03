// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Cmdlets
{
    using static Sample.API.Runtime.Extensions;
    using System;

    /// <summary>
    /// This operation creates or updates a policy set definition in the given management group with the given name.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdateAtManagementGroup=>PUT:"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"PolicySetDefinition_CreateExpanded1", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Sample.API.Models.IPolicySetDefinition))]
    [global::Sample.API.Description(@"This operation creates or updates a policy set definition in the given management group with the given name.")]
    [global::Sample.API.Generated]
    public partial class NewPolicySetDefinition_CreateExpanded1 : global::System.Management.Automation.PSCmdlet,
        Sample.API.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>The policy set definition.</summary>
        private Sample.API.Models.IPolicySetDefinition _parametersBody = new Sample.API.Models.PolicySetDefinition();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Sample.API.PolicyClient Client => Sample.API.Module.Instance.ClientAPI;

        /// <summary>The policy set definition description.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy set definition description.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string Description { get => _parametersBody.Description ?? null; set => _parametersBody.Description = value; }

        /// <summary>The display name of the policy set definition.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The display name of the policy set definition.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the policy set definition.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        public string DisplayName { get => _parametersBody.DisplayName ?? null; set => _parametersBody.DisplayName = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="ManagementGroupId" /> property.</summary>
        private string _managementGroupId;

        /// <summary>The ID of the management group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the management group.")]
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the management group.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public string ManagementGroupId { get => this._managementGroupId; set => this._managementGroupId = value; }

        /// <summary>
        /// The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Sample.API.Models.IAny) })]
        public Sample.API.Models.IAny Metadata { get => _parametersBody.Metadata ?? null /* object */; set => _parametersBody.Metadata = value; }

        /// <summary>
        /// <see cref="Sample.API.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Sample.API.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Sample.API.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Sample.API.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        [global::Sample.API.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The policy set definition parameters that can be used in policy definition references.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition parameters that can be used in policy definition references.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Sample.API.Models.IParameterDefinitions) })]
        public Sample.API.Models.IParameterDefinitions Parameters { get => _parametersBody.Parameters ?? null /* object */; set => _parametersBody.Parameters = value; }

        /// <summary>
        /// The instance of the <see cref="Sample.API.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Sample.API.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>
        /// The metadata describing groups of policy definition references within the policy set definition.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The metadata describing groups of policy definition references within the policy set definition.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The metadata describing groups of policy definition references within the policy set definition.",
        SerializedName = @"policyDefinitionGroups",
        PossibleTypes = new [] { typeof(Sample.API.Models.IPolicyDefinitionGroup) })]
        public Sample.API.Models.IPolicyDefinitionGroup[] PolicyDefinitionGroups { get => _parametersBody.PolicyDefinitionGroups ?? null /* arrayOf */; set => _parametersBody.PolicyDefinitionGroups = value; }

        /// <summary>An array of policy definition references.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "An array of policy definition references.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of policy definition references.",
        SerializedName = @"policyDefinitions",
        PossibleTypes = new [] { typeof(Sample.API.Models.IPolicyDefinitionReference) })]
        public Sample.API.Models.IPolicyDefinitionReference[] PolicyDefinitions { get => _parametersBody.PolicyDefinitions ?? null /* arrayOf */; set => _parametersBody.PolicyDefinitions = value; }

        /// <summary>Backing field for <see cref="PolicySetDefinitionName" /> property.</summary>
        private string _policySetDefinitionName;

        /// <summary>The name of the policy set definition to create.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the policy set definition to create.")]
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the policy set definition to create.",
        SerializedName = @"policySetDefinitionName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public string PolicySetDefinitionName { get => this._policySetDefinitionName; set => this._policySetDefinitionName = value; }

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.",
        SerializedName = @"policyType",
        PossibleTypes = new [] { typeof(Sample.API.Support.PolicyType) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Sample.API.Support.PolicyType))]
        public Sample.API.Support.PolicyType PolicyType { get => _parametersBody.PolicyType ?? ((Sample.API.Support.PolicyType)""); set => _parametersBody.PolicyType = value; }

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

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicySetDefinition">Sample.API.Models.IPolicySetDefinition</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicySetDefinition> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicySetDefinition">Sample.API.Models.IPolicySetDefinition</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicySetDefinition> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
        /// Intializes a new instance of the <see cref="NewPolicySetDefinition_CreateExpanded1" /> cmdlet class.
        /// </summary>
        public NewPolicySetDefinition_CreateExpanded1()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'PolicySetDefinitionsCreateOrUpdateAtManagementGroup' operation"))
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
                    await this.Client.PolicySetDefinitionsCreateOrUpdateAtManagementGroup(PolicySetDefinitionName, ManagementGroupId, _parametersBody, onOk, onCreated, onDefault, this, Pipeline);
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletAfterAPICall); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Sample.API.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  PolicySetDefinitionName=PolicySetDefinitionName,ManagementGroupId=ManagementGroupId,body=_parametersBody})
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
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicySetDefinition">Sample.API.Models.IPolicySetDefinition</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicySetDefinition> response)
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
                // (await response) // should be Sample.API.Models.IPolicySetDefinition
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
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { PolicySetDefinitionName=PolicySetDefinitionName, ManagementGroupId=ManagementGroupId, body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { PolicySetDefinitionName=PolicySetDefinitionName, ManagementGroupId=ManagementGroupId, body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IPolicySetDefinition">Sample.API.Models.IPolicySetDefinition</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IPolicySetDefinition> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Sample.API.Models.IPolicySetDefinition
                WriteObject((await response));
            }
        }
    }
}