using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Mesa : Objeto
    {
        Cubo pata1;
        Cubo pata2;
        Cubo pata3;
        Cubo pata4;
        Cubo mesa;

        public Mesa(float anchoPata, float alturaPata, float anchoMesa, float largoMesa, float espesorMesa)
            : base()
        {
            pata1 = new Cubo(anchoPata, alturaPata, anchoPata);
            pata2 = new Cubo(anchoPata, alturaPata, anchoPata);
            pata3 = new Cubo(anchoPata, alturaPata, anchoPata);
            pata4 = new Cubo(anchoPata, alturaPata, anchoPata);
            mesa = new Cubo(anchoMesa, espesorMesa, largoMesa);

            addObjecto(pata1, "pata1");
            addObjecto(pata2, "pata2");
            addObjecto(pata3, "pata3");
            addObjecto(pata4, "pata4");
            addObjecto(mesa, "mesa");

            pata1.trasladar(0f, 0f, 0f);
            pata2.trasladar(anchoMesa - anchoPata, 0f, 0f);
            pata3.trasladar(0, 0f, largoMesa - anchoPata);
            pata4.trasladar(anchoMesa - anchoPata, 0f, largoMesa - anchoPata);
            mesa.trasladar(0f, alturaPata, 0f);
        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {
            base.draw(matriz, colorShaderProgram);
        }
    }
}
