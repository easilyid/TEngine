using System.Runtime.CompilerServices;
using Fantasy;
using Fantasy.Async;
using Fantasy.Network;
using System.Collections.Generic;
#pragma warning disable CS8618
namespace Fantasy
{
   public static class NetworkProtocolHelper
   {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static async FTask<G2C_PingResponse> C2G_PingRequest(this Session session, C2G_PingRequest C2G_PingRequest_request)
		{
			return (G2C_PingResponse)await session.Call(C2G_PingRequest_request);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static async FTask<G2C_PingResponse> C2G_PingRequest(this Session session, long clientTime)
		{
			using var C2G_PingRequest_request = Fantasy.C2G_PingRequest.Create();
			C2G_PingRequest_request.ClientTime = clientTime;
			return (G2C_PingResponse)await session.Call(C2G_PingRequest_request);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static async FTask<G2C_LoginResponse> C2G_LoginRequest(this Session session, C2G_LoginRequest C2G_LoginRequest_request)
		{
			return (G2C_LoginResponse)await session.Call(C2G_LoginRequest_request);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static async FTask<G2C_LoginResponse> C2G_LoginRequest(this Session session, string username, string password)
		{
			using var C2G_LoginRequest_request = Fantasy.C2G_LoginRequest.Create();
			C2G_LoginRequest_request.Username = username;
			C2G_LoginRequest_request.Password = password;
			return (G2C_LoginResponse)await session.Call(C2G_LoginRequest_request);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void C2G_ChatMessage(this Session session, C2G_ChatMessage C2G_ChatMessage_message)
		{
			session.Send(C2G_ChatMessage_message);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void C2G_ChatMessage(this Session session, int channel, string content, long targetId)
		{
			using var C2G_ChatMessage_message = Fantasy.C2G_ChatMessage.Create();
			C2G_ChatMessage_message.Channel = channel;
			C2G_ChatMessage_message.Content = content;
			C2G_ChatMessage_message.TargetId = targetId;
			session.Send(C2G_ChatMessage_message);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void G2C_ChatMessage(this Session session, G2C_ChatMessage G2C_ChatMessage_message)
		{
			session.Send(G2C_ChatMessage_message);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void G2C_ChatMessage(this Session session, long senderId, string senderName, int channel, string content, long timestamp)
		{
			using var G2C_ChatMessage_message = Fantasy.G2C_ChatMessage.Create();
			G2C_ChatMessage_message.SenderId = senderId;
			G2C_ChatMessage_message.SenderName = senderName;
			G2C_ChatMessage_message.Channel = channel;
			G2C_ChatMessage_message.Content = content;
			G2C_ChatMessage_message.Timestamp = timestamp;
			session.Send(G2C_ChatMessage_message);
		}

   }
}