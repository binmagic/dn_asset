﻿using UnityEngine;

public class XCamera : XObject
{

    private XEntity _target = null;
    private GameObject _dummyObject = null;
    private Transform _dummyCamera = null;
    private Transform _cameraTransform = null;
    private Camera _camera;
    private GameObject _cameraObject = null;
    private Animator _ator = null;
    private AnimatorOverrideController _overrideController;

    private string _trigger = null;

    //basic root
    private bool _pos_inited = false;
    private float _angle_x = 0;
    private float _angle_y = 0;
    private Quaternion _root_quat = Quaternion.identity;

    //position & rotation
    private Vector3 _dummyCamera_pos = Vector3.zero;
    private Quaternion _dummyCamera_quat = Quaternion.identity;

    private XCameraActionComponent _act_component;
    private XCameraCloseUpComponent _close_component;


    public Transform CameraTrans { get { return _cameraTransform; } }

    public GameObject CameraObject { get { return _camera.gameObject; } }

    public Vector3 Position { get { return _cameraTransform.position; } }

    public Quaternion Rotaton { get { return _cameraTransform.rotation; } }

    public Camera UnityCamera { get { return _camera; } }

    public Animator Ator { get { return _ator; } }

    public XEntity Target
    {
        get { return (_target == null || _target.Deprecated) ? null : _target; }
        set { _target = value; }
    }

    public float Root_R_X { get { return _root_quat.eulerAngles.x; } }

    public float Root_R_Y { get { return _root_quat.eulerAngles.y; } }

    public void Initial(GameObject camera)
    {
        base.Initilize();
        _cameraObject = camera;
        _cameraTransform = camera.transform;
        if (_cameraObject != null)
        {
            _camera = _cameraObject.GetComponent<Camera>();
            _camera.enabled = true;

            if (_dummyObject == null)
            {
                _dummyObject = XResources.Load<GameObject>("Prefabs/DummyCamera", AssetType.Prefab);
                _dummyObject.name = "Dummy Camera";
            }
            _dummyCamera = _dummyObject.transform.GetChild(0);
            _ator = _dummyObject.GetComponent<Animator>();
            if (_overrideController == null)
            {
                _overrideController = new AnimatorOverrideController();
            }
            _overrideController.runtimeAnimatorController = _ator.runtimeAnimatorController;
            _ator.runtimeAnimatorController = _overrideController;
        }
    }

    public void OnEnterSceneFinally()
    {
        _target = XEntityMgr.singleton.Player;
        _act_component = new XCameraActionComponent();
        _act_component.OnInitial(this);
        _close_component = new XCameraCloseUpComponent();
        _close_component.OnInitial(this);
    }

    public void Uninitial()
    {
        _camera = null;
        _angle_x = 0;
        _angle_y = 0;
        _pos_inited = false;
        _overrideController = null;
        _target = null;
        GameObject.Destroy(_dummyObject);
        _act_component.OnUninit();
        _close_component.OnUninit();
        base.Unload();
    }

    public void Update(float delta)
    {
        if (_act_component != null)
        {
            _act_component.Update(delta);
        }
    }

    public void LateUpdate()
    {
        if (!_pos_inited)
        {
            _root_quat = Quaternion.identity;
            _pos_inited = true;
        }
        InnerUpdateEx();
    }

    private void InnerUpdateEx()
    {
        Vector3 forward = Vector3.Cross(_dummyCamera.forward, _dummyCamera.up);
        _dummyCamera_quat = Quaternion.LookRotation(forward, _dummyCamera.up);
        _cameraTransform.rotation = _root_quat * _dummyCamera_quat;

        Vector3 _dir = _dummyCamera.position - _dummyObject.transform.position;
        float _dis = _dir.magnitude;
        _dir.Normalize();
        if (_dis <= 0) _dis = 0.1f;
        _dummyCamera_pos = _root_quat * (_dis * _dir) + _dummyObject.transform.position;
        _cameraTransform.position = _dummyCamera_pos + (_target != null ? _target.Position : Vector3.zero);
        LookAtTarget();
    }

    public void Effect(string motion, string trigger)
    {
        _root_quat = Quaternion.identity;
        AnimationClip clip = XResources.Load<AnimationClip>(motion, AssetType.Anim);
        if (clip != null)
        {
            _trigger = trigger;
            if (_overrideController["CameraEffect"] != clip)
                _overrideController["CameraEffect"] = clip;
        }
    }

    public void ResetIdle()
    {
        if (_ator != null)
            _ator.SetTrigger(CameraTrigger.ToIdle.ToString());
    }

    public void TriggerEffect()
    {
        if (_trigger != null && !_ator.IsInTransition(0))
        {
            _ator.SetTrigger(_trigger);
            _trigger = null;
        }
    }

    public void XRotate(float addation)
    {
        if (addation != 0 && _target != null)
        {
            _angle_x += addation;
            ReCaleRoot();
        }
    }

    public void YRotate(float addation)
    {
        if (addation != 0 && _target != null)
        {
            _angle_y += addation;
            ReCaleRoot();
        }
    }

    public void XRotateEx(float x)
    {
        if (_target != null)
        {
            _angle_x = x;
            ReCaleRoot();
        }
    }

    public void YRotateEx(float y)
    {
        if (_target != null)
        {
            _angle_y = y;
            ReCaleRoot();
        }
    }

    public void ReCaleRoot()
    {
        _root_quat = Quaternion.Euler(_angle_x, _angle_y, 0);
    }

    public void LookAtTarget()
    {
        if (_target != null)
        {
            Vector3 pos = _target.Position + _dummyObject.transform.position;
            _cameraTransform.LookAt(pos);
        }
    }

    public bool IsVisibleFromCamera(XEntity entity, bool fully)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(_camera);
        return entity.TestVisible(planes, fully);
    }

    public void OverrideAnimClip(string motion, AnimationClip clip)
    {
        if (clip != null)
        {
            if (_overrideController[motion] != clip)
                _overrideController[motion] = clip;
        }
        else
        {
            _overrideController[motion] = null;
        }
    }

    public void SetCameraLayer(int layer, bool show)
    {
        if (show)
        {
            _camera.cullingMask |= 1 << layer;
        }
        else
        {
            _camera.cullingMask &= ~(1 << layer);
        }
    }

    public void SetCameraLayer(int layermask)
    {
        _camera.cullingMask = layermask;
    }

    public int GetCameraLayer()
    {
        return _camera.cullingMask;
    }

    public void SetSolidBlack(bool enabled)
    {
        if (enabled)
        {
            _camera.clearFlags = CameraClearFlags.SolidColor;
            _camera.backgroundColor = Color.black;
        }
        else
        {
            _camera.clearFlags = CameraClearFlags.Skybox;
        }
    }


}
