using LightProto;
using System;
using MemoryPack;
using System.Collections.Generic;
using Fantasy;
using Fantasy.Pool;
using Fantasy.Network.Interface;
using Fantasy.Serialize;

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8618
// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable RedundantTypeArgumentsOfMethod
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable PreferConcreteValueOverDefault
// ReSharper disable RedundantNameQualifier
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CheckNamespace
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable RedundantUsingDirective
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
namespace Fantasy
{
    /// <summary>
    /// Client ping request
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class C2G_PingRequest : AMessage, IRequest
    {
        public static C2G_PingRequest Create(bool autoReturn = true)
        {
            var c2G_PingRequest = MessageObjectPool<C2G_PingRequest>.Rent();
            c2G_PingRequest.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                c2G_PingRequest.SetIsPool(false);
            }
            
            return c2G_PingRequest;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            ClientTime = default;
            MessageObjectPool<C2G_PingRequest>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.C2G_PingRequest; } 
        [ProtoIgnore]
        public G2C_PingResponse ResponseType { get; set; }
        /// <summary>
        /// Client timestamp
        /// </summary>
        [ProtoMember(1)]
        public long ClientTime { get; set; }
    }
    /// <summary>
    /// Server ping response
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class G2C_PingResponse : AMessage, IResponse
    {
        public static G2C_PingResponse Create(bool autoReturn = true)
        {
            var g2C_PingResponse = MessageObjectPool<G2C_PingResponse>.Rent();
            g2C_PingResponse.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                g2C_PingResponse.SetIsPool(false);
            }
            
            return g2C_PingResponse;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            ErrorCode = 0;
            ServerTime = default;
            MessageObjectPool<G2C_PingResponse>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.G2C_PingResponse; } 
        [ProtoMember(1)]
        public uint ErrorCode { get; set; }
        /// <summary>
        /// Server timestamp
        /// </summary>
        [ProtoMember(2)]
        public long ServerTime { get; set; }
    }
    /// <summary>
    /// Client login request
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class C2G_LoginRequest : AMessage, IRequest
    {
        public static C2G_LoginRequest Create(bool autoReturn = true)
        {
            var c2G_LoginRequest = MessageObjectPool<C2G_LoginRequest>.Rent();
            c2G_LoginRequest.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                c2G_LoginRequest.SetIsPool(false);
            }
            
            return c2G_LoginRequest;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            Username = default;
            Password = default;
            MessageObjectPool<C2G_LoginRequest>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.C2G_LoginRequest; } 
        [ProtoIgnore]
        public G2C_LoginResponse ResponseType { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        [ProtoMember(1)]
        public string Username { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [ProtoMember(2)]
        public string Password { get; set; }
    }
    /// <summary>
    /// Server login response
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class G2C_LoginResponse : AMessage, IResponse
    {
        public static G2C_LoginResponse Create(bool autoReturn = true)
        {
            var g2C_LoginResponse = MessageObjectPool<G2C_LoginResponse>.Rent();
            g2C_LoginResponse.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                g2C_LoginResponse.SetIsPool(false);
            }
            
            return g2C_LoginResponse;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            ErrorCode = 0;
            ErrorCode = default;
            Token = default;
            PlayerId = default;
            MessageObjectPool<G2C_LoginResponse>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.G2C_LoginResponse; } 
        [ProtoMember(1)]
        public uint ErrorCode { get; set; }
        /// <summary>
        /// Error code (0 = success)
        /// </summary>
        [ProtoMember(2)]
        public uint ErrorCode { get; set; }
        /// <summary>
        /// Session token
        /// </summary>
        [ProtoMember(3)]
        public string Token { get; set; }
        /// <summary>
        /// Player ID
        /// </summary>
        [ProtoMember(4)]
        public long PlayerId { get; set; }
    }
    /// <summary>
    /// Client send chat message
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class C2G_ChatMessage : AMessage, IMessage
    {
        public static C2G_ChatMessage Create(bool autoReturn = true)
        {
            var c2G_ChatMessage = MessageObjectPool<C2G_ChatMessage>.Rent();
            c2G_ChatMessage.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                c2G_ChatMessage.SetIsPool(false);
            }
            
            return c2G_ChatMessage;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            Channel = default;
            Content = default;
            TargetId = default;
            MessageObjectPool<C2G_ChatMessage>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.C2G_ChatMessage; } 
        /// <summary>
        /// Chat channel (0=world, 1=team, 2=private)
        /// </summary>
        [ProtoMember(1)]
        public int Channel { get; set; }
        /// <summary>
        /// Message content
        /// </summary>
        [ProtoMember(2)]
        public string Content { get; set; }
        /// <summary>
        /// Target player ID (for private chat)
        /// </summary>
        [ProtoMember(3)]
        public long TargetId { get; set; }
    }
    /// <summary>
    /// Server broadcast chat message
    /// </summary>
    [Serializable]
    [ProtoContract]
    public partial class G2C_ChatMessage : AMessage, IMessage
    {
        public static G2C_ChatMessage Create(bool autoReturn = true)
        {
            var g2C_ChatMessage = MessageObjectPool<G2C_ChatMessage>.Rent();
            g2C_ChatMessage.AutoReturn = autoReturn;
            
            if (!autoReturn)
            {
                g2C_ChatMessage.SetIsPool(false);
            }
            
            return g2C_ChatMessage;
        }
        
        public void Return()
        {
            if (!AutoReturn)
            {
                SetIsPool(true);
                AutoReturn = true;
            }
            else if (!IsPool())
            {
                return;
            }
            Dispose();
        }

        public void Dispose()
        {
            if (!IsPool()) return; 
            SenderId = default;
            SenderName = default;
            Channel = default;
            Content = default;
            Timestamp = default;
            MessageObjectPool<G2C_ChatMessage>.Return(this);
        }
        public uint OpCode() { return OuterOpcode.G2C_ChatMessage; } 
        /// <summary>
        /// Sender player ID
        /// </summary>
        [ProtoMember(1)]
        public long SenderId { get; set; }
        /// <summary>
        /// Sender name
        /// </summary>
        [ProtoMember(2)]
        public string SenderName { get; set; }
        /// <summary>
        /// Chat channel
        /// </summary>
        [ProtoMember(3)]
        public int Channel { get; set; }
        /// <summary>
        /// Message content
        /// </summary>
        [ProtoMember(4)]
        public string Content { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [ProtoMember(5)]
        public long Timestamp { get; set; }
    }
}