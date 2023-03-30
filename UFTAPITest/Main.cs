/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘UFTAPITest.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir39 = null;
        public BindDirection bind_dir40 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity13 = null;
        public BindDirection bind_dir41 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity13_Policy = null;
        public BindDirection bind_dir42 = null;
        public BindDirection bind_dir43 = null;
        public BindDirection bind_dir44 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity9 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity9");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.DataExporterActivity11 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity11");
            _flow.DataExporterCloseActivity12 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity12");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity10 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity10");
            this.DataCursorActivity13 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity13");
            this.DataCursorActivity13_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence8 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence8");
            _flow.StServiceCallActivity7 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity7");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.StServiceCallActivity6 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity6");
            _flow.DataFetchActivity9.Comment = @"";
            _flow.DataFetchActivity9.IconPath = @"";
            _flow.DataFetchActivity9.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity9.QueryClassName = @"HP.ST.Ext.CustomDataProviders.LocalDataQuery";
            XmlDocument DataFetchActivity9_QueryParameters_Document = new XmlDocument();
            DataFetchActivity9_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity9Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>2004fd3a-5e20-4512-a85f-48a8c505d66d</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>City_Name</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>True</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value></Value></QueryParameter><QueryParameter><Name>TableStructure</Name><Value>from_city,String,|to_city,String,</Value></QueryParameter><QueryParameter><Name>TableContents</Name><Value>London|Paris</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity9_QueryParameters_Document.LoadXml(xmlDataFetchActivity9Params);
            _flow.DataFetchActivity9.QueryParameters = DataFetchActivity9_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("City_Name", _flow.DataFetchActivity9);
            this.Activities.Add (_flow.DataFetchActivity9);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            _flow.StartActivity1.KafkaSSL = new HP.ST.Fwk.KafkaFWK.KafkaSSLProperties();
            _flow.StartActivity1.IsKafkaUsed = false;
            _flow.StartActivity1.KafkaSSL.StrEnableSSL = @"No";
            _flow.StartActivity1.KafkaSSL.SSLCALocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientCertificateLocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyLocation = @"";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity13);
            _flow.Loop2.Activities.Add (_flow.Sequence8);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity11.Comment = @"";
            _flow.DataExporterActivity11.IconPath = @"";
            VTDPropertyInfoBase pi77 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter39 = new VTDObjectGetter(pi77);
            VTDPropertyInfoBase pi78 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter39 = new VTDObjectSetter(pi78);
            binding_setter39 = new StringFormaterDecorator(binding_setter39,"{Step.DataFetchActivity9.OutTable}");
            bind_dir39 = new BindDirection(_flow.DataFetchActivity9,binding_getter39,binding_setter39,BindTargetType.ToInProperty);
            _flow.DataExporterActivity11.InDirections.Add(bind_dir39);
            this.Activities.Add (_flow.DataExporterActivity11);
            _flow.DataExporterCloseActivity12.Comment = @"";
            _flow.DataExporterCloseActivity12.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity12);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity10.Comment = @"";
            _flow.DataDisconnectActivity10.IconPath = @"";
            VTDPropertyInfoBase pi79 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter40 = new VTDObjectGetter(pi79);
            VTDPropertyInfoBase pi80 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter40 = new VTDObjectSetter(pi80);
            binding_setter40 = new StringFormaterDecorator(binding_setter40,"{Step.DataFetchActivity9.OutTable}");
            bind_dir40 = new BindDirection(_flow.DataFetchActivity9,binding_getter40,binding_setter40,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity10.InDirections.Add(bind_dir40);
            this.Activities.Add (_flow.DataDisconnectActivity10);
            this.DataCursorActivity13.Comment = @"";
            this.DataCursorActivity13.IconPath = @"";
            VTDPropertyInfoBase pi81 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter41 = new VTDObjectGetter(pi81);
            VTDPropertyInfoBase pi82 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter41 = new VTDObjectSetter(pi82);
            binding_setter41 = new StringFormaterDecorator(binding_setter41,"{Step.DataFetchActivity9.OutTable}");
            bind_dir41 = new BindDirection(_flow.DataFetchActivity9,binding_getter41,binding_setter41,BindTargetType.ToInProperty);
            this.DataCursorActivity13.InDirections.Add(bind_dir41);
            this.DataCursorActivity13_Policy.StartPosition = CursorStartPosition.FirstRecord;
            this.DataCursorActivity13_Policy.StartAtSpecificRow = 1;
            this.DataCursorActivity13_Policy.StartCondition.ColumnName = "";
            this.DataCursorActivity13_Policy.StartCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity13_Policy.StartCondition.Value = "";
            this.DataCursorActivity13_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity13_Policy.EndAtSpecificRow = 1;
            this.DataCursorActivity13_Policy.EndCondition.ColumnName = "";
            this.DataCursorActivity13_Policy.EndCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity13_Policy.EndCondition.Value = "";
            this.DataCursorActivity13_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity13_Policy.StepSize = 1;
            this.DataCursorActivity13_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Wraparound;
            this.DataCursorActivity13.Policy = this.DataCursorActivity13_Policy;
            this.DataCursorActivity13.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity13.ResetCursor;
            _flow.Sequence8.Comment = @"";
            _flow.Sequence8.IconPath = @"";
            _flow.Sequence8.Name = @"Sequence8";
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity7);
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity5);
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity6);
            XmlDocument StServiceCallActivity7_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity7_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity7_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>{DataSource.City_Name.from_city}</DepartureCity><ArrivalCity>{DataSource.City_Name.to_city}</ArrivalCity></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity7.InputEnvelope = StServiceCallActivity7_InputEnvelope_Document;
            _flow.StServiceCallActivity7.Comment = @"";
            _flow.StServiceCallActivity7.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity7.Name = @"GetFlights";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress = _context.ResourceManager == null || String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity7.Service = @"Flights_Service";
            _flow.StServiceCallActivity7.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity7.Operation = @"GetFlights";
            _flow.StServiceCallActivity7.IsOneWay = false;
            _flow.StServiceCallActivity7.SendRequestToService=true;
            _flow.StServiceCallActivity7.FaultExpected=false;
            _flow.StServiceCallActivity7.IsAsync=false;
            _flow.StServiceCallActivity7.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity7.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi83 = new VTDPropertyInfoBase("from_city");
            VTDBaseGetter binding_getter42 = new VTDObjectGetter(pi83);
            VTDPropertyInfoBase pi84 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='DepartureCity'][1]");
            VTDBaseSetter binding_setter42 = new VTDXPathSetter(pi84,XmlTypeCode.String);
            binding_setter42 = new StringFormaterDecorator(binding_setter42,"{DataSource.City_Name.from_city}");
            bind_dir42 = new BindDirection(this.DataCursorActivity13,binding_getter42,binding_setter42,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity7.InDirections.Add(bind_dir42);
            VTDPropertyInfoBase pi85 = new VTDPropertyInfoBase("to_city");
            VTDBaseGetter binding_getter43 = new VTDObjectGetter(pi85);
            VTDPropertyInfoBase pi86 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='ArrivalCity'][1]");
            VTDBaseSetter binding_setter43 = new VTDXPathSetter(pi86,XmlTypeCode.String);
            binding_setter43 = new StringFormaterDecorator(binding_setter43,"{DataSource.City_Name.to_city}");
            bind_dir43 = new BindDirection(this.DataCursorActivity13,binding_getter43,binding_setter43,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity7.InDirections.Add(bind_dir43);
            XmlDocument StServiceCallActivity7_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity7.ExpectedOutputProperties = StServiceCallActivity7_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity7.ExpectedFaultProperties = StServiceCallActivity7_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity7.ExpectedOutputAttachments = StServiceCallActivity7_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity7_checkpoints(_flow.StServiceCallActivity7);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrders xmlns=""HP.SOAQ.SampleApp""><FlightsDetails><OrderNumber>88</OrderNumber></FlightsDetails></GetFlightOrders></Body></Envelope>");
            _flow.StServiceCallActivity5.InputEnvelope = StServiceCallActivity5_InputEnvelope_Document;
            _flow.StServiceCallActivity5.Comment = @"";
            _flow.StServiceCallActivity5.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity5.Name = @"GetFlightOrders";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress = _context.ResourceManager == null || String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlightOrders";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity5.Service = @"Flights_Service";
            _flow.StServiceCallActivity5.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity5.Operation = @"GetFlightOrders";
            _flow.StServiceCallActivity5.IsOneWay = false;
            _flow.StServiceCallActivity5.SendRequestToService=true;
            _flow.StServiceCallActivity5.FaultExpected=false;
            _flow.StServiceCallActivity5.IsAsync=false;
            _flow.StServiceCallActivity5.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity5.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrdersResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightOrdersResult><FlightOrder><CustomerName p1:nil=""true"" /><NumberOfTickets>1</NumberOfTickets><OrderNumber>87</OrderNumber></FlightOrder></GetFlightOrdersResult></GetFlightOrdersResponse></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity6_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity6_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity6_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrder xmlns=""HP.SOAQ.SampleApp""><OrderNumber>{Step.InputProperties.StServiceCallActivity5.Body.GetFlightOrders.FlightsDetails.OrderNumber}</OrderNumber></DeleteFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity6.InputEnvelope = StServiceCallActivity6_InputEnvelope_Document;
            _flow.StServiceCallActivity6.Comment = @"";
            _flow.StServiceCallActivity6.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity6.Name = @"DeleteFlightOrder";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress = _context.ResourceManager == null || String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/DeleteFlightOrder";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity6.Service = @"Flights_Service";
            _flow.StServiceCallActivity6.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity6.Operation = @"DeleteFlightOrder";
            _flow.StServiceCallActivity6.IsOneWay = false;
            _flow.StServiceCallActivity6.SendRequestToService=true;
            _flow.StServiceCallActivity6.FaultExpected=false;
            _flow.StServiceCallActivity6.IsAsync=false;
            _flow.StServiceCallActivity6.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity6.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi87 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrders'][1]/*[local-name(.)='FlightsDetails'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseGetter binding_getter44 = new VTDXPathGetter(pi87,XmlTypeCode.Int);
            VTDPropertyInfoBase pi88 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='DeleteFlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseSetter binding_setter44 = new VTDXPathSetter(pi88,XmlTypeCode.Int);
            bind_dir44 = new BindDirection(_flow.StServiceCallActivity5,binding_getter44,binding_setter44,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity6.InDirections.Add(bind_dir44);
            XmlDocument StServiceCallActivity6_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><DeleteFlightOrderResult>true</DeleteFlightOrderResult></DeleteFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity6.ExpectedOutputProperties = StServiceCallActivity6_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity6.ExpectedFaultProperties = StServiceCallActivity6_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity6.ExpectedOutputAttachments = StServiceCallActivity6_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity6_checkpoints(_flow.StServiceCallActivity6);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(), "bin", "ReportResources");
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    