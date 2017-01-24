using UnityEngine;
using UnityEditor;
using UnityEditor.UI;
using System;

//[Serializable]
//[CustomEditor(typeof(FaceShapeDrivers))]
public class FaceShapeDriversEd : Editor
{
    //SkinnedMeshRenderer skinnedMeshRenderer;
    //int maxShapes;
    //[SerializeField]
    //public SkinnedMeshRenderer SkinnedMeshRenderer { get { return skinnedMeshRenderer; } }
    //public int MaxShapes { get { return maxShapes; } }

    //new FaceShapeDrivers target { get { return base.target as FaceShapeDrivers; } }
    //[SerializeField]
    //public float fScale;
    //[SerializeField]
    //public float gScale;
    //public float furyScale;
    //public float glareScale;
    //public override void OnInspectorGUI()
    //{        
    //    DrawDefaultInspector();
    //    fScale = EditorGUILayout.Slider("Furious", furyScale, 0f, 100f);
    //    
    //    gScale = EditorGUILayout.Slider("Glare", glareScale, 0f, 100f);
    //    for (int ix = 0; ix < target.target.Length; ix++)
    //    {
    //        skinnedMeshRenderer = ((target.target[ix] ?? target.gameObject).GetComponent<SkinnedMeshRenderer>());
    //        if (skinnedMeshRenderer == null)
    //            return;

    //        maxShapes = skinnedMeshRenderer.sharedMesh.blendShapeCount;

    //        if (fScale != furyScale)
    //        {
    //            SetFuryExpression();
    //            if (ix == target.target.Length -1)
    //               target.number = furyScale = fScale;
    //        }
            
    //        else if (gScale != glareScale)
    //        {
    //            SetGlareExpression();
    //            if (ix == target.target.Length - 1)
    //                target.number = glareScale = gScale;
    //        }
    //    }

    //}

    //private void SetGlareExpression()
    //{
    //    ModifyGlareValues("Facial_Blends.BrowsDown_Left", 98);
    //    ModifyGlareValues("Facial_Blends.BrowsDown_Right", 83);
    //    ModifyGlareValues("Facial_Blends.BrowsIn_Left", 98);
    //    ModifyGlareValues("Facial_Blends.BrowsIn_Right", 83);
    //    ModifyGlareValues("Facial_Blends.NoseScrunch_Left", 39);
    //    ModifyGlareValues("Facial_Blends.NoseScrunch_Right", 47);
    //    ModifyGlareValues("Facial_Blends.Squint_Right", 72);
    //    ModifyGlareValues("Facial_Blends.Squint_Left", 65);
    //}

    //private void SetFuryExpression()
    //{
    //    ModifyFuryValues("Facial_Blends.BrowsDown_Left", 98);
    //    ModifyFuryValues("Facial_Blends.BrowsDown_Right", 83);
    //    ModifyFuryValues("Facial_Blends.BrowsIn_Left", 98);
    //    ModifyFuryValues("Facial_Blends.BrowsIn_Right", 83);
    //    ModifyFuryValues("Facial_Blends.LowerLipOut", 89);
    //    ModifyFuryValues("Facial_Blends.MouthOpen", 100);
    //    ModifyFuryValues("Facial_Blends.MouthUp", 30);
    //    ModifyFuryValues("Facial_Blends.Smile_Left", 35);
    //    ModifyFuryValues("Facial_Blends.NoseScrunch_Left", 39);
    //    ModifyFuryValues("Facial_Blends.NoseScrunch_Right", 47);
    //    ModifyFuryValues("Facial_Blends.Squint_Right", 72);
    //    ModifyFuryValues("Facial_Blends.Squint_Left", 65);
    //}

    //void ModifyFuryValues(string blendShapeName, float blendShapeMaxValue)
    //{
    //    int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
    //    if (index != -1)
    //        skinnedMeshRenderer.SetBlendShapeWeight(index, furyScale * (blendShapeMaxValue / 100));
    //}
    //void ModifyGlareValues(string blendShapeName, float blendShapeMaxValue)
    //{
    //    int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
    //    if (index != -1)
    //        skinnedMeshRenderer.SetBlendShapeWeight(index, glareScale * (blendShapeMaxValue / 100));
    //}
}

//

