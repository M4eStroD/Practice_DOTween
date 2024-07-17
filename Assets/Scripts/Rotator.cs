using DG.Tweening;

public class Rotator : Data
{
    protected override void Awake()
    {
        transform.DORotate(Transform, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
