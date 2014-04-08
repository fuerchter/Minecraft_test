using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Minecraft_test
{
    class FloorFace: Model
    {
        public FloorFace() //2 Dreiecke
        {
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, 0.5f),  Vector3.Up, new Vector2(0,1)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, -0.5f),  Vector3.Up, new Vector2(0,0)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f, -0.5f, -0.5f),  Vector3.Up, new Vector2(1,0)));

            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f, -0.5f, -0.5f), Vector3.Up, new Vector2(1,0)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f,  -0.5f, 0.5f), Vector3.Up, new Vector2(1,1)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, 0.5f), Vector3.Up, new Vector2(0,1)));
           
            SetUp();
          
    }
    }
}
