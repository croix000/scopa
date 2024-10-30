using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scopa
{
    public class MaterialSurface : MonoBehaviour
    {
        public enum ESurface
        {
            Concrete = 0,
            Dirt = 1,
            Grass = 2,
            Metal = 3,
            Slosh = 4,
            Tile = 5,
            Wood = 6,
            Glass = 7,
            Flesh = 8,
        }

        public ESurface Surface;

    }
}