using UnityEngine;

namespace Other.Template {
    public class SuspensionData : DefaultData {

        public bool showPreview = true;
        public float trackOffset = 1f;
        public int wheelCount = 5;
        public float wheelSpacing = 1.0f;
        public float wheelScale = 1f;

        public TankSize tankSize = TankSize.SUPER_LIGHT;
        
        public int sprocketMass = 1000;
        public Mesh sprocketMesh;
        public int sprocketNumOfMat = 1;
        public Material[] sprocketMaterials;
        public int sprocketNumOfCol = 1;
        public Mesh[] sprocketColliders;
        public float sprocketTrackOffset = 1f;
        
        public int idlerMass = 500;
        public Mesh idlerMesh;
        public int idlerNumOfMat = 1;
        public Material[] idlerMaterials;
        public int idlerNumOfCol = 1;
        public Mesh[] idlerColliders;
        public float idlerTrackOffset = 1f;
        
    }
} //END