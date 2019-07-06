using UnityEngine;

public class PostShadow : MonoBehaviour
{
    public GameObject renderTarget;

    protected Renderer[] _rendererComponents;

    // Use this for initialization
    void Start()
    {
        _rendererComponents = renderTarget.GetComponentsInChildren<Renderer>();
    }

    void OnPreRender()
    {
        foreach (var renderer in _rendererComponents)
        {
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        }
    }
    void OnPostRender()
    {
        foreach (var renderer in _rendererComponents)
        {
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }
}