using System;

namespace Input
{
    public interface IInputProvider
    {
        IObservable<bool> GetJump();
        IObservable<float> GetMoveDirection();
    }
}
