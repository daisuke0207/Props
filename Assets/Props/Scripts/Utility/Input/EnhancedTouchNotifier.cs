using UniTaskPubSub;
using UniTaskPubSub.AsyncEnumerable;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

namespace Props.Utility.Input
{
    public class EnhancedTouchNotifier : MonoBehaviour
    {
        public readonly AsyncEnumerableMessageBus FingerMoveMessageBus = new();
        public readonly AsyncMessageBus FingerDownMessageBus = new();
        public readonly AsyncMessageBus FingerUpMessageBus = new();
        
        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            // EnhancedTouchの有効化
            EnhancedTouchSupport.Enable();
            // イベント処理
            // 指を離した時
            Touch.onFingerUp += OnFingerUp;
            // 指が触れた時
            Touch.onFingerDown += OnFingerDown;
            // 指を動かした（ドラッグ）時
            Touch.onFingerMove += OnFingerMove;
        }

        private void OnFingerDown(Finger finger)
        {
            FingerDownMessageBus.Publish(finger.screenPosition);
        }

        private void OnFingerMove(Finger finger)
        {
            FingerMoveMessageBus.Publish(finger.screenPosition);
        }
        
        private void OnFingerUp(Finger finger)
        {
            FingerUpMessageBus.Publish(finger.screenPosition);
        }
    }
}