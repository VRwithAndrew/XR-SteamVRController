using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material otherMaterial = null;

    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    public void SetOtherMaterial()
    {
        meshRenderer.material = otherMaterial;
    }

    public void SetOriginalMaterial()
    {
        meshRenderer.material = originalMaterial;
    }
}
