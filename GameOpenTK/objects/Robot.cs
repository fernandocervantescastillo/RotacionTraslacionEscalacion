using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    class Robot : Objeto
    {
        Cubo cabeza;
        Cubo cuello;
        Cubo torso;
        Cubo vientre;
        Pierna pierna1;
        Pierna pierna2;
        Brazo brazo1;
        Brazo brazo2;


        public Robot(float espesor, float anchoExtremidad, float largoMuslo, float largoPierna, float largoPie,
            float largoBrazo, float largoAnteBrazo, float largoMano,
            float anchoVientre, float anchoTorso, float anchoCuello, float anchoCabeza,
            float largoVientre, float largoTorso, float largoCuello, float largoCabeza)
            : base()
        {

            pierna1 = new Pierna(espesor, anchoExtremidad, largoMuslo, largoPierna, largoPie);
            pierna2 = new Pierna(espesor, anchoExtremidad, largoMuslo, largoPierna, largoPie);
            brazo1 = new Brazo(espesor, anchoExtremidad, largoBrazo, largoAnteBrazo, largoMano);
            brazo2 = new Brazo(espesor, anchoExtremidad, largoBrazo, largoAnteBrazo, largoMano);
            cabeza = new Cubo(espesor, largoCabeza, anchoCabeza);
            cuello = new Cubo(espesor, largoCuello, anchoCuello);
            torso = new Cubo(espesor, largoTorso, anchoTorso);
            vientre = new Cubo(espesor, largoVientre, anchoVientre);

            pierna1.setCenter(0, largoPie + largoPierna + largoMuslo, 0);
            pierna2.setCenter(0, largoPie + largoPierna + largoMuslo, 0);
            brazo1.setCenter(0, largoMano + largoBrazo + largoAnteBrazo, 0);
            brazo2.setCenter(0, largoMano + largoBrazo + largoAnteBrazo, 0);

            addObjecto(pierna1, "pierna1");
            addObjecto(pierna2, "pierna2");
            addObjecto(brazo1, "brazo1");
            addObjecto(brazo2, "brazo2");
            addObjecto(cabeza, "cabeza");
            addObjecto(cuello, "cuello");
            addObjecto(torso, "torso");
            addObjecto(vientre, "vientre");

            cabeza.trasladar(0f, largoPierna + largoPie + largoMuslo + largoVientre + largoTorso + largoCuello, anchoExtremidad + anchoTorso / 2f - anchoCabeza / 2f);
            cuello.trasladar(0f, largoPierna + largoPie + largoMuslo + largoVientre + largoTorso, anchoExtremidad + anchoTorso / 2f - anchoCuello / 2f);
            torso.trasladar(0f, largoPierna + largoPie + largoMuslo + largoVientre, anchoExtremidad);
            vientre.trasladar(0f, largoPierna + largoPie + largoMuslo, anchoExtremidad);
            pierna1.trasladar(0f, largoPierna + largoPie + largoMuslo, anchoExtremidad);
            pierna2.trasladar(0f, largoPierna + largoPie + largoMuslo, anchoTorso);
            brazo1.trasladar(0f, largoPierna + largoPie + largoMuslo + largoVientre + largoTorso, 0f);
            brazo2.trasladar(0f, largoPierna + largoPie + largoMuslo + largoVientre + largoTorso, anchoExtremidad + anchoTorso);

        }

        public void girarBrazo1(float Ax, float Ay, float Az)
        {
            brazo1.rotar(Ax, Ay, Az);
        }
        public void girarBrazo2(float Ax, float Ay, float Az)
        {
            brazo2.rotar(Ax, Ay, Az);
        }

        public override void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {
            base.draw(matriz, colorShaderProgram);
        }
    }
}
