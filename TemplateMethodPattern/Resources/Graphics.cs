using System;
using System.Collections.Generic;

namespace TemplateMethodPattern.Resources {
    
    using TemplateMethodPattern.Contracts;

    public class Graphics : IGraphics {

        private List<String> _list;

        public Graphics() {   
            _list = new List<String>();
        }

        public void AddList(String item) {
            _list.Add(item);
        }

        public void ClearList(){
            _list.Clear();
        }

        public List<String> List { get => _list; }


    }
}
