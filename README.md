# iNet.Stomp.Client

[![Build status](https://ci.appveyor.com/api/projects/status/166elreftg7pc62g?svg=true)](https://ci.appveyor.com/project/mrmohande3/inet-stomp-client)

nuget package for .net to connect stomp server 

### Usage
    Install-Package iNet.Stomp.Client
    
### 1.Add stomp url and connect
```C#
IStompClient client = new StompClient("ws://xxxxx.xx");
var headers = new Dictionary<string, string>();
headers.Add("X-Authorization", "Bearer xxx");
await client.ConnectAsync(headers);
```
here we create instance from StompClient and set stomp url and create Dictionary for headers like your JWT if you have no header set you dictionary empty , now your clint connected
### 2.Subscribing
```C#
await client.SubscribeAsync<object>("notic", new Dictionary<string, string>(), ((sender, dto) =>
{
}));
```
for subscribing use SubscribeAsync method . this method is generic and get subscribed url and header for this method and action for returned objects , returned objects 

### 3.Send
```C#
await client.SendAsync("boy", "notic", new Dictionary<string, string>());
```
for sending use SendAsync method , this method get body object and convert this to json for sending and url method in server and header dictionary 
