using GameOpenTK.program;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOpenTK.objects
{
    abstract class Objeto
    {
        private float cX, cY, cZ;
        public Matrix4[] m;
        private IDictionary<string, Objeto> l;

        public Objeto()
        {
            m = new Matrix4[]{
                Matrix4.Identity
            };
            cX = 0;
            cY = 0;
            cZ = 0;
            l = new Dictionary<String, Objeto>();
        }

        public virtual void setCenter(float cX, float cY, float cZ)
        {
            trasladar(getCX(), getCY(), getCZ());
            this.cX = cX;
            this.cY = cY;
            this.cZ = cZ;

            trasladar(-getCX(), -getCY(), -getCZ());
        }

        public virtual float getCX()
        {
            return cX;
        }

        public virtual float getCY()
        {
            return cY;
        }

        public virtual float getCZ()
        {
            return cZ;
        }

        public void rotar(float ejeX, float ejeY, float ejeZ)
        {
            trasladar(getCX(), getCY(), getCZ());
            m[0] = Matrix4.CreateRotationX(ejeX) * m[0];
            m[0] = Matrix4.CreateRotationY(ejeY) * m[0];
            m[0] = Matrix4.CreateRotationZ(ejeZ) * m[0];
            trasladar(-getCX(), -getCY(), -getCZ());
        }

        public void trasladar(float x, float y, float z)
        {
            m[0] = Matrix4.CreateTranslation(x, y, z) * m[0];
        }

        public void escalar(float vX, float vY, float vZ)
        {
            m[0] = Matrix4.CreateScale(vX, vY, vZ) * m[0];
        }

        public void addObjecto(Objeto value, String key)
        {
            l.Add(key, value);
        }

        public Objeto getObjeto(String key)
        {
            return l[key];
        }

        public virtual void draw(Matrix4[] matriz, ColorShaderProgram colorShaderProgram)
        {

            Matrix4[] model;
            model = new Matrix4[]{
                Matrix4.Identity
            };
            model[0] = m[0] * matriz[0];

            Objeto objeto;
            foreach (KeyValuePair<string, Objeto> value in l)
            {
                objeto = value.Value;
                objeto.draw(model, colorShaderProgram);
            }
        }
    }
}
