using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VolumeSO", menuName = "CustomScriptableObject/VolumeSync")]
public class VolumeSO : ScriptableObject
{
    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }

    public float value;
    public float valuesfx;
    public float valuemusic;
}