using GameOpenTK.program;
using GameOpenTK.util;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Escenario : Objeto
    {

        ColorShaderProgram colorShaderProgram;

        Robot robot;
        Silla silla;


        public Escenario()
        {

            String vertexCode = TextResourceReader.readTextFileFromResource("../../shaders/vs.glsl");
            String fragmentCode = TextResourceReader.readTextFileFromResource("../../shaders/fs.glsl");

            colorShaderProgram = new ColorShaderProgram(vertexCode, fragmentCode);

            trasladar(-0.2f, 0.0f, 0.4f);


            robot = new Robot(0.2f, 0.2f, 0.5f, 0.4f, 0.2f, 0.4f, 0.3f, 0.2f, 0.7f, 0.7f, 0.2f, 0.4f, 0.3f, 0.7f, 0.2f, 0.4f);
            robot.trasladar(0, -1.5f, 0);
            robot.escalar(1.5f, 1.5f, 1.5f);

            addObjecto(robot, "Robot");


        }



        public void draw(Matrix4[] matriz)
        {
            colorShaderProgram.enableShader();
            colorShaderProgram.useProgram();

            base.draw(matriz, colorShaderProgram);

            robot.rotar(0.02f, 0f, 0f);
            robot.girarBrazo1(0, 0, 0.05f);
            robot.girarBrazo2(0, 0, -0.05f);


            colorShaderProgram.disableShader();
        }


    }
}
