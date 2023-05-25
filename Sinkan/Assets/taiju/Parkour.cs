using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    /// <summary>左右移動する力</summary>
    [SerializeField] float YmovePower = 5f;
    [SerializeField] float XmovePower = 5f;
    //   [SerializeField] Countdown3 Countdown3;
    Rigidbody2D m_rb = default;
    [SerializeField, Tooltip("水平方向の入力値")] float m_h;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 各種入力を受け取る
        // 入力を受け取る
        m_h = Input.GetAxisRaw("Vertical");

        m_rb.velocity = new Vector2(XmovePower, YmovePower * m_h);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //         Countdown3.StylishgaugePlus();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        OnTriggerStay(other);
    }
}
