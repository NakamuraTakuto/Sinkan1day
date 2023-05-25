using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Countdown3 _countdown;
    [SerializeField] Text _score;

    private void OnEnable()
    {
        _score.text = _countdown.Score.ToString();
    }
}
