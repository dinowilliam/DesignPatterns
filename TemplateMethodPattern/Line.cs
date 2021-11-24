namespace TemplateMethodPattern {

    using TemplateMethodPattern.Contracts;

    public class Line : Shape {

        public Line() { }

        protected override void doDrawing(IGraphics g) {
            g.AddList("--------------Line------------");
            g.AddList("Doing Drawing");
            g.AddList("Drawing a Line");
            g.AddList(string.Format("Line begin at {0}", Begin));
            g.AddList(string.Format("Line end at {0}", End));
            g.AddList("-----------------------------");
        }

        public int Begin { get; set; }
        public int End { get; set; }
    }
}
