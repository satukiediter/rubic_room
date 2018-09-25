using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazerpointer : MonoBehaviour {
    [SerializeField]
    private Transform _RightHandAnchor; // 右手

    [SerializeField]
    private Transform _LeftHandAnchor;  // 左手

    [SerializeField]
    private Transform _CenterEyeAnchor; // 目の中心

    [SerializeField]
    private float _MaxDistance = 100.0f; // 距離

    [SerializeField]
    private LineRenderer _LaserPointerRenderer; // LineRenderer

    [SerializeField]
    GameObject maincamera;

    public GameObject obj;

    public Material Select1;

    GameObject T;

    // コントローラー
    public Transform Pointer
    {
        get
        {
            // 現在アクティブなコントローラーを取得
            var controller = OVRInput.GetActiveController();
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                return _RightHandAnchor;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                return _LeftHandAnchor;
            }
            // どちらも取れなければ目の間からビームが出る
            return _CenterEyeAnchor;
        }
    }

    private void Start()
    {
        T = GameObject.Find("Gamedirector");
    }

    void Update()
    {
        // 現在アクティブなコントローラーを取得
        var controller = OVRInput.GetActiveController();
        var pointer = Pointer; // コントローラーを取得
                               // コントローラーがない or LineRendererがなければ何もしない
        if (pointer == null || _LaserPointerRenderer == null)
        {
            return;
        }
        // コントローラー位置からRayを飛ばす
        Ray pointerRay = new Ray(pointer.position, pointer.forward);

        // レーザーの起点
        _LaserPointerRenderer.SetPosition(0, pointerRay.origin);

        RaycastHit hitInfo;

        if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance))
        {
            // Rayがヒットしたらそこまで
            _LaserPointerRenderer.SetPosition(1, hitInfo.point);
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                obj = hitInfo.collider.gameObject;
                Select1 = hitInfo.collider.gameObject.GetComponent<Renderer>().material;
            }
            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
            {
                Material Select2 = hitInfo.collider.gameObject.GetComponent<Renderer>().material;
                hitInfo.collider.gameObject.GetComponent<Renderer>().material = Select1;
                obj.GetComponent<Renderer>().material = Select2;
                T.GetComponent<textmaneger>().count += 1;
            }

        }
        else
        {
            // Rayがヒットしなかったら向いている方向にMaxDistance伸ばす
            _LaserPointerRenderer.SetPosition(1, pointerRay.origin + pointerRay.direction * _MaxDistance);
        }

    }
}
