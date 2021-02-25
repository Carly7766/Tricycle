using System;
using UniRx;

namespace Input
{
    public class PCInputProvider : IInputProvider
    {
        public IObservable<bool> GetJump()
        {
            return Observable.EveryUpdate()
                .Select(_ => UnityEngine.Input.GetButtonDown("Jump"));
        }

        public IObservable<float> GetMoveDirection()
        {
            return Observable.EveryUpdate().Select(_ => UnityEngine.Input.GetAxis("Horizontal"));
        }
    }
}
