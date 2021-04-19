using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class FadeInOutText : MonoBehaviour
{
    [SerializeField] float defaultTime = 2;
    Color initialColor;
    Text text;

    
    void Start()
    {
        text = GetComponent<Text>();
        initialColor = text.color;
    }


    public void FadeIn(float _time = 1)
    {
        CancelInvoke();
        Invoke("ToogleTextComponent", _time);
        text.CrossFadeAlpha(255f, _time, false);
    }

    public void FadeOut(float _time = 1)
    {
        CancelInvoke();
        Invoke("ToogleTextComponent", _time);
        text.CrossFadeAlpha(0f, _time, false);
    }

    public void ToogleTextComponent()
    {
        text.enabled = !text.isActiveAndEnabled;
    }

}
