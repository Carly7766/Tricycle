using Input;
using UniRx;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class TricycleMover : IInitializable, ITickable
{
    private readonly IInputProvider _inputProvider;
    private readonly WheelJoint2D _wheelJoint;
    private readonly float _speed = 500;

    [Inject]
    public TricycleMover(IInputProvider inputProvider, WheelJoint2D wheelJoint)
    {
        _inputProvider = inputProvider;
        _wheelJoint = wheelJoint;
    }

    public void Initialize()
    {
        _inputProvider.GetJump().Subscribe(_ => { Debug.Log(_); });

        _inputProvider.GetMoveDirection().Subscribe(axis =>
        {
            var motor = _wheelJoint.motor;
            motor.motorSpeed = axis * _speed;

            _wheelJoint.motor = motor;
        });
    }

    public void Tick()
    {
    }
}
