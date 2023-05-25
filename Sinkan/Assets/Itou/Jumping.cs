using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// StartJump()���Ă�ł����ƃW�����v�ł����
/// </summary>
public class Jumping : MonoBehaviour
{
    [SerializeField, Tooltip("�W�����v���鍂��")] float _jumpHigh = 2;
    [SerializeField, Tooltip("�W�����v�̑���")] float _speed = 0;
    float _sin = 0;
    Vector3 _position;
    bool _isJumping = false;
   
    private void Update()
    {
        Jump();
    }
    public void StartJump()
    {
        if (!_isJumping)
        {
            _position = gameObject.transform.position;
            _isJumping = true;
        }
    }
    void Jump()
    {
        if (!_isJumping) return;
        if (_sin < Mathf.PI)
        {
            _sin += Time.deltaTime * _speed;
            gameObject.transform.position = new Vector3(_position.x,
                                                        _position.y + Mathf.Sin(_sin) * _jumpHigh,
                                                        _position.z);
        }
        else
        {
            _sin = 0;
            _isJumping = false;
        }

    }
}
