---
title: Overview
description: This topic provides an overview of using the Client SDK to build in-app voice applications.
navigation_weight: 0
---

# In-App Voice Overview

Client SDK allows you to add voice capabilities to your web or native application. You application would then be able to support a variety of use cases such as click to call a support agent, realtime messaging, and voice chat rooms.

Client SDK In-App Voice uses WebRTC and includes all the essentials you need to build a feature-rich voice experience.

* 1:1 or Group Calls
* Audio Controls – Mute, earmuff
* DTMF Support

Client SDK In-App Voice integrates with the Nexmo Voice API which amplifies the In-App Voice offering through extra functionality such as:

* Calls to phones (PSTN)
* Calls to SIP-enabled devices
* Connection to other services over Websockets
* Call management
* Complex call flow configurations
* Voice stream recording
* Conference calling
* Text-to-speech messages in 23 languages

The Android and iOS Client SDKs additionally offer:

* Network Change Handling
* Audio Routing Management
* Push Notifications

## Voice calls

There are two ways to make Voice calls:

1. Using VAPI using the Client SDK `callServer()` method.
2. Using peer-peer call functionality via the `inAppCall()` method.

The Client SDK application manages the [Event flow](/conversation/guides/event-flow) of the conversation.

## Setup

* [Create your App](/client-sdk/setup/create-your-application)
* [Add SDK to your App](/client-sdk/setup/add-sdk-to-your-app)
* [Set up push notifications](/client-sdk/setup/set-up-push-notifications)
* [Configure data center](/client-sdk/setup/configure-data-center)

## Getting Started

* [App to App call](/client-sdk/in-app-voice/getting-started/app-to-app-call)
* [Make a phone call](/client-sdk/in-app-voice/getting-started/make-phone-call)
* [Receive a phone call](/client-sdk/in-app-voice/getting-started/receive-phone-call)

## Concepts

Conversation API concepts:

```concept_list
product: conversation
```

In-app Voice concepts:

```concept_list
product: client-sdk/in-app-voice
```

## Use Cases

```use_cases
product: client-sdk
```

## Reference

* [Conversation API](/api/conversation)
* [Client SDK Reference - Web](/sdk/client-sdk/javascript)
* [Client SDK Reference - iOS](/sdk/client-sdk/ios)
* [Client SDK Reference - Android](/sdk/client-sdk/android)
