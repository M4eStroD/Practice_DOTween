using DG.Tweening;

public class Rotate : Data
{
    protected override void Update()
    {
        transform.DORotate(Transform, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
