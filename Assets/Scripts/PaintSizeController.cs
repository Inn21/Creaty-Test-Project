using PaintIn3D;
using UnityEngine;
using UnityEngine.UI;

public class PaintSizeController : MonoBehaviour
{
    [SerializeField] Slider SizeSlider;
    [SerializeField] P3dPaintSphere PaintController;

    void Awake()
    {
        ChangeColor(SizeSlider.value);
        SizeSlider?.onValueChanged.AddListener(ChangeColor);
    }

    public void ChangeColor(float value)
    {
        if (PaintController == null)
        {
            Debug.LogError($"Missing objects in {name}", this);
            Debug.Break();
            return;
        }
        PaintController.Scale = Vector3.one*value;
    }
}
