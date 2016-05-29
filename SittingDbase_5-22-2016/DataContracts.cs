using System.Runtime.Serialization;

namespace SittingDbase
{
    // see: https://msdn.microsoft.com/en-us/library/bb410770(v=vs.110).aspx
    // for more information about data contracts

    /// <summary>
    /// Data contract for serialization of encouragement information.
    /// </summary>
    [DataContract]
    public class Encouragement
    {
        [DataMember]
        public long key;

        [DataMember]
        public string description;
    }

    /// <summary>
    /// Data contract for serialization of stretch information.
    /// </summary>
    [DataContract]
    public class Stretch
    {
        [DataMember]
        public long key;

        [DataMember]
        public string name;

        [DataMember]
        public string imgURL;

        [DataMember]
        public string description;
    }

    /// <summary>
    /// Data contract for serialization of user settings.
    /// </summary>
    [DataContract]
    public class UserSettings
    {
        [DataMember]
        public int interval;

        [DataMember]
        public string username;

        public UserSettings()
        {
            this.interval = 45 * 60; // 45 minutes
            this.username = "User";
        }
    }
}
