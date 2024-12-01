using System;
using Photon.Deterministic;
using Quantum.Core;
using Quantum.Physics3D;

namespace Quantum.Platformer
{
    public unsafe class FallDamageSystem : SystemMainThreadFilter<FallDamageSystem.Filter>
    {
        public struct Filter{
            public EntityRef Entity;
            public Health Health;
            public Damage Damage;
            public Transform3D* Transform3D;
            public CharacterController3D* CharacterController;
        }

        private void EntityTakeDamage(Frame f, ref Filter filter)
        {
            CharacterController3D character = f.Get<CharacterController3D>(filter.Entity);
            Damage damage = f.Get<Damage>(filter.Entity);
            if (character.Grounded == false)
            {
                var currentPosition = f.Get<Transform3D>(filter.Entity).Position.Y;
                if (damage.MaxYPossition < currentPosition)
                {
                    FP possitionY = f.Get<Transform3D>(filter.Entity).Position.Y;
                    damage.MaxYPossition = possitionY;
                    f.Set(filter.Entity, damage);
                }
            }
            else if(character.Grounded == true && damage.MaxYPossition != 0){
                if(damage.MaxYPossition >= damage.MeterEquals){
                    Health health= f.Get<Health>(filter.Entity);
                    health.Value -= damage.Value * (damage.MaxYPossition.AsInt / damage.MeterEquals.AsInt);
                    f.Set(filter.Entity, health);
                }
                damage.MaxYPossition = 0;
                f.Set(filter.Entity, damage);
            }
        }
        public override void Update(Frame f, ref Filter filter) => EntityTakeDamage(f, ref filter);
    }
}