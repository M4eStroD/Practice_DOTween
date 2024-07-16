using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class EditText : MonoBehaviour
{
    private const string FirstText = "���� ����� �����, ";
    private const string SecondText = "� �����";
    private const string ThirdText = "��������� �����";

    private const int Second = 1200;

    [SerializeField] private Text _text;
    [SerializeField] private float _duration; 

    private void Awake()
    {
        ChangeTextAsync();
    }

    private async void ChangeTextAsync()
    {
        _text.DOText(FirstText, _duration);
        await Task.Delay((int)(_duration * Second));

        _text.DOText(SecondText, _duration).SetRelative();
        await Task.Delay((int)(_duration * Second));

        _text.DOText(ThirdText, _duration, true, ScrambleMode.All);
        await Task.Delay((int)(_duration * Second));
    }
}
