// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AI.Runtime {
    using UnityEngine;
    
    
    public class AIRuntimeNavToTarget : AIRunTimeBase {
        
        public GameObject mAIArgTarget;
        
        public GameObject mAIArgNavTarget;
        
        public Vector3 mAIArgNavPos;
        
        public override AIRuntimeStatus OnTick(XEntity entity) {
			return AITreeImpleted.NavToTargetUpdate(entity, mAIArgTarget, mAIArgNavTarget, mAIArgNavPos);
        }
    }
}