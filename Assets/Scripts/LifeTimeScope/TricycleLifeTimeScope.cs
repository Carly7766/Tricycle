using Input;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LifeTimeScope
{
    public class TricycleLifeTimeScope : LifetimeScope
    {
        [SerializeField] private Transform backTire = default;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PCInputProvider>(Lifetime.Scoped).AsImplementedInterfaces();
            builder.RegisterComponent<WheelJoint2D>(backTire.GetComponent<WheelJoint2D>());
            builder.RegisterEntryPoint<TricycleMover>(Lifetime.Scoped);
        }
    }
}
