---
title: Objective-C
language: objective_c
menu_weight: 2
---

Clone this [Github project](https://github.com/Nexmo/ClientSDK-Get-Started-Voice-Objective-C).

Using the Github project you cloned, in the Start folder, open `GettingStarted.xcworkspace`. Then, within XCode:

1. Open `User.h` file and replace the user token:

 ```objective-c
#define kJaneUUID @"" //TODO: swap with a user uuid for Jane
```

2. From the `Receive-phone-call` group, open `ReceivePhoneCallViewController.m` file and make sure the following lines exist:

 * `#import <NexmoClient/NexmoClient.h>` - imports the sdk
 * `@property User *user;` - sets the user that places the call
 * `@property NXMClient *client;` - property for the client instance
 * `@property NXMCall *call;` - property for the call instance

