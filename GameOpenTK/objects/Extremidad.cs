using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Extremidad : Objeto
    {
        Cubo mano;
        Cubo brazo;
        Cubo antebrazo;

        public Extremidad(float espesor, float ancho, float largoBrazo, float largoAnteBrazo, float largoMano)
            : base()
        {
            brazo = new Cubo(espesor, largoBrazo, ancho);
            antebrazo = new Cubo(espesor, largoAnteBrazo, ancho);
            mano = new Cubo(espesor, largoMano, ancho);

            addObjecto(brazo, "brazo");
            addObjecto(antebrazo, "antebrazo");
            addObjecto(mano, "mano");

            brazo.trasladar(0f, largoAnteBrazo + largoMano, 0f);
            antebrazo.trasladar(0, largoMano, 0f);
            mano.trasladar(0f, 0f, 0f);

        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {
            base.draw(matriz, colorShaderProgram);
        }
    }
}
