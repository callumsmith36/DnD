using DND.API;

namespace DND
{
    public class Spell : DNDReference
    {
        // Properties
        public int      Level           { get; private set; }
        public string   Range           { get; private set; }
        public string   Duration        { get; private set; }
        public string   CastingTime     { get; private set; }
        public string   Components      { get; private set; }
        public string   Material        { get; private set; }
        public string   School          { get; private set; }
        public bool     IsRitual        { get; private set; }
        public bool     IsConcentration { get; private set; }
        public string[] Description     { get; private set; }
        public string[] HigherLevel     { get; private set; }
        public string[] Classes         { get; private set; }
        public string[] Subclasses      { get; private set; }


        #region CONSTRUCTORS

        //
        //  Constructor
        //  (from custom data)
        //
        public Spell(
            int level, string name, string range,
            string time, string duration, string components,
            string mat, string school, bool ritual,
            bool concentration, string[] desc, string[] higherLvl,
            string[] classes, string[] subclasses
        )
            : base(name, "/custom/spells")
        {
            Level = level > 0 ? level : 0;
            Range = range;
            CastingTime = time;
            Duration = duration;
            Components = components;
            Material = mat;
            School = school;

            IsRitual = ritual;
            IsConcentration = concentration;

            Description = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                Description[i] = desc[i];

            HigherLevel = new string[higherLvl.Length];
            for (int i = 0; i < higherLvl.Length; i++)
                HigherLevel[i] = higherLvl[i];

            Classes = new string[classes.Length];
            for (int i = 0; i < classes.Length; i++)
                Classes[i] = classes[i];

            Subclasses = new string[subclasses.Length];
            for (int i = 0; i < subclasses.Length; i++)
                Subclasses[i] = subclasses[i];
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Spell(APISpell obj) : base(obj)
        {
            int i;

            Level = obj.level;
            Range = obj.range;
            CastingTime = obj.casting_time;
            Duration = obj.duration;
            Material = obj.material;
            School = obj.school.name;

            Components = string.Empty;
            for (i = 0; i < obj.components.Length; i++)
            {
                Components += obj.components[i];
                if (i < obj.components.Length - 1)
                    Components += ", ";
            }

            Description = obj.desc;
            HigherLevel = obj.higher_level;

            Classes = new string[obj.classes.Length];
            for (i = 0; i < obj.classes.Length; i++)
                Classes[i] = obj.classes[i].name;

            Subclasses = new string[obj.subclasses.Length];
            for (i = 0; i < obj.subclasses.Length; i++)
                Subclasses[i] = obj.subclasses[i].name;

            IsRitual = obj.ritual;
            IsConcentration = obj.concentration;
        }

        //
        //  Copy Constructor
        //
        public Spell(Spell spell) : base(spell)
        {
            int i;

            Level = spell.Level;
            Range = spell.Range;
            CastingTime = spell.CastingTime;
            Duration = spell.Duration;
            Components = spell.Components;
            Material = spell.Material;
            School = spell.School;

            Description = new string[spell.Description.Length];
            for (i = 0; i < spell.Description.Length; i++)
                Description[i] = spell.Description[i];

            HigherLevel = new string[spell.HigherLevel.Length];
            for (i = 0; i < spell.HigherLevel.Length; i++)
                HigherLevel[i] = spell.HigherLevel[i];

            Classes = new string[spell.Classes.Length];
            for (i = 0; i < spell.Classes.Length; i++)
                Classes[i] = spell.Classes[i];

            Subclasses = new string[spell.Subclasses.Length];
            for (i = 0; i < spell.Subclasses.Length; i++)
                Subclasses[i] = spell.Subclasses[i];
        }

        #endregion // CONSTRUCTORS


        //
        //  GetLevelString
        //
        public static string GetLevelString(int level)
        {
            string levelStr;
            switch (level)
            {
                case 0: levelStr = "cantrip"; break;
                case 1: levelStr = "1st-level"; break;
                case 2: levelStr = "2nd-level"; break;
                case 3: levelStr = "3rd-level"; break;
                default:
                    levelStr = string.Format("{0}th-level", level);
                    break;
            }

            return levelStr;
        }


        //
        //  ToAPIObject
        //
        public override APISpell ToAPIObject()
        {
            int i;

            APISpell obj = new APISpell();
            obj.name = Name;
            obj.index = Index;
            obj.url = URL;
            obj.level = Level;
            obj.range = Range;
            obj.material = Material;
            obj.duration = Duration;
            obj.casting_time = CastingTime;

            obj.desc = new string[Description.Length];
            for (i = 0; i < Description.Length; i++)
                obj.desc[i] = Description[i];

            obj.higher_level = new string[HigherLevel.Length];
            for (i = 0; i < HigherLevel.Length; i++)
                obj.higher_level[i] = HigherLevel[i];

            obj.ritual = IsRitual;
            obj.concentration = IsConcentration;

            List<string> compList = new List<string>();
            if (Components.Contains('V'))
                compList.Add("V");
            if (Components.Contains('S'))
                compList.Add("S");
            if (Components.Contains('M'))
                compList.Add("M");
            obj.components = compList.ToArray();

            obj.school = new APIReference(School, "/api/magic-schools");

            List<APIReference> classList = new List<APIReference>();
            for (i = 0; i < Classes.Length; i++)
            {
                var c = APIReadWrite.GetClass(Classes[i]);
                if (c != null)
                    classList.Add(new APIReference(c.Index, c.Name, c.URL));
            }

            obj.classes = classList.ToArray();

            obj.subclasses = new APIReference[Subclasses.Length];
            for (i = 0; i < Subclasses.Length; i++)
                obj.subclasses[i] = new APIReference(Subclasses[i], "/api/subclasses");

            return obj;
        }
    }
}
