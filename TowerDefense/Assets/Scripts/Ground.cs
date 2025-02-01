using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Ground : MonoBehaviour
{
    private Color basicColor;
    public Color mouseEnterColor;
    
    public Material roadMaterial;
    private Material basicMaterial;
    private bool isRoad;
    private MeshRenderer meshRenderer;

    private Renderer renderer;
    
    public Transform roadParent;
    private Transform groundParent;
    

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        meshRenderer = GetComponent<MeshRenderer>();
        basicColor = renderer.material.color;
        basicMaterial = renderer.material;
        groundParent = transform.parent;
    }

    private void OnMouseDown()
    {
        if (!isRoad)
        {
            meshRenderer.material = roadMaterial;
            gameObject.tag = "Road";
            
            gameObject.transform.SetParent(roadParent);
            isRoad = true;
        } 
        else if (isRoad)
        {
            
            meshRenderer.material = basicMaterial;
            gameObject.tag = "Ground";
            
            gameObject.transform.SetParent(groundParent);
            isRoad = false;
        }
    }

    private void OnMouseEnter()
    {
        if (!isRoad)
            renderer.material.color = mouseEnterColor;
    }

    private void OnMouseExit()
    {
        if (!isRoad)
            renderer.material.color = basicColor;
    }
    
}
