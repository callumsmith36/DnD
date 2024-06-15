/*********************************************************
 *  
 *  Name:       Feat.cs
 *  
 *  Purpose:    Class for handling a D&D feat
 *  
 *  Author:     CS
 *  
 *  Created:    11/04/2024
 * 
 *********************************************************/

using DND.API;

namespace DND
{
    public class Feat : IEquatable<Feat>
    {
        public enum FeatSource
        {
            None,
            Class, Race, Other
        }

        public enum FeatFrequency
        {
            None = 0,
            ShortRest = 1,
            LongRest = 2,
            Daily = 4
        }

        // Properties
        public string           Name            { get; set; }
        public string           Index           { get; set; }
        public string[]         Description     { get; set; }
        public bool             LimitedUse      { get; set; }
        public FeatSource       Source          { get; set; }
        public string           SourceName      { get; set; }
        public FeatFrequency    Frequency       { get; set; }
        public int              MaxUses         { get; set; }
        public int              UsesRemaining   { get; set; }


        //
        //  Constructor
        //
        public Feat(
            string name, string[] desc, bool limited,
            FeatSource source, string sourceName, FeatFrequency freq,
            int maxUses)
        {
            Name = name;
            Index = APIReadWrite.NameToIndex(name);
            Description = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                Description[i] = desc[i];

            LimitedUse = limited;
            Source = source;
            SourceName = sourceName;
            Frequency = limited ? freq : FeatFrequency.None;
            MaxUses = limited ? maxUses : 0;
            UsesRemaining = MaxUses;
        }

        //
        //  Constructor
        //
        public Feat(APIFeat obj)
        {
            Name = obj.name;
            Index = obj.index;

            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];

            LimitedUse = obj.limited;
            SourceName = obj.source_name;
            MaxUses = obj.max_uses;
            UsesRemaining = obj.uses_left;

            switch (obj.source.ToLower())
            {
                case "class": Source = FeatSource.Class; break;
                case "race": Source = FeatSource.Race; break;
                case "other": Source = FeatSource.Other; break;
                default:
                    Source = FeatSource.None;
                    break;
            }

            switch (obj.frequency.ToLower())
            {
                case "short-rest": Frequency = FeatFrequency.ShortRest; break;
                case "long-rest": Frequency = FeatFrequency.LongRest; break;
                case "daily": Frequency = FeatFrequency.Daily; break;
                default:
                    Frequency = FeatFrequency.None;
                    break;
            }
        }

        //
        //  Copy Constructor
        //
        public Feat(Feat other)
        {
            Name = other.Name;
            Index = other.Index;

            Description = new string[other.Description.Length];
            for (int i = 0; i < Description.Length; i++)
                Description[i] = other.Description[i];

            LimitedUse = other.LimitedUse;
            Source = other.Source;
            SourceName = other.SourceName;
            Frequency = other.Frequency;
            MaxUses = other.MaxUses;
            UsesRemaining = other.UsesRemaining;
        }


        //
        //  ToAPIObject
        //
        public APIFeat ToAPIObject()
        {
            string source;
            switch (Source)
            {
                case FeatSource.Class: source = "class"; break;
                case FeatSource.Race: source = "race"; break;
                case FeatSource.Other: source = "other"; break;
                default:
                    source = string.Empty;
                    break;
            }

            string frequency;
            switch (Frequency)
            {
                case FeatFrequency.ShortRest: frequency = "short-rest"; break;
                case FeatFrequency.LongRest: frequency = "long-rest"; break;
                case FeatFrequency.Daily: frequency = "daily"; break;
                default:
                    frequency = string.Empty;
                    break;
            }

            return new APIFeat(Name, Index, Description, LimitedUse, source, SourceName, frequency, MaxUses, UsesRemaining);
        }


        //
        //  == operator
        //
        public static bool operator ==(Feat? a, Feat? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(Feat? a, Feat? b)
        {
            return !(a == b);
        }

        //
        //  Equals
        //
        public bool Equals(Feat? other)
        {
            if (ReferenceEquals(this, other))
                return true;

            if (ReferenceEquals(other, null))
                return false;

            bool equal =
                Name == other.Name &&
                Index == other.Index &&
                Description.Length == other.Description.Length &&
                LimitedUse == other.LimitedUse &&
                Source == other.Source &&
                SourceName == other.SourceName &&
                Frequency == other.Frequency &&
                MaxUses == other.MaxUses &&
                UsesRemaining == other.UsesRemaining;

            if (equal)
            {
                for (int i = 0; i < Description.Length; i++)
                {
                    if (Description[i] != other.Description[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            return equal;
        }

        //
        //  Equals
        //
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(obj, null))
                return false;

            if (obj is not Feat)
                return false;

            return Equals(obj as Feat);
        }

        //
        //  GetHashCode
        //
        public override int GetHashCode()
        {
            return Index.GetHashCode();
        }
    }
}
