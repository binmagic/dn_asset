﻿using UnityEngine;


public class XMonster : XEntity
{

    public override void OnInitial()
    {
        _eEntity_Type |= EntityType.Monster;
        base.OnInitial();
        _layer = LayerMask.NameToLayer("Enemy");
        XAnimComponent anim = AttachComponent<XAnimComponent>();
        anim.OverrideAnim("Idle", _present.AnimLocation + _present.AttackIdle);

        string[] hits = _present.HitFly;
        string hit = hits == null || hits.Length == 0 ? null : hits[1];
        anim.OverrideAnim("HitLanding", _present.AnimLocation + hit);

        AttachComponent<XAIComponent>();
        AttachComponent<XNavComponent>();
    }


}
