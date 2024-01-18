using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FingerIDTracker : MonoBehaviour
{

	public int trackedFingerId;

	// �^�b�`�������Ƃ��Ďg��UnityEvent
	[Serializable]
	public class Vector3UnityEvent : UnityEvent<Vector3> { }

	// �g���b�L���O���Ă���w����ʂɐG�ꂽ�Ƃ��ɌĂяo�����
	public Vector3UnityEvent touchDetected;

	// �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
	public void Update()
	{
		int touchCount = Input.touchCount;

		for (int i = 0; i < touchCount; i++)
		{
			if (Input.GetTouch(i).fingerId == trackedFingerId)
			{
				touchDetected.Invoke(Input.GetTouch(i).position);
			}
		}
	}


}
