using PaintIn3D;
using UnityEngine;
using UnityEngine.UI;

public class CollorSliderController : MonoBehaviour
{
    [SerializeField] Slider CollorSlider;
    [SerializeField] P3dPaintSphere PaintController;
    [SerializeField] Image Handle;

    void Awake()
    {
        ChangeColor(CollorSlider.value);
        CollorSlider?.onValueChanged.AddListener(ChangeColor);
    }

    public void ChangeColor(float value)
    {
        if (PaintController == null || Handle == null) 
        { 
            Debug.LogError($"Missing objects in {name}",this); 
            Debug.Break();
            return; 
        }

        var color = Color.HSVToRGB(value, 1, 1);        
        PaintController.Color = Color.HSVToRGB(value, 1, 1); 
        Handle.color = Color.HSVToRGB(value, 1, 0.5f);
    }

}
