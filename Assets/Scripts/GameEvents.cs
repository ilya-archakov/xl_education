using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameEvents
    {
        public static System.Action onCollisionStone;
        public static System.Action onStickHit;
        public static void CollisionStonesInvoke(Collision coliision)
        {
            onCollisionStone?.Invoke();
        }
        public static void StickHit()
        {
            onStickHit?.Invoke();
        }
    }
}
