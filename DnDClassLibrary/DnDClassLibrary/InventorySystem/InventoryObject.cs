/*********************************************************
 *  
 *  Name:       InventorySystem/InventoryObject.cs
 *  
 *  Purpose:    Base class for all D&D items (equipment
 *              and magic items)
 *  
 *  Author:     CS
 *  
 *  Created:    17/03/2024
 * 
 *********************************************************/

using DND.API;
using DND.Types;

namespace DND.InventorySystem
{
    public abstract class InventoryObject : DNDReference
    {
        // Properties
        public EquipmentCategory    EquipmentCategory   { get; protected set; }
        public string[]             Description         { get; protected set; }
        public bool                 IsMagical           { get; protected set; }
        public bool                 IsContainer         { get; protected set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public InventoryObject(
            string name, string parentPath, EquipmentCategory category,
            string[] desc, bool magic, bool container = false
        )
            : base(name, parentPath)
        {
            EquipmentCategory = category;
            Description = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                Description[i] = desc[i];

            IsMagical = magic;
            IsContainer = container;
        }

        //
        //  Constructor
        //  (from APIEquipment)
        //
        public InventoryObject(APIEquipment obj) : base(obj)
        {
            EquipmentCategory = TypeMaps.GetValueFromName(obj.equipment_category.name, TypeMaps.EquipmentCategoryNames);
            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];

            IsMagical = false;

            switch (obj.index)
            {
                case "backpack":
                case "barrel":
                case "chest":
                case "component-pouch":
                case "pouch":
                case "quiver":
                case "sack":
                    IsContainer = true;
                    break;
                default:
                    IsContainer = false;
                    break;
            }
        }

        //
        //  Constructor
        //  (from APIMagicItem)
        //
        public InventoryObject(APIMagicItem obj) : base(obj)
        {
            EquipmentCategory = TypeMaps.GetValueFromName(obj.equipment_category.name, TypeMaps.EquipmentCategoryNames);
            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];

            IsMagical = true;

            switch (obj.index)
            {
                case "bag-of-holding":
                    IsContainer = true;
                    break;
                default:
                    IsContainer = false;
                    break;
            }
        }

        //
        //  Copy Constructor
        //
        public InventoryObject(InventoryObject obj) : base(obj)
        {
            EquipmentCategory = obj.EquipmentCategory;
            Description = new string[obj.Description.Length];
            for (int i = 0; i < obj.Description.Length; i++)
                Description[i] = obj.Description[i];

            IsMagical = obj.IsMagical;
            IsContainer = obj.IsContainer;
        }
    }
}
