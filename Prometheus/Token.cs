using System.Text.RegularExpressions;

namespace LearnKode
{
    class Token
    {

        #region Properties

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Regex regex;

        public Regex Regex
        {
            get { return regex; }
            set { regex = value; }
        }

        #endregion

        #region Constructors

        public Token(string name, string pattern)
        {
            this.name = name;
            this.regex = new Regex(pattern);
        }

        #endregion

    }
}
