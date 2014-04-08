using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Minecraft_test.Entity
{
    class Entity
    {
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale = new Vector3(1);

        public Entity(float x, float y, float z)
        {
            position = new Vector3(x, y, z);
        }
        public virtual void Update() { }

        public void Draw()
        {
        }
    }
}
