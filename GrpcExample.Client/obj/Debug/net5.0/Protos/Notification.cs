// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/notification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NotificationGrpcService {

  /// <summary>Holder for reflection information generated from Protos/notification.proto</summary>
  public static partial class NotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90b3Mvbm90aWZpY2F0aW9uLnByb3RvEgxub3RpZmljYXRpb24irAEK",
            "D1JlZ2lzdGVyUmVxdWVzdBIQCghjbGllbnRJZBgBIAEoCRIRCgltZXNzYWdl",
            "SWQYAiABKAkSJwoEdHlwZRgDIAEoDjIZLm5vdGlmaWNhdGlvbi5NZXNzYWdl",
            "VHlwZRIMCgR0aW1lGAQgASgDEiwKCHJlc3BvbnNlGAUgASgOMhoubm90aWZp",
            "Y2F0aW9uLlJlc3BvbnNlVHlwZRIPCgdwYXlsb2FkGAYgASgJIqwBChBSZWdp",
            "c3RlclJlc3BvbnNlEhAKCGNsaWVudElkGAEgASgJEhEKCW1lc3NhZ2VJZBgC",
            "IAEoCRInCgR0eXBlGAMgASgOMhkubm90aWZpY2F0aW9uLk1lc3NhZ2VUeXBl",
            "EgwKBHRpbWUYBCABKAMSKwoGc3RhdHVzGAUgASgOMhsubm90aWZpY2F0aW9u",
            "Lk1lc3NhZ2VTdGF0dXMSDwoHcGF5bG9hZBgGIAEoCSpdCgtNZXNzYWdlVHlw",
            "ZRIZChVNRVNTQUdFVFlQRV9VTkRFRklORUQQABIYChRNRVNTQUdFVFlQRV9P",
            "UkRJTkFSWRABEhkKFU1FU1NBR0VUWVBFX0lNUE9SVEFOVBACKn0KDU1lc3Nh",
            "Z2VTdGF0dXMSGwoXTUVTU0FHRVNUQVRVU19VTkRFRklORUQQABIZChVNRVNT",
            "QUdFU1RBVFVTX0NSRUFURUQQARIbChdNRVNTQUdFU1RBVFVTX1BST0NFU1NF",
            "RBACEhcKE01FU1NBR0VTVEFUVVNfRVJST1IQAypkCgxSZXNwb25zZVR5cGUS",
            "GgoWUkVTUE9OU0VUWVBFX1VOREVGSU5FRBAAEhkKFVJFU1BPTlNFVFlQRV9S",
            "RVFVSVJFRBABEh0KGVJFU1BPTlNFVFlQRV9OT1RfUkVRVUlSRUQQAjJdCgxO",
            "b3RpZmljYXRpb24STQoIUmVnaXN0ZXISHS5ub3RpZmljYXRpb24uUmVnaXN0",
            "ZXJSZXF1ZXN0Gh4ubm90aWZpY2F0aW9uLlJlZ2lzdGVyUmVzcG9uc2UoATAB",
            "QhqqAhdOb3RpZmljYXRpb25HcnBjU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NotificationGrpcService.MessageType), typeof(global::NotificationGrpcService.MessageStatus), typeof(global::NotificationGrpcService.ResponseType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NotificationGrpcService.RegisterRequest), global::NotificationGrpcService.RegisterRequest.Parser, new[]{ "ClientId", "MessageId", "Type", "Time", "Response", "Payload" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NotificationGrpcService.RegisterResponse), global::NotificationGrpcService.RegisterResponse.Parser, new[]{ "ClientId", "MessageId", "Type", "Time", "Status", "Payload" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MessageType {
    [pbr::OriginalName("MESSAGETYPE_UNDEFINED")] Undefined = 0,
    [pbr::OriginalName("MESSAGETYPE_ORDINARY")] Ordinary = 1,
    [pbr::OriginalName("MESSAGETYPE_IMPORTANT")] Important = 2,
  }

  public enum MessageStatus {
    [pbr::OriginalName("MESSAGESTATUS_UNDEFINED")] Undefined = 0,
    [pbr::OriginalName("MESSAGESTATUS_CREATED")] Created = 1,
    [pbr::OriginalName("MESSAGESTATUS_PROCESSED")] Processed = 2,
    [pbr::OriginalName("MESSAGESTATUS_ERROR")] Error = 3,
  }

  public enum ResponseType {
    [pbr::OriginalName("RESPONSETYPE_UNDEFINED")] Undefined = 0,
    [pbr::OriginalName("RESPONSETYPE_REQUIRED")] Required = 1,
    [pbr::OriginalName("RESPONSETYPE_NOT_REQUIRED")] NotRequired = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class RegisterRequest : pb::IMessage<RegisterRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegisterRequest> _parser = new pb::MessageParser<RegisterRequest>(() => new RegisterRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegisterRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NotificationGrpcService.NotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterRequest(RegisterRequest other) : this() {
      clientId_ = other.clientId_;
      messageId_ = other.messageId_;
      type_ = other.type_;
      time_ = other.time_;
      response_ = other.response_;
      payload_ = other.payload_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterRequest Clone() {
      return new RegisterRequest(this);
    }

    /// <summary>Field number for the "clientId" field.</summary>
    public const int ClientIdFieldNumber = 1;
    private string clientId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientId {
      get { return clientId_; }
      set {
        clientId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "messageId" field.</summary>
    public const int MessageIdFieldNumber = 2;
    private string messageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageId {
      get { return messageId_; }
      set {
        messageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::NotificationGrpcService.MessageType type_ = global::NotificationGrpcService.MessageType.Undefined;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NotificationGrpcService.MessageType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 5;
    private global::NotificationGrpcService.ResponseType response_ = global::NotificationGrpcService.ResponseType.Undefined;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NotificationGrpcService.ResponseType Response {
      get { return response_; }
      set {
        response_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 6;
    private string payload_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegisterRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegisterRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientId != other.ClientId) return false;
      if (MessageId != other.MessageId) return false;
      if (Type != other.Type) return false;
      if (Time != other.Time) return false;
      if (Response != other.Response) return false;
      if (Payload != other.Payload) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientId.Length != 0) hash ^= ClientId.GetHashCode();
      if (MessageId.Length != 0) hash ^= MessageId.GetHashCode();
      if (Type != global::NotificationGrpcService.MessageType.Undefined) hash ^= Type.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Response != global::NotificationGrpcService.ResponseType.Undefined) hash ^= Response.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClientId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientId);
      }
      if (MessageId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Time != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Time);
      }
      if (Response != global::NotificationGrpcService.ResponseType.Undefined) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Response);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientId);
      }
      if (MessageId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Time != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Time);
      }
      if (Response != global::NotificationGrpcService.ResponseType.Undefined) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Response);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ClientId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientId);
      }
      if (MessageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Response != global::NotificationGrpcService.ResponseType.Undefined) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Response);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegisterRequest other) {
      if (other == null) {
        return;
      }
      if (other.ClientId.Length != 0) {
        ClientId = other.ClientId;
      }
      if (other.MessageId.Length != 0) {
        MessageId = other.MessageId;
      }
      if (other.Type != global::NotificationGrpcService.MessageType.Undefined) {
        Type = other.Type;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Response != global::NotificationGrpcService.ResponseType.Undefined) {
        Response = other.Response;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClientId = input.ReadString();
            break;
          }
          case 18: {
            MessageId = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::NotificationGrpcService.MessageType) input.ReadEnum();
            break;
          }
          case 32: {
            Time = input.ReadInt64();
            break;
          }
          case 40: {
            Response = (global::NotificationGrpcService.ResponseType) input.ReadEnum();
            break;
          }
          case 50: {
            Payload = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ClientId = input.ReadString();
            break;
          }
          case 18: {
            MessageId = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::NotificationGrpcService.MessageType) input.ReadEnum();
            break;
          }
          case 32: {
            Time = input.ReadInt64();
            break;
          }
          case 40: {
            Response = (global::NotificationGrpcService.ResponseType) input.ReadEnum();
            break;
          }
          case 50: {
            Payload = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class RegisterResponse : pb::IMessage<RegisterResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegisterResponse> _parser = new pb::MessageParser<RegisterResponse>(() => new RegisterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegisterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NotificationGrpcService.NotificationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse(RegisterResponse other) : this() {
      clientId_ = other.clientId_;
      messageId_ = other.messageId_;
      type_ = other.type_;
      time_ = other.time_;
      status_ = other.status_;
      payload_ = other.payload_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse Clone() {
      return new RegisterResponse(this);
    }

    /// <summary>Field number for the "clientId" field.</summary>
    public const int ClientIdFieldNumber = 1;
    private string clientId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientId {
      get { return clientId_; }
      set {
        clientId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "messageId" field.</summary>
    public const int MessageIdFieldNumber = 2;
    private string messageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageId {
      get { return messageId_; }
      set {
        messageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::NotificationGrpcService.MessageType type_ = global::NotificationGrpcService.MessageType.Undefined;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NotificationGrpcService.MessageType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::NotificationGrpcService.MessageStatus status_ = global::NotificationGrpcService.MessageStatus.Undefined;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NotificationGrpcService.MessageStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 6;
    private string payload_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegisterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegisterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientId != other.ClientId) return false;
      if (MessageId != other.MessageId) return false;
      if (Type != other.Type) return false;
      if (Time != other.Time) return false;
      if (Status != other.Status) return false;
      if (Payload != other.Payload) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientId.Length != 0) hash ^= ClientId.GetHashCode();
      if (MessageId.Length != 0) hash ^= MessageId.GetHashCode();
      if (Type != global::NotificationGrpcService.MessageType.Undefined) hash ^= Type.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Status != global::NotificationGrpcService.MessageStatus.Undefined) hash ^= Status.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClientId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientId);
      }
      if (MessageId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Time != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Time);
      }
      if (Status != global::NotificationGrpcService.MessageStatus.Undefined) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientId);
      }
      if (MessageId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Time != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Time);
      }
      if (Status != global::NotificationGrpcService.MessageStatus.Undefined) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ClientId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientId);
      }
      if (MessageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageId);
      }
      if (Type != global::NotificationGrpcService.MessageType.Undefined) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Status != global::NotificationGrpcService.MessageStatus.Undefined) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegisterResponse other) {
      if (other == null) {
        return;
      }
      if (other.ClientId.Length != 0) {
        ClientId = other.ClientId;
      }
      if (other.MessageId.Length != 0) {
        MessageId = other.MessageId;
      }
      if (other.Type != global::NotificationGrpcService.MessageType.Undefined) {
        Type = other.Type;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Status != global::NotificationGrpcService.MessageStatus.Undefined) {
        Status = other.Status;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClientId = input.ReadString();
            break;
          }
          case 18: {
            MessageId = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::NotificationGrpcService.MessageType) input.ReadEnum();
            break;
          }
          case 32: {
            Time = input.ReadInt64();
            break;
          }
          case 40: {
            Status = (global::NotificationGrpcService.MessageStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Payload = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ClientId = input.ReadString();
            break;
          }
          case 18: {
            MessageId = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::NotificationGrpcService.MessageType) input.ReadEnum();
            break;
          }
          case 32: {
            Time = input.ReadInt64();
            break;
          }
          case 40: {
            Status = (global::NotificationGrpcService.MessageStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Payload = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
