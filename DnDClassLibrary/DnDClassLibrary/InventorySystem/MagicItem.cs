/*********************************************************
 *  
 *  Name:       InventorySystem/MagicItem.cs
 *  
 *  Purpose:    Class representing a D&D magic item
 *  
 *  Author:     CS
 *  
 *  Created:    30/01/2024
 * 
 *********************************************************/

using DND.API;
using DND.Types;

namespace DND.InventorySystem
{
    public class MagicItem : InventoryObject
    {
        // Properties
        public string   Rarity      { get; private set; }
        public bool     Attunement  { get; private set; }
        public bool     IsVariant   { get; private set; }
        public string[] Variants    { get; private set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public MagicItem(
            string name, EquipmentCategory category, string rarity,
            string[] desc, bool attunement, bool isVariant = false,
            string[]? variants = null
        )
            : base(name, "/custom/magic-items", category, desc, true)
        {
            Rarity = rarity;
            Attunement = attunement;
            IsVariant = isVariant;

            if (variants != null)
            {
                Variants = new string[variants.Length];
                for (int i = 0; i < variants.Length; i++)
                    Variants[i] = variants[i];
            }
            else
            {
                Variants = Array.Empty<string>();
            }
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public MagicItem(APIMagicItem obj) : base(obj)
        {
            Rarity = obj.rarity.name;
            IsVariant = obj.variant;
            Variants = new string[obj.variants.Length];
            for (int i = 0; i < obj.variants.Length; i++)
                Variants[i] = obj.variants[i].name;

            Attunement = obj.attunement;
            if (!Attunement && Description.Length > 0)
                Attunement = Description[0].ToLower().Contains("attunement");
        }

        //
        //  Copy Constructor
        //
        public MagicItem(MagicItem item) : base(item)
        {
            Rarity = item.Rarity;
            IsVariant = item.IsVariant;
            Variants = new string[item.Variants.Length];
            for (int i = 0; i < item.Variants.Length; i++)
                Variants[i] = item.Variants[i];

            Attunement = item.Attunement;
        }


        //
        //  ToAPIObject
        //
        public override APIMagicItem ToAPIObject()
        {
            return new APIMagicItem(
                Name, TypeMaps.EquipmentCategoryNames[EquipmentCategory], Rarity,
                Attunement, Description, IsVariant, Variants
            );
        }
    }
}
