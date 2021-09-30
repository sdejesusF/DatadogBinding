using System;
using ObjCRuntime;

namespace Datadog
{
	[Native]
	public enum DDBatchSize : long
	{
		Small = 0,
		Medium = 1,
		Large = 2
	}

	[Native]
	public enum DDRUMActionEventActionActionType : long
	{
		Custom = 0,
		Click = 1,
		Tap = 2,
		Scroll = 3,
		Swipe = 4,
		ApplicationStart = 5,
		Back = 6
	}

	[Native]
	public enum DDRUMActionEventRUMConnectivityInterfaces : long
	{
		Bluetooth = 0,
		Cellular = 1,
		Ethernet = 2,
		Wifi = 3,
		Wimax = 4,
		Mixed = 5,
		Other = 6,
		Unknown = 7,
		None = 8
	}

	[Native]
	public enum DDRUMActionEventRUMConnectivityStatus : long
	{
		Connected = 0,
		NotConnected = 1,
		Maybe = 2
	}

	[Native]
	public enum DDRUMActionEventSessionSessionType : long
	{
		User = 0,
		Synthetics = 1
	}

	[Native]
	public enum DDRUMErrorEventErrorResourceProviderProviderType : long
	{
		None = 0,
		Ad = 1,
		Advertising = 2,
		Analytics = 3,
		Cdn = 4,
		Content = 5,
		CustomerSuccess = 6,
		FirstParty = 7,
		Hosting = 8,
		Marketing = 9,
		Other = 10,
		Social = 11,
		TagManager = 12,
		Utility = 13,
		Video = 14
	}

	[Native]
	public enum DDRUMErrorEventErrorResourceRUMMethod : long
	{
		Post = 0,
		Get = 1,
		Head = 2,
		Put = 3,
		Delete = 4,
		Patch = 5
	}

	[Native]
	public enum DDRUMErrorEventErrorSource : long
	{
		Network = 0,
		Source = 1,
		Console = 2,
		Logger = 3,
		Agent = 4,
		Webview = 5,
		Custom = 6
	}

	[Native]
	public enum DDRUMErrorEventRUMConnectivityInterfaces : long
	{
		Bluetooth = 0,
		Cellular = 1,
		Ethernet = 2,
		Wifi = 3,
		Wimax = 4,
		Mixed = 5,
		Other = 6,
		Unknown = 7,
		None = 8
	}

	[Native]
	public enum DDRUMErrorEventRUMConnectivityStatus : long
	{
		Connected = 0,
		NotConnected = 1,
		Maybe = 2
	}

	[Native]
	public enum DDRUMErrorEventSessionSessionType : long
	{
		User = 0,
		Synthetics = 1
	}

	[Native]
	public enum DDRUMErrorSource : long
	{
		Source = 0,
		Network = 1,
		Webview = 2,
		Console = 3,
		Custom = 4
	}

	[Native]
	public enum DDRUMMethod : long
	{
		Post = 0,
		Get = 1,
		Head = 2,
		Put = 3,
		Delete = 4,
		Patch = 5
	}

	[Native]
	public enum DDRUMResourceEventRUMConnectivityInterfaces : long
	{
		Bluetooth = 0,
		Cellular = 1,
		Ethernet = 2,
		Wifi = 3,
		Wimax = 4,
		Mixed = 5,
		Other = 6,
		Unknown = 7,
		None = 8
	}

	[Native]
	public enum DDRUMResourceEventRUMConnectivityStatus : long
	{
		Connected = 0,
		NotConnected = 1,
		Maybe = 2
	}

	[Native]
	public enum DDRUMResourceEventResourceProviderProviderType : long
	{
		None = 0,
		Ad = 1,
		Advertising = 2,
		Analytics = 3,
		Cdn = 4,
		Content = 5,
		CustomerSuccess = 6,
		FirstParty = 7,
		Hosting = 8,
		Marketing = 9,
		Other = 10,
		Social = 11,
		TagManager = 12,
		Utility = 13,
		Video = 14
	}

	[Native]
	public enum DDRUMResourceEventResourceRUMMethod : long
	{
		None = 0,
		Post = 1,
		Get = 2,
		Head = 3,
		Put = 4,
		Delete = 5,
		Patch = 6
	}

	[Native]
	public enum DDRUMResourceEventResourceResourceType : long
	{
		Document = 0,
		Xhr = 1,
		Beacon = 2,
		Fetch = 3,
		Css = 4,
		Js = 5,
		Image = 6,
		Font = 7,
		Media = 8,
		Other = 9
	}

	[Native]
	public enum DDRUMResourceEventSessionSessionType : long
	{
		User = 0,
		Synthetics = 1
	}

	[Native]
	public enum DDRUMResourceType : long
	{
		Image = 0,
		Xhr = 1,
		Beacon = 2,
		Css = 3,
		Document = 4,
		Fetch = 5,
		Font = 6,
		Js = 7,
		Media = 8,
		Other = 9
	}

	[Native]
	public enum DDRUMUserActionType : long
	{
		Tap = 0,
		Scroll = 1,
		Swipe = 2,
		Custom = 3
	}

	[Native]
	public enum DDRUMViewEventRUMConnectivityInterfaces : long
	{
		Bluetooth = 0,
		Cellular = 1,
		Ethernet = 2,
		Wifi = 3,
		Wimax = 4,
		Mixed = 5,
		Other = 6,
		Unknown = 7,
		None = 8
	}

	[Native]
	public enum DDRUMViewEventRUMConnectivityStatus : long
	{
		Connected = 0,
		NotConnected = 1,
		Maybe = 2
	}

	[Native]
	public enum DDRUMViewEventSessionSessionType : long
	{
		User = 0,
		Synthetics = 1
	}

	[Native]
	public enum DDRUMViewEventViewLoadingType : long
	{
		None = 0,
		InitialLoad = 1,
		RouteChange = 2,
		ActivityDisplay = 3,
		ActivityRedisplay = 4,
		FragmentDisplay = 5,
		FragmentRedisplay = 6,
		ViewControllerDisplay = 7,
		ViewControllerRedisplay = 8
	}

	[Native]
	public enum DDSDKVerbosityLevel : long
	{
		None = 0,
		Debug = 1,
		Info = 2,
		Notice = 3,
		Warn = 4,
		Error = 5,
		Critical = 6
	}

	[Native]
	public enum DDUploadFrequency : long
	{
		Frequent = 0,
		Average = 1,
		Rare = 2
	}
}