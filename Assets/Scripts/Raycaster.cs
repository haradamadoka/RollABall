using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycaster : MonoBehaviour
{
    // �J�����ւ̃A�N�Z�X
    public Camera usedCamera;

    // ���̃��C�L���X�g�̑ΏۂƂȂ郌�C���[
    public LayerMask layers;

    // �L���X�g�̍ő勗��
    public float raycastDistance = 10.0f;

    // �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
    public void OnEnable()
    {
        if (!usedCamera)
        {
            usedCamera = Camera.main;
        }
    }

    // ���t���[���Ăяo�����
    public void DrawRay(Vector3 clickPosition)
    {
        // mousePosition���烌�C���쐬
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);

        // Ray�ƈ�v�������`��
        Debug.DrawRay(ray.origin, ray.direction);
    }



    // �^�b�`�������Ƃ��Ďg��UnityEvent
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }

    // �g���b�L���O���Ă���w����ʂɐG�ꂽ�Ƃ��ɌĂяo�����
    public StringUnityEvent hitDetected;

    // �c�N���X�Ɋ����̂��̑����\�b�h�c 
    // ���C�L���X�g�����s���A���X�|���X�Ƃ��ăC�x���g�𑗐M
    public void Raycast(Vector3 clickPosition)
    {
        RaycastHit hit;
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);

        if (Physics.Raycast(ray, out hit, raycastDistance, layers))
        {
            hitDetected.Invoke(hit.transform.name);
        }

}
public void Update()
    {
        Raycast(Input.mousePosition);
    }
}
