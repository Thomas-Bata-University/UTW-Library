using System;

namespace Other.Template {
    [Serializable]
    public class HullData : DefaultData {

        public bool showPreview = true;
        public float trackOffset = 1f;

        public TankSize tankSize = TankSize.SUPER_LIGHT;

    }
} //END