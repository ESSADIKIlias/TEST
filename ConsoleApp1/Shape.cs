using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Shape
    {   private string id;
        private float width;
        private float height;
        private int amountOfSides;
        private float[] position = new float[3];
        private float scale;
        private float[] rotation = new float[3];
        private  static List<Shape> shapesList= new List<Shape> {};
        public static HashSet<string> idSet = new HashSet<string>() { };

        public Shape (float width,float height,int amountOfSides, float positionX, float positionY,float positionZ,float scale, float rotationX,float rotationY,float rotationZ) {
            this.id = Guid.NewGuid().ToString();
            this.width = width;
            this.height = height;
            this.amountOfSides = amountOfSides;
            this.position = new float[] { positionX, positionY , positionZ};
            this.scale = scale;
            this.rotation = new float[] { rotationX, rotationY, rotationZ };
            shapesList.Add(this);
            idSet.Add(this.id);
            
        }

        public void setId (string id) {
            
       if (idSet.Add(id)) {
                idSet.Remove(this.id);
                this.id = id; }
            
            
        }

        public void setWidth(float width)
        {
            this.width = width;
        }

        public void setHeight(float height)
        {
            this.height = height;
        }

        public void setAmountOfSides(int amountOfSides)
        {
            this.amountOfSides = amountOfSides;
        }

        public void setPosition(float positionX, float positionY, float positionZ)
        {
            this.position = new float[] { positionX, positionY, positionZ };

       }

        public void setScale(float scale)
        {
            this.scale = scale;
        }

        public void setRotation(float rotationX, float rotationY, float rotationZ)
        {
            this.rotation = new float[] { rotationX, rotationY, rotationZ };
        }

        public void setPositionById(string id,float positionX, float positionY, float positionZ)
        {

            for (int i= 0; i < shapesList.Count; i++)
            {
                if (id.Equals(shapesList[i].id))
                {
                    shapesList[i].position= new float[3] { positionX , positionY , positionZ};
                }
            }      
        }
        public void setRotationById(string id, float rotationX, float rotationY, float rotationZ)
        {

            for (int i = 0; i < shapesList.Count; i++)
            {
                if (id.Equals(shapesList[i].id))
                {
                    shapesList[i].position = new float[3] { rotationX, rotationY, rotationZ };
                }
            }
        }

        public void setScaleById(string id, float scale)
        {

            for (int i = 0; i < shapesList.Count; i++)
            {
                if (id.Equals(shapesList[i].id))
                {
                    shapesList[i].scale =scale;
                }
            }
        }

        public void shapeById(string id)
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
                if (id.Equals(shapesList[i].id))
                {
                    Console.WriteLine("Id: " + shapesList[i].id);
                    Console.WriteLine("Width: " + shapesList[i].width);
                    Console.WriteLine("Height: " + shapesList[i].height);
                    Console.WriteLine("Amount of sides: " + shapesList[i].amountOfSides);
                    Console.WriteLine("Position: x:" + shapesList[i].position[0] +" y:" + shapesList[i].position[1] +" z:" + shapesList[i].position[2]);
                    Console.WriteLine("Scale: " + shapesList[i].scale);
                    Console.WriteLine("Rotation: x:" + shapesList[i].rotation[0] +" y:" + shapesList[i].rotation[1] +" z:" + shapesList[i].rotation[2]);
                }
            }
        }
        public void allShapes()
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
               
                    Console.WriteLine("Shape number " + (i+1));
                    Console.WriteLine("Id: " + shapesList[i].id);
                    Console.WriteLine("Width: " + shapesList[i].width);
                    Console.WriteLine("Height: " + shapesList[i].height);
                    Console.WriteLine("Amount of sides: " + shapesList[i].amountOfSides);
                    Console.WriteLine("Position: x:" + shapesList[i].position[0] + " y:" + shapesList[i].position[1] + " z:" + shapesList[i].position[2]);
                    Console.WriteLine("Scale: " + shapesList[i].scale);
                    Console.WriteLine("Rotation: x:" + shapesList[i].rotation[0] + " y:" + shapesList[i].rotation[1] + " z:" + shapesList[i].rotation[2]);
                
            }
        }
    }
}
