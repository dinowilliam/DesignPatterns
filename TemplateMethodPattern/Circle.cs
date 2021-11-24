namespace TemplateMethodPattern {

    using TemplateMethodPattern.Contracts;

    public class Circle : Shape {

        public Circle() { }

        protected override void doDrawing(IGraphics g) {
            g.AddList("-------------Circle-----------");
            g.AddList("Doing Drawing");
            g.AddList("Drawing a Circle");
            g.AddList(string.Format("Circle have a Center in {0}", Center));
            g.AddList(string.Format("Circle have a Radius of {0}", Radius));
            g.AddList("-----------------------------");
        }

        public int Center { get; set; }
        public int Radius { get; set; }
    }
}
