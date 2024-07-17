using DG.Tweening;

public class Scaler : Data
{
    protected override void Awake()
    {
        transform.DOScale(Transform, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
