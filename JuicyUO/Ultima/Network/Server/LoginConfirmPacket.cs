﻿#region license
//  Copyright (C) 2018 JuicyUO Development Community on Github
//
//	This project is an alternative client for the game Ultima Online.
//	The goal of this is to develop a lightweight client considering 
//	new technologies such as DirectX (MonoGame included). The foundation
//	is originally licensed (GNU) on JuicyUO and the JuicyUO Development
//	Team. (Copyright (c) 2015 JuicyUO Development Team)
//    
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion

#region usings
using JuicyUO.Core.Network;
using JuicyUO.Core.Network.Packets;
#endregion

namespace JuicyUO.Ultima.Network.Server
{
    public class LoginConfirmPacket : RecvPacket
    {
        readonly Serial m_serial;
        readonly short m_body;
        readonly short m_x;
        readonly short m_y;
        readonly short m_z;
        readonly byte m_direction;

        public Serial Serial
        {
            get { return m_serial; }
        }

        public short Body
        {
            get { return m_body; }
        }

        public short X
        {
            get { return m_x; }
        }

        public short Y
        {
            get { return m_y; }
        }

        public short Z
        {
            get { return m_z; }
        }

        public byte Direction
        {
            get { return m_direction; }
        }

        public LoginConfirmPacket(PacketReader reader)
            : base(0x1B, "Login Confirm")
        {
            m_serial = reader.ReadInt32();

            reader.ReadInt32(); //unknown. Always 0.

            m_body = reader.ReadInt16();
            m_x = reader.ReadInt16();
            m_y = reader.ReadInt16();
            m_z = reader.ReadInt16();
            m_direction = reader.ReadByte();
        }
    }
}