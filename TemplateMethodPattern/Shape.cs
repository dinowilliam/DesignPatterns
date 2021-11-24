using TemplateMethodPattern.Contracts;

namespace TemplateMethodPattern {
    public abstract class Shape    {        
        
        public void Draw(IGraphics g)        {
            prepareGraphic(g);
            doDrawing(g);
        }

        protected void prepareGraphic(IGraphics g){
            g.AddList("Preparing Graphics");
        }

        protected abstract void doDrawing(IGraphics g);

        
    }
}
