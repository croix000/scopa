using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Scopa
{
    [CreateAssetMenu(fileName = "New Materials Surface Data", menuName = "Scopa/Surface Data", order = 1)]
    public class MaterialsSurfaceData : ScriptableObject
    {
        
        [System.Serializable]
        public struct MaterialSurfacePair
        {
            [FoldoutGroup("$GetMaterialName")]
            [HorizontalGroup("$GetMaterialName/h")]
            [OnInspectorGUI("DrawPreview", true)]
            public Material material;
            [FoldoutGroup("$GetMaterialName")]
            [HorizontalGroup("$GetMaterialName/h")]
            public MaterialSurface.ESurface surface;

            string GetMaterialName => material ? material.name + "   |   " + surface.ToString(): "-Undefined-";


            private void DrawPreview()
            {
                if (this.material == null) return;

                GUILayout.BeginVertical(GUI.skin.box);
                GUILayout.Label(this.material.mainTexture, GUILayout.Height(64), GUILayout.Width(64));
                GUILayout.EndVertical();
            }


        }

        //[ListDrawerSettings(ShowFoldout = true)]
        public List<MaterialSurfacePair> Materials;

        public MaterialSurface.ESurface GetSurface(Material _mat)
        {

            for (int i = 0; i < Materials.Count; i++)
            {

                if (Materials[i].material == _mat)
                {
                    return Materials[i].surface;
                }

            }

            return MaterialSurface.ESurface.Concrete;

        }

    }
}