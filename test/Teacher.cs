using System.Collections;
using System.Collections.Generic;

namespace test
{
    public class Teacher:Person,IEnumerable 
    {
        public IEnumerable<Student> students { get; set; }
        public int Id { get; internal set; }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
