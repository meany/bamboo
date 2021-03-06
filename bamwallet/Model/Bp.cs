﻿// BAMWallet by Matthew Hellyer is licensed under CC BY-NC-ND 4.0. 
// To view a copy of this license, visit https://creativecommons.org/licenses/by-nc-nd/4.0

using ProtoBuf;

namespace BAMWallet.Model
{
    [ProtoContract]
    public class Bp
    {
        [ProtoMember(1)]
        public byte[] Proof { get; set; }
    }
}
