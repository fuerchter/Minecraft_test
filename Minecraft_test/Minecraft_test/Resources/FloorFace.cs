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
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(0.0f, 1.0f, 0.0f), new Vector2(0.0f, 1.0f)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, -0.5f),new Vector3(0.0f, 1.0f, 0.0f)  , new Vector2(0.0f,0.0f)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f, -0.5f, -0.5f),new Vector3(0.0f, 1.0f, 0.0f)  , new Vector2(1.0f,0.0f)));

            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f, -0.5f, -0.5f),new Vector3(0.0f, 1.0f, 0.0f) , new Vector2(1.0f,0.0f)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3( 0.5f,  -0.5f, 0.5f),new Vector3(0.0f, 1.0f, 0.0f) , new Vector2(1.0f,1.0f)));
            vertexData.Add(new VertexPositionNormalTexture(new Vector3(-0.5f, -0.5f, 0.5f),new Vector3(0.0f, 1.0f, 0.0f) , new Vector2(0.0f,1.0f)));
           
            SetUp();
          
    }
    }
}
