using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Pierna : Objeto
    {
        Cubo muslo;
        Cubo pierna;
        Cubo pie;

        public Pierna(float espesor, float ancho, float largoMuslo, float largoPierna, float largoPie)
            : base()
        {
            muslo = new Cubo(espesor, largoMuslo, ancho);
            pierna = new Cubo(espesor, largoPierna, ancho);
            pie = new Cubo(espesor, largoPie, ancho);

            addObjecto(muslo, "muslo");
            addObjecto(pierna, "pierna");
            addObjecto(pie, "pie");

            muslo.trasladar(0f, largoPierna + largoPie, 0f);
            pierna.trasladar(0, largoPie, 0f);
            pie.trasladar(0f, 0f, 0f);

        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {
            base.draw(matriz, colorShaderProgram);
        }
    }
}
