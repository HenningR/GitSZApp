﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySecureZoneApp.Api.TyrusNotificationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TyrusNotificationService.IClientNotificationService")]
    public interface IClientNotificationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendNotification", ReplyAction="http://tempuri.org/IClientNotificationService/SendNotificationResponse")]
        MySecureZoneApp.Api.TyrusNotificationService.SendNotificationResponse SendNotification(MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendNotification", ReplyAction="http://tempuri.org/IClientNotificationService/SendNotificationResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.SendNotificationResponse> SendNotificationAsync(MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/CreateOTP", ReplyAction="http://tempuri.org/IClientNotificationService/CreateOTPResponse")]
        MySecureZoneApp.Api.TyrusNotificationService.CreateOTPResponse CreateOTP(MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/CreateOTP", ReplyAction="http://tempuri.org/IClientNotificationService/CreateOTPResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.CreateOTPResponse> CreateOTPAsync(MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendClientPortfolioUpdateRequest", ReplyAction="http://tempuri.org/IClientNotificationService/SendClientPortfolioUpdateRequestRes" +
            "ponse")]
        bool SendClientPortfolioUpdateRequest(System.Guid partyID, string mailBody);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendClientPortfolioUpdateRequest", ReplyAction="http://tempuri.org/IClientNotificationService/SendClientPortfolioUpdateRequestRes" +
            "ponse")]
        System.Threading.Tasks.Task<bool> SendClientPortfolioUpdateRequestAsync(System.Guid partyID, string mailBody);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/CheckOTP", ReplyAction="http://tempuri.org/IClientNotificationService/CheckOTPResponse")]
        MySecureZoneApp.Api.TyrusNotificationService.CheckOTPResponse CheckOTP(MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/CheckOTP", ReplyAction="http://tempuri.org/IClientNotificationService/CheckOTPResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.CheckOTPResponse> CheckOTPAsync(MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetNotifications", ReplyAction="http://tempuri.org/IClientNotificationService/GetNotificationsResponse")]
        string GetNotifications(System.Guid clientID, System.Nullable<short> notificationCategory, System.Nullable<short> notificationStatus, System.Nullable<short> notificationType, bool useLinkedAccounts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetNotifications", ReplyAction="http://tempuri.org/IClientNotificationService/GetNotificationsResponse")]
        System.Threading.Tasks.Task<string> GetNotificationsAsync(System.Guid clientID, System.Nullable<short> notificationCategory, System.Nullable<short> notificationStatus, System.Nullable<short> notificationType, bool useLinkedAccounts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/UpdateNotificationStatus", ReplyAction="http://tempuri.org/IClientNotificationService/UpdateNotificationStatusResponse")]
        bool UpdateNotificationStatus(System.Guid notificationID, short notificationType, short notificationStatus, bool allReferencedMessages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/UpdateNotificationStatus", ReplyAction="http://tempuri.org/IClientNotificationService/UpdateNotificationStatusResponse")]
        System.Threading.Tasks.Task<bool> UpdateNotificationStatusAsync(System.Guid notificationID, short notificationType, short notificationStatus, bool allReferencedMessages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetNotificationTypes", ReplyAction="http://tempuri.org/IClientNotificationService/GetNotificationTypesResponse")]
        string GetNotificationTypes(System.Guid clientID, bool onlySelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetNotificationTypes", ReplyAction="http://tempuri.org/IClientNotificationService/GetNotificationTypesResponse")]
        System.Threading.Tasks.Task<string> GetNotificationTypesAsync(System.Guid clientID, bool onlySelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetSharedTnC", ReplyAction="http://tempuri.org/IClientNotificationService/GetSharedTnCResponse")]
        string GetSharedTnC(System.Guid sharedTnCID, short typeL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/GetSharedTnC", ReplyAction="http://tempuri.org/IClientNotificationService/GetSharedTnCResponse")]
        System.Threading.Tasks.Task<string> GetSharedTnCAsync(System.Guid sharedTnCID, short typeL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/UpdateNotificationType", ReplyAction="http://tempuri.org/IClientNotificationService/UpdateNotificationTypeResponse")]
        bool UpdateNotificationType(System.Guid partyID, short notificationCategory, short notificationType, bool selected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/UpdateNotificationType", ReplyAction="http://tempuri.org/IClientNotificationService/UpdateNotificationTypeResponse")]
        System.Threading.Tasks.Task<bool> UpdateNotificationTypeAsync(System.Guid partyID, short notificationCategory, short notificationType, bool selected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendMail", ReplyAction="http://tempuri.org/IClientNotificationService/SendMailResponse")]
        bool SendMail(string to, string cc, string bcc, string from, string replyTo, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/SendMail", ReplyAction="http://tempuri.org/IClientNotificationService/SendMailResponse")]
        System.Threading.Tasks.Task<bool> SendMailAsync(string to, string cc, string bcc, string from, string replyTo, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/switchUser", ReplyAction="http://tempuri.org/IClientNotificationService/switchUserResponse")]
        void switchUser(int loggedInUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/switchUser", ReplyAction="http://tempuri.org/IClientNotificationService/switchUserResponse")]
        System.Threading.Tasks.Task switchUserAsync(int loggedInUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/hasStaffSetupDevice", ReplyAction="http://tempuri.org/IClientNotificationService/hasStaffSetupDeviceResponse")]
        bool hasStaffSetupDevice(int sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/hasStaffSetupDevice", ReplyAction="http://tempuri.org/IClientNotificationService/hasStaffSetupDeviceResponse")]
        System.Threading.Tasks.Task<bool> hasStaffSetupDeviceAsync(int sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/RequestSecureChat", ReplyAction="http://tempuri.org/IClientNotificationService/RequestSecureChatResponse")]
        MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatResponse RequestSecureChat(MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientNotificationService/RequestSecureChat", ReplyAction="http://tempuri.org/IClientNotificationService/RequestSecureChatResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatResponse> RequestSecureChatAsync(MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendNotification", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendNotificationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Guid clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public short notificationCategory;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public short partyNotificationStatusL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public System.Guid notifyID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public bool sendAdvisorEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public bool sendAdvisorSms;
        
        public SendNotificationRequest() {
        }
        
        public SendNotificationRequest(System.Guid clientID, short notificationCategory, string subject, string message, short partyNotificationStatusL, System.Guid notifyID, bool sendAdvisorEmail, bool sendAdvisorSms) {
            this.clientID = clientID;
            this.notificationCategory = notificationCategory;
            this.subject = subject;
            this.message = message;
            this.partyNotificationStatusL = partyNotificationStatusL;
            this.notifyID = notifyID;
            this.sendAdvisorEmail = sendAdvisorEmail;
            this.sendAdvisorSms = sendAdvisorSms;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendNotificationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendNotificationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool SendNotificationResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string ResultInfo;
        
        public SendNotificationResponse() {
        }
        
        public SendNotificationResponse(bool SendNotificationResult, string ResultInfo) {
            this.SendNotificationResult = SendNotificationResult;
            this.ResultInfo = ResultInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOTP", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateOTPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Guid clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public short categoryL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string cellNumber;
        
        public CreateOTPRequest() {
        }
        
        public CreateOTPRequest(System.Guid clientID, short categoryL, string cellNumber) {
            this.clientID = clientID;
            this.categoryL = categoryL;
            this.cellNumber = cellNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOTPResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateOTPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateOTPResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string ResultInfo;
        
        public CreateOTPResponse() {
        }
        
        public CreateOTPResponse(bool CreateOTPResult, string ResultInfo) {
            this.CreateOTPResult = CreateOTPResult;
            this.ResultInfo = ResultInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckOTP", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckOTPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Guid clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public short categoryL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string otp;
        
        public CheckOTPRequest() {
        }
        
        public CheckOTPRequest(System.Guid clientID, short categoryL, string otp) {
            this.clientID = clientID;
            this.categoryL = categoryL;
            this.otp = otp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckOTPResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckOTPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CheckOTPResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string ResultInfo;
        
        public CheckOTPResponse() {
        }
        
        public CheckOTPResponse(bool CheckOTPResult, string ResultInfo) {
            this.CheckOTPResult = CheckOTPResult;
            this.ResultInfo = ResultInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestSecureChat", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RequestSecureChatRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Guid clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public short notificationCategory;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public short requestType;
        
        public RequestSecureChatRequest() {
        }
        
        public RequestSecureChatRequest(System.Guid clientID, short notificationCategory, short requestType) {
            this.clientID = clientID;
            this.notificationCategory = notificationCategory;
            this.requestType = requestType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestSecureChatResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RequestSecureChatResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool RequestSecureChatResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string ResultInfo;
        
        public RequestSecureChatResponse() {
        }
        
        public RequestSecureChatResponse(bool RequestSecureChatResult, string ResultInfo) {
            this.RequestSecureChatResult = RequestSecureChatResult;
            this.ResultInfo = ResultInfo;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientNotificationServiceChannel : MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientNotificationServiceClient : System.ServiceModel.ClientBase<MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService>, MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService {
        
        public ClientNotificationServiceClient() {
        }
        
        public ClientNotificationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientNotificationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientNotificationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientNotificationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySecureZoneApp.Api.TyrusNotificationService.SendNotificationResponse MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService.SendNotification(MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest request) {
            return base.Channel.SendNotification(request);
        }
        
        public bool SendNotification(System.Guid clientID, short notificationCategory, string subject, string message, short partyNotificationStatusL, System.Guid notifyID, bool sendAdvisorEmail, bool sendAdvisorSms, out string ResultInfo) {
            MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest inValue = new MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest();
            inValue.clientID = clientID;
            inValue.notificationCategory = notificationCategory;
            inValue.subject = subject;
            inValue.message = message;
            inValue.partyNotificationStatusL = partyNotificationStatusL;
            inValue.notifyID = notifyID;
            inValue.sendAdvisorEmail = sendAdvisorEmail;
            inValue.sendAdvisorSms = sendAdvisorSms;
            MySecureZoneApp.Api.TyrusNotificationService.SendNotificationResponse retVal = ((MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService)(this)).SendNotification(inValue);
            ResultInfo = retVal.ResultInfo;
            return retVal.SendNotificationResult;
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.SendNotificationResponse> SendNotificationAsync(MySecureZoneApp.Api.TyrusNotificationService.SendNotificationRequest request) {
            return base.Channel.SendNotificationAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySecureZoneApp.Api.TyrusNotificationService.CreateOTPResponse MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService.CreateOTP(MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest request) {
            return base.Channel.CreateOTP(request);
        }
        
        public bool CreateOTP(System.Guid clientID, short categoryL, string cellNumber, out string ResultInfo) {
            MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest inValue = new MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest();
            inValue.clientID = clientID;
            inValue.categoryL = categoryL;
            inValue.cellNumber = cellNumber;
            MySecureZoneApp.Api.TyrusNotificationService.CreateOTPResponse retVal = ((MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService)(this)).CreateOTP(inValue);
            ResultInfo = retVal.ResultInfo;
            return retVal.CreateOTPResult;
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.CreateOTPResponse> CreateOTPAsync(MySecureZoneApp.Api.TyrusNotificationService.CreateOTPRequest request) {
            return base.Channel.CreateOTPAsync(request);
        }
        
        public bool SendClientPortfolioUpdateRequest(System.Guid partyID, string mailBody) {
            return base.Channel.SendClientPortfolioUpdateRequest(partyID, mailBody);
        }
        
        public System.Threading.Tasks.Task<bool> SendClientPortfolioUpdateRequestAsync(System.Guid partyID, string mailBody) {
            return base.Channel.SendClientPortfolioUpdateRequestAsync(partyID, mailBody);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySecureZoneApp.Api.TyrusNotificationService.CheckOTPResponse MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService.CheckOTP(MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest request) {
            return base.Channel.CheckOTP(request);
        }
        
        public bool CheckOTP(System.Guid clientID, short categoryL, string otp, out string ResultInfo) {
            MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest inValue = new MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest();
            inValue.clientID = clientID;
            inValue.categoryL = categoryL;
            inValue.otp = otp;
            MySecureZoneApp.Api.TyrusNotificationService.CheckOTPResponse retVal = ((MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService)(this)).CheckOTP(inValue);
            ResultInfo = retVal.ResultInfo;
            return retVal.CheckOTPResult;
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.CheckOTPResponse> CheckOTPAsync(MySecureZoneApp.Api.TyrusNotificationService.CheckOTPRequest request) {
            return base.Channel.CheckOTPAsync(request);
        }
        
        public string GetNotifications(System.Guid clientID, System.Nullable<short> notificationCategory, System.Nullable<short> notificationStatus, System.Nullable<short> notificationType, bool useLinkedAccounts) {
            return base.Channel.GetNotifications(clientID, notificationCategory, notificationStatus, notificationType, useLinkedAccounts);
        }
        
        public System.Threading.Tasks.Task<string> GetNotificationsAsync(System.Guid clientID, System.Nullable<short> notificationCategory, System.Nullable<short> notificationStatus, System.Nullable<short> notificationType, bool useLinkedAccounts) {
            return base.Channel.GetNotificationsAsync(clientID, notificationCategory, notificationStatus, notificationType, useLinkedAccounts);
        }
        
        public bool UpdateNotificationStatus(System.Guid notificationID, short notificationType, short notificationStatus, bool allReferencedMessages) {
            return base.Channel.UpdateNotificationStatus(notificationID, notificationType, notificationStatus, allReferencedMessages);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateNotificationStatusAsync(System.Guid notificationID, short notificationType, short notificationStatus, bool allReferencedMessages) {
            return base.Channel.UpdateNotificationStatusAsync(notificationID, notificationType, notificationStatus, allReferencedMessages);
        }
        
        public string GetNotificationTypes(System.Guid clientID, bool onlySelected) {
            return base.Channel.GetNotificationTypes(clientID, onlySelected);
        }
        
        public System.Threading.Tasks.Task<string> GetNotificationTypesAsync(System.Guid clientID, bool onlySelected) {
            return base.Channel.GetNotificationTypesAsync(clientID, onlySelected);
        }
        
        public string GetSharedTnC(System.Guid sharedTnCID, short typeL) {
            return base.Channel.GetSharedTnC(sharedTnCID, typeL);
        }
        
        public System.Threading.Tasks.Task<string> GetSharedTnCAsync(System.Guid sharedTnCID, short typeL) {
            return base.Channel.GetSharedTnCAsync(sharedTnCID, typeL);
        }
        
        public bool UpdateNotificationType(System.Guid partyID, short notificationCategory, short notificationType, bool selected) {
            return base.Channel.UpdateNotificationType(partyID, notificationCategory, notificationType, selected);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateNotificationTypeAsync(System.Guid partyID, short notificationCategory, short notificationType, bool selected) {
            return base.Channel.UpdateNotificationTypeAsync(partyID, notificationCategory, notificationType, selected);
        }
        
        public bool SendMail(string to, string cc, string bcc, string from, string replyTo, string subject, string body) {
            return base.Channel.SendMail(to, cc, bcc, from, replyTo, subject, body);
        }
        
        public System.Threading.Tasks.Task<bool> SendMailAsync(string to, string cc, string bcc, string from, string replyTo, string subject, string body) {
            return base.Channel.SendMailAsync(to, cc, bcc, from, replyTo, subject, body);
        }
        
        public void switchUser(int loggedInUserID) {
            base.Channel.switchUser(loggedInUserID);
        }
        
        public System.Threading.Tasks.Task switchUserAsync(int loggedInUserID) {
            return base.Channel.switchUserAsync(loggedInUserID);
        }
        
        public bool hasStaffSetupDevice(int sid) {
            return base.Channel.hasStaffSetupDevice(sid);
        }
        
        public System.Threading.Tasks.Task<bool> hasStaffSetupDeviceAsync(int sid) {
            return base.Channel.hasStaffSetupDeviceAsync(sid);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatResponse MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService.RequestSecureChat(MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest request) {
            return base.Channel.RequestSecureChat(request);
        }
        
        public bool RequestSecureChat(System.Guid clientID, short notificationCategory, short requestType, out string ResultInfo) {
            MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest inValue = new MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest();
            inValue.clientID = clientID;
            inValue.notificationCategory = notificationCategory;
            inValue.requestType = requestType;
            MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatResponse retVal = ((MySecureZoneApp.Api.TyrusNotificationService.IClientNotificationService)(this)).RequestSecureChat(inValue);
            ResultInfo = retVal.ResultInfo;
            return retVal.RequestSecureChatResult;
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatResponse> RequestSecureChatAsync(MySecureZoneApp.Api.TyrusNotificationService.RequestSecureChatRequest request) {
            return base.Channel.RequestSecureChatAsync(request);
        }
    }
}
