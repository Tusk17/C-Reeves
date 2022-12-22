namespace LearnKode
{
    class Datatype
    {
        private string dataType;

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Datatype(string dataType, string id)
        {
            this.dataType = dataType;
            this.id = id;
        }
    }
}
