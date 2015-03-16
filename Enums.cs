//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Samaritan.Attributes;

namespace Samaritan
{
    internal enum DataType
    {
        Integer,
        String,
        Float,
        Boolean,
    };

    internal enum CFGKey
    {
        [StringValue("echo")]
        Echo,
        [StringValue("lanmode")]
        LanMode,
        [StringValue("rcon_password")]
        RconPassword,
        [StringValue("maxplayers")]
        MaxPlayers,
        [StringValue("port")]
        Port,
        [StringValue("hostname")]
        HostName,
        [StringValue("gamemode")]
        GameMode,
        [StringValue("filterscripts")]
        Filterscripts,
        [StringValue("plugins")]
        PlugIns,
        [StringValue("announce")]
        Announce,
        [StringValue("query")]
        Query,
        [StringValue("chatlogging")]
        ChatLogging,
        [StringValue("weburl")]
        WebUrl,
        [StringValue("onfoot_rate")]
        OnFootRate,
        [StringValue("incar_rate")]
        InCarRate,
        [StringValue("weapon_rate")]
        WeaponRate,
        [StringValue("stream_distance")]
        StreamDistance,
        [StringValue("stream_rate")]
        StreamRate,
        [StringValue("maxnpc")]
        MaxNpc,
        [StringValue("logtimeformat")]
        LogTimeFormat,
        [StringValue("mapname")]
        MapName,
    };

    static class Enums
    {
        public static string GetEnumStringValue(Enum value)
        {
            String enumValue = String.Empty;
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            StringValue[] attributes = fieldInfo.GetCustomAttributes(typeof(StringValue), false) as StringValue[];

            if (attributes.Length > 0)
            {
                enumValue = attributes[0].Value;
            }
            return enumValue;
        }

        public static uint GetEnumUintValue(Enum value)
        {
            UInt32 enumValue = 0;
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            UIntegerValue[] attributes = fieldInfo.GetCustomAttributes(typeof(UIntegerValue), false) as UIntegerValue[];

            if (attributes.Length > 0)
            {
                enumValue = attributes[0].Value;
            }
            return enumValue;
        }
    }
}
