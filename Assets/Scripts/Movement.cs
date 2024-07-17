using DG.Tweening;

public class Movement : Data
{
    protected override void Awake()
    {
        transform.DOMove(Transform, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
