using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Editor : MonoBehaviour
{
    private const string FirstText = "Есть такой текст, ";
    private const string SecondText = "и такой";
    private const string ThirdText = "Последний текст";

    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    Sequence _sequence;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText(FirstText, _duration).SetEase(Ease.Linear));
        _sequence.Append(_text.DOText(SecondText, _duration).SetRelative().SetEase(Ease.Linear));
        _sequence.Append(_text.DOText(ThirdText, _duration, true, ScrambleMode.All).SetEase(Ease.Linear));
        _sequence.SetLoops(-1, LoopType.Restart);
    }
}
