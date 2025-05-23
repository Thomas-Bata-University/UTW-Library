using System.Collections.Generic;

namespace Other.Template {
    public enum TankSize {

        SUPER_LIGHT,
        LIGHT,
        MEDIUM,
        HEAVY,
        SUPER_HEAVY

    }

    public class TankSizeInfo {

        public TankSize Size { get; }
        public string DisplayName { get; }
        public float LengthInMeters { get; }
        public string PrefabName { get; }

        public TankSizeInfo(TankSize size, string displayName, float length, string prefabName) {
            Size = size;
            DisplayName = displayName;
            LengthInMeters = length;
            PrefabName = prefabName;
        }

        public static readonly List<TankSizeInfo> All = new() {
            new TankSizeInfo(TankSize.SUPER_LIGHT, "Superlight – 3m", 3f, "SuperLight"),
            new TankSizeInfo(TankSize.LIGHT, "Light – 4.5m", 4.5f, "Light"),
            new TankSizeInfo(TankSize.MEDIUM, "Medium – 6.5m", 6.5f, "Medium"),
            new TankSizeInfo(TankSize.HEAVY, "Heavy – 7.5m", 7.5f, "Heavy"),
            new TankSizeInfo(TankSize.SUPER_HEAVY, "Superheavy – 10m", 10f, "SuperHeavy")
        };

        public static TankSizeInfo Get(TankSize size) {
            return All.Find(s => s.Size == size);
        }

        public static string[] GetDisplayNames() {
            return All.ConvertAll(s => s.DisplayName).ToArray();
        }

    }
}