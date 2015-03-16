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
using System.IO;

namespace Samaritan.IO
{
    class CFGReader
    {
        public Dictionary<CFGKey, string> Key { get; private set; }
        public string Path { get; set; }

        public CFGReader()
        {
            Initialize();
        }

        public CFGReader(string path)
        {
            Path = path;
            Initialize();
        }

        private void Initialize()
        {
            Key.Add(CFGKey.Announce, null);
            Key.Add(CFGKey.ChatLogging, null);
            Key.Add(CFGKey.Echo, null);
            Key.Add(CFGKey.Filterscripts, null);
            Key.Add(CFGKey.GameMode, null);
            Key.Add(CFGKey.HostName, null);
            Key.Add(CFGKey.InCarRate, null);
            Key.Add(CFGKey.LanMode, null);
            Key.Add(CFGKey.LogTimeFormat, null);
            Key.Add(CFGKey.MapName, null);
            Key.Add(CFGKey.MaxNpc, null);
            Key.Add(CFGKey.MaxPlayers, null);
            Key.Add(CFGKey.OnFootRate, null);
            Key.Add(CFGKey.PlugIns, null);
            Key.Add(CFGKey.Port, null);
            Key.Add(CFGKey.Query, null);
            Key.Add(CFGKey.RconPassword, null);
            Key.Add(CFGKey.StreamDistance, null);
            Key.Add(CFGKey.StreamRate, null);
            Key.Add(CFGKey.WeaponRate, null);
            Key.Add(CFGKey.WebUrl, null);
        }

        public void Read()
        {
            if (Path.Length == 0 || Path == null)
            {
                throw new Samaritan.Exceptions.CFGException("Invalid CFG File Path");
            }
            else
            {
                if (System.IO.Path.GetExtension(Path) != ".cfg")
                {
                    throw new Samaritan.Exceptions.CFGException("Invalid file extension!\nPath: " + Path);
                }
                else
                {
                    Key[CFGKey.Announce] = GetSingleKeyValue(CFGKey.Announce);
                    Key[CFGKey.ChatLogging] = GetSingleKeyValue(CFGKey.ChatLogging);
                    Key[CFGKey.Echo] = GetSingleKeyValue(CFGKey.Echo);
                    Key[CFGKey.Filterscripts] = GetSingleKeyValue(CFGKey.Filterscripts);
                    Key[CFGKey.GameMode] = GetSingleKeyValue(CFGKey.GameMode);
                    Key[CFGKey.HostName] = GetSingleKeyValue(CFGKey.HostName);
                    Key[CFGKey.InCarRate] = GetSingleKeyValue(CFGKey.InCarRate);
                    Key[CFGKey.LanMode] = GetSingleKeyValue(CFGKey.LanMode);
                    Key[CFGKey.LogTimeFormat] = GetSingleKeyValue(CFGKey.LogTimeFormat);
                    Key[CFGKey.MapName] = GetSingleKeyValue(CFGKey.MapName);
                    Key[CFGKey.MaxNpc] = GetSingleKeyValue(CFGKey.MaxNpc);
                    Key[CFGKey.MaxPlayers] = GetSingleKeyValue(CFGKey.MaxPlayers);
                    Key[CFGKey.OnFootRate] = GetSingleKeyValue(CFGKey.OnFootRate);
                    Key[CFGKey.PlugIns] = GetSingleKeyValue(CFGKey.PlugIns);
                    Key[CFGKey.Port] = GetSingleKeyValue(CFGKey.Port);
                    Key[CFGKey.Query] = GetSingleKeyValue(CFGKey.Query);
                    Key[CFGKey.RconPassword] = GetSingleKeyValue(CFGKey.RconPassword);
                    Key[CFGKey.StreamDistance] = GetSingleKeyValue(CFGKey.StreamDistance);
                    Key[CFGKey.StreamRate] = GetSingleKeyValue(CFGKey.StreamRate);
                    Key[CFGKey.WeaponRate] = GetSingleKeyValue(CFGKey.WeaponRate);
                    Key[CFGKey.WebUrl] = GetSingleKeyValue(CFGKey.WebUrl);
                }
            }
        }

        public string GetSingleKeyValue(CFGKey key)
        {
            String value = String.Empty;
            StreamReader content = File.OpenText(Path);
            String keyName = Enums.GetEnumStringValue(key);
            Boolean keyExists = false;

            while (!content.EndOfStream)
            {
                String line = content.ReadLine();
                if (line.Length == 0)
                {
                    continue;
                }
                else
                {
                    if (line.StartsWith(keyName))
                    {
                        keyExists = true;
                        value = line.Substring(line.Length + 1);
                        break;
                    }
                }
            }

            if (!keyExists)
            {
                throw new Samaritan.Exceptions.CFGException("Key name: " + keyName + ", doesn't exist in " + Path);
            }
            return value;
        }
    }
}
