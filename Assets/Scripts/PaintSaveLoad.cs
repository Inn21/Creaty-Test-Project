using PaintIn3D;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSaveLoad : MonoBehaviour
{
    [SerializeField] string SaveName;
    [SerializeField] P3dPaintableTexture texture;

    private void Awake()
    {
        if (texture == null)
        {
            Debug.LogError($"Missing objects in {name}", this);
            Debug.Break();
            return;
        }
    }
    public void Clear() => P3dPaintableTexture.ClearSave(SaveName);
    public void Save()
    {
        texture?.Save(SaveName);
        print("Texture is savede!");
    }    
    public void Load()
    {       
        texture?.Load(SaveName);
        print("Texture is Loaded!");
    }

}
