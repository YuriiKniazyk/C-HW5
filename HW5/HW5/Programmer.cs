using System;

namespace HW5
{
    public class Programmer : IDeveloper, IComparable
    {
        public string Language { get; set; }
        public string Tool
        {
            get => Language;
            set => Language = value;
        }
        public string Create()
        {
            return $"Programmer create {Language}";
        }

        public string Destroy()
        {
            return $"Programer destroy {Language}";
        }

        public int CompareTo(object user)
        {
            IDeveloper developer = user as IDeveloper;
            return Language.CompareTo(developer.Tool);
        }
    }
}