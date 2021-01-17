using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Silla : Objeto
    {
        Mesa mesa;
        Cubo pata1;
        Cubo pata2;
        Cubo pata3;

        public Silla(float anchoPata, float alturaPata, float anchoSilla, float largoSilla, float espesorSilla, float alturaRespaldo)
            : base()
        {
            mesa = new Mesa(anchoPata, alturaPata, anchoSilla, largoSilla, espesorSilla);
            pata1 = new Cubo(anchoPata, alturaRespaldo, anchoPata);
            pata2 = new Cubo(anchoPata, alturaRespaldo, anchoPata);
            pata3 = new Cubo(anchoPata, anchoPata, anchoSilla - 2 * anchoPata);

            addObjecto(pata1, "pata1");
            addObjecto(pata2, "pata2");
            addObjecto(pata3, "pata3");
            addObjecto(mesa, "mesa");

            pata1.trasladar(0f, alturaPata + espesorSilla, 0f);
            pata2.trasladar(0f, alturaPata + espesorSilla, anchoSilla - anchoPata);
            pata3.trasladar(0f, alturaPata + espesorSilla + alturaRespaldo - anchoPata, anchoPata);
            mesa.trasladar(0f, 0, 0f);
        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {
            base.draw(matriz, colorShaderProgram);
        }
    }
}
