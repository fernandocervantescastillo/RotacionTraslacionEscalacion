using GameOpenTK.data;
using GameOpenTK.program;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Cubo : Objeto
    {

        Vector3[] vertdata;
        Vector3[] coldata;
        int[] indicedata;

        IndexArray indexArray;
        VertexArray positionIndexArray;
        VertexArray colorIndexArray;

        private void initValue(float baseX, float baseY, float baseZ)
        {
            vertdata = new Vector3[] { 
                new Vector3(0, 0,  0),
                new Vector3(baseX, 0,  0),
                new Vector3(baseX, baseY,  0),
                new Vector3(0, baseY,  0),
                new Vector3(0, 0,  baseZ),
                new Vector3(baseX, 0,  baseZ),
                new Vector3(baseX, baseY,  baseZ),
                new Vector3(0, baseY,  baseZ),
            };

            indicedata = new int[]{
                //left
                0, 2, 1,
                0, 3, 2,
                //back
                1, 2, 6,
                6, 5, 1,
                //right
                4, 5, 6,
                6, 7, 4,
                //top
                2, 3, 6,
                6, 3, 7,
                //front
                0, 7, 3,
                0, 4, 7,
                //bottom
                0, 1, 5,
                0, 5, 4
            };

            coldata = new Vector3[] { 
                new Vector3(0.5f, 0f, 0f),
                new Vector3(0.5f, 0f, 0f), 
                new Vector3(0f, 1f, 0f),
                new Vector3(0.5f, 0f, 0f),
                new Vector3(0.5f, 0f, 0f), 
                new Vector3(0f, 1f, 0f),
                new Vector3(0.5f, 0f, 0f),
                new Vector3(0.5f, 0f, 0f)
            };

        }

        public Cubo(float baseX, float baseY, float baseZ)
            : base()
        {
            initValue(baseX, baseY, baseZ);
            indexArray = new IndexArray(indicedata);
            positionIndexArray = new VertexArray();
            colorIndexArray = new VertexArray();

        }

        private void bindData(ColorShaderProgram colorShaderProgram)
        {
            positionIndexArray.setVertexAttribPointer(vertdata, colorShaderProgram.vPosition);
            colorIndexArray.setVertexAttribPointer(coldata, colorShaderProgram.vColor);

        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {

            Matrix4[] model;
            model = new Matrix4[]{
                Matrix4.Identity
            };
            model[0] = m[0] * matriz[0];

            //base.draw(model, colorShaderProgram);

            bindData(colorShaderProgram);
            GL.UniformMatrix4(colorShaderProgram.modelView, false, ref model[0]);
            GL.DrawElements(BeginMode.Triangles, indicedata.Length, DrawElementsType.UnsignedInt, 0);
        }

    }
}
