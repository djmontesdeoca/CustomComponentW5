using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPulse : MonoBehaviour
{
    [Header("Opacity Params")]
    public float maxOpac;
    public float minOpac; 
    public float opacStep;

    [Header("renderer and material refs")]
    public MeshRenderer objRenderer;
    public Material objMaterial;

    private Color tempColor;

    // Start is called before the first frame update
    void Start()
    {
        // get a reference to the mesh renderer attached to this obj
        objRenderer = gameObject.GetComponent<MeshRenderer>();
        objMaterial = objRenderer.material;

        tempColor = new Color(objMaterial.color.r, objMaterial.color.g, objMaterial.color.b, objMaterial.color.a);
    }

    // Update is called once per frame
    void Update()
    {
        // if opacity reached bounds, reverse the step
        if (tempColor.a <= minOpac || tempColor.a >= maxOpac)
            opacStep *= -1;
        tempColor.a += opacStep;
        objMaterial.SetColor("_Color", tempColor);
    }
}
