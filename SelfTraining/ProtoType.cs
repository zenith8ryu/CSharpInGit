using System;
using System.Collections.Generic;
namespace selfTraining
{
    public class ProtoType
    {
        private string id;
        private string name;
        private int xPoint;
        private int yPoint;

        public ProtoType()
        {
            this.id = default(string);
            this.name = default(string);
            this.xPoint = 15;
            this.xPoint = 15;
        }
        public ProtoType(string id, string name, int xPoint, int yPoint)
        {
            this.id = id;
            this.name = name;
            this.xPoint = xPoint;
            this.xPoint = yPoint;
        }

        public void setX(int x)
        {
            this.xPoint = x;
        }

        public void setY(int y)
        {
            this.yPoint = y;
        }

        public int getX() { return this.xPoint; }

        public int getY() { return this.yPoint; }

        // public string prop01 { get; set; }

        public virtual void Method01()
        {
            Console.WriteLine("This is a prototype class.");
        }

        private void Method02()
        {
            Console.WriteLine("This is a prototype class.");
        }

    }
}