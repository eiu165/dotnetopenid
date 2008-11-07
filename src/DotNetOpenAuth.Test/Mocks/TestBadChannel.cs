﻿//-----------------------------------------------------------------------
// <copyright file="TestBadChannel.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Test.Mocks {
	using System;
	using System.Collections.Generic;
	using DotNetOpenAuth.Messaging;

	/// <summary>
	/// A Channel derived type that passes null to the protected constructor.
	/// </summary>
	internal class TestBadChannel : Channel {
		internal TestBadChannel(bool badConstructorParam)
			: base(badConstructorParam ? null : new TestMessageTypeProvider()) {
		}

		internal new void Create301RedirectResponse(IDirectedProtocolMessage message, IDictionary<string, string> fields) {
			base.Create301RedirectResponse(message, fields);
		}

		internal new void CreateFormPostResponse(IDirectedProtocolMessage message, IDictionary<string, string> fields) {
			base.CreateFormPostResponse(message, fields);
		}

		internal new void SendIndirectMessage(IDirectedProtocolMessage message) {
			base.SendIndirectMessage(message);
		}

		internal new IProtocolMessage Receive(Dictionary<string, string> fields, MessageReceivingEndpoint recipient) {
			return base.Receive(fields, recipient);
		}

		internal new IProtocolMessage ReadFromRequest(HttpRequestInfo request) {
			return base.ReadFromRequest(request);
		}

		protected override IDictionary<string, string> ReadFromResponseInternal(Response response) {
			throw new NotImplementedException();
		}

		protected override Response SendDirectMessageResponse(IProtocolMessage response) {
			throw new NotImplementedException();
		}
	}
}
