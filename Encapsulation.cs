/*using System;

namespace BoxApplication {
    class Box {
        public double length;
        public double breadth;
        public double height;

        public void setLength(double len) {
            length = len;
        }
        public void setBreadth(double bre) {
            breadth = bre;
        }
        public void setHeight(double hei) {
            height = hei;
        }
        public double getVolume() {
            return length * breadth * height;
        }
    }

    class Boxtester {
        static void Main(string[] args) {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume;

            // Box1 Specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 Specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // box1 volume
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // box2 volume
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            Console.ReadKey();
        }
    }
}*/