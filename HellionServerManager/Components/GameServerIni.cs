using System;
using System.ComponentModel;
using System.Reflection;
using System.IO;

namespace HellionServerManager.Controls
{
    public class GameServerIni
    {

        public string ServerPath = String.Empty;
        public string FileName = "GameServer.ini";

        #region Fields
        private static string serverName;
        private static string serverPass;
        private static int statusPort;
        private static int clientPort;
        private static int maxPlayers;
        private static int maxSaveFileCount;
        private static int serverTickCount;
        private static int solarSystemTime;
        private static int saveInterval;
        private static string mainServerIP;
        private static int mainServerPort;
        #endregion

        public GameServerIni()
        {
            
        }

        #region ServerConfig Properties
        [ReadOnly(false)]
        [Description("The max amount of save files that can exist at once. (Set lower to save drive space)")]
        [Category("Settings")]
        [DisplayName("Max Save Files")]
        public int number_of_save_file
        {
            get { return maxSaveFileCount; }
            set { maxSaveFileCount = value; }
        }

        [ReadOnly(false)]
        [Description("How many times the server is allowed to update per second (Default: 64)")]
        [Category("Settings")]
        [DisplayName("Server Tick Count")]
        public int server_tick_count
        {
            get { return serverTickCount; }
            set { serverTickCount = value; }
        }

        [ReadOnly(false)]
        [Description("How long the time in between saves in seconds. (Default: 900) (-1 = Off)")]
        [Category("Settings")]
        [DisplayName("Save Interval")]
        public int save_interval
        {
            get { return saveInterval; }
            set { saveInterval = value; }
        }

        [ReadOnly(false)]
        [Description("The time of the solar systems birth (Default: -1) (-1 = Random)")]
        [Category("Settings")]
        [DisplayName("Solar System Time")]
        public int solar_system_time
        {
            get { return solarSystemTime; }
            set { solarSystemTime = value; }
        }

        [ReadOnly(true)]
        [Description("The IP Address of the Main Server (Disabled)")]
        [Category("Settings")]
        [DisplayName("Main Server IP")]
        public string main_server_ip
        {
            get { return mainServerIP; }
            set { mainServerIP = value; }
        }

        [ReadOnly(true)]
        [Description("The Port of the Main Server (Disabled)")]
        [Category("Settings")]
        [DisplayName("Main Server Port")]
        public int main_server_port
        {
            get { return mainServerPort; }
            set { mainServerPort = value; }
        }

        [ReadOnly(false)]                          
        [Description("The name of the server shown to clients in the server browser. (Default: Hellion Dedicated Server)")]             
        [Category("Required Settings")]                   
        [DisplayName("Server Name")]     
        public string server_name
        {
            get { return serverName; }
            set { serverName = value; }
        }

        [ReadOnly(false)]
        [Description("The password to the server. (Default: None)")]
        [Category("Required Settings")]
        [DisplayName("Server Password")]
        public string server_pass
        {
            get { return serverPass; }
            set { serverPass = value; }
        }

        [ReadOnly(false)]
        [Description("The port to use for the server browser status, ping, and player count. (Default: 5970) (Any)")]
        [Category("Required Settings")]
        [DisplayName("Status Port")]
        public int status_port
        {
            get { return statusPort; }
            set { statusPort = value; }
        }

        [ReadOnly(false)]
        [Description("The port your clients will use to connect to your server. (Default: 5969) (Any)")]
        [Category("Required Settings")]
        [DisplayName("Client Port")]
        public int game_client_port
        {
            get { return clientPort; }
            set { clientPort = value; }
        }

        [ReadOnly(false)]
        [Description("Maximum Players allowed on the server. (Default: 20) (Max: 100)")]
        [Category("Required Settings")]
        [DisplayName("Max Players")]
        public int max_players
        {
            get { return maxPlayers; }
            set { maxPlayers = value; }
        }

        private object this[string property]
        {
            get
            {
                PropertyInfo myPropInfo = typeof(GameServerIni).GetProperty(property);
                return myPropInfo.GetValue(this, null);
            }
            set
            {
                PropertyInfo myPropInfo = typeof(GameServerIni).GetProperty(property);

                myPropInfo.SetValue(this, Convert.ChangeType( value, myPropInfo.PropertyType), null);

            }

        }

        #endregion

        #region Methods
        public void LoadDefaults()
        {
            serverName = "Hellion Dedicated Server";
            serverPass = "";
            statusPort = 5970;
            clientPort = 5969;
            maxPlayers = 20;
            maxSaveFileCount = 10;
            serverTickCount = 64;
            solarSystemTime = -1;
            saveInterval = 900;
            mainServerIP = "0.0.0.0";
            mainServerPort = 0;

        }

        public void Save()
        {
            if (!File.Exists(Path.Combine(ServerPath, FileName)))
            {



            }
            else
            {

            }
        }

        public void Load()
        {
            try
            {
                if (File.Exists(Path.Combine(ServerPath, FileName)))
                {
                    foreach (string line in File.ReadLines(Path.Combine(ServerPath, FileName)))
                    {
                        try
                        {
                            if (!line.StartsWith("#"))
                            {
                                var lineSetting = line.Split("=".ToCharArray(), 2);
                                this[lineSetting[0]] = lineSetting[1];
                            }
                        }
                        catch { }
                    }
                }
                else
                {
                    Log.Message("GameServer.Ini wasn't found!");
                }
            }
            catch (Exception ex)
            {
                Log.Message(ex.ToString());
            }


        }
        #endregion
    }
}
