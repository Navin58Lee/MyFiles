using System;
namespace MethodFour
{
    class Person
    {
        public string name;
        public int age;
        public char sex;
        public string getName()
        {
            return name;
        }
        public void setName(string nam)
        {
            name = nam;
        }
        public int getAge()
        {
            return age;
        }
        public void setASge(int ag)
        {
            age = ag;
        }
        public char getSex()
        {
            return sex;
        }
        public void setSex(char sx)
        {
            sex = sx;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;
            return this.name == ((Person)obj).name &&
                this.age == ((Person)obj).age &&
                this.sex == ((Person)obj).sex;
        }
    }
    class TestMain
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Beckham";
            p1.age = 41;
            p1.sex = 'M';
            Person p2 = new Person();
            p2.name = "Beckham";
            p2.age = 41;
            p2.sex = 'M';
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
        }
    }
}
