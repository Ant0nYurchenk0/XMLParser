using System.Collections.Generic;

namespace XMLparser
{
    class XMLParserStrategy
    {
        public List<StudentClass> Parse(string path)
        {
            return strategy.Parse(path); 
        }
        public void setStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }        
        private Strategy strategy = null;
        public Strategy Strategy { get => strategy; }
    }
}
