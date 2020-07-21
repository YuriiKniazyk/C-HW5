using System;

namespace HW5
{
    public class Builder : IDeveloper, IComparable
    {
        public string tool { get; set; }
        public string Tool
        {
            get => tool;
            set => tool = value;
        }

        public string Create()
        {
            return $"Builder create {tool}";
        }

        public string Destroy()
        {
            return $"Builder delete {tool}";
        }

        public int CompareTo(object user)
        {
            IDeveloper developer = user as IDeveloper;
            return Tool.CompareTo(developer.Tool);
        }
    }
}