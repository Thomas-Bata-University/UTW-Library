using System;
using UnityEngine;

namespace Other.Template {
    [Serializable]
    public class HullData : MonoBehaviour {

        public int Mass = 1000;
        public Mesh Mesh;
        public int NumOfMat = 1;
        public Material[] Materials;
        public int NumOfCol = 1;
        public Mesh[] Colliders;

        public bool showPreview = true;
        public float trackOffset = 1f;

        public TankSize tankSize = TankSize.SUPER_LIGHT;

    }
} //END