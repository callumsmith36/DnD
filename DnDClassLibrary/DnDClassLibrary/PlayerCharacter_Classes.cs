using DND.API;

namespace DND
{
    partial class PlayerCharacter
    {
        //
        //  GetClass
        //
        public Class? GetClass(string className)
        {
            string index = APIReadWrite.NameToIndex(className);
            foreach (var c in _classList)
            {
                if (c.Index == index)
                    return c;
            }

            return null;
        }

        //
        //  GetPrimaryClass
        //
        public Class? GetPrimaryClass()
        {
            return _classList.Count > 0 ? _classList[0] : null;
        }

        //
        //  GetClassList
        //
        public Class[] GetClassList()
        {
            return _classList.ToArray();
        }

        //
        //  GetClassLevel
        //
        public int GetClassLevel(string className)
        {
            string index = APIReadWrite.NameToIndex(className);

            for (int i = 0; i < _classList.Count; i++)
            {
                if (_classList[i].Index == index)
                    return _levelList[i];
            }

            return 0;
        }

        //
        //  SetClassLevel
        //
        public void SetClassLevel(string className, int level)
        {
            if (level < 1 || level > 20)
                return;

            string index = APIReadWrite.NameToIndex(className);
            for (int i = 0; i < _classList.Count; i++)
            {
                if (_classList[i].Index == index)
                {
                    _levelList[i] = level;
                    //UpdateProficiencyBonus();
                    OnLevelChanged?.Invoke();
                }
            }
        }

        //
        //  GetTotalLevel
        //
        public int GetTotalLevel()
        {
            int level = 0;
            foreach (var n in _levelList)
                level += n;

            return level;
        }

        //
        //  AddClass
        //
        public bool AddClass(string className, int level, bool isPrimary = false)
        {
            if (className.Length == 0 || level == 0)
                return false;

            if (GetClass(className) != null)
                return false;

            var c = APIReadWrite.GetClass(className);
            if (c != null)
            {
                if (isPrimary)
                {
                    _savingThrows.Clear();
                    foreach (var ability in c.SavingThrows)
                        AddSavingThrow(ability);
                }

                if (isPrimary && _classList.Count > 0)
                {
                    _classList.Insert(0, c);
                    _levelList.Insert(0, level);
                }
                else
                {
                    _classList.Add(c);
                    _levelList.Add(level);
                }

                _hitDiceRemaining[c] = level;

                //UpdateProficiencyBonus();
                OnLevelChanged?.Invoke();
                OnClassChanged?.Invoke();
                if (isPrimary)
                    OnPrimaryClassChanged?.Invoke();

                return true;
            }

            return false;
        }

        //
        //  RemoveClass
        //
        public bool RemoveClass(string className)
        {
            string index = APIReadWrite.NameToIndex(className);

            for (int i = 0; i < _classList.Count; i++)
            {
                if (_classList[i].Index == index)
                {
                    _hitDiceRemaining.Remove(_classList[i]);
                    _classList.RemoveAt(i);
                    _levelList.RemoveAt(i);

                    OnLevelChanged?.Invoke();
                    OnClassChanged?.Invoke();
                    return true;
                }
            }

            return false;
        }

        //
        //  LevelUp
        //
        public void LevelUp(string className = "")
        {
            if (GetTotalLevel() >= 20)
                return;

            if (className.Length == 0)
            {
                _levelList[0]++;
            }
            else
            {
                string index = APIReadWrite.NameToIndex(className);
                for (int i = 0; i < _classList.Count; i++)
                {
                    if (_classList[i].Index == index)
                        _levelList[i]++;
                }
            }

            //UpdateProficiencyBonus();
            OnLevelChanged?.Invoke();
        }

        //
        //  GetHitDiceRemaining
        //
        public int GetHitDiceRemaining(string className)
        {
            Class? c = GetClass(className);
            if (c != null && _hitDiceRemaining.TryGetValue(c, out var num) == true)
            {
                return num;
            }

            return 0;
        }

        //
        //  SetHitDiceRemaining
        //
        public void SetHitDiceRemaining(string name, int qty)
        {
            Class? c = GetClass(name);
            if (c == null || _hitDiceRemaining.ContainsKey(c) == false)
                return;

            int classLevel = GetClassLevel(name);
            qty = qty < 0 ? 0 : qty;
            qty = qty > classLevel ? classLevel : qty;

            _hitDiceRemaining[c] = qty;
        }

        //
        //  IncrementHitDiceRemaining
        //
        public void IncrementHitDiceRemaining(string name, int qty)
        {
            Class? c = GetClass(name);
            if (c == null || _hitDiceRemaining.ContainsKey(c) == false)
                return;

            int classLevel = GetClassLevel(name);
            int newValue = _hitDiceRemaining[c] + qty;
            if (newValue < 0)
                newValue = 0;
            else if (newValue > classLevel)
                newValue = classLevel;

            _hitDiceRemaining[c] = newValue;
        }

        //
        //  UpdateProficiencyBonus
        //
        private void UpdateProficiencyBonus()
        {
            int level = GetTotalLevel();

            if (level >= 1 && level < 5)
                ProficiencyBonus = 2;
            else if (level >= 5 && level < 9)
                ProficiencyBonus = 3;
            else if (level >= 9 && level < 13)
                ProficiencyBonus = 4;
            else if (level >= 13 && level < 17)
                ProficiencyBonus = 5;
            else if (level >= 17)
                ProficiencyBonus = 6;
        }
    }
}
