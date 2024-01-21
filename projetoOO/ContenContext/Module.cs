using System.Collections.Generic;

namespace   projetoOO.ContentContext
{
    public class Module
    {
        public Module
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }
}