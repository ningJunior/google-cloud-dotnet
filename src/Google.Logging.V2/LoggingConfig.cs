// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Logging.V2 {

  /// <summary>Holder for reflection information generated from google/logging/v2/logging_config.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LoggingConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/logging/v2/logging_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoggingConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvbG9nZ2luZy92Mi9sb2dnaW5nX2NvbmZpZy5wcm90bxIRZ29v",
            "Z2xlLmxvZ2dpbmcudjIaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8a",
            "G2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
            "L3RpbWVzdGFtcC5wcm90byLGAQoHTG9nU2luaxIMCgRuYW1lGAEgASgJEhMK",
            "C2Rlc3RpbmF0aW9uGAMgASgJEg4KBmZpbHRlchgFIAEoCRJHChVvdXRwdXRf",
            "dmVyc2lvbl9mb3JtYXQYBiABKA4yKC5nb29nbGUubG9nZ2luZy52Mi5Mb2dT",
            "aW5rLlZlcnNpb25Gb3JtYXQiPwoNVmVyc2lvbkZvcm1hdBIeChpWRVJTSU9O",
            "X0ZPUk1BVF9VTlNQRUNJRklFRBAAEgYKAlYyEAESBgoCVjEQAiJPChBMaXN0",
            "U2lua3NSZXF1ZXN0EhQKDHByb2plY3RfbmFtZRgBIAEoCRISCgpwYWdlX3Rv",
            "a2VuGAIgASgJEhEKCXBhZ2Vfc2l6ZRgDIAEoBSJXChFMaXN0U2lua3NSZXNw",
            "b25zZRIpCgVzaW5rcxgBIAMoCzIaLmdvb2dsZS5sb2dnaW5nLnYyLkxvZ1Np",
            "bmsSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIiMKDkdldFNpbmtSZXF1ZXN0",
            "EhEKCXNpbmtfbmFtZRgBIAEoCSJTChFDcmVhdGVTaW5rUmVxdWVzdBIUCgxw",
            "cm9qZWN0X25hbWUYASABKAkSKAoEc2luaxgCIAEoCzIaLmdvb2dsZS5sb2dn",
            "aW5nLnYyLkxvZ1NpbmsiUAoRVXBkYXRlU2lua1JlcXVlc3QSEQoJc2lua19u",
            "YW1lGAEgASgJEigKBHNpbmsYAiABKAsyGi5nb29nbGUubG9nZ2luZy52Mi5M",
            "b2dTaW5rIiYKEURlbGV0ZVNpbmtSZXF1ZXN0EhEKCXNpbmtfbmFtZRgBIAEo",
            "CTKlBQoPQ29uZmlnU2VydmljZVYyEogBCglMaXN0U2lua3MSIy5nb29nbGUu",
            "bG9nZ2luZy52Mi5MaXN0U2lua3NSZXF1ZXN0GiQuZ29vZ2xlLmxvZ2dpbmcu",
            "djIuTGlzdFNpbmtzUmVzcG9uc2UiMILT5JMCKhIoL3YyYmV0YTEve3Byb2pl",
            "Y3RfbmFtZT1wcm9qZWN0cy8qfS9zaW5rcxJ5CgdHZXRTaW5rEiEuZ29vZ2xl",
            "LmxvZ2dpbmcudjIuR2V0U2lua1JlcXVlc3QaGi5nb29nbGUubG9nZ2luZy52",
            "Mi5Mb2dTaW5rIi+C0+STAikSJy92MmJldGExL3tzaW5rX25hbWU9cHJvamVj",
            "dHMvKi9zaW5rcy8qfRKGAQoKQ3JlYXRlU2luaxIkLmdvb2dsZS5sb2dnaW5n",
            "LnYyLkNyZWF0ZVNpbmtSZXF1ZXN0GhouZ29vZ2xlLmxvZ2dpbmcudjIuTG9n",
            "U2luayI2gtPkkwIwIigvdjJiZXRhMS97cHJvamVjdF9uYW1lPXByb2plY3Rz",
            "Lyp9L3NpbmtzOgRzaW5rEoUBCgpVcGRhdGVTaW5rEiQuZ29vZ2xlLmxvZ2dp",
            "bmcudjIuVXBkYXRlU2lua1JlcXVlc3QaGi5nb29nbGUubG9nZ2luZy52Mi5M",
            "b2dTaW5rIjWC0+STAi8aJy92MmJldGExL3tzaW5rX25hbWU9cHJvamVjdHMv",
            "Ki9zaW5rcy8qfToEc2luaxJ7CgpEZWxldGVTaW5rEiQuZ29vZ2xlLmxvZ2dp",
            "bmcudjIuRGVsZXRlU2lua1JlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
            "dHkiL4LT5JMCKSonL3YyYmV0YTEve3NpbmtfbmFtZT1wcm9qZWN0cy8qL3Np",
            "bmtzLyp9QigKFWNvbS5nb29nbGUubG9nZ2luZy52MkINTG9nZ2luZ0NvbmZp",
            "Z1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.LogSink), global::Google.Logging.V2.LogSink.Parser, new[]{ "Name", "Destination", "Filter", "OutputVersionFormat" }, null, new[]{ typeof(global::Google.Logging.V2.LogSink.Types.VersionFormat) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.ListSinksRequest), global::Google.Logging.V2.ListSinksRequest.Parser, new[]{ "ProjectName", "PageToken", "PageSize" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.ListSinksResponse), global::Google.Logging.V2.ListSinksResponse.Parser, new[]{ "Sinks", "NextPageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.GetSinkRequest), global::Google.Logging.V2.GetSinkRequest.Parser, new[]{ "SinkName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.CreateSinkRequest), global::Google.Logging.V2.CreateSinkRequest.Parser, new[]{ "ProjectName", "Sink" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.UpdateSinkRequest), global::Google.Logging.V2.UpdateSinkRequest.Parser, new[]{ "SinkName", "Sink" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Logging.V2.DeleteSinkRequest), global::Google.Logging.V2.DeleteSinkRequest.Parser, new[]{ "SinkName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Describes a sink used to export log entries outside Cloud Logging.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LogSink : pb::IMessage<LogSink> {
    private static readonly pb::MessageParser<LogSink> _parser = new pb::MessageParser<LogSink>(() => new LogSink());
    public static pb::MessageParser<LogSink> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public LogSink() {
      OnConstruction();
    }

    partial void OnConstruction();

    public LogSink(LogSink other) : this() {
      name_ = other.name_;
      destination_ = other.destination_;
      filter_ = other.filter_;
      outputVersionFormat_ = other.outputVersionFormat_;
    }

    public LogSink Clone() {
      return new LogSink(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  Required. The client-assigned sink identifier. Example:
    ///  `"my-severe-errors-to-pubsub"`.
    ///  Sink identifiers are limited to 1000 characters
    ///  and can include only the following characters: `A-Z`, `a-z`,
    ///  `0-9`, and the special characters `_-.`.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destination" field.</summary>
    public const int DestinationFieldNumber = 3;
    private string destination_ = "";
    /// <summary>
    ///  The export destination. See
    ///  [Exporting Logs With Sinks](/logging/docs/api/tasks/exporting-logs).
    ///  Examples: `"storage.googleapis.com/a-bucket"`,
    ///  `"bigquery.googleapis.com/projects/a-project-id/datasets/a-dataset"`.
    /// </summary>
    public string Destination {
      get { return destination_; }
      set {
        destination_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 5;
    private string filter_ = "";
    /// <summary>
    ///  An [advanced logs filter](/logging/docs/view/advanced_filters)
    ///  that defines the log entries to be exported.  The filter must be
    ///  consistent with the log entry format designed by the
    ///  `outputVersionFormat` parameter, regardless of the format of the
    ///  log entry that was originally written to Cloud Logging.
    ///  Example: `"logName:syslog AND severity>=ERROR"`.
    /// </summary>
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "output_version_format" field.</summary>
    public const int OutputVersionFormatFieldNumber = 6;
    private global::Google.Logging.V2.LogSink.Types.VersionFormat outputVersionFormat_ = 0;
    /// <summary>
    ///  The log entry version used when exporting log entries from this
    ///  sink.  This version does not have to correspond to the version of
    ///  the log entry when it was written to Cloud Logging.
    /// </summary>
    public global::Google.Logging.V2.LogSink.Types.VersionFormat OutputVersionFormat {
      get { return outputVersionFormat_; }
      set {
        outputVersionFormat_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as LogSink);
    }

    public bool Equals(LogSink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Destination != other.Destination) return false;
      if (Filter != other.Filter) return false;
      if (OutputVersionFormat != other.OutputVersionFormat) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Destination.Length != 0) hash ^= Destination.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (OutputVersionFormat != 0) hash ^= OutputVersionFormat.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Destination.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Destination);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Filter);
      }
      if (OutputVersionFormat != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) OutputVersionFormat);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Destination.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Destination);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (OutputVersionFormat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OutputVersionFormat);
      }
      return size;
    }

    public void MergeFrom(LogSink other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Destination.Length != 0) {
        Destination = other.Destination;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.OutputVersionFormat != 0) {
        OutputVersionFormat = other.OutputVersionFormat;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Destination = input.ReadString();
            break;
          }
          case 42: {
            Filter = input.ReadString();
            break;
          }
          case 48: {
            outputVersionFormat_ = (global::Google.Logging.V2.LogSink.Types.VersionFormat) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LogSink message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      /// <summary>
      ///  Available log entry formats. Log entries can be written to Cloud
      ///  Logging in either format and can be exported in either format.
      ///  Version 2 is the preferred format.
      /// </summary>
      public enum VersionFormat {
        /// <summary>
        ///  An unspecified version format will default to V2.
        /// </summary>
        [pbr::OriginalName("VERSION_FORMAT_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        ///  `LogEntry` version 2 format.
        /// </summary>
        [pbr::OriginalName("V2")] V2 = 1,
        /// <summary>
        ///  `LogEntry` version 1 format.
        /// </summary>
        [pbr::OriginalName("V1")] V1 = 2,
      }

    }
    #endregion

  }

  /// <summary>
  ///  The parameters to `ListSinks`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListSinksRequest : pb::IMessage<ListSinksRequest> {
    private static readonly pb::MessageParser<ListSinksRequest> _parser = new pb::MessageParser<ListSinksRequest>(() => new ListSinksRequest());
    public static pb::MessageParser<ListSinksRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListSinksRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListSinksRequest(ListSinksRequest other) : this() {
      projectName_ = other.projectName_;
      pageToken_ = other.pageToken_;
      pageSize_ = other.pageSize_;
    }

    public ListSinksRequest Clone() {
      return new ListSinksRequest(this);
    }

    /// <summary>Field number for the "project_name" field.</summary>
    public const int ProjectNameFieldNumber = 1;
    private string projectName_ = "";
    /// <summary>
    ///  Required. The resource name of the project containing the sinks.
    ///  Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
    /// </summary>
    public string ProjectName {
      get { return projectName_; }
      set {
        projectName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 2;
    private string pageToken_ = "";
    /// <summary>
    ///  Optional. If the `pageToken` request parameter is supplied, then the next
    ///  page of results in the set are retrieved.  The `pageToken` parameter must
    ///  be set with the value of the `nextPageToken` result parameter from the
    ///  previous request. The value of `projectName` must be the same as in the
    ///  previous request.
    /// </summary>
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 3;
    private int pageSize_;
    /// <summary>
    ///  Optional. The maximum number of results to return from this request.  Fewer
    ///  results might be returned. You must check for the `nextPageToken` result to
    ///  determine if additional results are available, which you can retrieve by
    ///  passing the `nextPageToken` value in the `pageToken` parameter to the next
    ///  request.
    /// </summary>
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListSinksRequest);
    }

    public bool Equals(ListSinksRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProjectName != other.ProjectName) return false;
      if (PageToken != other.PageToken) return false;
      if (PageSize != other.PageSize) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ProjectName.Length != 0) hash ^= ProjectName.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ProjectName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectName);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (PageSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ProjectName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectName);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      return size;
    }

    public void MergeFrom(ListSinksRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProjectName.Length != 0) {
        ProjectName = other.ProjectName;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ProjectName = input.ReadString();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 24: {
            PageSize = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Result returned from `ListSinks`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListSinksResponse : pb::IMessage<ListSinksResponse> {
    private static readonly pb::MessageParser<ListSinksResponse> _parser = new pb::MessageParser<ListSinksResponse>(() => new ListSinksResponse());
    public static pb::MessageParser<ListSinksResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListSinksResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListSinksResponse(ListSinksResponse other) : this() {
      sinks_ = other.sinks_.Clone();
      nextPageToken_ = other.nextPageToken_;
    }

    public ListSinksResponse Clone() {
      return new ListSinksResponse(this);
    }

    /// <summary>Field number for the "sinks" field.</summary>
    public const int SinksFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Logging.V2.LogSink> _repeated_sinks_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Logging.V2.LogSink.Parser);
    private readonly pbc::RepeatedField<global::Google.Logging.V2.LogSink> sinks_ = new pbc::RepeatedField<global::Google.Logging.V2.LogSink>();
    /// <summary>
    ///  A list of sinks.
    /// </summary>
    public pbc::RepeatedField<global::Google.Logging.V2.LogSink> Sinks {
      get { return sinks_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    ///  If there are more results than were returned, then `nextPageToken` is
    ///  given a value in the response.  To get the next batch of results, call this
    ///  method again using the value of `nextPageToken` as `pageToken`.
    /// </summary>
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListSinksResponse);
    }

    public bool Equals(ListSinksResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sinks_.Equals(other.sinks_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= sinks_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      sinks_.WriteTo(output, _repeated_sinks_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += sinks_.CalculateSize(_repeated_sinks_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      return size;
    }

    public void MergeFrom(ListSinksResponse other) {
      if (other == null) {
        return;
      }
      sinks_.Add(other.sinks_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            sinks_.AddEntriesFrom(input, _repeated_sinks_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to `GetSink`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetSinkRequest : pb::IMessage<GetSinkRequest> {
    private static readonly pb::MessageParser<GetSinkRequest> _parser = new pb::MessageParser<GetSinkRequest>(() => new GetSinkRequest());
    public static pb::MessageParser<GetSinkRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetSinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetSinkRequest(GetSinkRequest other) : this() {
      sinkName_ = other.sinkName_;
    }

    public GetSinkRequest Clone() {
      return new GetSinkRequest(this);
    }

    /// <summary>Field number for the "sink_name" field.</summary>
    public const int SinkNameFieldNumber = 1;
    private string sinkName_ = "";
    /// <summary>
    ///  The resource name of the sink to return.
    ///  Example: `"projects/my-project-id/sinks/my-sink-id"`.
    /// </summary>
    public string SinkName {
      get { return sinkName_; }
      set {
        sinkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetSinkRequest);
    }

    public bool Equals(GetSinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SinkName != other.SinkName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SinkName.Length != 0) hash ^= SinkName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SinkName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SinkName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SinkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SinkName);
      }
      return size;
    }

    public void MergeFrom(GetSinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.SinkName.Length != 0) {
        SinkName = other.SinkName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SinkName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to `CreateSink`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CreateSinkRequest : pb::IMessage<CreateSinkRequest> {
    private static readonly pb::MessageParser<CreateSinkRequest> _parser = new pb::MessageParser<CreateSinkRequest>(() => new CreateSinkRequest());
    public static pb::MessageParser<CreateSinkRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CreateSinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CreateSinkRequest(CreateSinkRequest other) : this() {
      projectName_ = other.projectName_;
      Sink = other.sink_ != null ? other.Sink.Clone() : null;
    }

    public CreateSinkRequest Clone() {
      return new CreateSinkRequest(this);
    }

    /// <summary>Field number for the "project_name" field.</summary>
    public const int ProjectNameFieldNumber = 1;
    private string projectName_ = "";
    /// <summary>
    ///  The resource name of the project in which to create the sink.
    ///  Example: `"projects/my-project-id"`.
    ///
    ///  The new sink must be provided in the request.
    /// </summary>
    public string ProjectName {
      get { return projectName_; }
      set {
        projectName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sink" field.</summary>
    public const int SinkFieldNumber = 2;
    private global::Google.Logging.V2.LogSink sink_;
    /// <summary>
    ///  The new sink, which must not have an identifier that already
    ///  exists.
    /// </summary>
    public global::Google.Logging.V2.LogSink Sink {
      get { return sink_; }
      set {
        sink_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CreateSinkRequest);
    }

    public bool Equals(CreateSinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProjectName != other.ProjectName) return false;
      if (!object.Equals(Sink, other.Sink)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ProjectName.Length != 0) hash ^= ProjectName.GetHashCode();
      if (sink_ != null) hash ^= Sink.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ProjectName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectName);
      }
      if (sink_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Sink);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ProjectName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectName);
      }
      if (sink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sink);
      }
      return size;
    }

    public void MergeFrom(CreateSinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProjectName.Length != 0) {
        ProjectName = other.ProjectName;
      }
      if (other.sink_ != null) {
        if (sink_ == null) {
          sink_ = new global::Google.Logging.V2.LogSink();
        }
        Sink.MergeFrom(other.Sink);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ProjectName = input.ReadString();
            break;
          }
          case 18: {
            if (sink_ == null) {
              sink_ = new global::Google.Logging.V2.LogSink();
            }
            input.ReadMessage(sink_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to `UpdateSink`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UpdateSinkRequest : pb::IMessage<UpdateSinkRequest> {
    private static readonly pb::MessageParser<UpdateSinkRequest> _parser = new pb::MessageParser<UpdateSinkRequest>(() => new UpdateSinkRequest());
    public static pb::MessageParser<UpdateSinkRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UpdateSinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UpdateSinkRequest(UpdateSinkRequest other) : this() {
      sinkName_ = other.sinkName_;
      Sink = other.sink_ != null ? other.Sink.Clone() : null;
    }

    public UpdateSinkRequest Clone() {
      return new UpdateSinkRequest(this);
    }

    /// <summary>Field number for the "sink_name" field.</summary>
    public const int SinkNameFieldNumber = 1;
    private string sinkName_ = "";
    /// <summary>
    ///  The resource name of the sink to update.
    ///  Example: `"projects/my-project-id/sinks/my-sink-id"`.
    ///
    ///  The updated sink must be provided in the request and have the
    ///  same name that is specified in `sinkName`.  If the sink does not
    ///  exist, it is created.
    /// </summary>
    public string SinkName {
      get { return sinkName_; }
      set {
        sinkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sink" field.</summary>
    public const int SinkFieldNumber = 2;
    private global::Google.Logging.V2.LogSink sink_;
    /// <summary>
    ///  The updated sink, whose name must be the same as the sink
    ///  identifier in `sinkName`.  If `sinkName` does not exist, then
    ///  this method creates a new sink.
    /// </summary>
    public global::Google.Logging.V2.LogSink Sink {
      get { return sink_; }
      set {
        sink_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UpdateSinkRequest);
    }

    public bool Equals(UpdateSinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SinkName != other.SinkName) return false;
      if (!object.Equals(Sink, other.Sink)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SinkName.Length != 0) hash ^= SinkName.GetHashCode();
      if (sink_ != null) hash ^= Sink.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SinkName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SinkName);
      }
      if (sink_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Sink);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SinkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SinkName);
      }
      if (sink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sink);
      }
      return size;
    }

    public void MergeFrom(UpdateSinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.SinkName.Length != 0) {
        SinkName = other.SinkName;
      }
      if (other.sink_ != null) {
        if (sink_ == null) {
          sink_ = new global::Google.Logging.V2.LogSink();
        }
        Sink.MergeFrom(other.Sink);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SinkName = input.ReadString();
            break;
          }
          case 18: {
            if (sink_ == null) {
              sink_ = new global::Google.Logging.V2.LogSink();
            }
            input.ReadMessage(sink_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to `DeleteSink`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DeleteSinkRequest : pb::IMessage<DeleteSinkRequest> {
    private static readonly pb::MessageParser<DeleteSinkRequest> _parser = new pb::MessageParser<DeleteSinkRequest>(() => new DeleteSinkRequest());
    public static pb::MessageParser<DeleteSinkRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingConfigReflection.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DeleteSinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DeleteSinkRequest(DeleteSinkRequest other) : this() {
      sinkName_ = other.sinkName_;
    }

    public DeleteSinkRequest Clone() {
      return new DeleteSinkRequest(this);
    }

    /// <summary>Field number for the "sink_name" field.</summary>
    public const int SinkNameFieldNumber = 1;
    private string sinkName_ = "";
    /// <summary>
    ///  The resource name of the sink to delete.
    ///  Example: `"projects/my-project-id/sinks/my-sink-id"`.
    /// </summary>
    public string SinkName {
      get { return sinkName_; }
      set {
        sinkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DeleteSinkRequest);
    }

    public bool Equals(DeleteSinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SinkName != other.SinkName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SinkName.Length != 0) hash ^= SinkName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SinkName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SinkName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SinkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SinkName);
      }
      return size;
    }

    public void MergeFrom(DeleteSinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.SinkName.Length != 0) {
        SinkName = other.SinkName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SinkName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
