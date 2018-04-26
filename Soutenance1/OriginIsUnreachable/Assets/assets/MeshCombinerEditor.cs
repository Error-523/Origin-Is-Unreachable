using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

[CustomEditor (typeof (AdvancedMerge))]
public class MeshCombinerEditor : Editor {

    

    void OnSceneGUI()
    {
        AdvancedMerge am = target as AdvancedMerge;
        if (Handles.Button(am.transform.position + Vector3.up * 5, Quaternion.LookRotation(Vector3.up), 1, 1, Handles.CubeHandleCap))
            am.AdvanceMerge();
    }
}
