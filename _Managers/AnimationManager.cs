﻿using SideScrollShooter._Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    public class AnimationManager
    {
        private Dictionary<object, Animation> _anims = new();
        private object _lastKey;

        public void AddAnimation(object key, Animation animation)
        {
            _anims.Add(key, animation);
            _lastKey ??= key;
        }

        public void Update(object key)
        {
            if (_anims.TryGetValue(key, out Animation animation))
            {
                animation.Start();
                _anims[key].Update();
                _lastKey = key;
            }
            else
            {
                _anims[_lastKey].Stop();
                _anims[_lastKey].Reset();
            }    
        }

        public void Draw(Vector2 position)
        {
            _anims[_lastKey].Draw(position);
        }
    }
}
