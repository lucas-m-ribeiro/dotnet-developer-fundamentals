namespace projetoOO.ContentContext
{
    public class Courses : Content
    {

        public Courses
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurantionInMinutes { get; set; }
        public EContentlevel Level { get; set; }
        
    }
}