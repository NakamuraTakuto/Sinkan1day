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
    string[] _list = new string[] { "", "E", "D", "C", "B", "A", "S" };
    [SerializeField] List<Color> _listColor = new List<Color>();
    [SerializeField] Slider _stylishSlider;
    [SerializeField] Text _stylishText;
    // Start is called before the first frame update
    void Start()
    {
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

        _stylishText.text = _list[StylishStage];
        _stylishText.color = _listColor[StylishStage];
    }

    public void StylishgaugePlus()
    {
        if (StylishStage < StylishStageMax)
        {
            StylishStage += 1;
            CountDownTime = CountDownTimeMax;
        }


    }
}
