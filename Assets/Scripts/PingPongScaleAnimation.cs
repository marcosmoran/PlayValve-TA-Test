using UnityEngine;
using DG.Tweening;

public class PingPongScaleAnimation : MonoBehaviour
{
    public float duration = 1.0f;
    public float sizeGrowth = 0.5f;

    void Start()
    {
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = originalScale + new Vector3(sizeGrowth, sizeGrowth, sizeGrowth);

        transform.DOScale(targetScale, duration)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.InOutQuad);
    }
}