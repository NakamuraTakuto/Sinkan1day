using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    /// <summary>左右移動する力</summary>
    [SerializeField] float YmovePower = 5f;
    [SerializeField] float XmovePower = 5f;
    [SerializeField] GameObject _actionPanel;
    bool _actionTrriger = false;
    //   [SerializeField] Countdown3 Countdown3;
    Rigidbody2D m_rb = default;
    Animator _anim;
    [SerializeField, Tooltip("水平方向の入力値")] float m_h;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 各種入力を受け取る
        // 入力を受け取る
        m_h = Input.GetAxisRaw("Vertical");
        _anim.SetFloat("Speed", XmovePower);
        var xyPower = new Vector2(XmovePower, YmovePower * m_h);
        m_rb.velocity = xyPower;

        if (Input.GetKeyUp(KeyCode.Space) && _actionTrriger)
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            //ここでヒロケンを呼び出す
        }
        if(!_actionTrriger)
        {
            gameObject.GetComponent<Collider2D>().enabled = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            _actionTrriger = true;
            _actionPanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _actionTrriger = false;
        _actionPanel.SetActive(false);
    }
}
