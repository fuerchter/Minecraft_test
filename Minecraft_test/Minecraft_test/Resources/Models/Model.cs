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
    class Model
    {
        public static List<VertexPositionNormalTexture> vertexData = new List<VertexPositionNormalTexture>();
        public VertexBuffer vertexBuffer;

        public void SetUp() //läd vertexbuffer
    {
        vertexBuffer = new VertexBuffer(Basic.gDevice, typeof(VertexPositionNormalTexture), vertexData.Count, BufferUsage.WriteOnly);
            vertexBuffer.SetData(vertexData.ToArray());
    }

        public virtual void preRender(){}
        public void Render(Matrix world)
        {
            preRender();
        
            GameScreen.effect.World = world;

            GameScreen.effect.CurrentTechnique.Passes[0].Apply();//effect anwenden, aktualisieren

            Basic.gDevice.SetVertexBuffer(vertexBuffer);
            Basic.gDevice.DrawPrimitives(PrimitiveType.TriangleList, 0, vertexBuffer.VertexCount / 3); // da Dreiecke aus 3 ecken bestehen^^ 
        }
            public static Model floor = new FloorFace();
           // public static Model block = new Block();
    }
}
