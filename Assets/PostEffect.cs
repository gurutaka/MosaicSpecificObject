using UnityEngine;

public class PostEffect : MonoBehaviour
{
    public Material mosaic;

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, mosaic);
    }
}