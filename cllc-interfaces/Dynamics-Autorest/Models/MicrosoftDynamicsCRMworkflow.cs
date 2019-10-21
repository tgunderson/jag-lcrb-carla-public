// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// workflow
    /// </summary>
    public partial class MicrosoftDynamicsCRMworkflow
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflow(object entityimage = default(object), string triggeronupdateattributelist = default(string), int? businessprocesstype = default(int?), string _plugintypeidValue = default(string), int? processorder = default(int?), string name = default(string), bool? triggeroncreate = default(bool?), int? mode = default(int?), int? rank = default(int?), bool? ismanaged = default(bool?), string processroleassignment = default(string), string formid = default(string), bool? asyncautodelete = default(bool?), string _modifiedbyValue = default(string), string workflowidunique = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string xaml = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? deletestage = default(int?), string _activeworkflowidValue = default(string), string solutionid = default(string), int? createstage = default(int?), string _owningteamValue = default(string), string _createdbyValue = default(string), bool? subprocess = default(bool?), string primaryentity = default(string), int? statecode = default(int?), string _owninguserValue = default(string), bool? iscrmuiworkflow = default(bool?), int? runas = default(int?), string rendererobjecttypecode = default(string), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string _parentworkflowidValue = default(string), string _owneridValue = default(string), long? entityimageTimestamp = default(long?), int? category = default(int?), int? type = default(int?), bool? triggerondelete = default(bool?), int? updatestage = default(int?), string _owningbusinessunitValue = default(string), string introducedversion = default(string), string workflowid = default(string), bool? ondemand = default(bool?), string clientdata = default(string), int? scope = default(int?), string inputparameters = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? syncworkflowlogonfailure = default(bool?), string entityimageid = default(string), object iscustomizable = default(object), int? componentstate = default(int?), int? languagecode = default(int?), string entityimageUrl = default(string), bool? istransacted = default(bool?), string uniquename = default(string), long? versionnumber = default(long?), string description = default(string), string _sdkmessageidValue = default(string), IList<MicrosoftDynamicsCRMsla> slabaseWorkflowid = default(IList<MicrosoftDynamicsCRMsla>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), object ownerid = default(object), IList<MicrosoftDynamicsCRMasyncoperation> lkAsyncoperationWorkflowactivationid = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMworkflow parentworkflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMworkflow> workflowParentWorkflow = default(IList<MicrosoftDynamicsCRMworkflow>), IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> workflowLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess>), IList<MicrosoftDynamicsCRMexpiredprocess> workflowExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> workflowOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMslaitem> slaitembaseWorkflowid = default(IList<MicrosoftDynamicsCRMslaitem>), IList<MicrosoftDynamicsCRMtranslationprocess> workflowTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMphonetocaseprocess> workflowPhonetocaseprocess = default(IList<MicrosoftDynamicsCRMphonetocaseprocess>), IList<MicrosoftDynamicsCRMannotation> workflowAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMprocessstage> processProcessstage = default(IList<MicrosoftDynamicsCRMprocessstage>), IList<MicrosoftDynamicsCRMsyncerror> workflowSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMnewprocess> workflowNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), MicrosoftDynamicsCRMworkflow activeworkflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMworkflow> workflowActiveWorkflow = default(IList<MicrosoftDynamicsCRMworkflow>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMabsScheduledprocess> absWorkflowScheduledprocess = default(IList<MicrosoftDynamicsCRMabsScheduledprocess>), IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2> lkAdoxioApplicationbpfmvpv2Processid = default(IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2>), IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> lkAdoxioComplaintpublicbpfProcessid = default(IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf>), IList<MicrosoftDynamicsCRMadoxioApplicationbpfv3> lkAdoxioApplicationbpfv3Processid = default(IList<MicrosoftDynamicsCRMadoxioApplicationbpfv3>))
        {
            Entityimage = entityimage;
            Triggeronupdateattributelist = triggeronupdateattributelist;
            Businessprocesstype = businessprocesstype;
            this._plugintypeidValue = _plugintypeidValue;
            Processorder = processorder;
            Name = name;
            Triggeroncreate = triggeroncreate;
            Mode = mode;
            Rank = rank;
            Ismanaged = ismanaged;
            Processroleassignment = processroleassignment;
            Formid = formid;
            Asyncautodelete = asyncautodelete;
            this._modifiedbyValue = _modifiedbyValue;
            Workflowidunique = workflowidunique;
            Overwritetime = overwritetime;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Xaml = xaml;
            Modifiedon = modifiedon;
            Deletestage = deletestage;
            this._activeworkflowidValue = _activeworkflowidValue;
            Solutionid = solutionid;
            Createstage = createstage;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            Subprocess = subprocess;
            Primaryentity = primaryentity;
            Statecode = statecode;
            this._owninguserValue = _owninguserValue;
            Iscrmuiworkflow = iscrmuiworkflow;
            Runas = runas;
            Rendererobjecttypecode = rendererobjecttypecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            this._parentworkflowidValue = _parentworkflowidValue;
            this._owneridValue = _owneridValue;
            EntityimageTimestamp = entityimageTimestamp;
            Category = category;
            Type = type;
            Triggerondelete = triggerondelete;
            Updatestage = updatestage;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Introducedversion = introducedversion;
            Workflowid = workflowid;
            Ondemand = ondemand;
            Clientdata = clientdata;
            Scope = scope;
            Inputparameters = inputparameters;
            Createdon = createdon;
            Syncworkflowlogonfailure = syncworkflowlogonfailure;
            Entityimageid = entityimageid;
            Iscustomizable = iscustomizable;
            Componentstate = componentstate;
            Languagecode = languagecode;
            EntityimageUrl = entityimageUrl;
            Istransacted = istransacted;
            Uniquename = uniquename;
            Versionnumber = versionnumber;
            Description = description;
            this._sdkmessageidValue = _sdkmessageidValue;
            SlabaseWorkflowid = slabaseWorkflowid;
            Owningbusinessunit = owningbusinessunit;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            LkAsyncoperationWorkflowactivationid = lkAsyncoperationWorkflowactivationid;
            Parentworkflowid = parentworkflowid;
            WorkflowParentWorkflow = workflowParentWorkflow;
            WorkflowLeadtoopportunitysalesprocess = workflowLeadtoopportunitysalesprocess;
            WorkflowExpiredprocess = workflowExpiredprocess;
            WorkflowOpportunitysalesprocess = workflowOpportunitysalesprocess;
            SlaitembaseWorkflowid = slaitembaseWorkflowid;
            WorkflowTranslationprocess = workflowTranslationprocess;
            Owningteam = owningteam;
            WorkflowPhonetocaseprocess = workflowPhonetocaseprocess;
            WorkflowAnnotation = workflowAnnotation;
            ProcessProcessstage = processProcessstage;
            WorkflowSyncErrors = workflowSyncErrors;
            WorkflowNewprocess = workflowNewprocess;
            Activeworkflowid = activeworkflowid;
            WorkflowActiveWorkflow = workflowActiveWorkflow;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Owninguser = owninguser;
            AbsWorkflowScheduledprocess = absWorkflowScheduledprocess;
            LkAdoxioApplicationbpfmvpv2Processid = lkAdoxioApplicationbpfmvpv2Processid;
            LkAdoxioComplaintpublicbpfProcessid = lkAdoxioComplaintpublicbpfProcessid;
            LkAdoxioApplicationbpfv3Processid = lkAdoxioApplicationbpfv3Processid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggeronupdateattributelist")]
        public string Triggeronupdateattributelist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocesstype")]
        public int? Businessprocesstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_plugintypeid_value")]
        public string _plugintypeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processorder")]
        public int? Processorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggeroncreate")]
        public bool? Triggeroncreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processroleassignment")]
        public string Processroleassignment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public string Formid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncautodelete")]
        public bool? Asyncautodelete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowidunique")]
        public string Workflowidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xaml")]
        public string Xaml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletestage")]
        public int? Deletestage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activeworkflowid_value")]
        public string _activeworkflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createstage")]
        public int? Createstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subprocess")]
        public bool? Subprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentity")]
        public string Primaryentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscrmuiworkflow")]
        public bool? Iscrmuiworkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runas")]
        public int? Runas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rendererobjecttypecode")]
        public string Rendererobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentworkflowid_value")]
        public string _parentworkflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public int? Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggerondelete")]
        public bool? Triggerondelete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatestage")]
        public int? Updatestage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowid")]
        public string Workflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ondemand")]
        public bool? Ondemand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public int? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inputparameters")]
        public string Inputparameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncworkflowlogonfailure")]
        public bool? Syncworkflowlogonfailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public object Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istransacted")]
        public bool? Istransacted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageid_value")]
        public string _sdkmessageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_workflowid")]
        public IList<MicrosoftDynamicsCRMsla> SlabaseWorkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public object Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_asyncoperation_workflowactivationid")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LkAsyncoperationWorkflowactivationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentworkflowid")]
        public MicrosoftDynamicsCRMworkflow Parentworkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_parent_workflow")]
        public IList<MicrosoftDynamicsCRMworkflow> WorkflowParentWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> WorkflowLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_expiredprocess")]
        public IList<MicrosoftDynamicsCRMexpiredprocess> WorkflowExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> WorkflowOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaitembase_workflowid")]
        public IList<MicrosoftDynamicsCRMslaitem> SlaitembaseWorkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_translationprocess")]
        public IList<MicrosoftDynamicsCRMtranslationprocess> WorkflowTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_phonetocaseprocess")]
        public IList<MicrosoftDynamicsCRMphonetocaseprocess> WorkflowPhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Workflow_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> WorkflowAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "process_processstage")]
        public IList<MicrosoftDynamicsCRMprocessstage> ProcessProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Workflow_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> WorkflowSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_newprocess")]
        public IList<MicrosoftDynamicsCRMnewprocess> WorkflowNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeworkflowid")]
        public MicrosoftDynamicsCRMworkflow Activeworkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_active_workflow")]
        public IList<MicrosoftDynamicsCRMworkflow> WorkflowActiveWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_workflow_scheduledprocess")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocess> AbsWorkflowScheduledprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_applicationbpfmvpv2_processid")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2> LkAdoxioApplicationbpfmvpv2Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_complaintpublicbpf_processid")]
        public IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> LkAdoxioComplaintpublicbpfProcessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_applicationbpfv3_processid")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationbpfv3> LkAdoxioApplicationbpfv3Processid { get; set; }

    }
}
