using System.Runtime.Serialization;

namespace BreakTime
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
    /// Data contract for serialization of "what hurts".
    /// </summary>
    [DataContract]
    public class Hurts
    {
        [DataMember]
        public bool head;

        [DataMember]
        public bool eyes;

        [DataMember]
        public bool hands;

        [DataMember]
        public bool wrists;

        [DataMember]
        public bool neck;

        [DataMember]
        public bool elbows;

        [DataMember]
        public bool shoulders;

        [DataMember]
        public bool back;

        [DataMember]
        public bool legs;

        [DataMember]
        public bool knees;

        [DataMember]
        public bool feet;
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

        [DataMember]
        public Hurts hurts;

        public UserSettings()
        {
            this.interval = 45 * 60; // 45 minutes
            this.username = "User";
            this.hurts = new Hurts();
        }
    }
}
