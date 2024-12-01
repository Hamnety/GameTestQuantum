using Photon.Deterministic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Platformer
{
    public unsafe class DeathCharacterSystem : SystemMainThreadFilter<DeathCharacterSystem.Filter>
    {
        public struct Filter{
            public EntityRef Entity;
            public Health Health;
            public Damage Damage;
            public CharacterController3D* CharacterController;
        }

        private void EntityDeath(Frame f, ref Filter filter){
            Health characterHealth = f.Get<Health>(filter.Entity);
            if(characterHealth.Value <= 0){
                f.Destroy(filter.Entity);
            }
        }
        public override void Update(Frame f, ref Filter filter) => EntityDeath(f, ref filter);
    }
}
