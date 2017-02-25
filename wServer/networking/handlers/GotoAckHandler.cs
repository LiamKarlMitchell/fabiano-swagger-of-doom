﻿#region

using System;
using wServer.networking.cliPackets;

#endregion

namespace wServer.networking.handlers
{
    internal class GotoAckHandler : PacketHandlerBase<GotoAckPacket>
    {
        public override PacketID ID
        {
            get { return PacketID.GOTOACK; }
        }

        protected override void HandlePacket(Client client, GotoAckPacket packet)
        {
            throw new NotImplementedException();
        }
    }
}