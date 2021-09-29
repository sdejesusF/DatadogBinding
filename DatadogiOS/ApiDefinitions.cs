using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Datadog
{
	// @interface DDAppContext : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc12DDAppContext")]
	interface DDAppContext
	{
		// -(instancetype _Nonnull)initWithMainBundle:(NSBundle * _Nonnull)mainBundle __attribute__((objc_designated_initializer));
		[Export("initWithMainBundle:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSBundle mainBundle);
	}

	// @interface DDConfiguration : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc15DDConfiguration")]
	[DisableDefaultCtor]
	interface DDConfiguration
	{
		// +(DDConfigurationBuilder * _Nonnull)builderWithClientToken:(NSString * _Nonnull)clientToken environment:(NSString * _Nonnull)environment __attribute__((warn_unused_result));
		[Static]
		[Export("builderWithClientToken:environment:")]
		DDConfigurationBuilder BuilderWithClientToken(string clientToken, string environment);

		// +(DDConfigurationBuilder * _Nonnull)builderWithRumApplicationID:(NSString * _Nonnull)rumApplicationID clientToken:(NSString * _Nonnull)clientToken environment:(NSString * _Nonnull)environment __attribute__((warn_unused_result));
		[Static]
		[Export("builderWithRumApplicationID:clientToken:environment:")]
		DDConfigurationBuilder BuilderWithRumApplicationID(string rumApplicationID, string clientToken, string environment);
	}

	// @interface DDConfigurationBuilder : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDConfigurationBuilder")]
	[DisableDefaultCtor]
	interface DDConfigurationBuilder
	{
		// -(void)enableLogging:(BOOL)enabled;
		[Export("enableLogging:")]
		void EnableLogging(bool enabled);

		// -(void)enableTracing:(BOOL)enabled;
		[Export("enableTracing:")]
		void EnableTracing(bool enabled);

		// -(void)enableRUM:(BOOL)enabled;
		[Export("enableRUM:")]
		void EnableRUM(bool enabled);

		// -(void)setWithEndpoint:(DDEndpoint * _Nonnull)endpoint;
		[Export("setWithEndpoint:")]
		void SetWithEndpoint(DDEndpoint endpoint);

		// -(void)setWithCustomLogsEndpoint:(NSURL * _Nonnull)customLogsEndpoint;
		[Export("setWithCustomLogsEndpoint:")]
		void SetWithCustomLogsEndpoint(NSUrl customLogsEndpoint);

		// -(void)setWithCustomTracesEndpoint:(NSURL * _Nonnull)customTracesEndpoint;
		[Export("setWithCustomTracesEndpoint:")]
		void SetWithCustomTracesEndpoint(NSUrl customTracesEndpoint);

		// -(void)setWithCustomRUMEndpoint:(NSURL * _Nonnull)customRUMEndpoint;
		[Export("setWithCustomRUMEndpoint:")]
		void SetWithCustomRUMEndpoint(NSUrl customRUMEndpoint);

		// -(void)setWithLogsEndpoint:(DDLogsEndpoint * _Nonnull)logsEndpoint __attribute__((deprecated("This option is replaced by `set(endpoint:)`. Refer to the new API comment for details.")));
		[Export("setWithLogsEndpoint:")]
		void SetWithLogsEndpoint(DDLogsEndpoint logsEndpoint);

		// -(void)setWithTracesEndpoint:(DDTracesEndpoint * _Nonnull)tracesEndpoint __attribute__((deprecated("This option is replaced by `set(endpoint:)`. Refer to the new API comment for details.")));
		[Export("setWithTracesEndpoint:")]
		void SetWithTracesEndpoint(DDTracesEndpoint tracesEndpoint);

		// -(void)setWithTracedHosts:(NSSet<NSString *> * _Nonnull)tracedHosts __attribute__((deprecated("This option is replaced by `trackURLSession(firstPartyHosts:)`. Refer to the new API comment for important details.")));
		[Export("setWithTracedHosts:")]
		void SetWithTracedHosts(NSSet<NSString> tracedHosts);

		// -(void)trackWithFirstPartyHosts:(NSSet<NSString *> * _Nonnull)firstPartyHosts __attribute__((deprecated("This option is replaced by `trackURLSession(firstPartyHosts:)`. Refer to the new API comment for important details.")));
		[Export("trackWithFirstPartyHosts:")]
		void TrackWithFirstPartyHosts(NSSet<NSString> firstPartyHosts);

		// -(void)trackURLSessionWithFirstPartyHosts:(NSSet<NSString *> * _Nonnull)firstPartyHosts;
		[Export("trackURLSessionWithFirstPartyHosts:")]
		void TrackURLSessionWithFirstPartyHosts(NSSet<NSString> firstPartyHosts);

		// -(void)setWithServiceName:(NSString * _Nonnull)serviceName;
		[Export("setWithServiceName:")]
		void SetWithServiceName(string serviceName);

		// -(void)setWithRumSessionsSamplingRate:(float)rumSessionsSamplingRate;
		[Export("setWithRumSessionsSamplingRate:")]
		void SetWithRumSessionsSamplingRate(float rumSessionsSamplingRate);

		// -(void)trackUIKitRUMViews;
		[Export("trackUIKitRUMViews")]
		void TrackUIKitRUMViews();

		// -(void)trackUIKitRUMViewsUsing:(id<DDUIKitRUMViewsPredicate> _Nonnull)predicate;
		[Export("trackUIKitRUMViewsUsing:")]
		void TrackUIKitRUMViewsUsing(DDUIKitRUMViewsPredicate predicate);

		// -(void)trackUIKitActions;
		[Export("trackUIKitActions")]
		void TrackUIKitActions();

		// -(void)setRUMViewEventMapper:(DDRUMViewEvent * _Nullable (^ _Nonnull)(DDRUMViewEvent * _Nonnull))mapper;
		[Export("setRUMViewEventMapper:")]
		void SetRUMViewEventMapper(Func<DDRUMViewEvent, DDRUMViewEvent> mapper);

		// -(void)setRUMResourceEventMapper:(DDRUMResourceEvent * _Nullable (^ _Nonnull)(DDRUMResourceEvent * _Nonnull))mapper;
		[Export("setRUMResourceEventMapper:")]
		void SetRUMResourceEventMapper(Func<DDRUMResourceEvent, DDRUMResourceEvent> mapper);

		// -(void)setRUMActionEventMapper:(DDRUMActionEvent * _Nullable (^ _Nonnull)(DDRUMActionEvent * _Nonnull))mapper;
		[Export("setRUMActionEventMapper:")]
		void SetRUMActionEventMapper(Func<DDRUMActionEvent, DDRUMActionEvent> mapper);

		// -(void)setRUMErrorEventMapper:(DDRUMErrorEvent * _Nullable (^ _Nonnull)(DDRUMErrorEvent * _Nonnull))mapper;
		[Export("setRUMErrorEventMapper:")]
		void SetRUMErrorEventMapper(Func<DDRUMErrorEvent, DDRUMErrorEvent> mapper);

		// -(void)setWithBatchSize:(enum DDBatchSize)batchSize;
		[Export("setWithBatchSize:")]
		void SetWithBatchSize(DDBatchSize batchSize);

		// -(void)setWithUploadFrequency:(enum DDUploadFrequency)uploadFrequency;
		[Export("setWithUploadFrequency:")]
		void SetWithUploadFrequency(DDUploadFrequency uploadFrequency);

		// -(DDConfiguration * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		DDConfiguration Build();
	}

	// @interface DDDatadog : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc9DDDatadog")]
	interface DDDatadog
	{
		// +(void)initializeWithAppContext:(DDAppContext * _Nonnull)appContext configuration:(DDConfiguration * _Nonnull)configuration __attribute__((deprecated("
		[Static]
		[Export("initializeWithAppContext:configuration:")]
		void InitializeWithAppContext(DDAppContext appContext, DDConfiguration configuration);

		// +(void)initializeWithAppContext:(DDAppContext * _Nonnull)appContext trackingConsent:(DDTrackingConsent * _Nonnull)trackingConsent configuration:(DDConfiguration * _Nonnull)configuration;
		[Static]
		[Export("initializeWithAppContext:trackingConsent:configuration:")]
		void InitializeWithAppContext(DDAppContext appContext, DDTrackingConsent trackingConsent, DDConfiguration configuration);

		// +(enum DDSDKVerbosityLevel)verbosityLevel __attribute__((warn_unused_result));
		// +(void)setVerbosityLevel:(enum DDSDKVerbosityLevel)verbosityLevel;
		[Static]
		[Export("verbosityLevel")]
		DDSDKVerbosityLevel VerbosityLevel { get; set; }

		// +(void)setUserInfoWithId:(NSString * _Nullable)id name:(NSString * _Nullable)name email:(NSString * _Nullable)email;
		[Static]
		[Export("setUserInfoWithId:name:email:")]
		void SetUserInfoWithId([NullAllowed] string id, [NullAllowed] string name, [NullAllowed] string email);

		// +(void)setTrackingConsentWithConsent:(DDTrackingConsent * _Nonnull)consent;
		[Static]
		[Export("setTrackingConsentWithConsent:")]
		void SetTrackingConsentWithConsent(DDTrackingConsent consent);
	}

	// @interface DDEndpoint : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc10DDEndpoint")]
	[DisableDefaultCtor]
	interface DDEndpoint
	{
		// +(DDEndpoint * _Nonnull)eu __attribute__((warn_unused_result));
		[Static]
		[Export("eu")]
		DDEndpoint Eu { get; }

		// +(DDEndpoint * _Nonnull)us __attribute__((warn_unused_result));
		[Static]
		[Export("us")]
		DDEndpoint Us { get; }

		// +(DDEndpoint * _Nonnull)gov __attribute__((warn_unused_result));
		[Static]
		[Export("gov")]
		DDEndpoint Gov { get; }
	}

	// @interface DDGlobal : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc8DDGlobal")]
	interface DDGlobal
	{
		// @property (nonatomic, strong, class) DDTracer * _Nonnull sharedTracer;
		[Static]
		[Export("sharedTracer", ArgumentSemantic.Strong)]
		DDTracer SharedTracer { get; set; }

		// @property (nonatomic, strong, class) DDRUMMonitor * _Nonnull rum;
		[Static]
		[Export("rum", ArgumentSemantic.Strong)]
		DDRUMMonitor Rum { get; set; }
	}

	// @interface DDHTTPHeadersWriter : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc19DDHTTPHeadersWriter")]
	interface DDHTTPHeadersWriter
	{
	}

	// @interface DDLogger : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc8DDLogger")]
	[DisableDefaultCtor]
	interface DDLogger
	{
		// -(void)debug:(NSString * _Nonnull)message;
		[Export("debug:")]
		void Debug(string message);

		// -(void)debug:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("debug:attributes:")]
		void Debug(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)debug:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("debug:error:attributes:")]
		void Debug(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)info:(NSString * _Nonnull)message;
		[Export("info:")]
		void Info(string message);

		// -(void)info:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("info:attributes:")]
		void Info(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)info:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("info:error:attributes:")]
		void Info(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)notice:(NSString * _Nonnull)message;
		[Export("notice:")]
		void Notice(string message);

		// -(void)notice:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("notice:attributes:")]
		void Notice(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)notice:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("notice:error:attributes:")]
		void Notice(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)warn:(NSString * _Nonnull)message;
		[Export("warn:")]
		void Warn(string message);

		// -(void)warn:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("warn:attributes:")]
		void Warn(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)warn:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("warn:error:attributes:")]
		void Warn(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)error:(NSString * _Nonnull)message;
		[Export("error:")]
		void Error(string message);

		// -(void)error:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("error:attributes:")]
		void Error(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)error:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("error:error:attributes:")]
		void Error(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)critical:(NSString * _Nonnull)message;
		[Export("critical:")]
		void Critical(string message);

		// -(void)critical:(NSString * _Nonnull)message attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("critical:attributes:")]
		void Critical(string message, NSDictionary<NSString, NSObject> attributes);

		// -(void)critical:(NSString * _Nonnull)message error:(NSError * _Nonnull)error attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("critical:error:attributes:")]
		void Critical(string message, NSError error, NSDictionary<NSString, NSObject> attributes);

		// -(void)addAttributeForKey:(NSString * _Nonnull)key value:(id _Nonnull)value;
		[Export("addAttributeForKey:value:")]
		void AddAttributeForKey(string key, NSObject value);

		// -(void)removeAttributeForKey:(NSString * _Nonnull)key;
		[Export("removeAttributeForKey:")]
		void RemoveAttributeForKey(string key);

		// -(void)addTagWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export("addTagWithKey:value:")]
		void AddTagWithKey(string key, string value);

		// -(void)removeTagWithKey:(NSString * _Nonnull)key;
		[Export("removeTagWithKey:")]
		void RemoveTagWithKey(string key);

		// -(void)addWithTag:(NSString * _Nonnull)tag;
		[Export("addWithTag:")]
		void AddWithTag(string tag);

		// -(void)removeWithTag:(NSString * _Nonnull)tag;
		[Export("removeWithTag:")]
		void RemoveWithTag(string tag);

		// +(DDLoggerBuilder * _Nonnull)builder __attribute__((warn_unused_result));
		[Static]
		[Export("builder")]
		DDLoggerBuilder Builder();
	}

	// @interface DDLoggerBuilder : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc15DDLoggerBuilder")]
	[DisableDefaultCtor]
	interface DDLoggerBuilder
	{
		// -(void)setWithServiceName:(NSString * _Nonnull)serviceName;
		[Export("setWithServiceName:")]
		void SetWithServiceName(string serviceName);

		// -(void)setWithLoggerName:(NSString * _Nonnull)loggerName;
		[Export("setWithLoggerName:")]
		void SetWithLoggerName(string loggerName);

		// -(void)sendNetworkInfo:(BOOL)enabled;
		[Export("sendNetworkInfo:")]
		void SendNetworkInfo(bool enabled);

		// -(void)sendLogsToDatadog:(BOOL)enabled;
		[Export("sendLogsToDatadog:")]
		void SendLogsToDatadog(bool enabled);

		// -(void)printLogsToConsole:(BOOL)enabled;
		[Export("printLogsToConsole:")]
		void PrintLogsToConsole(bool enabled);

		// -(DDLogger * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		DDLogger Build();
	}

	// @interface DDLogsEndpoint : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc14DDLogsEndpoint")]
	[DisableDefaultCtor]
	interface DDLogsEndpoint
	{
		// +(DDLogsEndpoint * _Nonnull)eu __attribute__((warn_unused_result));
		[Static]
		[Export("eu")]
		DDLogsEndpoint Eu { get; }

		// +(DDLogsEndpoint * _Nonnull)us __attribute__((warn_unused_result));
		[Static]
		[Export("us")]
		DDLogsEndpoint Us { get; }

		// +(DDLogsEndpoint * _Nonnull)gov __attribute__((warn_unused_result));
		[Static]
		[Export("gov")]
		DDLogsEndpoint Gov { get; }

		// +(DDLogsEndpoint * _Nonnull)customWithUrl:(NSString * _Nonnull)url __attribute__((warn_unused_result));
		[Static]
		[Export("customWithUrl:")]
		DDLogsEndpoint CustomWithUrl(string url);
	}

	// @interface DDNSURLSessionDelegate
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDNSURLSessionDelegate")]
	interface DDNSURLSessionDelegate
	{
		// -(instancetype _Nonnull)initWithAdditionalFirstPartyHosts:(NSSet<NSString *> * _Nonnull)additionalFirstPartyHosts __attribute__((objc_designated_initializer));
		[Export("initWithAdditionalFirstPartyHosts:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSSet<NSString> additionalFirstPartyHosts);
	}

	// @interface DDRUMActionEvent : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc16DDRUMActionEvent")]
	[DisableDefaultCtor]
	interface DDRUMActionEvent
	{
		// @property (readonly, nonatomic, strong) DDRUMActionEventDD * _Nonnull dd;
		[Export("dd", ArgumentSemantic.Strong)]
		DDRUMActionEventDD Dd { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventAction * _Nonnull action;
		[Export("action", ArgumentSemantic.Strong)]
		DDRUMActionEventAction Action { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventApplication * _Nonnull application;
		[Export("application", ArgumentSemantic.Strong)]
		DDRUMActionEventApplication Application { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventRUMConnectivity * _Nullable connectivity;
		[NullAllowed, Export("connectivity", ArgumentSemantic.Strong)]
		DDRUMActionEventRUMConnectivity Connectivity { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		NSNumber Date { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable service;
		[NullAllowed, Export("service")]
		string Service { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventSession * _Nonnull session;
		[Export("session", ArgumentSemantic.Strong)]
		DDRUMActionEventSession Session { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventRUMUser * _Nullable usr;
		[NullAllowed, Export("usr", ArgumentSemantic.Strong)]
		DDRUMActionEventRUMUser Usr { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventView * _Nonnull view;
		[Export("view", ArgumentSemantic.Strong)]
		DDRUMActionEventView View { get; }
	}

	// @interface DDRUMActionEventAction : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDRUMActionEventAction")]
	[DisableDefaultCtor]
	interface DDRUMActionEventAction
	{
		// @property (readonly, nonatomic, strong) DDRUMActionEventActionCrash * _Nullable crash;
		[NullAllowed, Export("crash", ArgumentSemantic.Strong)]
		DDRUMActionEventActionCrash Crash { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventActionError * _Nullable error;
		[NullAllowed, Export("error", ArgumentSemantic.Strong)]
		DDRUMActionEventActionError Error { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable loadingTime;
		[NullAllowed, Export("loadingTime", ArgumentSemantic.Strong)]
		NSNumber LoadingTime { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventActionLongTask * _Nullable longTask;
		[NullAllowed, Export("longTask", ArgumentSemantic.Strong)]
		DDRUMActionEventActionLongTask LongTask { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventActionResource * _Nullable resource;
		[NullAllowed, Export("resource", ArgumentSemantic.Strong)]
		DDRUMActionEventActionResource Resource { get; }

		// @property (readonly, nonatomic, strong) DDRUMActionEventActionTarget * _Nullable target;
		[NullAllowed, Export("target", ArgumentSemantic.Strong)]
		DDRUMActionEventActionTarget Target { get; }

		// @property (readonly, nonatomic) enum DDRUMActionEventActionActionType type;
		[Export("type")]
		DDRUMActionEventActionActionType Type { get; }
	}

	// @interface DDRUMActionEventActionCrash : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc27DDRUMActionEventActionCrash")]
	[DisableDefaultCtor]
	interface DDRUMActionEventActionCrash
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMActionEventActionError : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc27DDRUMActionEventActionError")]
	[DisableDefaultCtor]
	interface DDRUMActionEventActionError
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMActionEventActionLongTask : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc30DDRUMActionEventActionLongTask")]
	[DisableDefaultCtor]
	interface DDRUMActionEventActionLongTask
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMActionEventActionResource : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc30DDRUMActionEventActionResource")]
	[DisableDefaultCtor]
	interface DDRUMActionEventActionResource
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMActionEventActionTarget : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc28DDRUMActionEventActionTarget")]
	[DisableDefaultCtor]
	interface DDRUMActionEventActionTarget
	{
		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }
	}

	// @interface DDRUMActionEventApplication : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc27DDRUMActionEventApplication")]
	[DisableDefaultCtor]
	interface DDRUMActionEventApplication
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMActionEventDD : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc18DDRUMActionEventDD")]
	[DisableDefaultCtor]
	interface DDRUMActionEventDD
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull formatVersion;
		[Export("formatVersion", ArgumentSemantic.Strong)]
		NSNumber FormatVersion { get; }
	}

	// @interface DDRUMActionEventRUMConnectivity : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc31DDRUMActionEventRUMConnectivity")]
	[DisableDefaultCtor]
	interface DDRUMActionEventRUMConnectivity
	{
		// @property (readonly, nonatomic, strong) DDRUMActionEventRUMConnectivityCellular * _Nullable cellular;
		[NullAllowed, Export("cellular", ArgumentSemantic.Strong)]
		DDRUMActionEventRUMConnectivityCellular Cellular { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull interfaces;
		[Export("interfaces", ArgumentSemantic.Copy)]
		NSNumber[] Interfaces { get; }

		// @property (readonly, nonatomic) enum DDRUMActionEventRUMConnectivityStatus status;
		[Export("status")]
		DDRUMActionEventRUMConnectivityStatus Status { get; }
	}

	// @interface DDRUMActionEventRUMConnectivityCellular : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc39DDRUMActionEventRUMConnectivityCellular")]
	[DisableDefaultCtor]
	interface DDRUMActionEventRUMConnectivityCellular
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable carrierName;
		[NullAllowed, Export("carrierName")]
		string CarrierName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable technology;
		[NullAllowed, Export("technology")]
		string Technology { get; }
	}

	// @interface DDRUMActionEventRUMUser : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc23DDRUMActionEventRUMUser")]
	[DisableDefaultCtor]
	interface DDRUMActionEventRUMUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }
	}

	// @interface DDRUMActionEventSession : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc23DDRUMActionEventSession")]
	[DisableDefaultCtor]
	interface DDRUMActionEventSession
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable hasReplay;
		[NullAllowed, Export("hasReplay", ArgumentSemantic.Strong)]
		NSNumber HasReplay { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic) enum DDRUMActionEventSessionSessionType type;
		[Export("type")]
		DDRUMActionEventSessionSessionType Type { get; }
	}

	// @interface DDRUMActionEventView : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc20DDRUMActionEventView")]
	[DisableDefaultCtor]
	interface DDRUMActionEventView
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (copy, nonatomic) NSString * _Nullable referrer;
		[NullAllowed, Export("referrer")]
		string Referrer { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMErrorEvent : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc15DDRUMErrorEvent")]
	[DisableDefaultCtor]
	interface DDRUMErrorEvent
	{
		// @property (readonly, nonatomic, strong) DDRUMErrorEventDD * _Nonnull dd;
		[Export("dd", ArgumentSemantic.Strong)]
		DDRUMErrorEventDD Dd { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventAction * _Nullable action;
		[NullAllowed, Export("action", ArgumentSemantic.Strong)]
		DDRUMErrorEventAction Action { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventApplication * _Nonnull application;
		[Export("application", ArgumentSemantic.Strong)]
		DDRUMErrorEventApplication Application { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventRUMConnectivity * _Nullable connectivity;
		[NullAllowed, Export("connectivity", ArgumentSemantic.Strong)]
		DDRUMErrorEventRUMConnectivity Connectivity { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		NSNumber Date { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventError * _Nonnull error;
		[Export("error", ArgumentSemantic.Strong)]
		DDRUMErrorEventError Error { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable service;
		[NullAllowed, Export("service")]
		string Service { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventSession * _Nonnull session;
		[Export("session", ArgumentSemantic.Strong)]
		DDRUMErrorEventSession Session { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventRUMUser * _Nullable usr;
		[NullAllowed, Export("usr", ArgumentSemantic.Strong)]
		DDRUMErrorEventRUMUser Usr { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventView * _Nonnull view;
		[Export("view", ArgumentSemantic.Strong)]
		DDRUMErrorEventView View { get; }
	}

	// @interface DDRUMErrorEventAction : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc21DDRUMErrorEventAction")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventAction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMErrorEventApplication : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc26DDRUMErrorEventApplication")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventApplication
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMErrorEventDD : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc17DDRUMErrorEventDD")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventDD
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull formatVersion;
		[Export("formatVersion", ArgumentSemantic.Strong)]
		NSNumber FormatVersion { get; }
	}

	// @interface DDRUMErrorEventError : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc20DDRUMErrorEventError")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventError
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable isCrash;
		[NullAllowed, Export("isCrash", ArgumentSemantic.Strong)]
		NSNumber IsCrash { get; }

		// @property (copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; set; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventErrorResource * _Nullable resource;
		[NullAllowed, Export("resource", ArgumentSemantic.Strong)]
		DDRUMErrorEventErrorResource Resource { get; }

		// @property (readonly, nonatomic) enum DDRUMErrorEventErrorSource source;
		[Export("source")]
		DDRUMErrorEventErrorSource Source { get; }

		// @property (copy, nonatomic) NSString * _Nullable stack;
		[NullAllowed, Export("stack")]
		string Stack { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; }
	}

	// @interface DDRUMErrorEventErrorResource : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc28DDRUMErrorEventErrorResource")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventErrorResource
	{
		// @property (readonly, nonatomic) enum DDRUMErrorEventErrorResourceRUMMethod method;
		[Export("method")]
		DDRUMErrorEventErrorResourceRUMMethod Method { get; }

		// @property (readonly, nonatomic, strong) DDRUMErrorEventErrorResourceProvider * _Nullable provider;
		[NullAllowed, Export("provider", ArgumentSemantic.Strong)]
		DDRUMErrorEventErrorResourceProvider Provider { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull statusCode;
		[Export("statusCode", ArgumentSemantic.Strong)]
		NSNumber StatusCode { get; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMErrorEventErrorResourceProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc36DDRUMErrorEventErrorResourceProvider")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventErrorResourceProvider
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export("domain")]
		string Domain { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly, nonatomic) enum DDRUMErrorEventErrorResourceProviderProviderType type;
		[Export("type")]
		DDRUMErrorEventErrorResourceProviderProviderType Type { get; }
	}

	// @interface DDRUMErrorEventRUMConnectivity : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc30DDRUMErrorEventRUMConnectivity")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventRUMConnectivity
	{
		// @property (readonly, nonatomic, strong) DDRUMErrorEventRUMConnectivityCellular * _Nullable cellular;
		[NullAllowed, Export("cellular", ArgumentSemantic.Strong)]
		DDRUMErrorEventRUMConnectivityCellular Cellular { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull interfaces;
		[Export("interfaces", ArgumentSemantic.Copy)]
		NSNumber[] Interfaces { get; }

		// @property (readonly, nonatomic) enum DDRUMErrorEventRUMConnectivityStatus status;
		[Export("status")]
		DDRUMErrorEventRUMConnectivityStatus Status { get; }
	}

	// @interface DDRUMErrorEventRUMConnectivityCellular : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc38DDRUMErrorEventRUMConnectivityCellular")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventRUMConnectivityCellular
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable carrierName;
		[NullAllowed, Export("carrierName")]
		string CarrierName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable technology;
		[NullAllowed, Export("technology")]
		string Technology { get; }
	}

	// @interface DDRUMErrorEventRUMUser : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDRUMErrorEventRUMUser")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventRUMUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }
	}

	// @interface DDRUMErrorEventSession : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDRUMErrorEventSession")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventSession
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable hasReplay;
		[NullAllowed, Export("hasReplay", ArgumentSemantic.Strong)]
		NSNumber HasReplay { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic) enum DDRUMErrorEventSessionSessionType type;
		[Export("type")]
		DDRUMErrorEventSessionSessionType Type { get; }
	}

	// @interface DDRUMErrorEventView : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc19DDRUMErrorEventView")]
	[DisableDefaultCtor]
	interface DDRUMErrorEventView
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (copy, nonatomic) NSString * _Nullable referrer;
		[NullAllowed, Export("referrer")]
		string Referrer { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMMonitor : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc12DDRUMMonitor")]
	interface DDRUMMonitor
	{
		// -(void)startViewWithViewController:(UIViewController * _Nonnull)viewController path:(NSString * _Nullable)path attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startViewWithViewController:path:attributes:")]
		void StartViewWithViewController(UIViewController viewController, [NullAllowed] string path, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopViewWithViewController:(UIViewController * _Nonnull)viewController attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopViewWithViewController:attributes:")]
		void StopViewWithViewController(UIViewController viewController, NSDictionary<NSString, NSObject> attributes);

		// -(void)startViewWithKey:(NSString * _Nonnull)key path:(NSString * _Nullable)path attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startViewWithKey:path:attributes:")]
		void StartViewWithKey(string key, [NullAllowed] string path, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopViewWithKey:(NSString * _Nonnull)key attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopViewWithKey:attributes:")]
		void StopViewWithKey(string key, NSDictionary<NSString, NSObject> attributes);

		// -(void)addTimingWithName:(NSString * _Nonnull)name;
		[Export("addTimingWithName:")]
		void AddTimingWithName(string name);

		// -(void)addErrorWithMessage:(NSString * _Nonnull)message source:(enum DDRUMErrorSource)source stack:(NSString * _Nullable)stack attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("addErrorWithMessage:source:stack:attributes:")]
		void AddErrorWithMessage(string message, DDRUMErrorSource source, [NullAllowed] string stack, NSDictionary<NSString, NSObject> attributes);

		// -(void)addErrorWithError:(NSError * _Nonnull)error source:(enum DDRUMErrorSource)source attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("addErrorWithError:source:attributes:")]
		void AddErrorWithError(NSError error, DDRUMErrorSource source, NSDictionary<NSString, NSObject> attributes);

		// -(void)startResourceLoadingWithResourceKey:(NSString * _Nonnull)resourceKey request:(NSURLRequest * _Nonnull)request attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startResourceLoadingWithResourceKey:request:attributes:")]
		void StartResourceLoadingWithResourceKey(string resourceKey, NSUrlRequest request, NSDictionary<NSString, NSObject> attributes);

		// -(void)startResourceLoadingWithResourceKey:(NSString * _Nonnull)resourceKey url:(NSURL * _Nonnull)url attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startResourceLoadingWithResourceKey:url:attributes:")]
		void StartResourceLoadingWithResourceKey(string resourceKey, NSUrl url, NSDictionary<NSString, NSObject> attributes);

		// -(void)startResourceLoadingWithResourceKey:(NSString * _Nonnull)resourceKey httpMethod:(enum DDRUMMethod)httpMethod urlString:(NSString * _Nonnull)urlString attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startResourceLoadingWithResourceKey:httpMethod:urlString:attributes:")]
		void StartResourceLoadingWithResourceKey(string resourceKey, DDRUMMethod httpMethod, string urlString, NSDictionary<NSString, NSObject> attributes);

		// -(void)addResourceMetricsWithResourceKey:(NSString * _Nonnull)resourceKey metrics:(NSURLSessionTaskMetrics * _Nonnull)metrics attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("addResourceMetricsWithResourceKey:metrics:attributes:")]
		void AddResourceMetricsWithResourceKey(string resourceKey, NSUrlSessionTaskMetrics metrics, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopResourceLoadingWithResourceKey:(NSString * _Nonnull)resourceKey response:(NSURLResponse * _Nonnull)response size:(NSNumber * _Nullable)size attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopResourceLoadingWithResourceKey:response:size:attributes:")]
		void StopResourceLoadingWithResourceKey(string resourceKey, NSUrlResponse response, [NullAllowed] NSNumber size, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopResourceLoadingWithResourceKey:(NSString * _Nonnull)resourceKey statusCode:(NSNumber * _Nullable)statusCode kind:(enum DDRUMResourceType)kind size:(NSNumber * _Nullable)size attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopResourceLoadingWithResourceKey:statusCode:kind:size:attributes:")]
		void StopResourceLoadingWithResourceKey(string resourceKey, [NullAllowed] NSNumber statusCode, DDRUMResourceType kind, [NullAllowed] NSNumber size, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopResourceLoadingWithErrorWithResourceKey:(NSString * _Nonnull)resourceKey error:(NSError * _Nonnull)error response:(NSURLResponse * _Nullable)response attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopResourceLoadingWithErrorWithResourceKey:error:response:attributes:")]
		void StopResourceLoadingWithErrorWithResourceKey(string resourceKey, NSError error, [NullAllowed] NSUrlResponse response, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopResourceLoadingWithErrorWithResourceKey:(NSString * _Nonnull)resourceKey errorMessage:(NSString * _Nonnull)errorMessage response:(NSURLResponse * _Nullable)response attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopResourceLoadingWithErrorWithResourceKey:errorMessage:response:attributes:")]
		void StopResourceLoadingWithErrorWithResourceKey(string resourceKey, string errorMessage, [NullAllowed] NSUrlResponse response, NSDictionary<NSString, NSObject> attributes);

		// -(void)startUserActionWithType:(enum DDRUMUserActionType)type name:(NSString * _Nonnull)name attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("startUserActionWithType:name:attributes:")]
		void StartUserActionWithType(DDRUMUserActionType type, string name, NSDictionary<NSString, NSObject> attributes);

		// -(void)stopUserActionWithType:(enum DDRUMUserActionType)type name:(NSString * _Nullable)name attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("stopUserActionWithType:name:attributes:")]
		void StopUserActionWithType(DDRUMUserActionType type, [NullAllowed] string name, NSDictionary<NSString, NSObject> attributes);

		// -(void)addUserActionWithType:(enum DDRUMUserActionType)type name:(NSString * _Nonnull)name attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("addUserActionWithType:name:attributes:")]
		void AddUserActionWithType(DDRUMUserActionType type, string name, NSDictionary<NSString, NSObject> attributes);

		// -(void)addAttributeForKey:(NSString * _Nonnull)key value:(id _Nonnull)value;
		[Export("addAttributeForKey:value:")]
		void AddAttributeForKey(string key, NSObject value);

		// -(void)removeAttributeForKey:(NSString * _Nonnull)key;
		[Export("removeAttributeForKey:")]
		void RemoveAttributeForKey(string key);
	}

	// @interface DDRUMResourceEvent : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc18DDRUMResourceEvent")]
	[DisableDefaultCtor]
	interface DDRUMResourceEvent
	{
		// @property (readonly, nonatomic, strong) DDRUMResourceEventDD * _Nonnull dd;
		[Export("dd", ArgumentSemantic.Strong)]
		DDRUMResourceEventDD Dd { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventAction * _Nullable action;
		[NullAllowed, Export("action", ArgumentSemantic.Strong)]
		DDRUMResourceEventAction Action { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventApplication * _Nonnull application;
		[Export("application", ArgumentSemantic.Strong)]
		DDRUMResourceEventApplication Application { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventRUMConnectivity * _Nullable connectivity;
		[NullAllowed, Export("connectivity", ArgumentSemantic.Strong)]
		DDRUMResourceEventRUMConnectivity Connectivity { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		NSNumber Date { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResource * _Nonnull resource;
		[Export("resource", ArgumentSemantic.Strong)]
		DDRUMResourceEventResource Resource { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable service;
		[NullAllowed, Export("service")]
		string Service { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventSession * _Nonnull session;
		[Export("session", ArgumentSemantic.Strong)]
		DDRUMResourceEventSession Session { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventRUMUser * _Nullable usr;
		[NullAllowed, Export("usr", ArgumentSemantic.Strong)]
		DDRUMResourceEventRUMUser Usr { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventView * _Nonnull view;
		[Export("view", ArgumentSemantic.Strong)]
		DDRUMResourceEventView View { get; }
	}

	// @interface DDRUMResourceEventAction : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc24DDRUMResourceEventAction")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventAction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMResourceEventApplication : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc29DDRUMResourceEventApplication")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventApplication
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMResourceEventDD : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc20DDRUMResourceEventDD")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventDD
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull formatVersion;
		[Export("formatVersion", ArgumentSemantic.Strong)]
		NSNumber FormatVersion { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable spanId;
		[NullAllowed, Export("spanId")]
		string SpanId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable traceId;
		[NullAllowed, Export("traceId")]
		string TraceId { get; }
	}

	// @interface DDRUMResourceEventRUMConnectivity : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc33DDRUMResourceEventRUMConnectivity")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventRUMConnectivity
	{
		// @property (readonly, nonatomic, strong) DDRUMResourceEventRUMConnectivityCellular * _Nullable cellular;
		[NullAllowed, Export("cellular", ArgumentSemantic.Strong)]
		DDRUMResourceEventRUMConnectivityCellular Cellular { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull interfaces;
		[Export("interfaces", ArgumentSemantic.Copy)]
		NSNumber[] Interfaces { get; }

		// @property (readonly, nonatomic) enum DDRUMResourceEventRUMConnectivityStatus status;
		[Export("status")]
		DDRUMResourceEventRUMConnectivityStatus Status { get; }
	}

	// @interface DDRUMResourceEventRUMConnectivityCellular : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc41DDRUMResourceEventRUMConnectivityCellular")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventRUMConnectivityCellular
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable carrierName;
		[NullAllowed, Export("carrierName")]
		string CarrierName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable technology;
		[NullAllowed, Export("technology")]
		string Technology { get; }
	}

	// @interface DDRUMResourceEventRUMUser : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc25DDRUMResourceEventRUMUser")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventRUMUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }
	}

	// @interface DDRUMResourceEventResource : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc26DDRUMResourceEventResource")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResource
	{
		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceConnect * _Nullable connect;
		[NullAllowed, Export("connect", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceConnect Connect { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceDNS * _Nullable dns;
		[NullAllowed, Export("dns", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceDNS Dns { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceDownload * _Nullable download;
		[NullAllowed, Export("download", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceDownload Download { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceFirstByte * _Nullable firstByte;
		[NullAllowed, Export("firstByte", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceFirstByte FirstByte { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic) enum DDRUMResourceEventResourceRUMMethod method;
		[Export("method")]
		DDRUMResourceEventResourceRUMMethod Method { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceProvider * _Nullable provider;
		[NullAllowed, Export("provider", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceProvider Provider { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceRedirect * _Nullable redirect;
		[NullAllowed, Export("redirect", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceRedirect Redirect { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable size;
		[NullAllowed, Export("size", ArgumentSemantic.Strong)]
		NSNumber Size { get; }

		// @property (readonly, nonatomic, strong) DDRUMResourceEventResourceSSL * _Nullable ssl;
		[NullAllowed, Export("ssl", ArgumentSemantic.Strong)]
		DDRUMResourceEventResourceSSL Ssl { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable statusCode;
		[NullAllowed, Export("statusCode", ArgumentSemantic.Strong)]
		NSNumber StatusCode { get; }

		// @property (readonly, nonatomic) enum DDRUMResourceEventResourceResourceType type;
		[Export("type")]
		DDRUMResourceEventResourceResourceType Type { get; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMResourceEventResourceConnect : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc33DDRUMResourceEventResourceConnect")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceConnect
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventResourceDNS : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc29DDRUMResourceEventResourceDNS")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceDNS
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventResourceDownload : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc34DDRUMResourceEventResourceDownload")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceDownload
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventResourceFirstByte : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc35DDRUMResourceEventResourceFirstByte")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceFirstByte
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventResourceProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc34DDRUMResourceEventResourceProvider")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceProvider
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export("domain")]
		string Domain { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly, nonatomic) enum DDRUMResourceEventResourceProviderProviderType type;
		[Export("type")]
		DDRUMResourceEventResourceProviderProviderType Type { get; }
	}

	// @interface DDRUMResourceEventResourceRedirect : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc34DDRUMResourceEventResourceRedirect")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceRedirect
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventResourceSSL : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc29DDRUMResourceEventResourceSSL")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventResourceSSL
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull duration;
		[Export("duration", ArgumentSemantic.Strong)]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull start;
		[Export("start", ArgumentSemantic.Strong)]
		NSNumber Start { get; }
	}

	// @interface DDRUMResourceEventSession : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc25DDRUMResourceEventSession")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventSession
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable hasReplay;
		[NullAllowed, Export("hasReplay", ArgumentSemantic.Strong)]
		NSNumber HasReplay { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic) enum DDRUMResourceEventSessionSessionType type;
		[Export("type")]
		DDRUMResourceEventSessionSessionType Type { get; }
	}

	// @interface DDRUMResourceEventView : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc22DDRUMResourceEventView")]
	[DisableDefaultCtor]
	interface DDRUMResourceEventView
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (copy, nonatomic) NSString * _Nullable referrer;
		[NullAllowed, Export("referrer")]
		string Referrer { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMView : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc9DDRUMView")]
	[DisableDefaultCtor]
	interface DDRUMView
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull path;
		[Export("path")]
		string Path { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull attributes;
		[Export("attributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Attributes { get; }

		// -(instancetype _Nonnull)initWithPath:(NSString * _Nonnull)path attributes:(NSDictionary<NSString *,id> * _Nonnull)attributes __attribute__((objc_designated_initializer));
		[Export("initWithPath:attributes:")]
		[DesignatedInitializer]
		IntPtr Constructor(string path, NSDictionary<NSString, NSObject> attributes);
	}

	// @interface DDRUMViewEvent : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc14DDRUMViewEvent")]
	[DisableDefaultCtor]
	interface DDRUMViewEvent
	{
		// @property (readonly, nonatomic, strong) DDRUMViewEventDD * _Nonnull dd;
		[Export("dd", ArgumentSemantic.Strong)]
		DDRUMViewEventDD Dd { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventApplication * _Nonnull application;
		[Export("application", ArgumentSemantic.Strong)]
		DDRUMViewEventApplication Application { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventRUMConnectivity * _Nullable connectivity;
		[NullAllowed, Export("connectivity", ArgumentSemantic.Strong)]
		DDRUMViewEventRUMConnectivity Connectivity { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		NSNumber Date { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable service;
		[NullAllowed, Export("service")]
		string Service { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventSession * _Nonnull session;
		[Export("session", ArgumentSemantic.Strong)]
		DDRUMViewEventSession Session { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventRUMUser * _Nullable usr;
		[NullAllowed, Export("usr", ArgumentSemantic.Strong)]
		DDRUMViewEventRUMUser Usr { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventView * _Nonnull view;
		[Export("view", ArgumentSemantic.Strong)]
		DDRUMViewEventView View { get; }
	}

	// @interface DDRUMViewEventApplication : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc25DDRUMViewEventApplication")]
	[DisableDefaultCtor]
	interface DDRUMViewEventApplication
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }
	}

	// @interface DDRUMViewEventDD : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc16DDRUMViewEventDD")]
	[DisableDefaultCtor]
	interface DDRUMViewEventDD
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull documentVersion;
		[Export("documentVersion", ArgumentSemantic.Strong)]
		NSNumber DocumentVersion { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull formatVersion;
		[Export("formatVersion", ArgumentSemantic.Strong)]
		NSNumber FormatVersion { get; }
	}

	// @interface DDRUMViewEventRUMConnectivity : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc29DDRUMViewEventRUMConnectivity")]
	[DisableDefaultCtor]
	interface DDRUMViewEventRUMConnectivity
	{
		// @property (readonly, nonatomic, strong) DDRUMViewEventRUMConnectivityCellular * _Nullable cellular;
		[NullAllowed, Export("cellular", ArgumentSemantic.Strong)]
		DDRUMViewEventRUMConnectivityCellular Cellular { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull interfaces;
		[Export("interfaces", ArgumentSemantic.Copy)]
		NSNumber[] Interfaces { get; }

		// @property (readonly, nonatomic) enum DDRUMViewEventRUMConnectivityStatus status;
		[Export("status")]
		DDRUMViewEventRUMConnectivityStatus Status { get; }
	}

	// @interface DDRUMViewEventRUMConnectivityCellular : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc37DDRUMViewEventRUMConnectivityCellular")]
	[DisableDefaultCtor]
	interface DDRUMViewEventRUMConnectivityCellular
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable carrierName;
		[NullAllowed, Export("carrierName")]
		string CarrierName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable technology;
		[NullAllowed, Export("technology")]
		string Technology { get; }
	}

	// @interface DDRUMViewEventRUMUser : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc21DDRUMViewEventRUMUser")]
	[DisableDefaultCtor]
	interface DDRUMViewEventRUMUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }
	}

	// @interface DDRUMViewEventSession : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc21DDRUMViewEventSession")]
	[DisableDefaultCtor]
	interface DDRUMViewEventSession
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable hasReplay;
		[NullAllowed, Export("hasReplay", ArgumentSemantic.Strong)]
		NSNumber HasReplay { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic) enum DDRUMViewEventSessionSessionType type;
		[Export("type")]
		DDRUMViewEventSessionSessionType Type { get; }
	}

	// @interface DDRUMViewEventView : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc18DDRUMViewEventView")]
	[DisableDefaultCtor]
	interface DDRUMViewEventView
	{
		// @property (readonly, nonatomic, strong) DDRUMViewEventViewAction * _Nonnull action;
		[Export("action", ArgumentSemantic.Strong)]
		DDRUMViewEventViewAction Action { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventViewCrash * _Nullable crash;
		[NullAllowed, Export("crash", ArgumentSemantic.Strong)]
		DDRUMViewEventViewCrash Crash { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable cumulativeLayoutShift;
		[NullAllowed, Export("cumulativeLayoutShift", ArgumentSemantic.Strong)]
		NSNumber CumulativeLayoutShift { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable domComplete;
		[NullAllowed, Export("domComplete", ArgumentSemantic.Strong)]
		NSNumber DomComplete { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable domContentLoaded;
		[NullAllowed, Export("domContentLoaded", ArgumentSemantic.Strong)]
		NSNumber DomContentLoaded { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable domInteractive;
		[NullAllowed, Export("domInteractive", ArgumentSemantic.Strong)]
		NSNumber DomInteractive { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventViewError * _Nonnull error;
		[Export("error", ArgumentSemantic.Strong)]
		DDRUMViewEventViewError Error { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable firstContentfulPaint;
		[NullAllowed, Export("firstContentfulPaint", ArgumentSemantic.Strong)]
		NSNumber FirstContentfulPaint { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable firstInputDelay;
		[NullAllowed, Export("firstInputDelay", ArgumentSemantic.Strong)]
		NSNumber FirstInputDelay { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable firstInputTime;
		[NullAllowed, Export("firstInputTime", ArgumentSemantic.Strong)]
		NSNumber FirstInputTime { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable isActive;
		[NullAllowed, Export("isActive", ArgumentSemantic.Strong)]
		NSNumber IsActive { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable largestContentfulPaint;
		[NullAllowed, Export("largestContentfulPaint", ArgumentSemantic.Strong)]
		NSNumber LargestContentfulPaint { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable loadEvent;
		[NullAllowed, Export("loadEvent", ArgumentSemantic.Strong)]
		NSNumber LoadEvent { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable loadingTime;
		[NullAllowed, Export("loadingTime", ArgumentSemantic.Strong)]
		NSNumber LoadingTime { get; }

		// @property (readonly, nonatomic) enum DDRUMViewEventViewLoadingType loadingType;
		[Export("loadingType")]
		DDRUMViewEventViewLoadingType LoadingType { get; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventViewLongTask * _Nullable longTask;
		[NullAllowed, Export("longTask", ArgumentSemantic.Strong)]
		DDRUMViewEventViewLongTask LongTask { get; }

		// @property (copy, nonatomic) NSString * _Nullable referrer;
		[NullAllowed, Export("referrer")]
		string Referrer { get; set; }

		// @property (readonly, nonatomic, strong) DDRUMViewEventViewResource * _Nonnull resource;
		[Export("resource", ArgumentSemantic.Strong)]
		DDRUMViewEventViewResource Resource { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull timeSpent;
		[Export("timeSpent", ArgumentSemantic.Strong)]
		NSNumber TimeSpent { get; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; set; }
	}

	// @interface DDRUMViewEventViewAction : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc24DDRUMViewEventViewAction")]
	[DisableDefaultCtor]
	interface DDRUMViewEventViewAction
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMViewEventViewCrash : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc23DDRUMViewEventViewCrash")]
	[DisableDefaultCtor]
	interface DDRUMViewEventViewCrash
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMViewEventViewError : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc23DDRUMViewEventViewError")]
	[DisableDefaultCtor]
	interface DDRUMViewEventViewError
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMViewEventViewLongTask : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc26DDRUMViewEventViewLongTask")]
	[DisableDefaultCtor]
	interface DDRUMViewEventViewLongTask
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @interface DDRUMViewEventViewResource : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc26DDRUMViewEventViewResource")]
	[DisableDefaultCtor]
	interface DDRUMViewEventViewResource
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull count;
		[Export("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; }
	}

	// @protocol OTTracer
	[BaseType(typeof(NSObject), Name = "_TtP11DatadogObjc8OTTracer_")]
	[Protocol, Model]
	interface OTTracer
	{
		// @required -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName __attribute__((warn_unused_result));
		[Abstract]
		[Export("startSpan:")]
		OTSpan StartSpan(string operationName);

		// @required -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName tags:(NSDictionary * _Nullable)tags __attribute__((warn_unused_result));
		[Abstract]
		[Export("startSpan:tags:")]
		OTSpan StartSpan(string operationName, [NullAllowed] NSDictionary tags);

		// @required -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent __attribute__((warn_unused_result));
		[Abstract]
		[Export("startSpan:childOf:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent);

		// @required -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent tags:(NSDictionary * _Nullable)tags __attribute__((warn_unused_result));
		[Abstract]
		[Export("startSpan:childOf:tags:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent, [NullAllowed] NSDictionary tags);

		// @required -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent tags:(NSDictionary * _Nullable)tags startTime:(NSDate * _Nullable)startTime __attribute__((warn_unused_result));
		[Abstract]
		[Export("startSpan:childOf:tags:startTime:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent, [NullAllowed] NSDictionary tags, [NullAllowed] NSDate startTime);

		// @required -(BOOL)inject:(id<OTSpanContext> _Nonnull)spanContext format:(NSString * _Nonnull)format carrier:(id _Nonnull)carrier error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("inject:format:carrier:error:")]
		bool Inject(OTSpanContext spanContext, string format, NSObject carrier, [NullAllowed] out NSError error);

		// @required -(BOOL)extractWithFormat:(NSString * _Nonnull)format carrier:(id _Nonnull)carrier error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("extractWithFormat:carrier:error:")]
		bool ExtractWithFormat(string format, NSObject carrier, [NullAllowed] out NSError error);
	}

	interface IOTTracer
	{
	}

	// @interface DDTracer : NSObject <OTTracer>
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc8DDTracer")]
	[DisableDefaultCtor]
	interface DDTracer : IOTTracer
	{
		// +(id<OTTracer> _Nonnull)initializeWithConfiguration:(DDTracerConfiguration * _Nonnull)configuration __attribute__((deprecated("Use `DDTracer(configuration:)`."))) __attribute__((warn_unused_result));
		[Static]
		[Export("initializeWithConfiguration:")]
		OTTracer InitializeWithConfiguration(DDTracerConfiguration configuration);

		// -(instancetype _Nonnull)initWithConfiguration:(DDTracerConfiguration * _Nonnull)configuration;
		[Export("initWithConfiguration:")]
		IntPtr Constructor(DDTracerConfiguration configuration);

		// -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName __attribute__((warn_unused_result));
		[Export("startSpan:")]
		OTSpan StartSpan(string operationName);

		// -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName tags:(NSDictionary * _Nullable)tags __attribute__((warn_unused_result));
		[Export("startSpan:tags:")]
		OTSpan StartSpan(string operationName, [NullAllowed] NSDictionary tags);

		// -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent __attribute__((warn_unused_result));
		[Export("startSpan:childOf:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent);

		// -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent tags:(NSDictionary * _Nullable)tags __attribute__((warn_unused_result));
		[Export("startSpan:childOf:tags:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent, [NullAllowed] NSDictionary tags);

		// -(id<OTSpan> _Nonnull)startSpan:(NSString * _Nonnull)operationName childOf:(id<OTSpanContext> _Nullable)parent tags:(NSDictionary * _Nullable)tags startTime:(NSDate * _Nullable)startTime __attribute__((warn_unused_result));
		[Export("startSpan:childOf:tags:startTime:")]
		OTSpan StartSpan(string operationName, [NullAllowed] OTSpanContext parent, [NullAllowed] NSDictionary tags, [NullAllowed] NSDate startTime);

		// -(BOOL)inject:(id<OTSpanContext> _Nonnull)spanContext format:(NSString * _Nonnull)format carrier:(id _Nonnull)carrier error:(NSError * _Nullable * _Nullable)error;
		[Export("inject:format:carrier:error:")]
		bool Inject(OTSpanContext spanContext, string format, NSObject carrier, [NullAllowed] out NSError error);

		// -(BOOL)extractWithFormat:(NSString * _Nonnull)format carrier:(id _Nonnull)carrier error:(NSError * _Nullable * _Nullable)error;
		[Export("extractWithFormat:carrier:error:")]
		bool ExtractWithFormat(string format, NSObject carrier, [NullAllowed] out NSError error);
	}

	// @interface DDTracerConfiguration : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc21DDTracerConfiguration")]
	interface DDTracerConfiguration
	{
		// -(void)setWithServiceName:(NSString * _Nonnull)serviceName;
		[Export("setWithServiceName:")]
		void SetWithServiceName(string serviceName);

		// -(void)sendNetworkInfo:(BOOL)enabled;
		[Export("sendNetworkInfo:")]
		void SendNetworkInfo(bool enabled);
	}

	// @interface DDTracesEndpoint : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc16DDTracesEndpoint")]
	[DisableDefaultCtor]
	interface DDTracesEndpoint
	{
		// +(DDTracesEndpoint * _Nonnull)eu __attribute__((warn_unused_result));
		[Static]
		[Export("eu")]
		DDTracesEndpoint Eu { get; }

		// +(DDTracesEndpoint * _Nonnull)us __attribute__((warn_unused_result));
		[Static]
		[Export("us")]
		DDTracesEndpoint Us { get; }

		// +(DDTracesEndpoint * _Nonnull)gov __attribute__((warn_unused_result));
		[Static]
		[Export("gov")]
		DDTracesEndpoint Gov { get; }

		// +(DDTracesEndpoint * _Nonnull)customWithUrl:(NSString * _Nonnull)url __attribute__((warn_unused_result));
		[Static]
		[Export("customWithUrl:")]
		DDTracesEndpoint CustomWithUrl(string url);
	}

	// @interface DDTrackingConsent : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc17DDTrackingConsent")]
	[DisableDefaultCtor]
	interface DDTrackingConsent
	{
		// +(DDTrackingConsent * _Nonnull)granted __attribute__((warn_unused_result));
		[Static]
		[Export("granted")]
		DDTrackingConsent Granted { get; }

		// +(DDTrackingConsent * _Nonnull)notGranted __attribute__((warn_unused_result));
		[Static]
		[Export("notGranted")]
		DDTrackingConsent NotGranted { get; }

		// +(DDTrackingConsent * _Nonnull)pending __attribute__((warn_unused_result));
		[Static]
		[Export("pending")]
		DDTrackingConsent Pending { get; }
	}

	// @protocol DDUIKitRUMViewsPredicate
	[BaseType(typeof(NSObject), Name = "_TtP11DatadogObjc24DDUIKitRUMViewsPredicate_")]
	[Protocol, Model]
	interface DDUIKitRUMViewsPredicate
	{
		// @required -(DDRUMView * _Nullable)rumViewFor:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result));
		[Abstract]
		[Export("rumViewFor:")]
		[return: NullAllowed]
		DDRUMView RumViewFor(UIViewController viewController);
	}

	// @interface OT : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11DatadogObjc2OT")]
	interface OT
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull formatTextMap;
		[Static]
		[Export("formatTextMap")]
		string FormatTextMap { get; }
	}

	// @protocol OTSpan
	[BaseType(typeof(NSObject), Name = "_TtP11DatadogObjc6OTSpan_")]
	[Protocol, Model]
	interface OTSpan
	{
		// @required @property (readonly, nonatomic, strong) id<OTSpanContext> _Nonnull context;
		[Abstract]
		[Export("context", ArgumentSemantic.Strong)]
		OTSpanContext Context { get; }

		// @required @property (readonly, nonatomic, strong) id<OTTracer> _Nonnull tracer;
		[Abstract]
		[Export("tracer", ArgumentSemantic.Strong)]
		OTTracer Tracer { get; }

		// @required -(void)setOperationName:(NSString * _Nonnull)operationName;
		[Abstract]
		[Export("setOperationName:")]
		void SetOperationName(string operationName);

		// @required -(void)setTag:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Abstract]
		[Export("setTag:value:")]
		void SetTag(string key, string value);

		// @required -(void)setTag:(NSString * _Nonnull)key numberValue:(NSNumber * _Nonnull)numberValue;
		[Abstract]
		[Export("setTag:numberValue:")]
		void SetTag(string key, NSNumber numberValue);

		// @required -(void)setTag:(NSString * _Nonnull)key boolValue:(BOOL)boolValue;
		[Abstract]
		[Export("setTag:boolValue:")]
		void SetTag(string key, bool boolValue);

		// @required -(void)log:(NSDictionary<NSString *,NSObject *> * _Nonnull)fields;
		[Abstract]
		[Export("log:")]
		void Log(NSDictionary<NSString, NSObject> fields);

		// @required -(void)log:(NSDictionary<NSString *,NSObject *> * _Nonnull)fields timestamp:(NSDate * _Nullable)timestamp;
		[Abstract]
		[Export("log:timestamp:")]
		void Log(NSDictionary<NSString, NSObject> fields, [NullAllowed] NSDate timestamp);

		// @required -(id<OTSpan> _Nonnull)setBaggageItem:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((warn_unused_result));
		[Abstract]
		[Export("setBaggageItem:value:")]
		OTSpan SetBaggageItem(string key, string value);

		// @required -(NSString * _Nullable)getBaggageItem:(NSString * _Nonnull)key __attribute__((warn_unused_result));
		[Abstract]
		[Export("getBaggageItem:")]
		[return: NullAllowed]
		string GetBaggageItem(string key);

		// @required -(void)setError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("setError:")]
		void SetError(NSError error);

		// @required -(void)setErrorWithKind:(NSString * _Nonnull)kind message:(NSString * _Nonnull)message stack:(NSString * _Nullable)stack;
		[Abstract]
		[Export("setErrorWithKind:message:stack:")]
		void SetErrorWithKind(string kind, string message, [NullAllowed] string stack);

		// @required -(void)finish;
		[Abstract]
		[Export("finish")]
		void Finish();

		// @required -(void)finishWithTime:(NSDate * _Nullable)finishTime;
		[Abstract]
		[Export("finishWithTime:")]
		void FinishWithTime([NullAllowed] NSDate finishTime);

		// @required -(id<OTSpan> _Nonnull)setActive;
		[Abstract]
		[Export("setActive")]
		OTSpan SetActive { get; }
	}

	// @protocol OTSpanContext
	[BaseType(typeof(NSObject), Name = "_TtP11DatadogObjc13OTSpanContext_")]
	[Protocol, Model]
	interface OTSpanContext
	{
		// @required -(void)forEachBaggageItem:(BOOL (^ _Nonnull)(NSString * _Nonnull, NSString * _Nonnull))callback;
		[Abstract]
		[Export("forEachBaggageItem:")]
		void ForEachBaggageItem(Func<NSString, NSString, bool> callback);
	}
}