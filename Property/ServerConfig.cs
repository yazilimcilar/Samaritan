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
using System.ComponentModel;

namespace Samaritan.Property
{
    class ServerConfig
    {
        private string serverEcho;
        private string serverRconPass;
        private string serverHostName;
        private string serverGameMode;
        private string serverFilterscripts;
        private string serverPlugins;
        private string serverWeburl;
        private string serverStreamDist;
        private string serverLogTimeFormat;
        private string serverMapname;

        private int serverLanMode;
        private int serverMaxPlayers;
        private int serverPort;
        private int serverAnnounce;
        private int serverQuery;
        private int serverChatLogging;
        private int serverOnFootRate;
        private int serverInCarRate;
        private int serverWeaponRate;
        private int serverStreamRate;
        private int serverMaxNpc;

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("echo")]
        public string Echo
        {
            get { return serverEcho; }
            set { serverEcho = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("lanmode")]
        public int LanMode
        {
            get { return serverLanMode; }
            set { serverLanMode = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("rcon_password")]
        public string RconPassword
        {
            get { return serverRconPass; }
            set { serverRconPass = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("maxplayers")]
        public int MaxPlayers
        {
            get { return serverMaxPlayers; }
            set { serverMaxPlayers = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("port")]
        public int Port
        {
            get { return serverPort; }
            set { serverPort = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("hostname")]
        public string HostName
        {
            get { return serverHostName; }
            set { serverHostName = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("gamemode")]
        public string GameMode
        {
            get { return serverGameMode; }
            set { serverGameMode = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("filterscripts")]
        public string Filterscripts
        {
            get { return serverFilterscripts; }
            set { serverFilterscripts = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("plugins")]
        public string Plugins
        {
            get { return serverPlugins; }
            set { serverPlugins = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("announce")]
        public int Announce
        {
            get { return serverAnnounce; }
            set { serverAnnounce = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("query")]
        public int Query
        {
            get { return serverQuery; }
            set { serverQuery = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("chatlogging")]
        public int ChatLogging
        {
            get { return serverChatLogging; }
            set { serverChatLogging = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("weburl")]
        public string WebUrl
        {
            get { return serverWeburl; }
            set { serverWeburl = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("onfoot_rate")]
        public int OnFootRate
        {
            get { return serverOnFootRate; }
            set { serverOnFootRate = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("incar_rate")]
        public int InCarRate
        {
            get { return serverInCarRate; }
            set { serverInCarRate = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("weapon_rate")]
        public int WeaponRate
        {
            get { return serverWeaponRate; }
            set { serverWeaponRate = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("stream_distance")]
        public string StreamDistance
        {
            get { return serverStreamDist; }
            set { serverStreamDist = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("stream_rate")]
        public int StreamRate
        {
            get { return serverStreamRate; }
            set { serverStreamRate = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("maxnpc")]
        public int MaxNpc
        {
            get { return serverMaxNpc; }
            set { serverMaxNpc = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("logtimeformat")]
        public string LogTimeFormat
        {
            get { return serverLogTimeFormat; }
            set { serverLogTimeFormat = value; }
        }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Configuration")]
        [DisplayName("mapname")]
        public string MapName
        {
            get { return serverMapname; }
            set { serverMapname = value; }
        }
    }
}
