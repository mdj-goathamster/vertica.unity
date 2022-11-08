using UnityEngine;

namespace @_
{
    [CreateAssetMenu(menuName = "_/Settings/Unit Settings", fileName = "Unit Settings", order = 0)]
    public class UnitSettingsAsset : ScriptableObject
    {
        [SerializeField]
        private UnitSettings _settings;
        
        public static implicit operator UnitSettings(UnitSettingsAsset self)
        {
            return self._settings;
        }
    }
}