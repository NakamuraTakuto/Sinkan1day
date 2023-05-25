using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown3 : MonoBehaviour
{
    public float CountDownTimeMax = 3;
    public float CountDownTime = 3;
    public int StylishStage = 0;
    public int StylishStageMax = 6;
    public int Score = 0;
    string[] _list = new string[] { "", "E", "D", "C", "B", "A", "S" };
    int[] _scorePoint = new int[] { 0, 100, 200, 300, 400, 500, 600 };
    float[] _pitch = new float[] { 0.5f, 0.6f, 0.8f, 1, 1.2f, 1.4f, 1.6f };
    [SerializeField] List<Color> _listColor = new List<Color>();
    [SerializeField] GameObject _slider;
    Slider _stylishSlider;
    [SerializeField] Text _stylishText;
    [SerializeField] Text _scoreText;
    [SerializeField] AudioSource _stylishAudioSource;
    [SerializeField] AudioClip _stylishAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        _stylishSlider = _slider.GetComponent<Slider>();
        _stylishSlider.maxValue = CountDownTimeMax;
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTime -= Time.deltaTime;

        if (CountDownTime < 0)
        {
            StylishStage = 0;
        }

        _stylishSlider.value = CountDownTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StylishgaugePlus();
        }

        UIs();
    }

    private void UIs()
    {
        _stylishText.text = _list[StylishStage];
        _stylishText.color = _listColor[StylishStage];
        _scoreText.text = Score.ToString();
        if (StylishStage == 0)
        {
            _slider.SetActive(false);
        }
        else
        {
            _slider.SetActive(true);
        }
    }

    public void StylishgaugePlus()
    {
        if (StylishStage < StylishStageMax)
        {
            StylishStage += 1;
        }
        _stylishAudioSource.pitch = _pitch[StylishStage];
        _stylishAudioSource.PlayOneShot(_stylishAudioClip);

        CountDownTime = CountDownTimeMax;

        Score += _scorePoint[StylishStage];
    }
}
