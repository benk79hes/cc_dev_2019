using System;

namespace DTO
{
    public class Class1
    {
        public int Id { get; set; }

        public string Name { get; set; }

        override
        public string ToString()
        {
            return Id + " " + Name;
        }
    }
}
