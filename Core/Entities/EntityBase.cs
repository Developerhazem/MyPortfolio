using System;

namespace Core.Entities
{
    public class EntityBase
    {
        //Guid data type is like int, we make it in separate class to remove duplicate code in each class...
        public Guid Id { get; set; }
    }

}
